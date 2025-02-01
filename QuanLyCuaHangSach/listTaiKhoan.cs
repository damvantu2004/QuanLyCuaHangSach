using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCuaHangSach
{
    public class listTaiKhoan
    {
        public static listTaiKhoan instance;
        List<TaiKhoan> listUser;

        public List<TaiKhoan> ListUser { get => listUser; set => listUser = value; }
        public static listTaiKhoan Instance
        {
            get
            {
                if (instance == null)
                    instance = new listTaiKhoan();
                return instance;
            }
            private set
            {
                instance = value;
            }
        }

        private listTaiKhoan()
        {
            ListUser = new List<TaiKhoan>();
            ListUser.Add(new TaiKhoan("admin@gmail.com", "0123456789", "admin", "admin", "Admin"));
            ListUser.Add(new TaiKhoan("admin1@gmail.com", "0123456788", "admin1", "admin1", "User"));
            ListUser.Add(new TaiKhoan("admin2@gmail.com", "0123456787", "admin2", "admin2", "User"));
        }
    }
}
