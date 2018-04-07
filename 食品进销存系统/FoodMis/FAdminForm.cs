using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Diagnostics;
using System.IO;

namespace FoodMis
{
    public partial class FAdminForm : Skin_Mac
    {
        public FAdminForm()
        {
            InitializeComponent();
        }
       
        public static String Username;
        public static String Password;

        private void FAdminForm_Load(object sender, EventArgs e)
        {
            label_Bleft.Text = "欢迎 管理员 " + Username + "  进入食品进销存系统 . . . ";
        }

        private void 管理员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理员管理 admin = new 管理员管理();
            admin.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(admin);
        }

        private void 采购员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            采购员管理 buyer = new 采购员管理();
            buyer.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(buyer);
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客户管理 customer = new 客户管理();
            customer.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(customer);
        }

        private void 销售员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            销售员管理 salesperson = new 销售员管理();
            salesperson.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(salesperson);
     
        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            供应商管理 supplier = new 供应商管理();
            supplier.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(supplier);
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Bright.Text = dt.ToString(" yyyy年MM月dd日  下午hh:mm:ss");
   
        }

        private void 注销ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要注销登录吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                StartExe(Application.ExecutablePath);
                Application.ExitThread();
            }
        }
        private static void StartExe(string appName)
        {
            string path = appName;
            Process ps = new Process();
            ps.StartInfo.FileName = path;
            ps.StartInfo.Arguments = "T";
            ps.StartInfo.CreateNoWindow = true;
            ps.StartInfo.WorkingDirectory = Path.GetDirectoryName(path);
            ps.Start();
        }

    }
}
