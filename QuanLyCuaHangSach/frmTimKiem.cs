using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace YourProjectNamespace
{
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
            comboBox1.Items.Add("Hóa đơn");
            comboBox1.Items.Add("Khách hàng");

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string loaiTimKiem = comboBox1.Text;
            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;

            DataTable dt = new DataTable();

            if (loaiTimKiem == "Hóa đơn")
            {
                dt.Columns.Add("Mã Hóa Đơn");
                dt.Columns.Add("Ngày");
                dt.Columns.Add("Khách Hàng");
                dt.Columns.Add("Tổng Tiền");

                dt.Rows.Add("HD001", "2024-02-01", "Nguyễn Văn A", "1,000,000 VND");
                dt.Rows.Add("HD002", "2024-02-02", "Trần Thị B", "500,000 VND");
            }
            else if (loaiTimKiem == "Khách hàng")
            {
                dt.Columns.Add("Mã Khách Hàng");
                dt.Columns.Add("Tên");
                dt.Columns.Add("Số Điện Thoại");
                dt.Columns.Add("Lần Mua Gần Nhất");

                dt.Rows.Add("KH001", "Nguyễn Văn A", "0123456789", "2024-02-01");
                dt.Rows.Add("KH002", "Trần Thị B", "0987654321", "2024-02-02");
            }

            dgvKetQua.DataSource = dt;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
