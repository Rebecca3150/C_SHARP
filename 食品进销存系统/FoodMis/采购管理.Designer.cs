namespace FoodMis
{
    partial class 采购管理
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(采购管理));
            this.mainWindows = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.采购录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.增加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.采购单据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.付款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindows
            // 
            this.mainWindows.Location = new System.Drawing.Point(8, 78);
            this.mainWindows.Margin = new System.Windows.Forms.Padding(4);
            this.mainWindows.Name = "mainWindows";
            this.mainWindows.Padding = new System.Windows.Forms.Padding(4);
            this.mainWindows.Size = new System.Drawing.Size(1035, 455);
            this.mainWindows.TabIndex = 4;
            this.mainWindows.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采购录入ToolStripMenuItem,
            this.采购单据ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 采购录入ToolStripMenuItem
            // 
            this.采购录入ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.增加ToolStripMenuItem});
            this.采购录入ToolStripMenuItem.Name = "采购录入ToolStripMenuItem";
            this.采购录入ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.采购录入ToolStripMenuItem.Text = "采购单据";
            // 
            // 增加ToolStripMenuItem
            // 
            this.增加ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem,
            this.新增ToolStripMenuItem1});
            this.增加ToolStripMenuItem.Name = "增加ToolStripMenuItem";
            this.增加ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.增加ToolStripMenuItem.Text = "购货订单";
            // 
            // 查询ToolStripMenuItem
            // 
            this.查询ToolStripMenuItem.Name = "查询ToolStripMenuItem";
            this.查询ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.查询ToolStripMenuItem.Text = "查询";
            this.查询ToolStripMenuItem.Click += new System.EventHandler(this.查询ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem1
            // 
            this.新增ToolStripMenuItem1.Name = "新增ToolStripMenuItem1";
            this.新增ToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.新增ToolStripMenuItem1.Text = "新增";
            this.新增ToolStripMenuItem1.Click += new System.EventHandler(this.新增ToolStripMenuItem1_Click);
            // 
            // 采购单据ToolStripMenuItem
            // 
            this.采购单据ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.付款单ToolStripMenuItem});
            this.采购单据ToolStripMenuItem.Name = "采购单据ToolStripMenuItem";
            this.采购单据ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.采购单据ToolStripMenuItem.Text = "资金单据";
            // 
            // 付款单ToolStripMenuItem
            // 
            this.付款单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询ToolStripMenuItem1});
            this.付款单ToolStripMenuItem.Name = "付款单ToolStripMenuItem";
            this.付款单ToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.付款单ToolStripMenuItem.Text = "付款单";
            // 
            // 查询ToolStripMenuItem1
            // 
            this.查询ToolStripMenuItem1.Name = "查询ToolStripMenuItem1";
            this.查询ToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.查询ToolStripMenuItem1.Text = "查询";
            this.查询ToolStripMenuItem1.Click += new System.EventHandler(this.查询ToolStripMenuItem1_Click);
            // 
            // 采购管理
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 559);
            this.Controls.Add(this.mainWindows);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "采购管理";
            this.Text = "采购管理";
            this.TitleCenter = false;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox mainWindows;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 采购录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 增加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购单据ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 付款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 查询ToolStripMenuItem1;
    }
}