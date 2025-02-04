using QuanLyCuaHangSach.DAL;
using System;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent(); // Khởi tạo các thành phần của form
        }

        private void fLogin_Load(object sender, EventArgs e)
        {
            textBox1.Focus(); // Đặt con trỏ vào ô nhập tài khoản khi form được tải
            textBox2.PasswordChar = '*'; // Ẩn mật khẩu bằng cách hiển thị dấu '*'
        }

        // Hàm xử lý đăng nhập
        private void Authenticate()
        {
            string username = textBox1.Text; // Lấy giá trị tài khoản từ ô nhập liệu
            string password = textBox2.Text; // Lấy giá trị mật khẩu từ ô nhập liệu

            // Kiểm tra tài khoản mặc định là 'root' với mật khẩu 'root'
            if (username == "root" && password == "root")
            {
                MessageBox.Show("Đăng nhập thành công với quyền Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mainForm = new frmMain(); // Khởi tạo form chính (Admin)
                this.Hide(); // Ẩn form đăng nhập
                mainForm.ShowDialog(); // Hiển thị form chính
                this.Show(); // Hiển thị lại form đăng nhập sau khi form chính đóng
                return;
            }

            string hashedPassword = Functions.ComputeSha256Hash(password); // Mã hóa mật khẩu để kiểm tra
            int? role = LoginDAL.TryLogin(username, hashedPassword); // Thử đăng nhập và lấy vai trò

            if (role.HasValue) // Kiểm tra nếu đăng nhập thành công
            {
                if (role.Value == 1) // Nếu vai trò là 1 (Nhân viên)
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmHoaDon hoaDonForm = new frmHoaDon(); // Khởi tạo form hóa đơn
                    this.Hide(); // Ẩn form đăng nhập
                    hoaDonForm.ShowDialog(); // Hiển thị form hóa đơn
                    this.Show(); // Hiển thị lại form đăng nhập sau khi form hóa đơn đóng
                }
                else // Nếu vai trò là 0 (Admin)
                {
                    MessageBox.Show("Đăng nhập thành công với quyền Admin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmMain mainForm = new frmMain(); // Khởi tạo form chính
                    this.Hide(); // Ẩn form đăng nhập
                    mainForm.ShowDialog(); // Hiển thị form chính
                    this.Show(); // Hiển thị lại form đăng nhập sau khi form chính đóng
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error); // Thông báo lỗi
            }
        }

        private void buttonDangNhap_Click(object sender, EventArgs e)
        {
            Authenticate(); // Gọi hàm đăng nhập khi nhấn nút Đăng Nhập
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu nhấn phím Enter
            {
                Authenticate(); // Gọi hàm đăng nhập
                e.SuppressKeyPress = true; // Ngăn Enter tạo ký tự mới trong ô nhập liệu
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) // Kiểm tra nếu nhấn phím Enter
            {
                Authenticate(); // Gọi hàm đăng nhập
                e.SuppressKeyPress = true; // Ngăn Enter tạo ký tự mới trong ô nhập liệu
            }

            if (e.KeyCode == Keys.Tab) // Kiểm tra nếu nhấn phím Tab
            {
                textBox2.Focus(); // Chuyển con trỏ đến ô nhập mật khẩu
                e.SuppressKeyPress = true; // Ngăn Tab tạo ký tự mới trong ô nhập liệu
            }
        }
    }
}