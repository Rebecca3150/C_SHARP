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
    public partial class Zxiaoshou : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        public Zxiaoshou()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            textBoxX_name.Text = "";
            textBoxX_phone.Text = "";
            textBoxX_pass2.Text = "";
            textBoxX_pass.Text = "";
            Random random = new Random();
            int ID = random.Next(1000, 10000);
            textBoxX_number.Text = Convert.ToString(ID);
        }

        private void Zxiaoshou_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            int ID = random.Next(1000, 10000);
            textBoxX_number.Text = Convert.ToString(ID);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
                string check = "";
                string sql = "";
                int x = 1;
                check = textBoxX_number.Text;
                conn.Open();
                sql = "select * from view_Check where n1='" + check + "' or n2='" + check + "' or n3='" + check + "'";
                command = new SqlCommand(sql, conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("用户重复，请重新选择身份/或重新选择此身份！");
                }
                else
                {
                    x = 0;
                }
                reader.Close();
                conn.Close();
                if (x == 0)
                {
                            if (textBoxX_name.Text == "" || textBoxX_phone.Text == "" || textBoxX_pass.Text == "" || textBoxX_pass2.Text == "")
                            {
                                MessageBox.Show("为空!");
                            }
                            else
                            {
                                if (!textBoxX_pass.Text.Equals(textBoxX_pass2.Text))
                                {
                                    MessageBox.Show("前后密码不一致！");
                                }
                                else
                                {
                                    string number = textBoxX_number.Text;
                                    string name = textBoxX_name.Text;
                                    string phone = textBoxX_phone.Text;
                                    string pass = textBoxX_pass.Text;
                                    try
                                    {
                                        string sql2 = "insert into salesperson(number,salesperson_name,phone,password) values ('" + number + "','" + name + "','" + phone + "','" + pass + "')";
                                        conn.Open();
                                        command = new SqlCommand(sql2, conn);
                                        command.ExecuteNonQuery();
                                        MessageBox.Show(this, "注册完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        conn.Close();
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show("发生错误！提示：" + ex.Message);
                                    }
                                }
                            }
                       
                }
        }
    }
}
