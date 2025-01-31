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
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            LoadChartData("Số Đơn Hàng"); // Mặc định hiển thị biểu đồ số đơn hàng
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

            //// Kết nối tới database
            //string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USER;Password=YOUR_PASSWORD;";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    string query = "";

            //    // Chọn loại dữ liệu cần hiển thị
            //    if (chartType == "Số Đơn Hàng")
            //        query = "SELECT Ngay, COUNT(*) AS TongDon FROM HoaDon GROUP BY Ngay ORDER BY Ngay DESC";
            //    else if (chartType == "Số Sách Bán")
            //        query = "SELECT Ngay, SUM(SoLuong) AS TongSach FROM ChiTietHoaDon GROUP BY Ngay ORDER BY Ngay DESC";
            //    else if (chartType == "Doanh Thu")
            //        query = "SELECT Ngay, SUM(TongTien) AS DoanhThu FROM HoaDon GROUP BY Ngay ORDER BY Ngay DESC";

            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                string ngay = Convert.ToDateTime(reader["Ngay"]).ToString("dd/MM");
            //                int giaTri = Convert.ToInt32(reader[1]); // Cột thứ 2 là tổng số đơn/sách/doanh thu
            //                series.Points.AddXY(ngay, giaTri);
            //            }
            //        }
            //    }
            //}

            // test giao diện
            Random rnd = new Random(); // 🚀 DỮ LIỆU GIẢ LẬP
            for (int i = 0; i < 10; i++)
            {
                string ngay = DateTime.Now.AddDays(-i).ToString("dd/MM");
                int giaTri = rnd.Next(10, 100); // 🚨 GIÁ TRỊ NGẪU NHIÊN
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
            isDarkMode = !isDarkMode; // Đảo trạng thái Dark Mode

            if (isDarkMode)
            {
                // Đổi màu nền và chữ sang Dark Mode
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.White;

                panelSoDonHang.BackColor = Color.FromArgb(60, 60, 65);
                panelSoSachBan.BackColor = Color.FromArgb(60, 60, 65);
                panelDoanhThu.BackColor = Color.FromArgb(60, 60, 65);

                lblSoDonHang.ForeColor = Color.White;
                lblSoSachBan.ForeColor = Color.White;
                lblDoanhThu.ForeColor = Color.White;

                btnDarkMode.Text = "☀️ Light Mode";
                btnDarkMode.BackColor = Color.Gray;
                btnDarkMode.ForeColor = Color.White;
            }
            else
            {
                // Quay lại Light Mode
                BackColor = Color.White;
                ForeColor = Color.Black;

                panelSoDonHang.BackColor = Color.LightBlue;
                panelSoSachBan.BackColor = Color.LightGreen;
                panelDoanhThu.BackColor = Color.LightCoral;

                lblSoDonHang.ForeColor = Color.Black;
                lblSoSachBan.ForeColor = Color.Black;
                lblDoanhThu.ForeColor = Color.Black;

                btnDarkMode.Text = "🌙 Dark Mode";
                btnDarkMode.BackColor = Color.LightGray;
                btnDarkMode.ForeColor = Color.Black;
            }
        }
    }
}
