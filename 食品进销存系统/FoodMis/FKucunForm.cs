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
    public partial class FKucunForm : Skin_Mac
    {
        public FKucunForm()
        {
            InitializeComponent();
        }

        public static String Username;
        public static String Password;


        private void FKucunForm_Load(object sender, EventArgs e)
        {
            label_Bleft.Text = "欢迎 仓库管理员 " + Username + "  进入食品进销存系统 . . . ";
        }

        private void 利润分析ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            利润分析 money = new 利润分析();
            money.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(money);
        }

        private void 库存盘点ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            库存盘点 commodity_stock = new 库存盘点();
            commodity_stock.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(commodity_stock);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Bright.Text = dt.ToString(" yyyy年MM月dd日  下午hh:mm:ss");
   
        }

        private void 商品管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            商品管理 goods = new 商品管理();
            goods.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(goods);
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
