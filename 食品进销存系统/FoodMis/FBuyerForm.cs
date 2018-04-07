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
    public partial class FBuyerForm : Skin_Mac
    {
        public FBuyerForm()
        {
            InitializeComponent();
        }

        public static String NAME;
        public static String Username;
        public static String Password;

        private void FBuyerForm_Load(object sender, EventArgs e)
        {
            label_Bleft.Text = "欢迎 采购员 " + NAME + "  进入食品进销存系统 . . . ";
        }

      
        private void 个人中心ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            C个人中心.NAME = NAME;
            C个人中心.Username = Username;
            C个人中心.Password = Password;
            C个人中心 yh = new C个人中心();
            yh.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(yh);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Bright.Text = dt.ToString(" yyyy年MM月dd日  下午hh:mm:ss");
   
        }

        private void 采购ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            采购管理 add = new 采购管理();
            add.ShowDialog();
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
