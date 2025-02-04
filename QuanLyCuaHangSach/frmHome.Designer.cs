using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangSach
{
    partial class frmHome
    {
        private System.ComponentModel.IContainer components = null;

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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelSoDonHang = new System.Windows.Forms.Panel();
            this.lblSoDonHang = new System.Windows.Forms.Label();
            this.btnShowSoDon = new System.Windows.Forms.Button();
            this.panelSoSachBan = new System.Windows.Forms.Panel();
            this.lblSoSachBan = new System.Windows.Forms.Label();
            this.btnShowSoSach = new System.Windows.Forms.Button();
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.btnShowDoanhThu = new System.Windows.Forms.Button();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.chrData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelSoDonHang.SuspendLayout();
            this.panelSoSachBan.SuspendLayout();
            this.panelDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chrData)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSoDonHang
            // 
            this.panelSoDonHang.BackColor = System.Drawing.Color.LightBlue;
            this.panelSoDonHang.Controls.Add(this.lblSoDonHang);
            this.panelSoDonHang.Controls.Add(this.btnShowSoDon);
            this.panelSoDonHang.Location = new System.Drawing.Point(30, 30);
            this.panelSoDonHang.Name = "panelSoDonHang";
            this.panelSoDonHang.Size = new System.Drawing.Size(250, 100);
            this.panelSoDonHang.TabIndex = 0;
            // 
            // lblSoDonHang
            // 
            this.lblSoDonHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoDonHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoDonHang.Location = new System.Drawing.Point(10, 10);
            this.lblSoDonHang.Name = "lblSoDonHang";
            this.lblSoDonHang.Size = new System.Drawing.Size(237, 23);
            this.lblSoDonHang.TabIndex = 0;
            this.lblSoDonHang.Text = "Số đơn theo ngày";
            this.lblSoDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowSoDon
            // 
            this.btnShowSoDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSoDon.Location = new System.Drawing.Point(70, 50);
            this.btnShowSoDon.Name = "btnShowSoDon";
            this.btnShowSoDon.Size = new System.Drawing.Size(100, 30);
            this.btnShowSoDon.TabIndex = 1;
            this.btnShowSoDon.Text = "Xem biểu đồ";
            this.btnShowSoDon.Click += new System.EventHandler(this.btnShowSoDon_Click);
            // 
            // panelSoSachBan
            // 
            this.panelSoSachBan.BackColor = System.Drawing.Color.LightGreen;
            this.panelSoSachBan.Controls.Add(this.lblSoSachBan);
            this.panelSoSachBan.Controls.Add(this.btnShowSoSach);
            this.panelSoSachBan.Location = new System.Drawing.Point(300, 30);
            this.panelSoSachBan.Name = "panelSoSachBan";
            this.panelSoSachBan.Size = new System.Drawing.Size(250, 100);
            this.panelSoSachBan.TabIndex = 1;
            // 
            // lblSoSachBan
            // 
            this.lblSoSachBan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoSachBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoSachBan.Location = new System.Drawing.Point(10, 10);
            this.lblSoSachBan.Name = "lblSoSachBan";
            this.lblSoSachBan.Size = new System.Drawing.Size(237, 23);
            this.lblSoSachBan.TabIndex = 0;
            this.lblSoSachBan.Text = "Số sách đã bán theo ngày";
            this.lblSoSachBan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowSoSach
            // 
            this.btnShowSoSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowSoSach.Location = new System.Drawing.Point(70, 50);
            this.btnShowSoSach.Name = "btnShowSoSach";
            this.btnShowSoSach.Size = new System.Drawing.Size(100, 30);
            this.btnShowSoSach.TabIndex = 1;
            this.btnShowSoSach.Text = "Xem biểu đồ";
            this.btnShowSoSach.Click += new System.EventHandler(this.btnShowSoSach_Click);
            // 
            // panelDoanhThu
            // 
            this.panelDoanhThu.BackColor = System.Drawing.Color.LightCoral;
            this.panelDoanhThu.Controls.Add(this.lblDoanhThu);
            this.panelDoanhThu.Controls.Add(this.btnShowDoanhThu);
            this.panelDoanhThu.Location = new System.Drawing.Point(570, 30);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(250, 100);
            this.panelDoanhThu.TabIndex = 2;
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoanhThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.Location = new System.Drawing.Point(10, 10);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(237, 23);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Doanh thu theo ngày";
            this.lblDoanhThu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowDoanhThu
            // 
            this.btnShowDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowDoanhThu.Location = new System.Drawing.Point(70, 50);
            this.btnShowDoanhThu.Name = "btnShowDoanhThu";
            this.btnShowDoanhThu.Size = new System.Drawing.Size(100, 30);
            this.btnShowDoanhThu.TabIndex = 1;
            this.btnShowDoanhThu.Text = "Xem biểu đồ";
            this.btnShowDoanhThu.Click += new System.EventHandler(this.btnShowDoanhThu_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDarkMode.AutoSize = true;
            this.btnDarkMode.Location = new System.Drawing.Point(830, 54);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(120, 40);
            this.btnDarkMode.TabIndex = 3;
            this.btnDarkMode.Text = "🌙 Dark Mode";
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            // 
            // chrData
            // 
            chartArea4.Name = "ChartArea1";
            this.chrData.ChartAreas.Add(chartArea4);
            this.chrData.Location = new System.Drawing.Point(30, 150);
            this.chrData.Name = "chrData";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Dữ liệu";
            this.chrData.Series.Add(series4);
            this.chrData.Size = new System.Drawing.Size(920, 400);
            this.chrData.TabIndex = 4;
            // 
            // frmHome
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.btnDarkMode);
            this.Controls.Add(this.panelSoDonHang);
            this.Controls.Add(this.panelSoSachBan);
            this.Controls.Add(this.panelDoanhThu);
            this.Controls.Add(this.chrData);
            this.Name = "frmHome";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.panelSoDonHang.ResumeLayout(false);
            this.panelSoSachBan.ResumeLayout(false);
            this.panelDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chrData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Panel panelSoDonHang;
        private System.Windows.Forms.Label lblSoDonHang;
        private System.Windows.Forms.Button btnShowSoDon;
        private System.Windows.Forms.Panel panelSoSachBan;
        private System.Windows.Forms.Label lblSoSachBan;
        private System.Windows.Forms.Button btnShowSoSach;
        private System.Windows.Forms.Panel panelDoanhThu;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.Button btnShowDoanhThu;
        private Button btnDarkMode;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrData;
    }
}
