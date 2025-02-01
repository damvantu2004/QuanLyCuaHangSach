using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace YourProjectNamespace
{
    public partial class frmHome : Form
    {
        private bool isDarkMode = false; // Biến kiểm tra trạng thái Dark Mode

        public frmHome()
        {
            InitializeComponent();
            SetupResponsiveUI();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadChartData("Số Đơn Hàng"); // Mặc định hiển thị biểu đồ số đơn hàng
        }

        /// <summary>
        /// 🛠️ Thiết lập UI để tự động scale khi thay đổi kích thước cửa sổ
        /// </summary>
        private void SetupResponsiveUI()
        {
            // 🔹 TableLayoutPanel chính (Mở rộng toàn bộ form)
            TableLayoutPanel tableLayoutPanel = new TableLayoutPanel
            {
                ColumnCount = 4,
                RowCount = 2,
                Dock = DockStyle.Fill, // Quan trọng: Cho phép tự mở rộng
                AutoSize = true,
            };

            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));

            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 120F));
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // 🔹 Thiết lập `DockStyle.Fill` cho các thành phần
            panelSoDonHang.Dock = DockStyle.Fill;
            panelSoSachBan.Dock = DockStyle.Fill;
            panelDoanhThu.Dock = DockStyle.Fill;
            btnDarkMode.Dock = DockStyle.Fill;

            // 🔹 Biểu đồ phải mở rộng toàn bộ hàng 2
            chrData.Dock = DockStyle.Fill;

            // 🔹 Thêm các thành phần vào TableLayoutPanel
            tableLayoutPanel.Controls.Add(panelSoDonHang, 0, 0);
            tableLayoutPanel.Controls.Add(panelSoSachBan, 1, 0);
            tableLayoutPanel.Controls.Add(panelDoanhThu, 2, 0);
            tableLayoutPanel.Controls.Add(btnDarkMode, 3, 0);
            tableLayoutPanel.Controls.Add(chrData, 0, 1);

            // Biểu đồ chiếm toàn bộ 4 cột
            tableLayoutPanel.SetColumnSpan(chrData, 4);

            // 🔹 Thêm vào form
            Controls.Add(tableLayoutPanel);

            // 🔹 Đặt form khởi động toàn màn hình
            //this.WindowState = FormWindowState.Maximized;
        }


        /// <summary>
        /// 📊 Load dữ liệu vào biểu đồ dựa trên loại dữ liệu được chọn.
        /// </summary>
        private void LoadChartData(string chartType)
        {
            chrData.Series.Clear(); // Xóa dữ liệu cũ

            Series series = new Series(chartType)
            {
                ChartType = SeriesChartType.Column // Biểu đồ dạng cột
            };

            // 🚀 Test giao diện với dữ liệu ngẫu nhiên
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string ngay = DateTime.Now.AddDays(-i).ToString("dd/MM");
                int giaTri = rnd.Next(10, 100);
                series.Points.AddXY(ngay, giaTri);
            }

            chrData.Series.Add(series);
        }

        /// <summary>
        /// 📊 Khi bấm vào button "Xem biểu đồ" trong phần "Số đơn theo ngày"
        /// </summary>
        private void btnShowSoDon_Click(object sender, EventArgs e)
        {
            LoadChartData("Số Đơn Hàng");
        }

        /// <summary>
        /// 📊 Khi bấm vào button "Xem biểu đồ" trong phần "Số sách đã bán theo ngày"
        /// </summary>
        private void btnShowSoSach_Click(object sender, EventArgs e)
        {
            LoadChartData("Số Sách Bán");
        }

        /// <summary>
        /// 📊 Khi bấm vào button "Xem biểu đồ" trong phần "Doanh thu theo ngày"
        /// </summary>
        private void btnShowDoanhThu_Click(object sender, EventArgs e)
        {
            LoadChartData("Doanh Thu");
        }

        /// <summary>
        /// 🌙 Chuyển đổi chế độ Dark Mode / Light Mode.
        /// </summary>
        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            isDarkMode = !isDarkMode;

            if (isDarkMode)
            {
                // Dark Mode
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.White;

                panelSoDonHang.BackColor = Color.FromArgb(60, 60, 65);
                panelSoSachBan.BackColor = Color.FromArgb(60, 60, 65);
                panelDoanhThu.BackColor = Color.FromArgb(60, 60, 65);

                lblSoDonHang.ForeColor = lblSoSachBan.ForeColor = lblDoanhThu.ForeColor = Color.White;

                btnDarkMode.Text = "☀️ Light Mode";
                btnDarkMode.BackColor = Color.Gray;
                btnDarkMode.ForeColor = Color.White;
            }
            else
            {
                // Light Mode
                BackColor = Color.White;
                ForeColor = Color.Black;

                panelSoDonHang.BackColor = Color.LightBlue;
                panelSoSachBan.BackColor = Color.LightGreen;
                panelDoanhThu.BackColor = Color.LightCoral;

                lblSoDonHang.ForeColor = lblSoSachBan.ForeColor = lblDoanhThu.ForeColor = Color.Black;

                btnDarkMode.Text = "🌙 Dark Mode";
                btnDarkMode.BackColor = Color.LightGray;
                btnDarkMode.ForeColor = Color.Black;
            }
        }
    }
}
