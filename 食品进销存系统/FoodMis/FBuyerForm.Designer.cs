namespace FoodMis
{
    partial class FBuyerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FBuyerForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.采购ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.资金单据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人中心ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.付款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label_Bleft = new System.Windows.Forms.Label();
            this.label_Bright = new System.Windows.Forms.Label();
            this.新增ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采购ToolStripMenuItem,
            this.资金单据ToolStripMenuItem,
            this.个人中心ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 采购ToolStripMenuItem
            // 
            this.采购ToolStripMenuItem.Name = "采购ToolStripMenuItem";
            this.采购ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.采购ToolStripMenuItem.Text = "采购管理";
            this.采购ToolStripMenuItem.Click += new System.EventHandler(this.采购ToolStripMenuItem_Click);
            // 
            // 资金单据ToolStripMenuItem
            // 
            this.资金单据ToolStripMenuItem.Name = "资金单据ToolStripMenuItem";
            this.资金单据ToolStripMenuItem.Size = new System.Drawing.Size(12, 24);
            // 
            // 个人中心ToolStripMenuItem
            // 
            this.个人中心ToolStripMenuItem.Name = "个人中心ToolStripMenuItem";
            this.个人中心ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.个人中心ToolStripMenuItem.Text = "个人中心";
            this.个人中心ToolStripMenuItem.Click += new System.EventHandler(this.个人中心ToolStripMenuItem_Click);
            // 
            // 付款单ToolStripMenuItem
            // 
            this.付款单ToolStripMenuItem.Name = "付款单ToolStripMenuItem";
            this.付款单ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Location = new System.Drawing.Point(3, 75);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(1019, 641);
            this.MainGroup.TabIndex = 5;
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label_Bleft
            // 
            this.label_Bleft.AutoSize = true;
            this.label_Bleft.Location = new System.Drawing.Point(7, 719);
            this.label_Bleft.Name = "label_Bleft";
            this.label_Bleft.Size = new System.Drawing.Size(15, 15);
            this.label_Bleft.TabIndex = 11;
            this.label_Bleft.Text = "l";
            // 
            // label_Bright
            // 
            this.label_Bright.AutoSize = true;
            this.label_Bright.Location = new System.Drawing.Point(806, 719);
            this.label_Bright.Name = "label_Bright";
            this.label_Bright.Size = new System.Drawing.Size(67, 15);
            this.label_Bright.TabIndex = 10;
            this.label_Bright.Text = "显示时间";
            // 
            // 新增ToolStripMenuItem1
            // 
            this.新增ToolStripMenuItem1.Name = "新增ToolStripMenuItem1";
            this.新增ToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // FBuyerForm
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
            this.Name = "FBuyerForm";
            this.Text = "食品进销存系统——采购管理";
            this.TitleCenter = false;
            this.Load += new System.EventHandler(this.FBuyerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 采购ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 资金单据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人中心ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 付款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label_Bleft;
        private System.Windows.Forms.Label label_Bright;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}