using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class KQTongHopDAO
    {
        private static KQTongHopDAO instance;

        public static KQTongHopDAO Instance { get { if (instance == null) instance = new KQTongHopDAO(); return instance; } set => instance = value; }
        private KQTongHopDAO() { }

        public bool LuuKetQua(string mahs,string malop,string namhoc,string mahanhkiem)
        {
            float diemTB = (float)Math.Round(DiemDAO.Instance.DiemTBCaNamCacMon(mahs, malop, namhoc),2);
            string mahocluc = HocLucDAO.Instance.XepLoaiHocLucCaNam(mahs, malop, namhoc);
            string makq = KetQuaDAO.Instance.XepLoaiKetQua(mahs, malop, namhoc);
            string query = "INSERT INTO dbo.KQ_TongHop( MaHS,MaLop,NamHoc,MaHocLuc,MaHK,DiemTBNam,MaKQ)" +
                            " VALUES  ( '" + mahs + "' ,N'" + malop + "',N'" + namhoc + "','" + mahocluc + "','" + mahanhkiem + "'," + diemTB + ",'"+makq+"')";
            XoaKetQua(mahs, malop, namhoc);
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaKetQua(string mahs,string malop,string namhoc)
        {
            string query = "DELETE dbo.KQ_TongHop WHERE MaHS='" + mahs + "' AND MaLop=N'" + malop + "' AND NamHoc = N'" + namhoc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public float DiemTBNam(string mahs)
        {
            float re = 0;
            string query = "SELECT DiemTBNam FROM dbo.KQ_TongHop, dbo.HocSinh WHERE KQ_TongHop.MaHS = '"+mahs+"' AND  KQ_TongHop.MaHS = HocSinh.MaHS AND CheckInClass = 1";
            if(DataProvider.Instance.ExecuteSchalar(query)!= null)
             re =float.Parse(DataProvider.Instance.ExecuteSchalar(query).ToString());
            return re;
        }
        //public DataTable LoadKQCNToReport()
        //{
        //    string query = "EXEC dbo.LoadKQCN_LopToReport";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    return data;
        //}
        //public DataTable LoadKQCNByNHandLop(string manamhoc, string malop)
        //{
        //    string query = "EXEC dbo.LoadKQCN_LopByNamHocAndLop @manamhoc = N'" + manamhoc + "' , @malop = N'" + malop + "'";
        //    DataTable data = DataProvider.Instance.ExecuteQuery(query);
        //    return data;
        //}
        public DataTable LoadKQCNByNamHocAndMaLop(string manamhoc, string malop)
        {
            string query = "SELECT HocSinh.MaHS, HoTen, TenLop,DiemTBNam,TenKQ FROM dbo.KQ_TongHop, dbo.HocSinh,dbo.Lop,dbo.KetQua WHERE dbo.KQ_TongHop.MaHS=dbo.HocSinh.MaHS AND dbo.KQ_TongHop.MaLop=dbo.Lop.MaLop AND dbo.KQ_TongHop.MaKQ=dbo.KetQua.MaKQ AND dbo.KQ_TongHop.MaLop=N'" + malop + "' AND dbo.KQ_TongHop.NamHoc=N'" + manamhoc + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable GetKQHK(string mahs, string namhoc, string malop)
        {
            string query = "SELECT * FROM dbo.KQ_HocKi_TongHop WHERE dbo.KQ_HocKi_TongHop.MaHS=N'" + mahs + "' AND dbo.KQ_HocKi_TongHop.MaLop=N'" + malop + "'AND dbo.KQ_HocKi_TongHop.NamHoc=N'" + namhoc + "'";
            return DataProvider.Instance.ExecuteQuery(query);
        }

    }
}
