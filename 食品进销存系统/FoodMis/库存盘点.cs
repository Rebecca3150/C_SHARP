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
    public partial class 库存盘点 : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;

        public 库存盘点()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private void 库存盘点_Load(object sender, EventArgs e)
        {
            conn.Open();

            string sql1 = "select * from commodity_stock";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView_stock.Items.Add((listView_stock.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["goods_id"]));
                int id = Convert.ToInt32(reader["goods_id"]);
                item.SubItems.Add(Convert.ToString(reader["num"]));
                item.SubItems.Add(Convert.ToString(reader["commodity_name"]));
                item.SubItems.Add(Convert.ToString(reader["original_price"]));
                item.SubItems.Add(Convert.ToString(reader["price"]));
        
                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();
        }

      

        private void button_up_Click(object sender, EventArgs e)
        {
            listView_stock.Items.Clear();
            conn.Open();

            string sql1 = "select * from commodity_stock";
            command = new SqlCommand(sql1, conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = listView_stock.Items.Add((listView_stock.Items.Count + 1) + "");
                item.SubItems.Add(Convert.ToString(reader["goods_id"]));
               item.SubItems.Add(Convert.ToString(reader["num"]));
                item.SubItems.Add(Convert.ToString(reader["commodity_name"]));
                item.SubItems.Add(Convert.ToString(reader["original_price"]));
                item.SubItems.Add(Convert.ToString(reader["price"]));
                item.EnsureVisible();//让listView始终显示最新的一行数据
            }
            reader.Close();
            conn.Close();


        }

        private void Button_select_Click(object sender, EventArgs e)
        {
            listView_stock.Items.Clear();
            try
            {
            string sqll = "";
            if (textBox_name.Text == "")
            {
                MessageBox.Show("为空！");
            }
            else
            {
              
                    sqll="select * from commodity_stock where commodity_name like '%" + textBox_name.Text + "%'";
               
            }
           
           
                conn.Open();

               command = new SqlCommand(sqll, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = listView_stock.Items.Add((listView_stock.Items.Count + 1) + "");
                    item.SubItems.Add(Convert.ToString(reader["goods_id"]));
                    item.SubItems.Add(Convert.ToString(reader["num"]));
                    item.SubItems.Add(Convert.ToString(reader["commodity_name"]));
                    item.SubItems.Add(Convert.ToString(reader["original_price"]));
                    item.SubItems.Add(Convert.ToString(reader["price"]));
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

    
    }
}
