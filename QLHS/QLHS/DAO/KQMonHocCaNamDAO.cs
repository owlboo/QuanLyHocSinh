using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class KQMonHocCaNamDAO
    {
        private static KQMonHocCaNamDAO instance;

        public static KQMonHocCaNamDAO Instance { get { if (instance == null) instance = new KQMonHocCaNamDAO(); return instance; } set => instance = value; }
        private KQMonHocCaNamDAO() { }

        public bool LuuKetQua(string mahs, string malop, string mamon, string namhoc)
        {
            float diemTB = (float)Math.Round(DiemDAO.Instance.DiemTBMonCaNam(mahs, malop, namhoc, mamon),2);
            string query = "INSERT INTO dbo.KQ_CaNam_MonHoc( MaHS, MaLop, NamHoc, MaMH,DTBMonCaNam )"
                            + "VALUES  ( '"+mahs+"',N'"+malop+"',N'"+namhoc+"','"+mamon+"',"+diemTB+")";
            XoaKetQua(mahs, malop, mamon, namhoc);
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaKetQua(string mahs,string malop,string mamon,string namhoc)
        {
            string query = "DELETE dbo.KQ_CaNam_MonHoc WHERE MaHS='" + mahs + "' AND MaLop=N'" + malop + "' AND NamHoc=N'" + namhoc + "' AND MaMH = '" + mamon + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        //public DataTable LoadKQCaNamMonHocToReport()
        //{
        //    string query = "";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    return data;
        //}
        public DataTable LoadKQCaNamMHByNamHocAndMonHoc(string manamhoc, string mamh)
        {
            string query = "SELECT HocSinh.MaHS,HoTen,TenMon,DTBMonCaNam FROM dbo.KQ_CaNam_MonHoc,HocSinh,dbo.MonHoc WHERE dbo.KQ_CaNam_MonHoc.MaHS = dbo.HocSinh.MaHS AND dbo.KQ_CaNam_MonHoc.MaMH=dbo.MonHoc.MaMH AND NamHoc =N'"+manamhoc+ "' AND dbo.KQ_CaNam_MonHoc.MaMH='" + mamh+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable GetDTBHKByMaHS(string mahs, string manamhoc, string mamh)
        {
            string query = "SELECT * FROM dbo.KetQua_HocKi_MonHoc WHERE MaMH='"+mamh+"' AND MaNamHoc = N'"+manamhoc+"' AND MaHS='"+mahs+"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
