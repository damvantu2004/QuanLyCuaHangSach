﻿using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YourProjectNamespace
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();

            // 1️⃣ Panel: Hiển thị số đơn hàng
            this.panelSoDonHang = new System.Windows.Forms.Panel();
            this.lblSoDonHang = new System.Windows.Forms.Label();
            this.btnShowSoDon = new System.Windows.Forms.Button();

            // 2️⃣ Panel: Hiển thị số sách đã bán
            this.panelSoSachBan = new System.Windows.Forms.Panel();
            this.lblSoSachBan = new System.Windows.Forms.Label();
            this.btnShowSoSach = new System.Windows.Forms.Button();

            // 3️⃣ Panel: Hiển thị doanh thu
            this.panelDoanhThu = new System.Windows.Forms.Panel();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.btnShowDoanhThu = new System.Windows.Forms.Button();

            // 4️⃣ Nút bật/tắt chế độ Dark Mode
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnDarkMode.Location = new System.Drawing.Point(850, 50);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(120, 40);
            this.btnDarkMode.TabIndex = 3;
            this.btnDarkMode.Text = "🌙 Dark Mode";
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            this.Controls.Add(this.btnDarkMode);


            // 5️⃣ Biểu đồ hiển thị dữ liệu
            this.chrData = new System.Windows.Forms.DataVisualization.Charting.Chart();

            // -------------- CẤU HÌNH GIAO DIỆN ---------------- //

            // 
            // panelSoDonHang - Tổng số đơn hàng
            // 
            this.panelSoDonHang.BackColor = System.Drawing.Color.LightBlue;
            this.panelSoDonHang.Controls.Add(this.lblSoDonHang);
            this.panelSoDonHang.Controls.Add(this.btnShowSoDon);
            this.panelSoDonHang.Location = new System.Drawing.Point(30, 30);
            this.panelSoDonHang.Name = "panelSoDonHang";
            this.panelSoDonHang.Size = new System.Drawing.Size(250, 100);
            this.panelSoDonHang.TabIndex = 0;

            // 
            // lblSoDonHang - Hiển thị số lượng đơn hàng
            // 
            this.lblSoDonHang.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoDonHang.Location = new System.Drawing.Point(10, 10);
            this.lblSoDonHang.Name = "lblSoDonHang";
            this.lblSoDonHang.Size = new System.Drawing.Size(237, 23);
            this.lblSoDonHang.TabIndex = 0;
            this.lblSoDonHang.Text = "Số đơn theo ngày";

            // 
            // btnShowSoDon - Button hiển thị biểu đồ số đơn hàng
            // 
            this.btnShowSoDon.Location = new System.Drawing.Point(70, 50);
            this.btnShowSoDon.Name = "btnShowSoDon";
            this.btnShowSoDon.Size = new System.Drawing.Size(100, 30);
            this.btnShowSoDon.Text = "Xem biểu đồ";
            this.btnShowSoDon.Click += new System.EventHandler(this.btnShowSoDon_Click);

            // 
            // panelSoSachBan - Tổng số sách đã bán
            // 
            this.panelSoSachBan.BackColor = System.Drawing.Color.LightGreen;
            this.panelSoSachBan.Controls.Add(this.lblSoSachBan);
            this.panelSoSachBan.Controls.Add(this.btnShowSoSach);
            this.panelSoSachBan.Location = new System.Drawing.Point(300, 30);
            this.panelSoSachBan.Name = "panelSoSachBan";
            this.panelSoSachBan.Size = new System.Drawing.Size(250, 100);
            this.panelSoSachBan.TabIndex = 1;

            // 
            // lblSoSachBan - Hiển thị số lượng sách đã bán
            // 
            this.lblSoSachBan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSoSachBan.Location = new System.Drawing.Point(10, 10);
            this.lblSoSachBan.Name = "lblSoSachBan";
            this.lblSoSachBan.Size = new System.Drawing.Size(237, 23);
            this.lblSoSachBan.TabIndex = 0;
            this.lblSoSachBan.Text = "Số sách đã bán theo ngày";

            // 
            // btnShowSoSach - Button hiển thị biểu đồ số sách đã bán
            // 
            this.btnShowSoSach.Location = new System.Drawing.Point(70, 50);
            this.btnShowSoSach.Name = "btnShowSoSach";
            this.btnShowSoSach.Size = new System.Drawing.Size(100, 30);
            this.btnShowSoSach.Text = "Xem biểu đồ";
            this.btnShowSoSach.Click += new System.EventHandler(this.btnShowSoSach_Click);

            // 
            // panelDoanhThu - Tổng doanh thu
            // 
            this.panelDoanhThu.BackColor = System.Drawing.Color.LightCoral;
            this.panelDoanhThu.Controls.Add(this.lblDoanhThu);
            this.panelDoanhThu.Controls.Add(this.btnShowDoanhThu);
            this.panelDoanhThu.Location = new System.Drawing.Point(570, 30);
            this.panelDoanhThu.Name = "panelDoanhThu";
            this.panelDoanhThu.Size = new System.Drawing.Size(250, 100);
            this.panelDoanhThu.TabIndex = 2;

            // 
            // lblDoanhThu - Hiển thị tổng doanh thu
            // 
            this.lblDoanhThu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblDoanhThu.Location = new System.Drawing.Point(10, 10);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(237, 23);
            this.lblDoanhThu.TabIndex = 0;
            this.lblDoanhThu.Text = "Doanh thu theo ngày";

            // 
            // btnShowDoanhThu - Button hiển thị biểu đồ doanh thu
            // 
            this.btnShowDoanhThu.Location = new System.Drawing.Point(70, 50);
            this.btnShowDoanhThu.Name = "btnShowDoanhThu";
            this.btnShowDoanhThu.Size = new System.Drawing.Size(100, 30);
            this.btnShowDoanhThu.Text = "Xem biểu đồ";
            this.btnShowDoanhThu.Click += new System.EventHandler(this.btnShowDoanhThu_Click);

            // 
            // chrData - Biểu đồ hiển thị dữ liệu
            // 
            chartArea1.Name = "ChartArea1";
            this.chrData.ChartAreas.Add(chartArea1);
            this.chrData.Location = new System.Drawing.Point(30, 150);
            this.chrData.Name = "chrData";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Dữ liệu";
            this.chrData.Series.Add(series1);
            this.chrData.Size = new System.Drawing.Size(920, 400);
            this.chrData.TabIndex = 4;

            // 
            // frmHome - Cấu hình Form Trang chủ
            // 
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panelSoDonHang);
            this.Controls.Add(this.panelSoSachBan);
            this.Controls.Add(this.panelDoanhThu);
            this.Controls.Add(this.chrData);
            this.Name = "frmHome";
            this.Text = "Trang chủ";
            this.Load += new System.EventHandler(this.frmHome_Load);
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
