using System.Windows.Forms;

namespace QuanLyCuaHangSach
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
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nudQuantity = new System.Windows.Forms.NumericUpDown();
            this.btnAddToBill = new System.Windows.Forms.Button();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnSaveBill = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBookList
            // 
            this.dgvBookList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookList.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBookList.ColumnHeadersHeight = 29;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dgvBookList.GridColor = System.Drawing.SystemColors.Control;
            this.dgvBookList.Location = new System.Drawing.Point(20, 50);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            this.dgvBookList.RowHeadersWidth = 51;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(765, 170);
            this.dgvBookList.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Tác giả";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // nudQuantity
            // 
            this.nudQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nudQuantity.Location = new System.Drawing.Point(791, 50);
            this.nudQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantity.Name = "nudQuantity";
            this.nudQuantity.Size = new System.Drawing.Size(150, 22);
            this.nudQuantity.TabIndex = 1;
            this.nudQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnAddToBill
            // 
            this.btnAddToBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddToBill.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddToBill.Location = new System.Drawing.Point(791, 103);
            this.btnAddToBill.Name = "btnAddToBill";
            this.btnAddToBill.Size = new System.Drawing.Size(150, 51);
            this.btnAddToBill.TabIndex = 2;
            this.btnAddToBill.Text = "➕ Thêm vào hóa đơn";
            this.btnAddToBill.UseVisualStyleBackColor = false;
            // 
            // dgvBill
            // 
            this.dgvBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBill.ColumnHeadersHeight = 29;
            this.dgvBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvBill.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBill.Location = new System.Drawing.Point(20, 240);
            this.dgvBill.Name = "dgvBill";
            this.dgvBill.RowHeadersWidth = 51;
            this.dgvBill.Size = new System.Drawing.Size(921, 242);
            this.dgvBill.TabIndex = 3;
            this.dgvBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBill_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã sách";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên sách";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Giá";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(16, 494);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(300, 30);
            this.lblTotal.TabIndex = 4;
            this.lblTotal.Text = "Tổng tiền: 0 VNĐ";
            // 
            // btnSaveBill
            // 
            this.btnSaveBill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveBill.Location = new System.Drawing.Point(550, 488);
            this.btnSaveBill.Name = "btnSaveBill";
            this.btnSaveBill.Size = new System.Drawing.Size(150, 40);
            this.btnSaveBill.TabIndex = 5;
            this.btnSaveBill.Text = "💾 Lưu hóa đơn";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.Location = new System.Drawing.Point(706, 488);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 40);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "🖨 In hóa đơn";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox1.Location = new System.Drawing.Point(92, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sách :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(791, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 41);
            this.button1.TabIndex = 9;
            this.button1.Text = "Xóa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(394, 488);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 10;
            this.button2.Text = "❌ Hủy hóa đơn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.Location = new System.Drawing.Point(734, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "SĐT:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.Location = new System.Drawing.Point(403, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ tên khách hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2.Location = new System.Drawing.Point(550, 22);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(165, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.SystemColors.HighlightText;
            this.textBox3.Location = new System.Drawing.Point(791, 22);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 22);
            this.textBox3.TabIndex = 14;
            // 
            // frmHoaDon
            // 
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(953, 533);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.nudQuantity);
            this.Controls.Add(this.btnAddToBill);
            this.Controls.Add(this.dgvBill);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSaveBill);
            this.Controls.Add(this.btnPrint);
            this.Name = "frmHoaDon";
            this.Text = "Tạo Hóa Đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.NumericUpDown nudQuantity;
        private System.Windows.Forms.Button btnAddToBill;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSaveBill;
        private System.Windows.Forms.Button btnPrint;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}
