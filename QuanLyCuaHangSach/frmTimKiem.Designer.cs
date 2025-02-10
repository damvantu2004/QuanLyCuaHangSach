namespace QuanLyCuaHangSach
{
    partial class frmTimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblNgayBatDau;
        private System.Windows.Forms.Label lblNgayKetThuc;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKetThuc;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Button btnBaoCao;
        private System.Windows.Forms.DataGridView dgvKetQua;
        private System.Windows.Forms.Label lblSoLuongKetQua;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.TextBox txtMaKHOrSDT; // Thêm textbox
        private System.Windows.Forms.Label lblMaKHOrSDT;
        private System.Windows.Forms.TextBox txtMaSach;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNgayBatDau = new System.Windows.Forms.Label();
            this.lblNgayKetThuc = new System.Windows.Forms.Label();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKetThuc = new System.Windows.Forms.DateTimePicker();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnBaoCao = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblSoLuongKetQua = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.txtMaKHOrSDT = new System.Windows.Forms.TextBox();
            this.lblMaKHOrSDT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgayBatDau
            // 
            this.lblNgayBatDau.AutoSize = true;
            this.lblNgayBatDau.Location = new System.Drawing.Point(358, 21);
            this.lblNgayBatDau.Name = "lblNgayBatDau";
            this.lblNgayBatDau.Size = new System.Drawing.Size(93, 16);
            this.lblNgayBatDau.TabIndex = 0;
            this.lblNgayBatDau.Text = "Ngày Bắt Đầu:";
            // 
            // lblNgayKetThuc
            // 
            this.lblNgayKetThuc.AutoSize = true;
            this.lblNgayKetThuc.Location = new System.Drawing.Point(358, 60);
            this.lblNgayKetThuc.Name = "lblNgayKetThuc";
            this.lblNgayKetThuc.Size = new System.Drawing.Size(98, 16);
            this.lblNgayKetThuc.TabIndex = 2;
            this.lblNgayKetThuc.Text = "Ngày Kết Thúc:";
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayBatDau.Location = new System.Drawing.Point(462, 16);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayBatDau.TabIndex = 1;
            // 
            // dtpNgayKetThuc
            // 
            this.dtpNgayKetThuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayKetThuc.Location = new System.Drawing.Point(462, 54);
            this.dtpNgayKetThuc.Name = "dtpNgayKetThuc";
            this.dtpNgayKetThuc.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKetThuc.TabIndex = 3;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(361, 116);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnBaoCao
            // 
            this.btnBaoCao.Location = new System.Drawing.Point(462, 116);
            this.btnBaoCao.Name = "btnBaoCao";
            this.btnBaoCao.Size = new System.Drawing.Size(75, 23);
            this.btnBaoCao.TabIndex = 7;
            this.btnBaoCao.Text = "Tạo Báo Cáo";
            this.btnBaoCao.Click += new System.EventHandler(this.btnBaoCao_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvKetQua.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKetQua.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvKetQua.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvKetQua.ColumnHeadersHeight = 29;
            this.dgvKetQua.GridColor = System.Drawing.SystemColors.Control;
            this.dgvKetQua.Location = new System.Drawing.Point(20, 145);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.Size = new System.Drawing.Size(1047, 373);
            this.dgvKetQua.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(157, 17);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // lblSoLuongKetQua
            // 
            this.lblSoLuongKetQua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSoLuongKetQua.AutoSize = true;
            this.lblSoLuongKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongKetQua.Location = new System.Drawing.Point(921, 521);
            this.lblSoLuongKetQua.Name = "lblSoLuongKetQua";
            this.lblSoLuongKetQua.Size = new System.Drawing.Size(146, 18);
            this.lblSoLuongKetQua.TabIndex = 10;
            this.lblSoLuongKetQua.Text = "Số Lượng Kết Quả: 0";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(921, 555);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(71, 15);
            this.lblTongTien.TabIndex = 11;
            this.lblTongTien.Text = "Tổng tiền: 0";
            // 
            // txtMaKHOrSDT
            // 
            this.txtMaKHOrSDT.Location = new System.Drawing.Point(157, 56);
            this.txtMaKHOrSDT.Name = "txtMaKHOrSDT";
            this.txtMaKHOrSDT.Size = new System.Drawing.Size(150, 22);
            this.txtMaKHOrSDT.TabIndex = 4;
            // 
            // lblMaKHOrSDT
            // 
            this.lblMaKHOrSDT.AutoSize = true;
            this.lblMaKHOrSDT.Location = new System.Drawing.Point(20, 62);
            this.lblMaKHOrSDT.Name = "lblMaKHOrSDT";
            this.lblMaKHOrSDT.Size = new System.Drawing.Size(119, 16);
            this.lblMaKHOrSDT.TabIndex = 12;
            this.lblMaKHOrSDT.Text = "Nhập MaKH(SDT):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Chọn Mục Tìm Kiếm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nhập Mã Sách:";
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(157, 93);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(150, 22);
            this.txtMaSach.TabIndex = 15;
            // 
            // frmTimKiem
            // 
            this.ClientSize = new System.Drawing.Size(1090, 580);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMaKHOrSDT);
            this.Controls.Add(this.txtMaKHOrSDT);
            this.Controls.Add(this.lblSoLuongKetQua);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblNgayBatDau);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.lblNgayKetThuc);
            this.Controls.Add(this.dtpNgayKetThuc);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnBaoCao);
            this.Controls.Add(this.dgvKetQua);
            this.Name = "frmTimKiem";
            this.Text = "Tìm Kiếm ";
            this.Load += new System.EventHandler(this.frmTimKiem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}