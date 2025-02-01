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
        /// 
        private void ResizeParentForm(Form childForm)
        {
            // Lấy kích thước màn hình hiện tại
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;

            // Tính toán kích thước mới nhưng không vượt quá màn hình
            int newWidth = Math.Min(childForm.Width + 20, screen.Width);
            int newHeight = Math.Min(childForm.Height + menuStrip1.Height + 40, screen.Height);

            // Cập nhật kích thước form cha
            this.Size = new Size(newWidth, newHeight);

            // Canh giữa form cha trên màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void ChildForm_SizeChanged(object sender, EventArgs e)
        {
            Form child = sender as Form;
            if (child != null)
            {
                ResizeParentForm(child); // Gọi phương thức cập nhật kích thước của form cha
            }
        }

        private void OpenChildForm(Form childForm)
        {
            // Đóng form con cũ (nếu có)
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Gán form con mới vào biến activeForm
            activeForm = childForm;

            // Thiết lập không phải là cửa sổ cấp cao nhất (nằm trong form cha)
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;

            // Không Dock = Fill để tránh ảnh hưởng kích thước form cha
            childForm.Dock = DockStyle.None;

            // Xóa các control cũ trong panelContainer và thêm form con mới
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(childForm);

            // Lắng nghe sự kiện thay đổi kích thước form con
            childForm.SizeChanged += ChildForm_SizeChanged;

            // Cập nhật kích thước form cha theo form con
            ResizeParentForm(childForm);

            // Hiển thị form con
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
