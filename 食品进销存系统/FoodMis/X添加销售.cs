using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FoodMis
{
    public partial class X添加销售 : UserControl
    {

        private SqlConnection conn;
        private SqlCommand command;

        public static String NAME="";
        public static String Username;
        public static String Password;

        public static int ID;
        public static int goods_id;
        public static int NUM;
        public static int bnum=0;
        public static int money1 = 0;
        public static int money2 = 0;

        public X添加销售()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");
        }

   

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bnum++;
            X商品 addGoods = new X商品();
            addGoods.ShowDialog();
        }

        private void X添加销售_Load(object sender, EventArgs e)
        {
            //生成销售订单编号
            Random random = new Random();
            ID = random.Next(1000000, 10000000);
            label5.Text = "销售订单编号： "+ID;

            conn.Open();
            String sql = "select * from customer";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["customer_name"]);
            }
            reader.Close();
            conn.Close();
        }

        private void simpleButton2_Click(object sender, System.EventArgs e)
        {
            //生成销售订单编号
            Random random = new Random();
            ID = random.Next(1000000, 10000000);
            label5.Text = "销售订单编号： " + ID;


            money1 = 0;
            money2 = 0;
            int x = -1;
            //首先检验窗体属性是否已更改，与listView中的值进行比较
            foreach (ListViewItem lv in listView1.Items)
            {

             
                if (Convert.ToInt32(lv.SubItems[1].Text) == goods_id)
                {
                   
                    if (listView1.Items.Count == bnum)
                    {
                        x = 1;//无法再次添加
                    }
                    else
                    {
                        //商品相同的，数量继续向上增加
                        lv.SubItems[5].Text = Convert.ToString(Convert.ToInt32(lv.SubItems[5].Text)+NUM);
                        x = 0;
                        bnum--;
                    }
                }

                //计算总金额
                
                money1 += (Convert.ToInt32(lv.SubItems[3].Text))*(Convert.ToInt32(lv.SubItems[5].Text));
                money2 += (Convert.ToInt32(lv.SubItems[4].Text)) * (Convert.ToInt32(lv.SubItems[5].Text));
              

            }

            if (x ==-1)
            {
                conn.Open();
                string sql1 = "select * from commodity_stock where goods_id='" + goods_id + "'";
                command = new SqlCommand(sql1, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = listView1.Items.Add((listView1.Items.Count + 1) + "");
                    item.SubItems.Add(Convert.ToString(reader["goods_id"]));
                    item.SubItems.Add(Convert.ToString(reader["commodity_name"]));
                    item.SubItems.Add(Convert.ToString(reader["original_price"]));
                    item.SubItems.Add(Convert.ToString(reader["price"]));
                    item.SubItems.Add(Convert.ToString(NUM));

                    item.EnsureVisible();//让listView始终显示最新的一行数据
                }
                reader.Close();
                conn.Close();

            }

            label4.Text = "总成本： " + money1+" 元！"; ;
            label3.Text = "总金额： " +money2+" 元！";

        }

        private void button_save_Click(object sender, System.EventArgs e)
        {
          
            string date = DateTime.Now.ToShortDateString().ToString();
          
             string sql="";
            String customer_name = comboBox1.Text;
            try
            {
                conn.Open();

                //保存至总表，保存至其从表
                foreach (ListViewItem lv in listView1.Items)
                {

                    sql = "insert into sales_form(goods_id,original_price,price,num,good_name,sales_id) values ('"
                                + Convert.ToInt32(lv.SubItems[1].Text) + "','" + lv.SubItems[3].Text + "','" + lv.SubItems[4].Text + "','" + lv.SubItems[5].Text
                                + "','" + lv.SubItems[2].Text + "','" + ID + "')";
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();


                }
             


                sql = "insert into sales(id,customer_name,salesperson_name,date,money) values ('"
                                + ID + "','" + customer_name + "','" + NAME + "','" + date
                                + "','" + money2 + "')";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();

                
                Random random = new Random();
             
                //添加至收款单

                int fkid = random.Next(1000000, 10000000);
                sql = "insert into receivables(id,buyer_name,sales_id,salesperson_name,a_money,status) values ('"
                 + fkid + "','" + customer_name + "','" + ID + "','" + NAME
                  + "','" + money2 + "','未支付')";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
               
               //从库存中修改
                foreach (ListViewItem lv in listView1.Items)
                {
                    sql = "update commodity_stock set num=num-" + Convert.ToInt32(lv.SubItems[5].Text) + " where goods_id='" + lv.SubItems[1].Text + "'";
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                }

              
                //计算利润
                foreach (ListViewItem lv in listView1.Items)
                {
                    int ANUM=0;
                    sql = "select * from commodity_stock where goods_id='"+Convert.ToInt32(lv.SubItems[1].Text)+"'";
                    command = new SqlCommand(sql, conn);
                    SqlDataReader reader2 = command.ExecuteReader();
                    while (reader2.Read())
                    {
                       ANUM=Convert.ToInt32(reader2["num"]); 
                    }
                    reader2.Close();

                 

                    double profit2 = (Convert.ToInt32(lv.SubItems[4].Text) - Convert.ToInt32(lv.SubItems[3].Text)) * (Convert.ToInt32(lv.SubItems[5].Text));
                    String profit = Convert.ToString(profit2);
                    string sql1 = "select * from money where goods_id='" + lv.SubItems[1].Text + "'";
                    command = new SqlCommand(sql1, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        //更新金额表
                        sql = "update money set purchased_num='" + Convert.ToInt32(lv.SubItems[5].Text) + "',no_num='" + ANUM + "',profit='" +profit+ "' where goods_id='" + lv.SubItems[1].Text + "'";
                    
                    }
                    else
                    {
                        //插入到金额表
                        sql = "insert into money(goods_id,purchased_num,no_num,profit) values ('"
                 + lv.SubItems[1].Text + "','" + Convert.ToInt32(lv.SubItems[5].Text) + "','" + ANUM + "','" +profit + "')";
                      
                    }
                    reader.Close();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                  
                  

                }


                conn.Close();
                //跳转
                MessageBox.Show("已保存！");


                //恢复初值
                goods_id = 0;
                NUM = 0;
                bnum = 0;
                money1 = 0;
                money2 = 0;
           
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现错误！提示："+ex.Message);
            }
        }

        private void button_to_Click(object sender, System.EventArgs e)
        {
           
            string date = DateTime.Now.ToShortDateString().ToString();
           
             string sql="";
            String customer_name = comboBox1.Text;
            try
            {
                conn.Open();
                //保存至总表，保存至其从表
                foreach (ListViewItem lv in listView1.Items)
                {
                    
                    sql = "insert into sales_form(goods_id,original_price,price,num,good_name,sales_id) values ('"
                                + Convert.ToInt32(lv.SubItems[1].Text) + "','" + lv.SubItems[3].Text + "','" + lv.SubItems[4].Text + "','" + lv.SubItems[5].Text
                                + "','" + lv.SubItems[2].Text + "','" + ID + "')";
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();

                  
                }

                
                sql = "insert into sales(id,customer_name,salesperson_name,date,money) values ('"
                                + ID + "','" + customer_name + "','" + NAME + "','" + date
                                + "','" + money2 + "')";
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
               
                Random random = new Random();
               
             
             
                //从库存中修改
                foreach (ListViewItem lv in listView1.Items)
                {
                    sql = "update commodity_stock set num=num-" + Convert.ToInt32(lv.SubItems[5].Text) + " where goods_id='" + lv.SubItems[1].Text + "'";
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                }
              

                //计算利润
                foreach (ListViewItem lv in listView1.Items)
                {
                   
                    int ANUM=0;
                    sql = "select * from commodity_stock where goods_id='"+Convert.ToInt32(lv.SubItems[1].Text)+"'";
                    command = new SqlCommand(sql, conn);
                    SqlDataReader reader2 = command.ExecuteReader();
                    while (reader2.Read())
                    {
                       ANUM=Convert.ToInt32(reader2["num"]); 
                    }
                    reader2.Close();

                   

                    double profit = (Convert.ToInt32(lv.SubItems[4].Text) - Convert.ToInt32(lv.SubItems[3].Text)) * (Convert.ToInt32(lv.SubItems[5].Text));
                    string sql1 = "select * from money where goods_id='" + lv.SubItems[1].Text + "'";
                    command = new SqlCommand(sql1, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        //更新金额表
                        sql = "update money set purchased_num='" + Convert.ToInt32(lv.SubItems[5].Text) + "',no_num='" + ANUM + "',profit='" +profit+ "' where goods_id='" + lv.SubItems[1].Text + "'";
                      
                    }
                    else
                    {
                        //插入到金额表
                        sql = "insert into money(goods_id,purchased_num,no_num,profit) values ('"
                 + lv.SubItems[1].Text + "','" + Convert.ToInt32(lv.SubItems[5].Text) + "','" + ANUM + "','" +profit + "')";
                       
                    }
                    reader.Close();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                  
                }
                conn.Close();
          
             //跳转乃至一个窗体 
                int fkid = random.Next(1000000, 10000000);
                X结算.id=fkid;
                X结算.buyer_name=customer_name;
                X结算.sales_id=ID;
                X结算.salesperson_name=NAME;
                X结算.a_money=money2;
                X结算.show=Convert.ToString(money2);
                X结算.SS = -1;
                X结算 js = new X结算();
                js.ShowDialog();

                //恢复初值
                goods_id = 0;
                NUM = 0;
                bnum = 0;
                money1 = 0;
                money2 = 0;
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("出现错误！提示："+ex.Message);
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            ID = random.Next(1000000, 10000000);
            label5.Text = "销售订单编号： " + ID;

            goods_id = 0;
            NUM = 0;
            bnum = 0;
            money1 = 0;
            money2 = 0;

            listView1.Items.Clear();
            label4.Text = "总成本： " + money1 + " 元！"; ;
            label3.Text = "总金额： " + money2 + " 元！";
              
        }
    }
}
