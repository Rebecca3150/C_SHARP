namespace FoodMis
{
    partial class FSaleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSaleForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.销售单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.浏览销售情况ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增销售ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户设置ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Bleft = new System.Windows.Forms.Label();
            this.label_Bright = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.销售单ToolStripMenuItem,
            this.收款单ToolStripMenuItem,
            this.用户设置ToolStripMenuItem1,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 销售单ToolStripMenuItem
            // 
            this.销售单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.浏览销售情况ToolStripMenuItem,
            this.新增销售ToolStripMenuItem});
            this.销售单ToolStripMenuItem.Name = "销售单ToolStripMenuItem";
            this.销售单ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.销售单ToolStripMenuItem.Text = "销售管理";
            // 
            // 浏览销售情况ToolStripMenuItem
            // 
            this.浏览销售情况ToolStripMenuItem.Name = "浏览销售情况ToolStripMenuItem";
            this.浏览销售情况ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.浏览销售情况ToolStripMenuItem.Text = "销售情况";
            this.浏览销售情况ToolStripMenuItem.Click += new System.EventHandler(this.浏览销售情况ToolStripMenuItem_Click);
            // 
            // 新增销售ToolStripMenuItem
            // 
            this.新增销售ToolStripMenuItem.Name = "新增销售ToolStripMenuItem";
            this.新增销售ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.新增销售ToolStripMenuItem.Text = "新增销售";
            this.新增销售ToolStripMenuItem.Click += new System.EventHandler(this.新增销售ToolStripMenuItem_Click);
            // 
            // 收款单ToolStripMenuItem
            // 
            this.收款单ToolStripMenuItem.Name = "收款单ToolStripMenuItem";
            this.收款单ToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.收款单ToolStripMenuItem.Text = "收款单";
            this.收款单ToolStripMenuItem.Click += new System.EventHandler(this.收款单ToolStripMenuItem_Click);
            // 
            // 用户设置ToolStripMenuItem1
            // 
            this.用户设置ToolStripMenuItem1.Name = "用户设置ToolStripMenuItem1";
            this.用户设置ToolStripMenuItem1.Size = new System.Drawing.Size(81, 24);
            this.用户设置ToolStripMenuItem1.Text = "个人中心";
            this.用户设置ToolStripMenuItem1.Click += new System.EventHandler(this.用户设置ToolStripMenuItem1_Click);
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Location = new System.Drawing.Point(3, 75);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(1019, 641);
            this.MainGroup.TabIndex = 4;
            this.MainGroup.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(201, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 70);
            this.label1.TabIndex = 0;
            this.label1.Text = "食品进销存系统";
            // 
            // label_Bleft
            // 
            this.label_Bleft.AutoSize = true;
            this.label_Bleft.Location = new System.Drawing.Point(7, 719);
            this.label_Bleft.Name = "label_Bleft";
            this.label_Bleft.Size = new System.Drawing.Size(15, 15);
            this.label_Bleft.TabIndex = 9;
            this.label_Bleft.Text = "l";
            // 
            // label_Bright
            // 
            this.label_Bright.AutoSize = true;
            this.label_Bright.Location = new System.Drawing.Point(806, 719);
            this.label_Bright.Name = "label_Bright";
            this.label_Bright.Size = new System.Drawing.Size(67, 15);
            this.label_Bright.TabIndex = 8;
            this.label_Bright.Text = "显示时间";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // FSaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 751);
            this.Controls.Add(this.label_Bleft);
            this.Controls.Add(this.label_Bright);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FSaleForm";
            this.Text = "食品进销存系统——销售管理";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.FSaleForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_Bleft;
        private System.Windows.Forms.Label label_Bright;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem 销售单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 收款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 浏览销售情况ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增销售ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户设置ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}