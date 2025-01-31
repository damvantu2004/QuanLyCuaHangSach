namespace QuanLyCuaHangSach
{
    partial class frmQuanLyTaiKhoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvEmployee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenDangNhap = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.Label();
            this.txbMK = new System.Windows.Forms.TextBox();
            this.cbxRole = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tslThem = new System.Windows.Forms.ToolStripLabel();
            this.tslSua = new System.Windows.Forms.ToolStripLabel();
            this.tslXoa = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 35);
            this.label5.TabIndex = 2;
            this.label5.Text = "Danh sách tài khoản";
            // 
            // dtgvEmployee
            // 
            this.dtgvEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEmployee.Location = new System.Drawing.Point(-1, 187);
            this.dtgvEmployee.Name = "dtgvEmployee";
            this.dtgvEmployee.RowHeadersWidth = 51;
            this.dtgvEmployee.RowTemplate.Height = 24;
            this.dtgvEmployee.Size = new System.Drawing.Size(800, 360);
            this.dtgvEmployee.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txbTenDangNhap
            // 
            this.txbTenDangNhap.Location = new System.Drawing.Point(130, 61);
            this.txbTenDangNhap.Name = "txbTenDangNhap";
            this.txbTenDangNhap.Size = new System.Drawing.Size(100, 22);
            this.txbTenDangNhap.TabIndex = 5;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.AutoSize = true;
            this.txbMatKhau.Location = new System.Drawing.Point(290, 67);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.Size = new System.Drawing.Size(61, 16);
            this.txbMatKhau.TabIndex = 6;
            this.txbMatKhau.Text = "Mật khẩu";
            // 
            // txbMK
            // 
            this.txbMK.Location = new System.Drawing.Point(357, 67);
            this.txbMK.Name = "txbMK";
            this.txbMK.Size = new System.Drawing.Size(100, 22);
            this.txbMK.TabIndex = 7;
            // 
            // cbxRole
            // 
            this.cbxRole.FormattingEnabled = true;
            this.cbxRole.Location = new System.Drawing.Point(595, 67);
            this.cbxRole.Name = "cbxRole";
            this.cbxRole.Size = new System.Drawing.Size(121, 24);
            this.cbxRole.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(528, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Chức vụ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(676, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 40);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tìm Kiếm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslThem,
            this.tslSua,
            this.tslXoa});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tslThem
            // 
            this.tslThem.Name = "tslThem";
            this.tslThem.Size = new System.Drawing.Size(46, 22);
            this.tslThem.Text = "Thêm";
            // 
            // tslSua
            // 
            this.tslSua.Name = "tslSua";
            this.tslSua.Size = new System.Drawing.Size(34, 22);
            this.tslSua.Text = "Sửa";
            // 
            // tslXoa
            // 
            this.tslXoa.Name = "tslXoa";
            this.tslXoa.Size = new System.Drawing.Size(35, 22);
            this.tslXoa.Text = "Xóa";
            // 
            // frmQuanLyTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxRole);
            this.Controls.Add(this.txbMK);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenDangNhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvEmployee);
            this.Controls.Add(this.label5);
            this.Name = "frmQuanLyTaiKhoan";
            this.Text = "frmQuanLyTaiKhoan";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEmployee)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dtgvEmployee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label txbMatKhau;
        private System.Windows.Forms.TextBox txbMK;
        private System.Windows.Forms.ComboBox cbxRole;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tslThem;
        private System.Windows.Forms.ToolStripLabel tslSua;
        private System.Windows.Forms.ToolStripLabel tslXoa;
    }
}