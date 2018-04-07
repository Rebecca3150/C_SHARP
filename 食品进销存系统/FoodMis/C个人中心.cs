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
    public partial class C个人中心 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        public static String Username;
        public static String NAME;
        public static String Password;

        public C个人中心()
        {
            InitializeComponent();
            conn = new SqlConnection(@" data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");
        }

        private void C个人中心_Load(object sender, EventArgs e)
        {
            groupBox_P.Visible = false;
            String tel = "";
            conn.Open();
            string sql1 = "select * from buyer where number='" + Username + "'";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                tel = Convert.ToString(reader["phone"]);

            }
            reader.Close();
            conn.Close();

            textBox_name.Text = NAME;
            textBox_pass.Text = Password;
            textBox_tel.Text = tel;
            textBox4.Text = Username;
        }

        private void button_change_Click(object sender, EventArgs e)
        {
            if (button_change.Text.Equals("修改密码"))
            {
                groupBox_P.Show();
                groupBox_P.Visible = true;
                button_change.Text = "取消修改密码";
            }
            else if (button_change.Text.Equals("取消修改密码"))
            {
                groupBox_P.Visible = false;
                button_change.Text = "修改密码";
            }
          
        }

        private void button_saveP_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("为空！");
            }
            else
            {
                String pass1 = textBox1.Text;
                String pass2 = textBox2.Text;
                String pass3 = textBox3.Text;
                if (!pass2.Equals(pass3))
                {
                    MessageBox.Show("两次输入的新密码不一致！");
                }
                else if (pass1.Equals(pass2))
                {
                    MessageBox.Show("新密码与原始密码重复！");
                }
                else if (!pass1.Equals(textBox_pass.Text))
                {
                    MessageBox.Show("原始密码错误！");
                }
                else
                {
                    try
                    {
                        string sql = "update buyer set password='" + pass2 + "' where number=" + Username;
                        conn.Open();
                        command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show(this, "密码修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                        textBox_pass.Text = pass2;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("修改失败！提示：" + ex.Message);
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text == "" || textBox_tel.Text == "")
            {
                MessageBox.Show("为空！");
            }
            else
            {
                string NAme = textBox_name.Text;
                string tell = textBox_tel.Text;
                try
                {
                    string sql = "update buyer set salesperson_name='" + NAme + "',phone='" + tell + "' where number=" + Username;
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show(this, "修改成功，有些信息待下次登录时完全修改完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    textBox_name.Text = NAme;
                    textBox_tel.Text = tell;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("修改失败！提示：" + ex.Message);
                }
            }
        }
    }
}
