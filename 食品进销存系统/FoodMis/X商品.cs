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
    public partial class X商品 : Skin_Mac
    {
        private SqlConnection conn;
        private SqlCommand command;

        
        public X商品()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }




        private void X商品_Load(object sender, EventArgs e)
        {
            string sql = "";
            conn.Open();
            sql = "select * from commodity_stock";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["commodity_name"]);
              

            }
            reader.Close();

            conn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {

                String goods_name = comboBox1.Text;
                label4.Text = "";
                int number = 0;
                conn.Open();
                String sql = "select * from commodity_stock where commodity_name='" + goods_name + "'";
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    number = Convert.ToInt32(reader["num"]);
                }
                reader.Close();

                conn.Close();
                if ((Convert.ToInt32(textBox1.Text) > number) && (textBox1.Text!=""))
                {
                    label4.Text = "超出库存量！";
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String goods_name = comboBox1.Text;
            conn.Open();
            String sql = "select * from commodity_stock where commodity_name='" + goods_name + "'";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                label5.Text = "库存量 ： " + Convert.ToString(reader["num"]);

            }
            reader.Close();

            conn.Close();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            String goods_name = comboBox1.Text;
            int num = Convert.ToInt32(textBox1.Text);
            int goods_id=0;
            int number = 0;
            conn.Open();
            String sql = "select * from commodity_stock where commodity_name='" + goods_name + "'";
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                number = Convert.ToInt32(reader["num"]);
                goods_id=Convert.ToInt32(reader["goods_Id"]);
            }
            reader.Close();

            conn.Close();
            if (num > number)
            {
                MessageBox.Show("超出库存量！");
            }
            else
            {
                X添加销售.goods_id = goods_id;
                X添加销售.NUM = num;
                MessageBox.Show("提交完毕，此窗口将关闭！");
                this.Close();
            }



        }

  
    }
}
