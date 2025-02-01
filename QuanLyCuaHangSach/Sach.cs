using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach
{
    public class Sach
    {
        private string tenSach;
        private string tacGia;
        private string theLoai;
        private string ngonNgu;
        public string TenSach { get => tenSach; set => tenSach = value; }
        public string TacGia { get => tacGia; set => tacGia = value; }
        public string TheLoai { get => theLoai; set => theLoai = value; }
        public string NgonNgu { get => ngonNgu; set => ngonNgu = value; }
        public Sach(string tenSach, string tacGia, string theLoai, string ngonNgu)
        {
            TenSach = tenSach;
            TacGia = tacGia;
            TheLoai = theLoai;
            NgonNgu = ngonNgu;
        }
    }
}
