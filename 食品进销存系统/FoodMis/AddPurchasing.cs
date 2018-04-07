using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Web;

namespace FoodMis
{
    public partial class AddPurchasing : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        private SqlDataAdapter adapter;
        private DataSet dataSet;

        Boolean ifSaved = false;
        List<int> goodsId;

        private String PRICE="无";

        public AddPurchasing()
        {
            InitializeComponent();
            ifSaved = false;
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

            //以下是第二次代码:
            //显示供应商：应当先选择供应商，然后选择其供应的相关物品。
            InitializeForm();
        
        }

        private void InitializeForm()
        {

            string sql = "select * from supplier";
            conn.Open();
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Salesperson_name.Items.Add((string)reader["supplier_name"]);
            }
            reader.Close();



            //显示采购员名称：
            string sql2 = "select * from buyer";
            command = new SqlCommand(sql2, conn);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Buyer_name.Items.Add(reader["buyer_name"]);
            }
            reader.Close();
            conn.Close();
        }


        private void Salesperson_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*获取combox的选定项的值：如果是绑定数据源的话。。用combobox.Selectedvalue
               如果是用add 加的话。 用combobox。.SelectedItem
               用combobox。text也行*/
            Purchasing_name.Items.Clear();
            string Salesperson = Salesperson_name.SelectedItem.ToString();
            string sql = "select * from supplier where supplier_name='" + Salesperson + "'";
            int supplier_id = 0;
            conn.Open();
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                supplier_id = (int)reader["id"];
            }
            reader.Close();
            string sql2 = "select * from goods where supplier_id=" + supplier_id;
            command = new SqlCommand(sql2, conn);
            reader = command.ExecuteReader();
            goodsId = new List<int>();
            while (reader.Read())
            {
                Purchasing_name.Items.Add(reader["goods_name"]);
                goodsId.Add((int)reader["id"]);
                // Purchasing_name.Items.IndexOf()
            }
            reader.Close();
            conn.Close();
        }

        private void PurchasingName_Click(object sender, EventArgs e)
        {

        }

        private void AddPayment_Click(object sender, EventArgs e)
        {
           
           
        }

        private void Buyer_name_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Purchasing_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            //查询单价
             PRICE = "";
            conn.Open();
            string sql1 = "select * from goods where goods_name='" + Purchasing_name.Text + "'";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PRICE = Convert.ToString(reader["original_price"]);
            }
            reader.Close();
            conn.Close();
           
                textBox_price.Text = "   " + PRICE + "      元";
          
         
           
        }

        private void save_Click(object sender, EventArgs e)
        {
            //在purchasing表中Purchasing_id是采购物编号
            int Purchasing_id = 0;
            string selectedPurchasingName = Purchasing_name.Text;
            int temp = Purchasing_name.Items.IndexOf(selectedPurchasingName);
            if (selectedPurchasingName != "")
            {
                Purchasing_id = goodsId[temp];
            }
          int goods_id=0;
            string price="";
            //通过pruchasing_name查找其id
            conn.Open();
            string sql1 = "select * from goods where goods_name='"+Purchasing_name.Text+"'";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
              goods_id=Convert.ToInt32(reader["id"]);
              price = Convert.ToString(reader["original_price"]);

            }
            reader.Close();
            conn.Close();







            string sql = "insert into purchasing(purchasing_id,purchasing_name,original_price,num,buyer_name,salesperson_name,date) values ('" + Purchasing_id + "','" + Purchasing_name.Text + "','" + PRICE + "','" + Num.Text + "','" + Buyer_name.Text + "','" + Salesperson_name.Text + "','" + DateTime.Now.ToString() + "')";
            conn.Open();
            command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
           conn.Close();

            //判断是否应该添加进入库存中
           int ss = 0;
           conn.Open();
           string sql12 = "select * from commodity_stock where goods_id='" + goods_id + "'";
           command = new SqlCommand(sql12, conn);
           SqlDataReader reader2 = command.ExecuteReader();
          if(reader2.Read())
           {
               ss = 1;

           }
          else
          {
              ss = 2;
          }
           reader2.Close();
           conn.Close();
            //若已存在，则增加数量
           if (ss == 1)
           {
               sql = "update commodity_stock set num=num+" +Convert.ToInt32(Num.Text) + " where goods_id='" + goods_id+"'";
               conn.Open();
               command = new SqlCommand(sql, conn);
               command.ExecuteNonQuery();
               conn.Close();
           }
           else if (ss == 2)
           { //若还未存在，则添加即可
               sql = "insert into commodity_stock(goods_id,num,commodity_name,original_price) values ('" + goods_id + "','" + Num.Text + "','" + Purchasing_name.Text + "','" + price + "')";
               conn.Open();
               command = new SqlCommand(sql, conn);
               command.ExecuteNonQuery();
               conn.Close();
               MessageBox.Show(this, "添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }

            /*
            Purchasing_name.Items.Clear();
            original_price.Text = "";
            Num.Text = "";
            Buyer_name.Items.Clear();
            Salesperson_name.Items.Clear();

            InitializeForm();
             */

            ifSaved = true;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Purchasing_name.Items.Clear();
            Num.Text = "";
            Buyer_name.Items.Clear();
            Salesperson_name.Items.Clear();

            InitializeForm();

            ifSaved = false;
        }

        private void save_Click_1(object sender, EventArgs e)
        {
          
                //在purchasing表中Purchasing_id是采购物编号
                int Purchasing_id = 0;
                string selectedPurchasingName = Purchasing_name.Text;
                int temp = Purchasing_name.Items.IndexOf(selectedPurchasingName);
                if (selectedPurchasingName != "")
                {
                    Purchasing_id = goodsId[temp];
                }
                int goods_id = 0;
                string price = "";
                string price2 = textBox1.Text;
                //通过pruchasing_name查找其id
                conn.Open();
                string sql1 = "select * from goods where goods_name='" + Purchasing_name.Text + "'";
                command = new SqlCommand(sql1, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    goods_id = Convert.ToInt32(reader["id"]);
                    price = Convert.ToString(reader["original_price"]);

                }
                reader.Close();
                conn.Close();



                string sql = "insert into purchasing(purchasing_id,purchasing_name,original_price,num,buyer_name,salesperson_name,date) values ('" + Purchasing_id + "','" + Purchasing_name.Text + "','" + PRICE + "','" + Num.Text + "','" + Buyer_name.Text + "','" + Salesperson_name.Text + "','" + DateTime.Now.ToString() + "')";
                conn.Open();
                command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                conn.Close();

                //判断是否应该添加进入库存中
                int ss = 0;
                conn.Open();
                string sql12 = "select * from commodity_stock where goods_id='" + goods_id + "'";
                command = new SqlCommand(sql12, conn);
                SqlDataReader reader2 = command.ExecuteReader();
                if (reader2.Read())
                {
                    ss = 1;

                }
                else
                {
                    ss = 2;
                }
                reader2.Close();
                conn.Close();
                //若已存在，则增加数量
                if (ss == 1)
                {
                    sql = "update commodity_stock set num=num+" + Convert.ToInt32(Num.Text) + " where goods_id='" + goods_id + "'";
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(this, "保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (ss == 2)
                { //若还未存在，则添加即可
                    sql = "insert into commodity_stock(goods_id,num,commodity_name,original_price,price) values ('" + goods_id + "','" + Num.Text + "','" + Purchasing_name.Text + "','" + price + "','" + price2 + "')";
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show(this, "保存成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                /*
                Purchasing_name.Items.Clear();
                original_price.Text = "";
                Num.Text = "";
                Buyer_name.Items.Clear();
                Salesperson_name.Items.Clear();

                InitializeForm();
                 */

                ifSaved = true;
            }
           

        private void reset_Click_1(object sender, EventArgs e)
        {
            Purchasing_name.Items.Clear();
            Num.Text = "";
            Buyer_name.Items.Clear();
            Salesperson_name.Items.Clear();

            InitializeForm();

            ifSaved = false;
        }

        private void AddPayment2_Click(object sender, EventArgs e)
        {
            if (ifSaved)
            {
                AddPayment addPayment = new AddPayment();
                //this.Hide(); 有这句的话也会导致显示不出AddPayment的界面的控件信息：可能是因为hide就是隐藏整个Addpurchasing panel，从而它相当于消失不见了。
                String sql = "select * from purchasing";
                conn.Open();
                adapter = new SqlDataAdapter(sql, conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet);
                int count = dataSet.Tables[0].Rows.Count;
                string str = dataSet.Tables[0].Rows[count - 1]["id"].ToString();
                string Oprice = dataSet.Tables[0].Rows[count - 1]["original_price"].ToString();

                conn.Close();

                addPayment.Purchasing_id = Convert.ToInt32(str);

                addPayment.Supplier_name.Text = Salesperson_name.Text;
                addPayment.Buyer_name.Text = Buyer_name.Text;
                double price = Convert.ToDouble(Oprice) * Convert.ToDouble(Num.Text);
                addPayment.A_money.Text = Convert.ToString(price);
                addPayment.Status.Text = "已结算";

                addPayment.Show();
                this.Controls.Clear();
                this.Controls.Add(addPayment);

            }
            else
            {
                MessageBox.Show(this, "请先保存本次采购订单信息，再填写相应付款单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

     

      

      

  
    
     
    
     

    

      
    }
}
