using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using QuanLyCuaHangSach.Class.DAL;

namespace QuanLyCuaHangSach
{
    public partial class frmTimKiem : Form
    {
        private TimKiemDAL _timKiemDAL;
        private string _connectionString;

        public enum LoaiTimKiem
        {
            HoaDon,
            Sach,
            KhachHang
        }
        public frmTimKiem()
        {
            InitializeComponent();

            // Thêm các loại tìm kiếm vào ComboBox
            comboBox1.Items.Add(LoaiTimKiem.HoaDon.ToString());
            comboBox1.Items.Add(LoaiTimKiem.Sach.ToString());
            comboBox1.Items.Add(LoaiTimKiem.KhachHang.ToString());

            // Khởi tạo DAL và Connection String
            _connectionString = ConfigurationManager.ConnectionStrings["QuanLyCuaHangSach"].ConnectionString;
            _timKiemDAL = new TimKiemDAL(_connectionString);

            //Chọn mặc định ComboBox là Hóa Đơn
            comboBox1.SelectedItem = LoaiTimKiem.HoaDon.ToString();

            // Gán sự kiện SelectedIndexChanged cho ComboBox
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoaiTimKiem loaiTimKiem;

            // Kiểm tra xem người dùng đã chọn loại tìm kiếm hay chưa
            if (!Enum.TryParse(comboBox1.Text, out loaiTimKiem))
            {
                MessageBox.Show("Vui lòng chọn loại tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                switch (loaiTimKiem)
                {
                    case LoaiTimKiem.HoaDon:

                        TimKiemHoaDon();
                        break;
                    case LoaiTimKiem.KhachHang:

                        TimKiemKhachHang();
                        break;
                    case LoaiTimKiem.Sach:

                        TimKiemSach();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.StackTrace);
            }
        }

        private void TimKiemHoaDon()
        {
            if (dtpNgayBatDau.Value > dtpNgayKetThuc.Value)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime ngayBatDau = dtpNgayBatDau.Value;
            DateTime ngayKetThuc = dtpNgayKetThuc.Value;
            string maKH = txtMaKHOrSDT.Text; // Sử dụng txtMaKHOrSDT cho mã KH
            string maSach = txtMaSach.Text;

            List<TimKiemDAL.HoaDonKhachHangInfo> ketQuaTimKiem = _timKiemDAL.TimKiemHoaDonVaKhachHang(ngayBatDau, ngayKetThuc, maKH, maSach);
            HienThiKetQua(ketQuaTimKiem);

            decimal tongTien = 0;
            foreach (var hoaDon in ketQuaTimKiem)
            {
                tongTien += hoaDon.TongTienHoaDon;
            }

            lblTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0");
        }

        private void TimKiemKhachHang()
        {
            string maKHOrSDT = txtMaKHOrSDT.Text;
            List<TimKiemDAL.KhachHangInfo> ketQuaTimKiem = _timKiemDAL.TimKiemKhachHangTheoMaOrSDT(maKHOrSDT);

            if (ketQuaTimKiem.Count > 0)
            {
                HienThiKetQua(ketQuaTimKiem);

                decimal tongTienAll = 0;
                int soLanMuaAll = 0;
                foreach (var kh in ketQuaTimKiem)
                {
                    tongTienAll += kh.TongTien;
                    soLanMuaAll += kh.SoLanMua;
                }

                lblTongTien.Text = "Tổng tiền: " + tongTienAll.ToString("N0");
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng với mã hoặc số điện thoại này.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearResults();
            }
        }

        private void TimKiemSach()
        {
            string maSach = txtMaSach.Text;
            TimKiemDAL.SachInfo sach = _timKiemDAL.LayThongTinSachTheoMa(maSach);

            if (sach != null)
            {
                List<TimKiemDAL.SachInfo> danhSachSach = new List<TimKiemDAL.SachInfo> { sach };  // Tạo danh sách chứa 1 cuốn sách
                HienThiKetQua(danhSachSach);
                lblTongTien.Text = ""; //Không có tổng tiền trong tìm kiếm sách
            }
            else
            {
                MessageBox.Show("Không tìm thấy Sách.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearResults();
            }
        }

        private void HienThiKetQua<T>(List<T> ketQuaTimKiem)
        {
            dgvKetQua.DataSource = ketQuaTimKiem;
            lblSoLuongKetQua.Text = "Số lượng kết quả: " + ketQuaTimKiem.Count;
        }

        private void ClearResults()
        {
            dgvKetQua.DataSource = null;
            lblSoLuongKetQua.Text = "";
            lblTongTien.Text = "";
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tạo báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }
    }
}