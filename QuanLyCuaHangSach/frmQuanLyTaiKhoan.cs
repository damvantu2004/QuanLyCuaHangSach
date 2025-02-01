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
        #region
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

            colSoDienThoai.DataPropertyName = "SoDienThoai";
            colEmail.DataPropertyName = "Email";
            colChucVu.DataPropertyName = "ChucVu";
            colTenDangNhap.DataPropertyName = "TenDangNhap";
            colMatKhau.DataPropertyName = "MatKhau";
        
            colTenDangNhap.Width = 150;
            colMatKhau.Width = 150;
            colEmail.Width = 200;
            colSoDienThoai.Width = 150;
            colChucVu.Width = 150;

            dataGridView.Columns.AddRange(new DataGridViewColumn[] { colEmail, colSoDienThoai, colTenDangNhap, colMatKhau, colChucVu });
        }
        void LoadListTaiKhoan()
        { 
            dataGridView.DataSource = listTaiKhoan.Instance.ListUser;
        }
        #endregion

        #region Event
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            CreateColumnForDataGridView();
        }
        #endregion Event
    }
}
