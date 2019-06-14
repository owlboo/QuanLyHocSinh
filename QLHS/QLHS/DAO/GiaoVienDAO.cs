using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class GiaoVienDAO
    {
        private static GiaoVienDAO instance;

        public static GiaoVienDAO Instance { get { if (instance == null) instance = new GiaoVienDAO(); return instance; }  set => instance = value; }
        private GiaoVienDAO() { }

        public DataTable LoadGiaoVien()
        {
            string query = "SELECT MaGV,TenGV,SDT,DiaChi,TenMon FROM dbo.GiaoVien,dbo.MonHoc WHERE GiaoVien.MaMH=dbo.MonHoc.MaMH";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public bool ThemGiaoVien(string magv, string tengv, string sdt, string diachi, string mamon)
        {
            string query = "EXEC dbo.USP_ThemGiaoVien @magv = '"+magv+"',@tengv = N'"+tengv+"',@sdt = '"+sdt+"',@diachi = N'"+diachi+"',@mamh = '"+mamon+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaGiaoVien(string magv)
        {
            string query = "EXEC dbo.USP_XoaGiaoVien @magv = '"+magv+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaGiaoVien(string magv, string tengv, string sdt, string diachi, string mamon)
        {
            string query = "EXEC dbo.USP_SuaGiaoVien @magv = '"+magv+"',@tengv = N'"+tengv+"',@sdt = '"+sdt+"',@diachi = N'"+diachi+"',@mamh = '"+mamon+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckGiaoVienExist(string magv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GiaoVien WHERE MaGV = N'" + magv + "'");
            return data.Rows.Count > 0;
        }
        public string ChangeTenMontoMaMH(string ten)
        {
                string query = "SELECT MonHoc.MaMH FROM dbo.GiaoVien RIGHT JOIN dbo.MonHoc ON MonHoc.MaMH = GiaoVien.MaMH WHERE TenMon LIKE N'%" + ten + "%'";
                string re = DataProvider.Instance.ExecuteSchalar(query).ToString();
                return re;
        }
        public List<GiaoVien> SearchGVByMaGV(string magv)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = "SELECT MaGV,TenGV,SDT,DiaChi,TenMon,MonHoc.MaMH FROM dbo.GiaoVien,dbo.MonHoc WHERE GiaoVien.MaMH=dbo.MonHoc.MaMH AND MaGV LIKE N'" + magv+"'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow r in data.Rows)
            {
                GiaoVien gv = new GiaoVien(r);
                list.Add(gv);
            }
            return list;
        }
        public List<GiaoVien> SearchGVByTenGV(string tengv)
        {
            List<GiaoVien> list = new List<GiaoVien>();
            string query = "SELECT MaGV,TenGV,SDT,DiaChi,TenMon,MonHoc.MaMH FROM dbo.GiaoVien,dbo.MonHoc WHERE GiaoVien.MaMH=dbo.MonHoc.MaMH AND dbo.fuConvertToUnsign1(TenGV) LIKE N'%'+dbo.fuConvertToUnsign1(N'" + tengv+"')+'%'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow r in data.Rows)
            {
                GiaoVien gv = new GiaoVien(r);
                list.Add(gv);
            }
            return list;
        }
        public List<GiaoVien> getListGV()
        {
            List<GiaoVien> listGV = new List<GiaoVien>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM GiaoVien,MonHoc WHERE GiaoVien.MaMH=MonHoc.MaMH");

            foreach (DataRow item in data.Rows)
            {
                GiaoVien gv = new GiaoVien(item);
                listGV.Add(gv);
            }
            return listGV;
        }
    }
}