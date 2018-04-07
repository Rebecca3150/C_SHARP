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
    public partial class AddPayment : UserControl
    {
        private SqlConnection conn;
        private SqlCommand command;
        public int Purchasing_id;
        private double Y_money;

        public AddPayment()
        {
            InitializeComponent();
            conn = new SqlConnection(@"data source=DESKTOP-5L92GB0;initial catalog=dbFoodMis;user id=sa;pwd=218028;");

        }

        private void AddPayment_Load(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            Y_money = Convert.ToDouble(A_money.Text);
            string sql = "insert into payment(supplier_name,info,purchasing_id,buyer_name,type,a_money,y_money,status) values ('" + Supplier_name.Text + "','" + info.Text + "','" + Purchasing_id + "','" + Buyer_name.Text + "','" + type.Text + "','" + A_money.Text + "','" + Y_money + "','" + 1 + "')";
            conn.Open();
            command = new SqlCommand(sql, conn);
            command.ExecuteNonQuery();
            MessageBox.Show(this, "成功添加付款单！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            conn.Close();


            AddPurchasing addPurchasing = new AddPurchasing();
            addPurchasing.Show();
            this.Controls.Clear();
            this.Controls.Add(addPurchasing);
             
        }

        private void reset_Click(object sender, EventArgs e)
        {

        }
    }
}
