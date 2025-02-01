using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach
{
    public class TaiKhoan
    {
        private string email;
        private string soDienThoai;
        private string tenDangNhap;
        private string matKhau;
        private string chucVu;
        public string Email { get => email;set=>  email=value; }
        public string SoDienThoai { get => soDienThoai; set => soDienThoai=value; }
        public string TenDangNhap { get => tenDangNhap; set => tenDangNhap = value; }
        public string MatKhau { get => matKhau; set => matKhau = value; }
        public string ChucVu { get => chucVu; set => chucVu = value; }

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
