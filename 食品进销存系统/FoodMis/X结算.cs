using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CCWin;


namespace FoodMis
{
    public partial class X结算 : Skin_Mac
    {
        private SqlConnection conn;
        private SqlCommand command;

        public static int SS=-1;//状态

        public static int id;
        public static String buyer_name;//客户信息
        public static int sales_id;
        public static String salesperson_name;
        public static int a_money;

        public static String show;
        public X结算()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;"); 
        }

      
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((Convert.ToInt32(show) < Convert.ToInt32(textBox2.Text)) && (textBox2.Text!=""))
            {
                MessageBox.Show("超出应付总金额！");
            }
            else
            {

                try
                {
                    conn.Open();
                    string sql = "";

                    if (SS == 0)
                    {
                        //未支付
                        if (Convert.ToInt32(show) == Convert.ToInt32(textBox2.Text))
                        {
                            sql = "update receivables set info='" + textBox1.Text + "',type='" + comboBox1.Text + "',y_money='" + a_money + "',status='支付完成' where id=" + id;
                        }
                        else
                        {
                            sql = "update receivables set info='" + textBox1.Text + "',type='" + comboBox1.Text + "',y_money='" + Convert.ToInt32(textBox2.Text) + "',status='正在支付' where id=" + id;

                        }
                    }
                    else if (SS == 1)
                    {
                        //正在支付
                        if (Convert.ToInt32(show) == Convert.ToInt32(textBox2.Text))
                        {
                            sql = "update receivables set info='" + textBox1.Text + "',type=type+'/" + comboBox1.Text + "',y_money='" + a_money + "',status='支付完成' where id=" + id;
                        }
                        else
                        {
                            sql = "update receivables set info='" + textBox1.Text + "',type=type+'/" + comboBox1.Text + "',y_money='" + (Convert.ToInt32(textBox2.Text) - Convert.ToInt32(show) + a_money) + "',status='正在支付' where id=" + id;

                        }


                    }
                    else if (SS == -1)
                    {
                        //直接去付款
                        if (Convert.ToInt32(show) == Convert.ToInt32(textBox2.Text))
                        {
                            sql = "insert into receivables(id,buyer_name,info,sales_id,salesperson_name,type,a_money,y_money,status) values ('"
                                    + id + "','" + buyer_name + "','" + textBox1.Text + "','" + sales_id
                                    + "','" + salesperson_name + "','" + comboBox1.Text+"','"+a_money+"','"+a_money + "','支付完成')";
                        }
                        else
                        {
                            sql = "insert into receivables(id,buyer_name,info,sales_id,salesperson_name,type,a_money,y_money,status) values ('"
                                       + id + "','" + buyer_name + "','" + textBox1.Text + "','" + sales_id
                                       + "','" + salesperson_name + "','" + comboBox1.Text + "','" + a_money + "','" + textBox2.Text + "','正在支付')";
                    
                        }
                    }
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show(this, "付款完成！");

                    this.Close();

                    conn.Close();
                }//try
                catch (Exception ex)
                {
                    MessageBox.Show("付款失败，提示：" + ex.Message);
                }
            }
                   
        }

        private void X结算_Load(object sender, EventArgs e)
        {
            label4.Text = "应付金额： " + show + " 元";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
