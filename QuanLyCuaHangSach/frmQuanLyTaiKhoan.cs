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
            dataGridView.DataSource = null;
            dataGridView.DataSource = danhSach.Select(tk => new
            {
                Id = tk.Id,
                Ten = tk.Ten,
                MatKhau = tk.MatKhau,
                Email = tk.Email,
                ChucVu = tk.ChucVu
            }).ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmThemTaiKhoan themForm = new frmThemTaiKhoan(this);
            themForm.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView.SelectedRows.Count > 0)
            {
                // Lấy hàng được chọn
                var selectedRow = dataGridView.SelectedRows[0];

                // Lấy dữ liệu từ các ô trong hàng
                int id = Convert.ToInt32(selectedRow.Cells[0].Value); // Cột Id (chỉ số 0)
                string ten = selectedRow.Cells[1].Value.ToString();   // Cột Ten (chỉ số 1)
                string email = selectedRow.Cells[2].Value.ToString(); // Cột Email (chỉ số 2)
                string matKhau = selectedRow.Cells[3].Value.ToString(); // Cột MatKhau (chỉ số 3)
                string chucVu = selectedRow.Cells[4].Value.ToString(); // Cột ChucVu (chỉ số 4)

                // Tạo đối tượng TaiKhoan từ dữ liệu lấy được
                var taiKhoan = new TaiKhoan
                {
                    Id = id,
                    Ten = ten,
                    Email = email,
                    MatKhau = matKhau,
                    ChucVu = chucVu
                };

                // Mở form sửa và truyền tài khoản được chọn
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
