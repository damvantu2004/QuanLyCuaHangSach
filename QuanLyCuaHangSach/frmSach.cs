using System;
using System.Windows.Forms;
using System.Data;

namespace YourProjectNamespace
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadData();
        }

        private void LoadComboBoxes()
        {
            // Lấy dữ liệu từ database để điền vào các combobox
            cboTacGia.Items.AddRange(new string[] { "Tất cả", "Tác giả A", "Tác giả B" });
            cboTheLoai.Items.AddRange(new string[] { "Tất cả", "Tiểu thuyết", "Kinh tế", "Khoa học" });
            cboNgonNgu.Items.AddRange(new string[] { "Tất cả", "Tiếng Việt", "Tiếng Anh", "Tiếng Pháp" });

            cboTacGia.SelectedIndex = 0;
            cboTheLoai.SelectedIndex = 0;
            cboNgonNgu.SelectedIndex = 0;
        }

        private void LoadData()
        {
            // Dữ liệu giả lập (cần thay bằng database thực tế)
            DataTable dt = new DataTable();
            dt.Columns.Add("Mã Sách");
            dt.Columns.Add("Tên Sách");
            dt.Columns.Add("Tác Giả");
            dt.Columns.Add("Thể Loại");
            dt.Columns.Add("Ngôn Ngữ");

            dgvSach.DataSource = dt;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            // Xử lý tìm kiếm (chưa kết nối database)
            MessageBox.Show("Tìm kiếm sách...");
        }

        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }
    }
}
