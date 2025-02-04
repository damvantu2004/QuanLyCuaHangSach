using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    partial class frmSach
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
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.cboTheLoai = new System.Windows.Forms.ComboBox();
            this.cboNgonNgu = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblTheLoai = new System.Windows.Forms.Label();
            this.lblNgonNgu = new System.Windows.Forms.Label();
            this.lblTimKiem = new System.Windows.Forms.Label();
            this.txtTacGia = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSach
            // 
            this.dgvSach.AllowUserToAddRows = false;
            this.dgvSach.AllowUserToDeleteRows = false;
            this.dgvSach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSach.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSach.ColumnHeadersHeight = 29;
            this.dgvSach.Location = new System.Drawing.Point(12, 100);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.ReadOnly = true;
            this.dgvSach.RowHeadersWidth = 51;
            this.dgvSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSach.Size = new System.Drawing.Size(1069, 344);
            this.dgvSach.TabIndex = 9;
            this.dgvSach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSach_CellClick);
            // 
            // txtTenSach
            // 
            this.txtTenSach.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenSach.Location = new System.Drawing.Point(241, 30);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(184, 22);
            this.txtTenSach.TabIndex = 1;
            this.txtTenSach.TextChanged += new System.EventHandler(this.txtTenSach_TextChanged);
            // 
            // cboTheLoai
            // 
            this.cboTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboTheLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTheLoai.Location = new System.Drawing.Point(521, 70);
            this.cboTheLoai.Name = "cboTheLoai";
            this.cboTheLoai.Size = new System.Drawing.Size(161, 24);
            this.cboTheLoai.TabIndex = 5;
            // 
            // cboNgonNgu
            // 
            this.cboNgonNgu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cboNgonNgu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgonNgu.Location = new System.Drawing.Point(817, 70);
            this.cboNgonNgu.Name = "cboNgonNgu";
            this.cboNgonNgu.Size = new System.Drawing.Size(99, 24);
            this.cboNgonNgu.TabIndex = 7;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Location = new System.Drawing.Point(978, 458);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(103, 50);
            this.btnTimKiem.TabIndex = 8;
            this.btnTimKiem.Text = "🔍 Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // lblTacGia
            // 
            this.lblTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(151, 73);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(71, 16);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "✍ Tác giả:";
            // 
            // lblTheLoai
            // 
            this.lblTheLoai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTheLoai.AutoSize = true;
            this.lblTheLoai.Location = new System.Drawing.Point(431, 73);
            this.lblTheLoai.Name = "lblTheLoai";
            this.lblTheLoai.Size = new System.Drawing.Size(74, 16);
            this.lblTheLoai.TabIndex = 4;
            this.lblTheLoai.Text = "📚 Thể loại:";
            // 
            // lblNgonNgu
            // 
            this.lblNgonNgu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgonNgu.AutoSize = true;
            this.lblNgonNgu.Location = new System.Drawing.Point(714, 73);
            this.lblNgonNgu.Name = "lblNgonNgu";
            this.lblNgonNgu.Size = new System.Drawing.Size(83, 16);
            this.lblNgonNgu.TabIndex = 6;
            this.lblNgonNgu.Text = "🈯 Ngôn ngữ:";
            // 
            // lblTimKiem
            // 
            this.lblTimKiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTimKiem.AutoSize = true;
            this.lblTimKiem.Location = new System.Drawing.Point(151, 33);
            this.lblTimKiem.Name = "lblTimKiem";
            this.lblTimKiem.Size = new System.Drawing.Size(78, 16);
            this.lblTimKiem.TabIndex = 0;
            this.lblTimKiem.Text = "🔍Tên sách:";
            this.lblTimKiem.Click += new System.EventHandler(this.lblTimKiem_Click);
            // 
            // txtTacGia
            // 
            this.txtTacGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTacGia.Location = new System.Drawing.Point(241, 74);
            this.txtTacGia.Name = "txtTacGia";
            this.txtTacGia.Size = new System.Drawing.Size(184, 22);
            this.txtTacGia.TabIndex = 10;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnXoa.Location = new System.Drawing.Point(245, 458);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 50);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSua.Location = new System.Drawing.Point(139, 458);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(100, 50);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnThem.Location = new System.Drawing.Point(30, 458);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(103, 50);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Location = new System.Drawing.Point(872, 458);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 50);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLuu.Location = new System.Drawing.Point(766, 458);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(100, 50);
            this.btnLuu.TabIndex = 15;
            this.btnLuu.Text = "Lưu ";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmSach
            // 
            this.ClientSize = new System.Drawing.Size(1093, 520);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtTacGia);
            this.Controls.Add(this.lblTimKiem);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTheLoai);
            this.Controls.Add(this.cboTheLoai);
            this.Controls.Add(this.lblNgonNgu);
            this.Controls.Add(this.cboNgonNgu);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.dgvSach);
            this.Name = "frmSach";
            this.Text = "📚 Quản lý Sách";
            this.Load += new System.EventHandler(this.frmSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // ** Các biến điều khiển trong Form **
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.ComboBox cboTheLoai, cboNgonNgu;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTacGia, lblTheLoai, lblNgonNgu, lblTimKiem;
        private TextBox txtTacGia;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private Button btnHuy;
        private Button btnLuu;
    }
}
