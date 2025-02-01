using System;
using System.Windows.Forms;

namespace YourProjectNamespace
{
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            // Bạn sẽ thêm code load dữ liệu từ database vào đây
        }

        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            // Xử lý thêm sách vào hóa đơn (bạn sẽ tự bổ sung nghiệp vụ)
        }

        private void btnSaveBill_Click(object sender, EventArgs e)
        {
            // Xử lý lưu hóa đơn vào database (bạn sẽ tự bổ sung)
            MessageBox.Show("Hóa đơn đã được lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
