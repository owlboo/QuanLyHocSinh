using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class HocSinhDAO
    {
        private static HocSinhDAO instance;

        public static HocSinhDAO Instance
        {
            get { if (instance == null) instance = new HocSinhDAO(); return instance; }
            set => instance = value;
        }
        private HocSinhDAO() { }

        public bool ThemHocSinh(string mahs, string hoten, string gioitinh, DateTime ngaysinh, string noisinh, string dienthoai, string email, string diachi)
        {

            string query = "EXEC dbo.USP_ThemHocSinh @mahs = '" + mahs + "' , @hoten = N'" + hoten + "' , @gioitinh = N'" + gioitinh + "' , @ngaysinh = '" + ngaysinh + "' , @noisinh = N'" + noisinh + "' , @dienthoai = N'" + dienthoai + "' , @email = N'" + email + "' , @diachi = N'" + diachi + "' ";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        //if existed return true, else return false
        public bool checkExistedStuByMaHS(string mahs)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh WHERE MaHS= '" + mahs + "'");

            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        //if existed return true, else return false
        public bool checkExistedStuByName(string name)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocSinh WHERE HoTen=N'" + name + "'");

            if (data.Rows.Count > 0)
                return true;
            return false;
        }

        //if update succeed return true, else return false
        public bool updateHocSinh(string mahs, string hoten, string gioitinh, DateTime ngaysinh, string noisinh, string dienthoai, string email, string diachi)
        {
            string query = "EXEC dbo.USP_UpdateHocSinh @mahs = '" + mahs + "' , @tenhs = N'" + hoten + "', @ngaysinh = '" + ngaysinh + "' , @noisinh = N'" + noisinh + "', @sodienthoai = N'" + dienthoai + "', @diachi = N'" + diachi + "', @gioitinh = N'" + gioitinh + "' , @email = N'" + email + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        //if deleted succeed return true, else return false
        public bool deleteHocSinh(string mahs)
        {
            string query = "EXEC dbo.USP_XoaHocSinh @mahs = '" + mahs + "'";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public int getMaxMaHS()
        {
            try
            {
                return (int)DataProvider.Instance.ExecuteSchalar("SELECT Max(MaHS) FROM HocSinh");
            }
            catch
            {
                return 1;
            }
        }
        public bool CheckHSinClass(string mahs, string malop)
        {
            string query = "SELECT COUNT(*) FROM dbo.HocSinh,dbo.XepLop WHERE dbo.XepLop.MaHS=dbo.HocSinh.MaHS AND HocSinh.MaHS= '" + mahs + "' AND MaLop= N'" + malop + "'";
            int result = Int32.Parse(DataProvider.Instance.ExecuteSchalar(query).ToString());
            return result > 0;
        }
        public bool CheckNameStudentByMaHS(string name, string mahs)
        {
            string query = "SELECT HoTen FROM HocSinh WHERE MaHS = '" + mahs + "'";

            string hoten = DataProvider.Instance.ExecuteSchalar(query).ToString();
            if (hoten.Equals(name))
                return true;
            return false;
        }
        public DataTable GetHocSinhByMaLopAndNamHoc(string malop, string namhoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT HocSinh.MaHS,HoTen FROM dbo.HocSinh,dbo.XepLop,dbo.Lop WHERE dbo.XepLop.MaHS=dbo.HocSinh.MaHS AND dbo.Lop.MaLop=dbo.XepLop.MaLop AND Lop.MaLop= N'" + malop + "' AND NamHoc = N'" + namhoc + "'");
            return data;
        }
        public DataTable LoadHSByMaLopNH(string ml, string nh)
        {
            string query = "EXEC dbo.GetHSByMaLopNH @malop = '" + ml + "' ,  @namhoc = N'" + nh + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadHSByMaKhoiNH(string mk, string nh)
        {
            string query = "EXEC dbo.GetHSByMaKhoiNH @makhoi = N'" + mk + "' , @manamhoc = N'" + nh + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadHS()
        {
            string query = "EXEC dbo.GetHS";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
