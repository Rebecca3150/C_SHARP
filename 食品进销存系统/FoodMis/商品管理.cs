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
    public partial class 商品管理 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        public 商品管理()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }


       private void 商品管理_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql1 = "select * from goods";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView_goods.Items.Add((listView_goods.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["goods_name"]));
                item.SubItems.Add(Convert.ToString(reader["original_price"]));
                item.SubItems.Add(Convert.ToString(reader["supplier_id"]));

                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();
          
        }

        private void Button_select_Click(object sender, EventArgs e)
        {
            listView_goods.Items.Clear();
            int id = Convert.ToInt32(TextBox_select.Text);
            try
            {
                conn.Open();

                string sql1 = "select * from goods where id like '%" + id + "%'";
                command = new SqlCommand(sql1, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = listView_goods.Items.Add((listView_goods.Items.Count + 1) + "");
                    item.SubItems.Add(Convert.ToString(reader["id"]));
                    item.SubItems.Add(Convert.ToString(reader["goods_name"]));
                    item.SubItems.Add(Convert.ToString(reader["original_price"]));
                    item.SubItems.Add(Convert.ToString(reader["supplier_id"]));

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

        private void Button_delete_Click(object sender, EventArgs e)
        {

            if (listView_goods.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确定删除?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(listView_goods.SelectedItems[0].SubItems[1].Text);
                    conn.Open();
                    string sql = "delete from goods where id='" + ID + "'";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    //6.选择Command的适合方法
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                    {
                        MessageBox.Show("删除成功!");
                        //   this.BindData();
                        listView_goods.SelectedItems[0].Remove();//删除选定行
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
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            listView_goods.Items.Clear();
            conn.Open();

            string sql1 = "select * from goods";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView_goods.Items.Add((listView_goods.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["id"]));
                item.SubItems.Add(Convert.ToString(reader["goods_name"]));
                item.SubItems.Add(Convert.ToString(reader["original_price"]));
                item.SubItems.Add(Convert.ToString(reader["supplier_id"]));

                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();
           
        }

        private void listView_goods_SelectedIndexChanged(object sender, EventArgs e)
        {
             if (listView_goods.SelectedItems.Count > 0)//如果已经选择了某行数据
            {
                textBox_name.Text = listView_goods.SelectedItems[0].SubItems[2].Text;
                textBox_price.Text = listView_goods.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            商品添加 addGoodsForm = new 商品添加();
            addGoodsForm.ShowDialog();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            String name = textBox_name.Text;
            String price = textBox_price.Text;

            if (listView_goods.SelectedItems.Count > 0)//如果已经选择了某行
            {
                try
                {
                    //开始向数据库中更新数据
                  
                    MessageBox.Show("更新完成！");
                    textBox_name.Text = "";
                    textBox_price.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("更新失败！提示：" + ex.Message);
                }

            }
        }

        private void button_Nclear_Click(object sender, EventArgs e)
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

        private void button_update_Click_1(object sender, EventArgs e)
        {
            String name = textBox_name.Text;
            String price = textBox_price.Text;
          
                if (listView_goods.SelectedItems.Count > 0)//如果已经选择了某行
                {
                    try
                    {
                        int ID = Convert.ToInt32(listView_goods.SelectedItems[0].SubItems[1].Text);

                        //开始向数据库中更新数据
                        string sql = "update goods set goods_name='" + name + "',original_price='" + price + "' where id=" + ID;
                        conn.Open();
                        command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show(this, "更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();

                        //列表中修改
                        listView_goods.SelectedItems[0].SubItems[2].Text = name;
                        listView_goods.SelectedItems[0].SubItems[3].Text = price;

                        textBox_name.Text = "";
                        textBox_price.Text = "";
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("更新失败！提示：" + ex.Message);
                    }

                }

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button_Nclear_Click_1(object sender, EventArgs e)
        {
            textBox_name.Text = "";
            textBox_price.Text = "";
        }

      
     

      
    }
}
