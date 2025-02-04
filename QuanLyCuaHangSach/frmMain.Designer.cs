using System.Drawing;

namespace QuanLyCuaHangSach
{
    partial class frmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taoHoaDonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baoCaoToolStripMenuItem;
        private System.Windows.Forms.Panel panelContainer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taoHoaDonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baoCaoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TimKiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.sachToolStripMenuItem,
            this.taoHoaDonToolStripMenuItem,
            this.quanLyTaiKhoanToolStripMenuItem,
            this.baoCaoToolStripMenuItem,
            this.TimKiemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1000, 35);
            this.menuStrip1.TabIndex = 0;
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(112, 31);
            this.homeToolStripMenuItem.Text = "🏠 Trang chủ";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // sachToolStripMenuItem
            // 
            this.sachToolStripMenuItem.Name = "sachToolStripMenuItem";
            this.sachToolStripMenuItem.Size = new System.Drawing.Size(79, 31);
            this.sachToolStripMenuItem.Text = "📖 Sách";
            this.sachToolStripMenuItem.Click += new System.EventHandler(this.sachToolStripMenuItem_Click);
            // 
            // taoHoaDonToolStripMenuItem
            // 
            this.taoHoaDonToolStripMenuItem.Name = "taoHoaDonToolStripMenuItem";
            this.taoHoaDonToolStripMenuItem.Size = new System.Drawing.Size(132, 31);
            this.taoHoaDonToolStripMenuItem.Text = "📝 Tạo hóa đơn";
            this.taoHoaDonToolStripMenuItem.Click += new System.EventHandler(this.taoHoaDonToolStripMenuItem_Click);
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(163, 31);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "👤 Quản lý tài khoản";
            this.quanLyTaiKhoanToolStripMenuItem.Click += new System.EventHandler(this.quanLyTaiKhoanToolStripMenuItem_Click);
            // 
            // baoCaoToolStripMenuItem
            // 
            this.baoCaoToolStripMenuItem.Name = "baoCaoToolStripMenuItem";
            this.baoCaoToolStripMenuItem.Size = new System.Drawing.Size(102, 31);
            this.baoCaoToolStripMenuItem.Text = "📊 Báo cáo";
            this.baoCaoToolStripMenuItem.Click += new System.EventHandler(this.baoCaoToolStripMenuItem_Click);
            // 
            // TimKiemToolStripMenuItem
            // 
            this.TimKiemToolStripMenuItem.Name = "TimKiemToolStripMenuItem";
            this.TimKiemToolStripMenuItem.Size = new System.Drawing.Size(105, 31);
            this.TimKiemToolStripMenuItem.Text = "🔍Tìm kiếm";
            this.TimKiemToolStripMenuItem.Click += new System.EventHandler(this.TimKiemToolStripMenuItem_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.Control;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 35);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1000, 565);
            this.panelContainer.TabIndex = 1;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // frmMain
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Quản lý Cửa hàng Sách";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.ToolStripMenuItem TimKiemToolStripMenuItem;
    }
}
