using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangSach.Class.DAL
{
    internal class TimKiemDAL
    {
        private readonly string _connectionString; // readonly vì connection string không thay đổi

        public TimKiemDAL(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString), "Connection string cannot be null."); // Kiểm tra null
        }

        public List<HoaDonKhachHangInfo> TimKiemHoaDonVaKhachHang(DateTime startDate, DateTime endDate, string maKH = null, string maSach = null)
        {
            List<HoaDonKhachHangInfo> results = new List<HoaDonKhachHangInfo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT 
                        HD.MaHoaDon,
                        HD.NgayMua,
                        KH.MaKH,
                        KH.TenKH,
                        KH.SDT,
                        KH.DiaChi,
                        NV.TenNV,
                        SUM(CTHD.SoLuong * CTHD.DonGia) AS TongTienHoaDon
                    FROM HoaDon HD
                    INNER JOIN KhachHang KH ON HD.MaKH = KH.MaKH
                    INNER JOIN NhanVien NV ON HD.MaNV = NV.MaNV
                    INNER JOIN ChiTietHoaDon CTHD ON HD.MaHoaDon = CTHD.MaHoaDon
                    INNER JOIN Sach S ON CTHD.MaSach = S.MaSach
                    WHERE HD.NgayMua <= @EndDate AND @StartDate <= HD.NgayMua
                ";

                if (!string.IsNullOrEmpty(maKH))
                {
                    query += " AND KH.MaKH = @MaKH";
                }

                if (!string.IsNullOrEmpty(maSach))
                {
                    query += " AND S.MaSach = @MaSach";
                }

                query += " GROUP BY HD.MaHoaDon, HD.NgayMua, KH.MaKH, KH.TenKH, KH.SDT, KH.DiaChi, NV.TenNV";

                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection)) // Sử dụng using
                    {
                        command.Parameters.AddWithValue("@StartDate", startDate);
                        command.Parameters.AddWithValue("@EndDate", endDate);

                        if (!string.IsNullOrEmpty(maKH))
                        {
                            command.Parameters.AddWithValue("@MaKH", maKH);
                        }

                        if (!string.IsNullOrEmpty(maSach))
                        {
                            command.Parameters.AddWithValue("@MaSach", maSach);
                        }

                        using (SqlDataReader reader = command.ExecuteReader()) // Sử dụng using
                        {
                            while (reader.Read())
                            {
                                HoaDonKhachHangInfo info = new HoaDonKhachHangInfo
                                {
                                    MaHoaDon = reader["MaHoaDon"].ToString(),
                                    NgayMua = Convert.ToDateTime(reader["NgayMua"]),
                                    MaKH = Convert.ToInt32(reader["MaKH"]),
                                    TenKH = reader["TenKH"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    DiaChi = reader["DiaChi"].ToString(),
                                    TenNV = reader["TenNV"].ToString(),
                                    TongTienHoaDon = Convert.ToDecimal(reader["TongTienHoaDon"])
                                };
                                results.Add(info);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tìm kiếm hóa đơn và khách hàng: " + ex.Message);
                    throw; // Re-throw exception để lớp gọi có thể xử lý
                }
            }

            return results;
        }

        public List<KhachHangInfo> TimKiemKhachHangTheoMaOrSDT(string maKHOrSDT)
        {
            List<KhachHangInfo> results = new List<KhachHangInfo>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                   SELECT
                        KH.MaKH,
                        KH.TenKH,
                        KH.GioiTinh,
                        KH.DiaChi,
                        KH.SDT,
                        KH.SoLuotMua,
                        ISNULL(SUM(CTHD.SoLuong * CTHD.DonGia), 0) AS TongTien,
                        COUNT(DISTINCT HD.MaHoaDon) AS SoLanMua
                    FROM KhachHang KH
                    LEFT JOIN HoaDon HD ON KH.MaKH = HD.MaKH
                    LEFT JOIN ChiTietHoaDon CTHD ON HD.MaHoaDon = CTHD.MaHoaDon
                    WHERE KH.MaKH = @MaKHOrSDT OR KH.SDT = @MaKHOrSDT
                    GROUP BY KH.MaKH, KH.TenKH, KH.GioiTinh, KH.DiaChi, KH.SDT, KH.SoLuotMua;";

                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaKHOrSDT", maKHOrSDT);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                KhachHangInfo info = new KhachHangInfo
                                {
                                    MaKH = Convert.ToInt32(reader["MaKH"]),
                                    TenKH = reader["TenKH"].ToString(),
                                    GioiTinh = reader["GioiTinh"].ToString(),
                                    DiaChi = reader["DiaChi"].ToString(),
                                    SDT = reader["SDT"].ToString(),
                                    SoLuotMua = Convert.ToInt32(reader["SoLuotMua"]),
                                    TongTien = Convert.ToDecimal(reader["TongTien"]),
                                    SoLanMua = Convert.ToInt32(reader["SoLanMua"])
                                };
                                results.Add(info);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
                    throw;
                }
            }

            return results;
        }

        public SachInfo LayThongTinSachTheoMa(string maSach)
        {
            SachInfo info = null;

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                string query = @"
                    SELECT 
                        MaSach,
                        TenSach,
                        NgonNgu,
                        SoLuong,
                        GiaBan,
                        GiaNhap
                    FROM Sach
                    WHERE MaSach = @MaSach
                ";

                try
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MaSach", maSach);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                info = new SachInfo
                                {
                                    MaSach = Convert.ToInt32(reader["MaSach"]),
                                    TenSach = reader["TenSach"].ToString(),
                                    NgonNgu = reader["NgonNgu"].ToString(),
                                    SoLuong = Convert.ToInt32(reader["SoLuong"]),
                                    GiaBan = Convert.ToDecimal(reader["GiaBan"]),
                                    GiaNhap = Convert.ToDecimal(reader["GiaNhap"])
                                };
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Lỗi khi lấy thông tin sách: " + ex.Message);
                    throw;
                }
            }

            return info;
        }

        // Lớp HoaDonKhachHangInfo (được lồng bên trong TimKiemDAL)
        public class HoaDonKhachHangInfo
        {
            public string MaHoaDon { get; set; }
            public DateTime NgayMua { get; set; }
            public int MaKH { get; set; }
            public string TenKH { get; set; }
            public string SDT { get; set; }
            public string DiaChi { get; set; }
            public string TenNV { get; set; }
            public decimal TongTienHoaDon { get; set; }
        }

        // Lớp KhachHangInfo (được lồng bên trong TimKiemDAL)
        public class KhachHangInfo
        {
            public int MaKH { get; set; }
            public string TenKH { get; set; }
            public string GioiTinh { get; set; }
            public string DiaChi { get; set; }
            public string SDT { get; set; }
            public int SoLuotMua { get; set; }
            public decimal TongTien { get; set; }
            public int SoLanMua { get; set; }
        }

        // Lớp SachInfo (được lồng bên trong TimKiemDAL)
        public class SachInfo
        {
            public int MaSach { get; set; }
            public string TenSach { get; set; }
            public string NgonNgu { get; set; }
            public int SoLuong { get; set; }
            public decimal GiaBan { get; set; }
            public decimal GiaNhap { get; set; }
        }
    }
}