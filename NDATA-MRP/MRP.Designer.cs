namespace NDATA_MRP
{
    partial class MainForm
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.HeThongMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangNhapMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DangXuatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoiMatKhauMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuanLyUserMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ThoatMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PhieuCanMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HeThongMenuItem,
            this.PhieuCanMenuItem,
            this.nhaToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuMain.Size = new System.Drawing.Size(1367, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuMain";
            // 
            // HeThongMenuItem
            // 
            this.HeThongMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DangNhapMenuItem,
            this.DangXuatMenuItem,
            this.DoiMatKhauMenuItem,
            this.QuanLyUserMenuItem,
            this.toolStripSeparator1,
            this.ThoatMenuItem});
            this.HeThongMenuItem.Name = "HeThongMenuItem";
            this.HeThongMenuItem.Size = new System.Drawing.Size(69, 20);
            this.HeThongMenuItem.Text = "Hệ thống";
            // 
            // DangNhapMenuItem
            // 
            this.DangNhapMenuItem.Name = "DangNhapMenuItem";
            this.DangNhapMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DangNhapMenuItem.Text = "Đăng &nhập";
            this.DangNhapMenuItem.Click += new System.EventHandler(this.DangNhapMenuItem_Click);
            // 
            // DangXuatMenuItem
            // 
            this.DangXuatMenuItem.Enabled = false;
            this.DangXuatMenuItem.Name = "DangXuatMenuItem";
            this.DangXuatMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DangXuatMenuItem.Text = "Đăng &xuất";
            this.DangXuatMenuItem.Click += new System.EventHandler(this.DangXuatMenuItem_Click);
            // 
            // DoiMatKhauMenuItem
            // 
            this.DoiMatKhauMenuItem.Enabled = false;
            this.DoiMatKhauMenuItem.Name = "DoiMatKhauMenuItem";
            this.DoiMatKhauMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DoiMatKhauMenuItem.Text = "Đổi mật khẩu";
            this.DoiMatKhauMenuItem.Click += new System.EventHandler(this.DoiMatKhauMenuItem_Click);
            // 
            // QuanLyUserMenuItem
            // 
            this.QuanLyUserMenuItem.Enabled = false;
            this.QuanLyUserMenuItem.Name = "QuanLyUserMenuItem";
            this.QuanLyUserMenuItem.Size = new System.Drawing.Size(180, 22);
            this.QuanLyUserMenuItem.Text = "Q&uản lý người dùng";
            this.QuanLyUserMenuItem.Click += new System.EventHandler(this.QuanLyUserMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // ThoatMenuItem
            // 
            this.ThoatMenuItem.Name = "ThoatMenuItem";
            this.ThoatMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ThoatMenuItem.Text = "&Thoát";
            this.ThoatMenuItem.Click += new System.EventHandler(this.ThoatMenuItem_Click);
            // 
            // PhieuCanMenuItem
            // 
            this.PhieuCanMenuItem.Name = "PhieuCanMenuItem";
            this.PhieuCanMenuItem.Size = new System.Drawing.Size(71, 20);
            this.PhieuCanMenuItem.Text = "Phiếu cân";
            // 
            // nhaToolStripMenuItem
            // 
            this.nhaToolStripMenuItem.Name = "nhaToolStripMenuItem";
            this.nhaToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.nhaToolStripMenuItem.Text = "Nhân sự";
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.kháchHàngToolStripMenuItem.Text = "&Khách hàng";
            // 
            // statusMain
            // 
            this.statusMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusMain.Location = new System.Drawing.Point(0, 510);
            this.statusMain.Name = "statusMain";
            this.statusMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusMain.Size = new System.Drawing.Size(1367, 22);
            this.statusMain.TabIndex = 2;
            this.statusMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(38, 17);
            this.toolStripStatusLabel1.Text = "status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 532);
            this.Controls.Add(this.statusMain);
            this.Controls.Add(this.menuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "MRP - PATAYA VIỆT NAM";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusMain.ResumeLayout(false);
            this.statusMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem HeThongMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangNhapMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DangXuatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoiMatKhauMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ThoatMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PhieuCanMenuItem;
        private System.Windows.Forms.StatusStrip statusMain;
        private System.Windows.Forms.ToolStripMenuItem QuanLyUserMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}