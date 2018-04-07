namespace FoodMis
{
    partial class FSupMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSupMainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.采购管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.收款单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.利润分析ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.库存管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.采购员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MainGroup = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_Bright = new System.Windows.Forms.Label();
            this.label_Bleft = new System.Windows.Forms.Label();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.MainGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.采购管理ToolStripMenuItem,
            this.销售管理ToolStripMenuItem,
            this.库存管理ToolStripMenuItem,
            this.用户管理ToolStripMenuItem,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(4, 32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1043, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 采购管理ToolStripMenuItem
            // 
            this.采购管理ToolStripMenuItem.Name = "采购管理ToolStripMenuItem";
            this.采购管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.采购管理ToolStripMenuItem.Text = "采购管理";
            this.采购管理ToolStripMenuItem.Click += new System.EventHandler(this.采购管理ToolStripMenuItem_Click);
            // 
            // 销售管理ToolStripMenuItem
            // 
            this.销售管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.收款单ToolStripMenuItem});
            this.销售管理ToolStripMenuItem.Name = "销售管理ToolStripMenuItem";
            this.销售管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.销售管理ToolStripMenuItem.Text = "销售管理";
            // 
            // 收款单ToolStripMenuItem
            // 
            this.收款单ToolStripMenuItem.Name = "收款单ToolStripMenuItem";
            this.收款单ToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.收款单ToolStripMenuItem.Text = "收款单";
            this.收款单ToolStripMenuItem.Click += new System.EventHandler(this.收款单ToolStripMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem
            // 
            this.库存管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.利润分析ToolStripMenuItem,
            this.库存管理ToolStripMenuItem1});
            this.库存管理ToolStripMenuItem.Name = "库存管理ToolStripMenuItem";
            this.库存管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.库存管理ToolStripMenuItem.Text = "库存管理";
            // 
            // 利润分析ToolStripMenuItem
            // 
            this.利润分析ToolStripMenuItem.Name = "利润分析ToolStripMenuItem";
            this.利润分析ToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.利润分析ToolStripMenuItem.Text = "利润分析";
            this.利润分析ToolStripMenuItem.Click += new System.EventHandler(this.利润分析ToolStripMenuItem_Click);
            // 
            // 库存管理ToolStripMenuItem1
            // 
            this.库存管理ToolStripMenuItem1.Name = "库存管理ToolStripMenuItem1";
            this.库存管理ToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.库存管理ToolStripMenuItem1.Text = "库存盘点";
            this.库存管理ToolStripMenuItem1.Click += new System.EventHandler(this.库存管理ToolStripMenuItem1_Click);
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员管理ToolStripMenuItem,
            this.采购员管理ToolStripMenuItem,
            this.客户管理ToolStripMenuItem,
            this.销售员管理ToolStripMenuItem,
            this.供应商管理ToolStripMenuItem,
            this.商品管理ToolStripMenuItem});
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.管理员管理ToolStripMenuItem.Text = "管理员管理";
            this.管理员管理ToolStripMenuItem.Click += new System.EventHandler(this.管理员管理ToolStripMenuItem_Click);
            // 
            // 采购员管理ToolStripMenuItem
            // 
            this.采购员管理ToolStripMenuItem.Name = "采购员管理ToolStripMenuItem";
            this.采购员管理ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.采购员管理ToolStripMenuItem.Text = "采购员管理";
            this.采购员管理ToolStripMenuItem.Click += new System.EventHandler(this.采购员管理ToolStripMenuItem_Click);
            // 
            // 客户管理ToolStripMenuItem
            // 
            this.客户管理ToolStripMenuItem.Name = "客户管理ToolStripMenuItem";
            this.客户管理ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.客户管理ToolStripMenuItem.Text = "客户管理";
            this.客户管理ToolStripMenuItem.Click += new System.EventHandler(this.客户管理ToolStripMenuItem_Click);
            // 
            // 销售员管理ToolStripMenuItem
            // 
            this.销售员管理ToolStripMenuItem.Name = "销售员管理ToolStripMenuItem";
            this.销售员管理ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.销售员管理ToolStripMenuItem.Text = "销售员管理";
            this.销售员管理ToolStripMenuItem.Click += new System.EventHandler(this.销售员管理ToolStripMenuItem_Click);
            // 
            // 供应商管理ToolStripMenuItem
            // 
            this.供应商管理ToolStripMenuItem.Name = "供应商管理ToolStripMenuItem";
            this.供应商管理ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.供应商管理ToolStripMenuItem.Text = "供应商管理";
            this.供应商管理ToolStripMenuItem.Click += new System.EventHandler(this.供应商管理ToolStripMenuItem_Click);
            // 
            // 商品管理ToolStripMenuItem
            // 
            this.商品管理ToolStripMenuItem.Name = "商品管理ToolStripMenuItem";
            this.商品管理ToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.商品管理ToolStripMenuItem.Text = "商品管理";
            this.商品管理ToolStripMenuItem.Click += new System.EventHandler(this.商品管理ToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainGroup
            // 
            this.MainGroup.Controls.Add(this.label1);
            this.MainGroup.Location = new System.Drawing.Point(3, 73);
            this.MainGroup.Name = "MainGroup";
            this.MainGroup.Size = new System.Drawing.Size(1019, 643);
            this.MainGroup.TabIndex = 3;
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
            // label_Bright
            // 
            this.label_Bright.AutoSize = true;
            this.label_Bright.Location = new System.Drawing.Point(806, 719);
            this.label_Bright.Name = "label_Bright";
            this.label_Bright.Size = new System.Drawing.Size(67, 15);
            this.label_Bright.TabIndex = 6;
            this.label_Bright.Text = "显示时间";
            // 
            // label_Bleft
            // 
            this.label_Bleft.AutoSize = true;
            this.label_Bleft.Location = new System.Drawing.Point(7, 719);
            this.label_Bleft.Name = "label_Bleft";
            this.label_Bleft.Size = new System.Drawing.Size(15, 15);
            this.label_Bleft.TabIndex = 7;
            this.label_Bleft.Text = "l";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // FSupMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1051, 751);
            this.Controls.Add(this.label_Bleft);
            this.Controls.Add(this.label_Bright);
            this.Controls.Add(this.MainGroup);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FSupMainForm";
            this.Text = "食品进销存系统";
            this.TitleCenter = false;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.MainGroup.ResumeLayout(false);
            this.MainGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 采购管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 采购员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品管理ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox MainGroup;
        private System.Windows.Forms.Label label_Bright;
        private System.Windows.Forms.Label label_Bleft;
        private System.Windows.Forms.ToolStripMenuItem 利润分析ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 库存管理ToolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem 收款单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}