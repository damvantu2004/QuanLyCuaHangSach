using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangSach
{
    public partial class frmBaoCao : Form
    {
        public frmBaoCao()
        {
            InitializeComponent();
            cboBaoCao.Items.Add("Báo cáo doanh thu theo tháng");
            cboBaoCao.Items.Add("Báo cáo doanh thu theo tuần");
            cboBaoCao.Items.Add("Báo cáo doanh thu theo ngày");
            cboBaoCao.Items.Add("Báo cáo loại sách được yêu thích");
            cboBaoCao.Items.Add("Báo cáo sách được yêu thích");

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

            chrBaoCao.Visible = false;
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

        }

    }
}
