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
    public partial class RegisterForm : Skin_Mac
    {
        public RegisterForm()
        {
            InitializeComponent();
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "系统管理员")
            {
                Zadmin ad = new Zadmin();
                ad.Show();
                groupMain.Controls.Clear();
                groupMain.Controls.Add(ad);
            }
            else if (comboBox1.Text == "销售员")
            {
                Zxiaoshou xi = new Zxiaoshou();
                xi.Show();
                groupMain.Controls.Clear();
                groupMain.Controls.Add(xi);
            }
            else if (comboBox1.Text == "采购员")
            {
                Zcaigou ca = new Zcaigou();
                ca.Show();
                groupMain.Controls.Clear();
                groupMain.Controls.Add(ca);
            }
          
        }

       

       
     
    }
}
