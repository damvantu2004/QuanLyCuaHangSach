using System.Windows.Forms;

namespace YourProjectNamespace
{
    partial class frmHoaDon
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();

            // DataGridView - Danh sách sách
            this.dgvBookList.Location = new System.Drawing.Point(20, 20);
            this.dgvBookList.Size = new System.Drawing.Size(400, 200);
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // NumericUpDown - Chọn số lượng sách
            this.nudQuantity.Location = new System.Drawing.Point(430, 20);
            this.nudQuantity.Minimum = 1;
            this.nudQuantity.Size = new System.Drawing.Size(100, 22);

            // Button - Thêm vào hóa đơn
            this.btnAddToBill.Text = "➕ Thêm vào hóa đơn";
            this.btnAddToBill.Location = new System.Drawing.Point(550, 20);
            this.btnAddToBill.Size = new System.Drawing.Size(150, 30);

            // DataGridView - Danh sách hóa đơn
            this.dgvBill.Location = new System.Drawing.Point(20, 250);
            this.dgvBill.Size = new System.Drawing.Size(680, 200);
            this.dgvBill.Columns.Add("Mã sách", "Mã sách");
            this.dgvBill.Columns.Add("Tên sách", "Tên sách");
            this.dgvBill.Columns.Add("Giá", "Giá");
            this.dgvBill.Columns.Add("Số lượng", "Số lượng");
            this.dgvBill.Columns.Add("Thành tiền", "Thành tiền");

            // Label - Tổng tiền
            this.lblTotal.Text = "Tổng tiền: 0 VNĐ";
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(20, 470);
            this.lblTotal.Size = new System.Drawing.Size(300, 30);

            // Button - Lưu hóa đơn
            this.btnSaveBill.Text = "💾 Lưu hóa đơn";
            this.btnSaveBill.Location = new System.Drawing.Point(550, 470);
            this.btnSaveBill.Size = new System.Drawing.Size(150, 40);

            // Button - Đóng form
            this.btnClose.Text = "❌ Đóng";
            this.btnClose.Location = new System.Drawing.Point(550, 520);
            this.btnClose.Size = new System.Drawing.Size(150, 40);

            // Form Hóa Đơn
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.btnClose);
            this.Text = "Tạo Hóa Đơn";

            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnClose;
    }
}
