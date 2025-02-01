namespace QuanLyCuaHangSach
{
    partial class frmBaoCao
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cboBaoCao = new System.Windows.Forms.ComboBox();
            this.dtpNgayBatDau = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayKT = new System.Windows.Forms.DateTimePicker();
            this.btnTaoBaoCao = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.chrBaoCao = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chrBaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // cboBaoCao
            // 
            this.cboBaoCao.FormattingEnabled = true;
            this.cboBaoCao.Location = new System.Drawing.Point(12, 12);
            this.cboBaoCao.Name = "cboBaoCao";
            this.cboBaoCao.Size = new System.Drawing.Size(986, 24);
            this.cboBaoCao.TabIndex = 0;
            // 
            // dtpNgayBatDau
            // 
            this.dtpNgayBatDau.Location = new System.Drawing.Point(262, 43);
            this.dtpNgayBatDau.Name = "dtpNgayBatDau";
            this.dtpNgayBatDau.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayBatDau.TabIndex = 1;
            // 
            // dtpNgayKT
            // 
            this.dtpNgayKT.Location = new System.Drawing.Point(570, 43);
            this.dtpNgayKT.Name = "dtpNgayKT";
            this.dtpNgayKT.Size = new System.Drawing.Size(200, 22);
            this.dtpNgayKT.TabIndex = 2;
            // 
            // btnTaoBaoCao
            // 
            this.btnTaoBaoCao.Location = new System.Drawing.Point(804, 43);
            this.btnTaoBaoCao.Name = "btnTaoBaoCao";
            this.btnTaoBaoCao.Size = new System.Drawing.Size(96, 23);
            this.btnTaoBaoCao.TabIndex = 3;
            this.btnTaoBaoCao.Text = "Tạo báo cáo";
            this.btnTaoBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.Location = new System.Drawing.Point(906, 45);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(96, 23);
            this.btnXuatBaoCao.TabIndex = 4;
            this.btnXuatBaoCao.Text = "Xuất báo cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = true;
            // 
            // chrBaoCao
            // 
            chartArea1.Name = "ChartArea1";
            this.chrBaoCao.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chrBaoCao.Legends.Add(legend1);
            this.chrBaoCao.Location = new System.Drawing.Point(12, 89);
            this.chrBaoCao.Name = "chrBaoCao";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chrBaoCao.Series.Add(series1);
            this.chrBaoCao.Size = new System.Drawing.Size(986, 569);
            this.chrBaoCao.TabIndex = 5;
            this.chrBaoCao.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày bắt đầu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(476, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày kết thúc";
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 657);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chrBaoCao);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnTaoBaoCao);
            this.Controls.Add(this.dtpNgayKT);
            this.Controls.Add(this.dtpNgayBatDau);
            this.Controls.Add(this.cboBaoCao);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            ((System.ComponentModel.ISupportInitialize)(this.chrBaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBaoCao;
        private System.Windows.Forms.DateTimePicker dtpNgayBatDau;
        private System.Windows.Forms.DateTimePicker dtpNgayKT;
        private System.Windows.Forms.Button btnTaoBaoCao;
        private System.Windows.Forms.Button btnXuatBaoCao;
        private System.Windows.Forms.DataVisualization.Charting.Chart chrBaoCao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}