using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        string Status = "";
        int index = -1;
        int indexSearch = -1;
        List<String> listChucVu=new List<string>() { "Admin","User"};
        private long result;
        #region Method
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
            dataGridView.DataSource = null;
            CreateColumnForDataGridView();
            dataGridView.DataSource = listTaiKhoan.Instance.ListUser;
            dataGridView.Refresh();
        }

        void EnableControls(bool isEnableTextBox, bool isEnableDataGridView)
        {
            cboChucVu.Enabled=txtTenDangNhap.Enabled = txtMatKhau.Enabled = txtEmail.Enabled = txtSoDienThoai.Enabled = isEnableTextBox;
            dataGridView.Enabled = isEnableDataGridView;
        }
        #endregion Method

        void ClearTextBox()
        {
            foreach (Control item in this.Controls)
            {
                TextBox item1 = item as TextBox;
                if (item1 != null)
                {
                    item1.Clear();
                }
            }
        }

        bool CheckInput()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Email không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtSoDienThoai.Text))
            {
                MessageBox.Show("Số điện thoại không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtTenDangNhap.Text))
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Mật khẩu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrEmpty(cboChucVu.Text))
            {
                MessageBox.Show("Chức vụ không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!(long.TryParse(txtSoDienThoai.Text, out result)))
            {
                MessageBox.Show("Số điện thoại phải có 10 số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if(result<=0)
            {
                MessageBox.Show("Số điện thoại không được âm hoặc bằng tất cả đều là số 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //số điện thoại phải bắt đầu bằng số 0
            if (txtSoDienThoai.Text[0] != '0')
            {
                MessageBox.Show("Số điện thoại phải bắt đầu bằng số 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            //kiểm tra email
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains(".com"))
            {
                MessageBox.Show("Email không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        #region Event
        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            EnableControls(false, true);
            LoadListTaiKhoan();
            CreateColumnForDataGridView();
            cboChucVu.DataSource = listChucVu;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            EnableControls(true, false);

            btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;
      
            Status = "Them";
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
           
            if(index == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa","Canh Bao");
                return;
            }
            EnableControls(true, false);
             
            btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            txtEmail.Text = listTaiKhoan.Instance.ListUser[index].Email;
            txtSoDienThoai.Text = listTaiKhoan.Instance.ListUser[index].SoDienThoai;
            txtTenDangNhap.Text = listTaiKhoan.Instance.ListUser[index].TenDangNhap;
            txtMatKhau.Text = listTaiKhoan.Instance.ListUser[index].MatKhau;
            cboChucVu.Text = listTaiKhoan.Instance.ListUser[index].ChucVu;
            Status = "Sua";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa", "Canh Bao");
                return;
            }
            //bạn có muốn xóa không
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            listTaiKhoan.Instance.ListUser.RemoveAt(index);
            LoadListTaiKhoan();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!CheckInput())
            {
                return;
            }
            string SoDienThoai = txtSoDienThoai.Text;
            string Email = txtEmail.Text;
            string TenDangNhap = txtTenDangNhap.Text;
            string MatKhau = txtMatKhau.Text;
            string ChucVu = cboChucVu.Text;


            if (Status == "Them")
            {
                listTaiKhoan.Instance.ListUser.Add(new TaiKhoan(Email, SoDienThoai, TenDangNhap, MatKhau, ChucVu));
            }
            if (Status == "Sua")
            {
                listTaiKhoan.Instance.ListUser[index].Email = txtEmail.Text;
                listTaiKhoan.Instance.ListUser[index].SoDienThoai = txtSoDienThoai.Text;
                listTaiKhoan.Instance.ListUser[index].TenDangNhap = txtTenDangNhap.Text;
                listTaiKhoan.Instance.ListUser[index].MatKhau = txtMatKhau.Text;
                listTaiKhoan.Instance.ListUser[index].ChucVu = cboChucVu.Text;
            }

            EnableControls(false, true);

            LoadListTaiKhoan();

            ClearTextBox();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            EnableControls(false, true);
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Status=="TimKiem")
            {
                indexSearch = e.RowIndex;
                for (int i = 0; i < listTaiKhoan.Instance.ListUser.Count; i++)
                {
                    if (dataGridView.Rows[indexSearch].Cells[1].Value.ToString() == listTaiKhoan.Instance.ListUser[i].TenDangNhap)
                    {
                        index = i;
                        break;
                    }
                }
            }
            else
            {
                index = e.RowIndex;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            txtSoDienThoai.Enabled = true;

            btnThem.Enabled = btnLuu.Enabled= false;
            btnHuy.Enabled = true;
            Status = "TimKiem";
        }


        private void txtSoDienThoai_TextChanged(object sender, EventArgs e)
        {
            string search = txtSoDienThoai.Text;
            if(search != "")
            {
                // tao list phu de luu lai danh sach tim kiem
                List<TaiKhoan> listTimKiem = new List<TaiKhoan>();
                foreach (var item in listTaiKhoan.Instance.ListUser)
                {
                    if (item.TenDangNhap.ToLower().Contains(search.ToLower()))
                    {
                        listTimKiem.Add(item);
                    }
                }
                dataGridView.DataSource = null;
                CreateColumnForDataGridView();
                dataGridView.DataSource = listTimKiem;
            }
            else
            {
                dataGridView.DataSource = null;
                LoadListTaiKhoan();
            }

        }

        #endregion Event


    }
}
