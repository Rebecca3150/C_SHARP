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
    public partial class 供应商管理 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        public 供应商管理()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }



        private void 供应商管理_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql1 = "select * from supplier";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView_sup.Items.Add((listView_sup.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["supplier_name"]));
                item.SubItems.Add(Convert.ToString(reader["phone"]));
                item.SubItems.Add(Convert.ToString(reader["address"]));

                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();

          
        }

        private void button_S_Click(object sender, EventArgs e)
        {
            listView_sup.Items.Clear();
            String SU = textBox_SU.Text;
            try
            {
                conn.Open();

                string sql1 = "select * from supplier where supplier_name like '%" + SU + "%'";
                command = new SqlCommand(sql1, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = listView_sup.Items.Add((listView_sup.Items.Count + 1) + "");
                    item.SubItems.Add(Convert.ToString(reader["id"]));
                    item.SubItems.Add(Convert.ToString(reader["supplier_name"]));
                    item.SubItems.Add(Convert.ToString(reader["phone"]));
                    item.SubItems.Add(Convert.ToString(reader["address"]));


                    item.EnsureVisible();//让listView始终显示最新的一行数据
                }
                reader.Close();
                conn.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("查询失败！提示：" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView_sup.Items.Clear();
            conn.Open();

            string sql1 = "select * from supplier";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView_sup.Items.Add((listView_sup.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["supplier_name"]));
                item.SubItems.Add(Convert.ToString(reader["phone"]));
                item.SubItems.Add(Convert.ToString(reader["address"]));


                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();
          
        }

        private void listView_sup_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_sup.SelectedItems.Count > 0)//如果已经选择了某行数据
            {
                textBox_NU.Text = listView_sup.SelectedItems[0].SubItems[2].Text;
                textBox_NP.Text = listView_sup.SelectedItems[0].SubItems[3].Text;
                textBox_NP2.Text = listView_sup.SelectedItems[0].SubItems[4].Text; ;
            }
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            if (listView_sup.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(listView_sup.SelectedItems[0].SubItems[1].Text);
                    conn.Open();
                    string sql = "delete from supplier where id='" + ID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //6.选择Command的适合方法
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("删除成功");
                        //   this.BindData();
                        listView_sup.SelectedItems[0].Remove();//删除选定行
                    }
                    else
                    {
                        MessageBox.Show("删除失败!");
                    }
                    //7.关闭数据库连接
                    conn.Close();

                        
                }
            }
            else
            {
                MessageBox.Show("抱歉，未选中！");
            }
        }

        private void button_add_Click(object sender, EventArgs e)
        {
         
            String name = textBox_U.Text;
            String phone = textBox_P.Text;
            String address = textBox_P2.Text;


            if (name == "")
            {
                MessageBox.Show("供应商名称为空！");
            }
            else if (phone == "")
            {
                MessageBox.Show("供应商联系方式为空！");
            }
            else if (address == "")
            {
                MessageBox.Show("供应商地址为空！");
            }
            else
            {
                conn.Open();
                int x = 1;
                string sql2 = "select * from supplier where supplier_name='" + name + "'";
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
                    string sql = "insert into supplier(supplier_name,phone,address) values ('" + name + "','" + phone + "','" + address + "')";
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show(this, "成功添加！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    string id = "";
                    string sql1 = "select id from supplier where supplier_name='" + name + "'";
                    command = new SqlCommand(sql1, conn);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    { id = Convert.ToString(reader["id"]); }
                    conn.Close();

                    //从数据库中读出刚刚注册过的
                    ListViewItem item = listView_sup.Items.Add((listView_sup.Items.Count + 1) + "");
                    item.SubItems.Add(id);//添加id
                    item.SubItems.Add(name);//添加用户名
                    item.SubItems.Add(phone);//添加密码
                    item.SubItems.Add(address);//添加密码



                    textBox_U.Text = "";
                    textBox_P.Text = "";
                    textBox_P2.Text = "";
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_U.Text = "";
            textBox_P.Text = "";
            textBox_P2.Text = "";
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            String NU = textBox_NU.Text;
            String NP = textBox_NP.Text;
            String NP2 = textBox_NP2.Text;

            if (listView_sup.SelectedItems.Count > 0)//如果已经选择了某行
            {
                try
                {
                    int ID = Convert.ToInt32(listView_sup.SelectedItems[0].SubItems[1].Text);

                    //开始向数据库中更新数据
                    string sql = "update supplier set supplier_name='" + NU + "',phone='" + NP + "',address='"+NP2+"' where id=" + ID;
                    conn.Open();
                    command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show(this, "更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conn.Close();

                    //列表中修改
                    listView_sup.SelectedItems[0].SubItems[2].Text = NU;
                    listView_sup.SelectedItems[0].SubItems[3].Text = NP;
                    listView_sup.SelectedItems[0].SubItems[4].Text = NP2;

                    textBox_NU.Text = "";
                    textBox_NP.Text = "";
                    textBox_NP2.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新失败！提示：" + ex.Message);
                }

            }

        }

        private void button_Nclear_Click(object sender, EventArgs e)
        {
            textBox_NU.Text = "";
            textBox_NP.Text = "";
            textBox_NP2.Text = "";
            
        }

        private void textBox_P_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }  
        }

        private void textBox_NP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键  
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数  
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符  
                }
            }  
        }

        private void textBox_U_TextChanged(object sender, EventArgs e)
        {
            String u = textBox_U.Text;
            conn.Open();

            string sql1 = "select * from supplier where supplier_name='" + u + "'";
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

     
    }
}
