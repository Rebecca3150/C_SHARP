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
    public partial class 商品添加 : Skin_Mac
    {
        private SqlConnection conn;
        private SqlCommand command;

        public 商品添加()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

         private void 商品添加_Load(object sender, EventArgs e)
        {
            //comboBox1.Items.Add((string)reader["supplier_name"]);
            string sql = "select * from supplier";
            conn.Open();
            command = new SqlCommand(sql, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add((string)reader["supplier_name"]);
            }
            reader.Close();
            conn.Close();
         }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            String name = textBox_name.Text;
            String price = textBox_price.Text;
            string supplier_name = comboBox1.Text;
            int supplier_id=0;
            string sqll = "select * from supplier where supplier_name='"+supplier_name+"'";
            conn.Open();
            command = new SqlCommand(sqll, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                supplier_id=Convert.ToInt32(reader["id"]);
            }
            reader.Close();
            conn.Close();

            if(name==""){
                MessageBox.Show("商品名称为空！");
            }
            else if (price=="")
            {
                MessageBox.Show("商品单价为空！");
            }

           else{
               try
               {
                   conn.Open();
                   int x = 1;
                   string sql2 = "select * from goods where goods_name='" + name + "'";
                   command = new SqlCommand(sql2, conn);
                   SqlDataReader reader2 = command.ExecuteReader();
                   if (reader2.Read())
                   {
                       x = 1;
                       MessageBox.Show("名称重复！");
                   }
                   else
                   {
                       x = 0;
                   }
                   reader2.Close();
                   conn.Close();
                   if (x == 0)
                   {
                       string sql = "insert into goods(goods_name,original_price,supplier_id) values ('" + name + "','" + price + "','" + supplier_id + "')";
                       conn.Open();
                       command = new SqlCommand(sql, conn);
                       command.ExecuteNonQuery();
                       MessageBox.Show(this, "成功添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       conn.Close();

                       textBox_name.Text = "";
                       textBox_price.Text = "";

                   }
               }
               catch (Exception ex)
               {
                   MessageBox.Show("添加失败！提示：" + ex.Message);


                   textBox_name.Text = "";
                   textBox_price.Text = "";
               }
            }

            }

        

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
            textBox_name.Text = "";
            textBox_price.Text = "";
        }

        private void textBox_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            //判斷只能輸入數字和Backspace
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
                e.Handled = true;

            //判断可输入小数点，但小数点不能放在数字的前面，且要保证只能输入一个小数点在正确的位置
            if ((int)e.KeyChar == 46)                       //小数点    
            {
                if (textBox_price.Text.Length <= 0)
                    e.Handled = true;           //小数点不能在第一位    
                else
                {
                    float f;
                    float oldf;
                    bool b1 = false, b2 = false;
                    b1 = float.TryParse(textBox_price.Text, out oldf);
                    b2 = float.TryParse(textBox_price.Text + e.KeyChar.ToString(), out f);
                    if (b2 == false)
                    {
                        if (b1 == true)
                            e.Handled = true;
                        else
                            e.Handled = false;
                    }
                    else
                        e.Handled = false;
                }
            }
        }


        private void textBox_name_TextChanged(object sender, EventArgs e)
        {
            String name = textBox_name.Text;
            conn.Open();

            string sql1 = "select * from goods where goods_name='" + name + "'";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                label8.Text = "名称重复！";
            }
            else
            {
                label8.Text = "";
            }
            reader.Close();
            conn.Close();

          
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


      

    }
}
