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
    public partial class FSaleForm : Skin_Mac
    {
        public FSaleForm()
        {
            InitializeComponent();
        }

        public static String NAME;
        public static String Username;
        public static String Password;

        private void FSaleForm_Load(object sender, EventArgs e)
        {
            label_Bleft.Text = "欢迎 销售员 " + NAME + "  进入食品进销存系统 . . . ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            label_Bright.Text = dt.ToString(" yyyy年MM月dd日  下午hh:mm:ss");
   
        }

        private void 浏览销售情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X销售情况 g = new X销售情况();
            g.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(g);
        }

        private void 新增销售ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X添加销售.NAME = NAME;
            X添加销售.Username = Username;
            X添加销售 gt = new X添加销售();
            gt.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(gt);
        }

        private void 收款单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X收款单 sk = new X收款单();
            sk.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(sk);
        }

        private void 用户设置ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            X用户设置.NAME = NAME;
            X用户设置.Username = Username;
            X用户设置.Password = Password;
            X用户设置 yh = new X用户设置();
            yh.Show();
            MainGroup.Controls.Clear();
            MainGroup.Controls.Add(yh);
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
