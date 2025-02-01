using System;
using System.Windows.Forms;
using System.Data;
using QuanLyCuaHangSach;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection;
using System.Collections.Generic;

namespace YourProjectNamespace
{
    public partial class frmSach : Form
    {
        public frmSach()
        {
            InitializeComponent();
        }
        string Status = "";
        int index = -1;
        int indexSearch = -1;
        #region Methods
        void CreateColumnFordgvSach()
        {
            var colTenSach = new DataGridViewTextBoxColumn();
            var colTacGia = new DataGridViewTextBoxColumn();
            var colTheLoai = new DataGridViewTextBoxColumn();
            var colNgonNgu = new DataGridViewTextBoxColumn();


            colTenSach.HeaderText = "Tên sách";
            colTacGia.HeaderText = "Tác giả";
            colTheLoai.HeaderText = "Thể loại";
            colNgonNgu.HeaderText = "Ngôn ngữ";


            colTenSach.DataPropertyName = "TenSach";
            colTacGia.DataPropertyName = "TacGia";
            colTheLoai.DataPropertyName = "TheLoai";
            colNgonNgu.DataPropertyName = "NgonNgu";


            colTenSach.Width = 300;
            colTacGia.Width = 300;
            colTheLoai.Width = 300;
            colNgonNgu.Width = 300;


            dgvSach.Columns.AddRange(new DataGridViewColumn[] { colTenSach, colTacGia, colTheLoai, colNgonNgu });
        }
        private void LoadComboBoxes()
        {
            // Lấy dữ liệu từ database để điền vào các combobox

            cboTheLoai.Items.AddRange(new string[] { "Tất cả", "Tiểu thuyết", "Kinh tế", "Khoa học" });
            cboNgonNgu.Items.AddRange(new string[] { "Tất cả", "Tiếng Việt", "Tiếng Anh", "Tiếng Pháp" });

            cboTheLoai.SelectedIndex = 0;
            cboNgonNgu.SelectedIndex = 0;
        }
        void EnableControls(bool isEnableTextBox, bool isEnableDataGridView)
        {
            txtTenSach.Enabled = txtTacGia.Enabled = cboTheLoai.Enabled = cboNgonNgu.Enabled = isEnableTextBox;
            dgvSach.Enabled = isEnableDataGridView;
        }
        void ClearTextBox()
        {
            foreach (Control item in this.Controls)
            {
                System.Windows.Forms.TextBox item1 = item as System.Windows.Forms.TextBox;
                if (item1 != null)
                {
                    item1.Clear();
                }
            }
        }
        bool checkInput()
        {
            if (string.IsNullOrEmpty(txtTenSach.Text))
            {
                MessageBox.Show("Tên sách không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenSach.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTacGia.Text))
            {
                MessageBox.Show("Tác giả không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTacGia.Focus();
                return false;
            }
            return true;
        }
        void LoadListSach()
        {
            dgvSach.DataSource = null;
            CreateColumnFordgvSach();
            dgvSach.DataSource = listTaiKhoan.Instance.ListUser;
            dgvSach.Refresh();
        }
        #endregion
        #region Events
        private void frmSach_Load(object sender, EventArgs e)
        {
            EnableControls(false, true);
            LoadListSach();
            CreateColumnFordgvSach();
            LoadComboBoxes();
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
            if (index == -1)
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần sửa", "Canh Bao");
                return;
            }
            EnableControls(true, false);

            btnThem.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = btnHuy.Enabled = true;

            txtTacGia.Text = listSach.Instance.ListBook[index].TacGia;
            txtTenSach.Text = listSach.Instance.ListBook[index].TenSach;
            cboNgonNgu.Text = listSach.Instance.ListBook[index].NgonNgu;
            cboTheLoai.Text = listSach.Instance.ListBook[index].TheLoai;
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
            listSach.Instance.ListBook.RemoveAt(index);
            LoadListSach();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!checkInput())
            {
                return;
            }
            string TenSach = txtTenSach.Text;
            string TacGia = txtTacGia.Text;
            string TheLoai = cboTheLoai.Text;
            string NgonNgu = cboNgonNgu.Text;


            if (Status == "Them")
            {
                listSach.Instance.ListBook.Add(new Sach(TenSach, TacGia, TheLoai, NgonNgu));
            }
            if (Status == "Sua")
            {
                listSach.Instance.ListBook[index].TenSach = TenSach;
                listSach.Instance.ListBook[index].TacGia = TacGia;
                listSach.Instance.ListBook[index].TheLoai = TheLoai;
                listSach.Instance.ListBook[index].NgonNgu = NgonNgu;
            }

            EnableControls(false, true);

            LoadListSach();

            ClearTextBox();

            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }
        private void lblTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)//btnHuy
        {
            EnableControls(false, true);
            ClearTextBox();
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = btnHuy.Enabled = false;
        }

        private void dgvSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Status == "TimKiem")
            {
                indexSearch = e.RowIndex;
                for (int i = 0; i < listSach.Instance.ListBook.Count; i++)
                {
                    if (dgvSach.Rows[indexSearch].Cells[1].Value.ToString() == listSach.Instance.ListBook[i].TenSach)
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
            txtTenSach.Enabled = true;

            btnThem.Enabled = btnLuu.Enabled = false;
            btnHuy.Enabled = true;
            Status = "TimKiem";
        }

        private void txtTenSach_TextChanged(object sender, EventArgs e)
        {
            string search = txtTenSach.Text;
            if (search != "")
            {
                List<Sach> listTimKiem = new List<Sach>();
                foreach (var item in listSach.Instance.ListBook)
                {
                    if (item.TenSach.ToLower().Contains(search.ToLower()))
                    {
                        listTimKiem.Add(item);
                    }
                }
                dgvSach.DataSource = null;
                CreateColumnFordgvSach();
                dgvSach.DataSource = listTimKiem;
            }
            else
            {
                dgvSach.DataSource = null;
                LoadListSach();
            }
        }



        #endregion


    }
}
