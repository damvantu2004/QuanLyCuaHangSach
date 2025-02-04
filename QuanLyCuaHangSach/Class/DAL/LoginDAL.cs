using QuanLyCuaHangSach.Database;
using System.Data;
using System.Data.SqlClient;

namespace QuanLyCuaHangSach.DAL
{
    internal class LoginDAL
    {
        public static int? TryLogin(string username, string password)
        {
            string sqlCheckKey = "SELECT Quyen FROM TaiKhoan WHERE TenDangNhap = @username AND MatKhau = @password";
            SqlParameter[] checkKeyParams = {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };

            DataTable dt = DatabaseLayer.GetDataToTable(sqlCheckKey, checkKeyParams);

            if (dt.Rows.Count == 1)
            {
                return dt.Rows[0]["Quyen"].Equals(0) ? 0 : 1; // 0: Admin, 1: Nhân viên
            }
            else
            {
                return null;
            }
        }
    }
}
