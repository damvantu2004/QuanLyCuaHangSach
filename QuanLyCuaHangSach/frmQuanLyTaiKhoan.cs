using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class frmQuanLyTaiKhoan : Form
    {
        public class TaiKhoan
        {
            // Thuộc tính Id (định danh duy nhất cho mỗi tài khoản)
            public int Id { get; set; }

            // Thuộc tính Tên đăng nhập
            public string Ten { get; set; }

            // Thuộc tính Email
            public string Email { get; set; }

            // Thuộc tính Mật khẩu
            public string MatKhau { get; set; }

            // Thuộc tính Chức vụ
            public string ChucVu { get; set; }
        }
        public List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();
        private List<TaiKhoan> danhSachHienTai = new List<TaiKhoan>();
        internal object chucVu;

        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
            HienThiDanhSach(danhSachTaiKhoan);
        }
        public void HienThiDanhSach(List<frmQuanLyTaiKhoan.TaiKhoan> danhSach)
        {
            // Implementation of HienThiDanhSach method
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan themForm = new frmThemTaiKhoan(this);
            themForm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Lấy tài khoản được chọn
                var selectedRow = dataGridView.SelectedRows[0];
                var taiKhoan = (TaiKhoan)selectedRow.DataBoundItem;

                // Mở form sửa
                frmSuaTaiKhoan suaForm = new frmSuaTaiKhoan(this, taiKhoan);
                suaForm.ShowDialog(); 
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(danhSachHienTai.Count == 0)
        {
                MessageBox.Show("Không có dữ liệu để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var taiKhoan = (TaiKhoan)selectedRow.DataBoundItem;

                // Xóa tài khoản khỏi danh sách gốc
                danhSachTaiKhoan.Remove(taiKhoan);

                // Cập nhật danh sách hiển thị
                HienThiDanhSach(danhSachHienTai.Where(tk => tk != taiKhoan).ToList());
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTimKiem.Text))
            {
                MessageBox.Show("Vui lòng nhập email hoặc tài khoản để tìm kiếm.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string keyword = txtTimKiem.Text.ToLower();
            var ketQua = danhSachTaiKhoan.Where(tk =>
                tk.Ten.ToLower().Contains(keyword) ||
                tk.Email.ToLower().Contains(keyword)).ToList();

            HienThiDanhSach(ketQua); // Hiển thị kết quả tìm kiếm
        }
    }
}
