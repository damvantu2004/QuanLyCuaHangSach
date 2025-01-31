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
    public partial class frmSuaTaiKhoan : Form
    {
        private readonly List<string> ListChucVu = new List<string> { "Admin", "User" };
        private frmQuanLyTaiKhoan mainForm;
        public TaiKhoan taiKhoan;

        public frmSuaTaiKhoan(frmQuanLyTaiKhoan mainForm, TaiKhoan taiKhoan)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.taiKhoan = taiKhoan;

            // Hiển thị thông tin tài khoản hiện tại
            txtTen.Text = taiKhoan.Ten;
            txtEmail.Text = taiKhoan.Email;
            txtMatKhau.Text = taiKhoan.MatKhau;

            // Khởi tạo ComboBox với danh sách chức vụ
            cboChucVu.DataSource = mainForm.chucVu;
            cboChucVu.SelectedItem = taiKhoan.ChucVu; // Chọn chức vụ hiện tại
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra dữ liệu nhập vào
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cập nhật thông tin tài khoản
            taiKhoan.Ten = txtTen.Text;
            taiKhoan.Email = txtEmail.Text;
            taiKhoan.MatKhau = txtMatKhau.Text;
            taiKhoan.ChucVu = cboChucVu.SelectedItem?.ToString() ?? taiKhoan.ChucVu;

            // Cập nhật DataGridView trên form chính
            mainForm.HienThiDanhSach(mainForm.danhSachTaiKhoan);

            // Thông báo thành công
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng Form Sửa
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            // Đóng Form Sửa mà không lưu
            this.Close();
        }

        private void frmSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            cboChucVu.DataSource = ListChucVu;
        }
    }
}
