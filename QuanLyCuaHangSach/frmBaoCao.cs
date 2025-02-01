using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace QuanLyCuaHangSach
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
            cboBaoCao.Items.Add("Báo cáo doanh thu và lợi nhuận");
            cboBaoCao.Items.Add("Báo cáo sách bán chạy");
            cboBaoCao.Items.Add("Báo cáo tệp khách hàng");
            cboBaoCao.Items.Add("Thống kê sách trong kho");
            cboBaoCao.Items.Add("Thống kê hóa đơn bán");

            cboBaoCao.SelectedItem = null;

            dtpNgayBD.MaxDate = DateTime.Today;
            dtpNgayKT.MinDate = DateTime.Today;
            dtpNgayKT.MaxDate = DateTime.Today;
        }

        private void chrBaoCao_Click(object sender, EventArgs e)
        {

        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {
            dtpNgayBD.Enabled = false;
            dtpNgayKT.Enabled = false;

            btnTaoBaoCao.Enabled = false;
            btnXuatBaoCao.Enabled = false;

            chrBaoCao.Visible = true;
        }

        private void dtpNgayBD_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayKT.MinDate = dtpNgayBD.Value;
        }

        private void dtpNgayKT_ValueChanged(object sender, EventArgs e)
        {
            dtpNgayBD.MaxDate = dtpNgayKT.Value;
        }

        private void cboBaoCao_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboBaoCao.SelectedIndex.ToString() != null)
            {
                dtpNgayBD.Enabled = true;
                dtpNgayKT.Enabled = true;

                btnTaoBaoCao.Enabled = true;
            }
            else
            {
                dtpNgayBD.Enabled = false;
                dtpNgayKT.Enabled = false;

                btnTaoBaoCao.Enabled = false;
            }
        }

        private void btnTaoBaoCao_Click(object sender, EventArgs e)
        {
            chrBaoCao.Series.Clear(); // Xóa dữ liệu cũ

            Series series = new Series("Doanh Thu")
            {
                ChartType = SeriesChartType.Column // Biểu đồ dạng cột
            };

            // 🚀 Test dữ liệu ngẫu nhiên
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                string ngay = DateTime.Now.AddDays(-i).ToString("dd/MM");
                int giaTri = rnd.Next(10, 100);
                series.Points.AddXY(ngay, giaTri);
            }

            chrBaoCao.Series.Add(series);
            chrBaoCao.Visible = true; // 🔥 Đảm bảo biểu đồ hiển thị sau khi tạo dữ liệu
        }


    }
}
