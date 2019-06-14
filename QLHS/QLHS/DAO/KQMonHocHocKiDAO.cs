using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QLHS.DAO {
    public class KQMonHocHocKiDAO {
        private static KQMonHocHocKiDAO instance;
        public static KQMonHocHocKiDAO Instance { get { if (instance == null) instance = new KQMonHocHocKiDAO(); return instance; } set => instance = value; }
        private KQMonHocHocKiDAO() { }
        public bool LuuKetQua(string mahs, string malop, string mamon, int mahocki, string namhoc) { float diemTB = (float)Math.Round(DiemDAO.Instance.DiemTBMonHocKi(mahs, malop, namhoc, mahocki, mamon), 2); string query = "INSERT INTO dbo.KetQua_HocKi_MonHoc(MaHS,MaLop,MaMH,MaNamHoc,DTBMonHocKi,HocKi)" + "VALUES('" + mahs + "', N'" + malop + "', '" + mamon + "', N'" + namhoc + "', " + diemTB + "," + mahocki + ")"; XoaKetQua(mahs, malop, namhoc, mamon, mahocki); int re = DataProvider.Instance.ExecuteNonQuery(query); return re > 0; }
        public bool XoaKetQua(string mahs, string malop, string namhoc, string mamon, int hocki)
        {
            string query = "DELETE dbo.KetQua_HocKi_MonHoc WHERE MaHS='" + mahs + "' AND MaLop=N'" + malop + "' AND MaNamHoc=N'" + namhoc + "' AND MaMH = '" + mamon + "'AND HocKi=" + hocki;
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public DataTable LoadKQHKMonHocToReport()
        {
            string query = "EXEC dbo.LoadKQHKMonToReport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadKQHKMonHocByNamHocAndHocKyAndMonHoc(string namhoc, string hocki, string monhoc)
        { string query = "EXEC dbo.LoadKQHKMonHocByNamHocAndHocKiAndMonHoc @manamhoc = N'" + namhoc + "' , @mahocki = N'" + hocki + "', @mamonhoc = N'" + monhoc + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}