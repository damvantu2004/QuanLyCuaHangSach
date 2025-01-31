using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static QuanLyCuaHangSach.frmQuanLyTaiKhoan;

namespace QuanLyCuaHangSach
{
    public partial class frmThemTaiKhoan : Form
    {
        private readonly List<string> ListChucVu = new List<string> { "Admin", "User" };
        private readonly frmQuanLyTaiKhoan mainForm;

        public frmThemTaiKhoan(frmQuanLyTaiKhoan mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;

            // Khởi tạo ComboBox với danh sách chức vụ
            cboChucVu.DataSource = mainForm.chucVu;
            if (cboChucVu.Items.Count > 0)
            {
                cboChucVu.SelectedIndex = 0; // Chọn mục đầu tiên làm giá trị mặc định
            }
        }
        public frmThemTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var taiKhoan = new TaiKhoan
            {
                Id = mainForm.danhSachTaiKhoan.Count + 1, // Tự động tăng ID
                Ten = txtTen.Text,
                Email = txtEmail.Text,
                MatKhau = txtMatKhau.Text,
                ChucVu = cboChucVu.SelectedItem.ToString() // Lấy chức vụ từ ComboBox
            };

            mainForm.danhSachTaiKhoan.Add(taiKhoan);

            // Cập nhật danh sách hiển thị trên Form chính
            mainForm.HienThiDanhSach(mainForm.danhSachTaiKhoan);

            // Đóng Form Thêm
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThemTaiKhoan_Load(object sender, EventArgs e)
        {
            cboChucVu.DataSource = ListChucVu;
        }
    }
}

