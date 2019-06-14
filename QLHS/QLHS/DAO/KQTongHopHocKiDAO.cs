using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class KQTongHopHocKiDAO
    {
        private static KQTongHopHocKiDAO instance;

        public static KQTongHopHocKiDAO Instance { get { if (instance == null) instance = new KQTongHopHocKiDAO(); return instance; } set => instance = value; }
        private KQTongHopHocKiDAO() { }

        public bool LuuKetQua(string mahs, string malop, int mahocki,string mahanhkiem, string namhoc)
        {
            float diemTB = (float)Math.Round(DiemDAO.Instance.DiemTBMonHocKiCacMon(mahs, malop, namhoc, mahocki),2);
            string mahocluc = HocLucDAO.Instance.XepLoaiHocLucHocKy(mahs, malop, namhoc, mahocki);
            string query = "INSERT INTO dbo.KQ_HocKi_TongHop( MaHS,MaLop,MaHocKi,NamHoc,MaHocLuc,MaHK,DiemTBHocKi)" +
                           " VALUES  ( '"+mahs+"',N'"+malop+"',"+mahocki+",N'"+namhoc+"','"+mahocluc+"','"+mahanhkiem+"',"+diemTB+")";
            XoaKetQua(mahs, malop, mahocki, namhoc);
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaKetQua(string mahs,string malop,int mahocki,string namhoc)
        {
            string query = "DELETE dbo.KQ_HocKi_TongHop WHERE MaHS='" + mahs + "' AND MaLop=N'" + malop + "' AND NamHoc=N'" + namhoc + "' AND MaHocKi=" + mahocki + "";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public DataTable LoadKQHocKiToReport()
        {
            string query = "EXEC dbo.LoadKQHKtoReport";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable LoadKQHocKiByMaLopAndNamHocAndHocKi(string manamhoc, string malop, string mahocki)
        {
            string query = "EXEC dbo.LoadKQHKByMaLopAndNamHocAndHocKi @manamhoc = N'" + manamhoc + "' , @malop = N'" + malop + "' , @mahocki = N'" + mahocki + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
    }
}
