using System;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangSach;

namespace YourProjectNamespace
{
    public partial class frmMain : Form
    {
        private Form activeForm = null; // Biến lưu form đang hiển thị

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            OpenChildForm(new frmHome()); // Mặc định mở trang chủ
        }

        /// <summary>
        /// Hàm mở form con trong panelContainer
        /// </summary>
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHome());
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmSach());

        }

        private void taoHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmHoaDon());
        }

        private void quanLyTaiKhoanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQuanLyTaiKhoan());
        }

        private void baoCaoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmBaoCao());
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            if (BackColor == Color.White)
            {
                BackColor = Color.FromArgb(45, 45, 48);
                ForeColor = Color.White;
                menuStrip1.BackColor = Color.FromArgb(30, 30, 30);
                menuStrip1.ForeColor = Color.White;
                panelContainer.BackColor = Color.FromArgb(60, 60, 60);
            }
            else
            {
                BackColor = Color.White;
                ForeColor = Color.Black;
                menuStrip1.BackColor = SystemColors.Control;
                menuStrip1.ForeColor = Color.Black;
                panelContainer.BackColor = SystemColors.Control;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
