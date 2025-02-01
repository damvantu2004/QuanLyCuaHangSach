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
        void CreateColumnForDataGridView()
        {
            var colTenDangNhap = new DataGridViewTextBoxColumn();
            var colMatKhau = new DataGridViewTextBoxColumn();
            var colEmail = new DataGridViewTextBoxColumn();
            var colSoDienThoai = new DataGridViewTextBoxColumn();
            var colChucVu = new DataGridViewTextBoxColumn();

            colTenDangNhap.HeaderText = "Tên đăng nhập";
            colMatKhau.HeaderText = "Mật khẩu";
            colEmail.HeaderText = "Email";
            colSoDienThoai.HeaderText = "Số điện thoại";
            colChucVu.HeaderText = "Chức vụ";

            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colEmail, colSoDienThoai, colTenDangNhap, colMatKhau,  colChucVu });
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
        }
    }
}
