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
    public partial class FSupMainForm : Skin_Mac
    {
        public FSupMainForm()
        {
            InitializeComponent();
        }

        public static String Username;
        public static String Password;

        public 管理员管理 admin;
        public 采购员管理 buyer;
        public 客户管理 customer;
        public 销售员管理 salesperson;
        public 供应商管理 supplier;
        public 商品管理 goods;
        public 利润分析 money;
        public 库存盘点 commodity_stock;
      

        private void MainForm_Load(object sender, EventArgs e)
        {
            label_Bleft.Text = "欢迎 超级管理员 " + Username + "  进入食品进销存系统 . . . ";
            admin = new 管理员管理();
            buyer = new 采购员管理();
            customer = new 客户管理();
            salesperson = new 销售员管理();
            supplier = new 供应商管理();
            goods = new 商品管理();
            money = new 利润分析();
            commodity_stock = new 库存盘点();
       
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Bright.Text = dt.ToString(" yyyy年MM月dd日  下午hh:mm:ss");
   
        }

        private void 管理员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(admin);
        }

        private void 采购员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            buyer.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(buyer);
        }

        private void 客户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(customer);
    
        }

        private void 销售员管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            salesperson.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(salesperson);
     
        }

        private void 供应商管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supplier.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(supplier);
  
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            goods.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(goods);
    
        }

      

     
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void 采购管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            采购管理 purchasing = new 采购管理();
            purchasing.Show();
        }

        private void 利润分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            money.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(money);
        }

        private void 库存管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            commodity_stock.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(commodity_stock);
        }

        private void 收款单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X收款单 sk = new X收款单();
            sk.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(sk);
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
