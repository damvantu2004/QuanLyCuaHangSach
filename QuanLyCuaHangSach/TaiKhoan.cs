using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach
{
    public class TaiKhoan
    {
        
        public string Email { get => Email; set => Email=value; }
        public string SoDienThoai { get => SoDienThoai; set => SoDienThoai=value; }
        public string TenDangNhap { get => TenDangNhap; set => TenDangNhap = value; }
        public string MatKhau { get => MatKhau; set => MatKhau = value; }
        public string ChucVu { get => ChucVu; set => ChucVu = value; }

        public TaiKhoan(string email, string soDienThoai, string tenDangNhap, string matKhau, string chucVu)
        {
            Email = email;
            SoDienThoai = soDienThoai;
            TenDangNhap = tenDangNhap;
            MatKhau = matKhau;
            ChucVu = chucVu;
        }
    }
}
