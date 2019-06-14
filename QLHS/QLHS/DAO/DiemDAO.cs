using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class DiemDAO
    {
        private static DiemDAO instance;

        public static DiemDAO Instance
        {
            get
            {
                if (instance == null) instance = new DiemDAO(); return instance;
            }
            set => instance = value;
        }
        private DiemDAO() { }
        public bool CheckHSInBangDiemMon(string mahs,string mamon)
        {
            string query = "SELECT * FROM dbo.BangDiem bd, CTBD c WHERE bd.ID=c.IDBangDiem AND bd.MaHS = '"+mahs+"' AND c.MaMH = '"+mamon+"'";
            DataTable result = DataProvider.Instance.ExecuteQuery(query);
            return result.Rows.Count>0;
        }
        public bool KiemTraDiem(DataGridView dgv, string loaidiem)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[loaidiem].Value != null)
                {
                    string ChuoiChuaXuLy = row.Cells[loaidiem].Value.ToString();
                    string ChuoiDaXuLy = "";

                    int count = 0;
                    for (int i = 0; i < ChuoiChuaXuLy.Length; i++)
                    {
                        if (ChuoiChuaXuLy[i] != ';' && i != ChuoiChuaXuLy.Length - 1)
                        {
                            count++;
                        }
                        else
                        {
                            if (i == ChuoiChuaXuLy.Length - 1)
                            {
                                i++;
                                count++;

                            }

                            ChuoiDaXuLy = ChuoiChuaXuLy.Substring(i - count, count);
                            if (count != 0 && QuyDInhDiemDAO.Instance.KiemTraDiem(ChuoiDaXuLy) == false)
                            {
                                return false;
                            }
                            ChuoiDaXuLy = "";
                            count = 0;
                        }
                    }
                }
            }
            return true;
        }
        public void LuuDiem(string mahs, string malop, string macotdiem, float diemso, int hocki, string namhoc, string mamon)
        {
            string query = String.Format("EXEC dbo.InsertDiemAndMon @mahs = '{0}',@malop = N'{1}',@macotdiem = '{2}',@diem = {3},@hocki = {4},@namhoc = N'{5}',@monhoc = '{6}'", mahs, malop, macotdiem, Math.Round(diemso, 2), hocki, namhoc, mamon);
            DataProvider.Instance.ExecuteNonQuery(query);
        }
        public bool XoaDIem(string mahs,string tencotdiem,int id)
        {
            string query = "EXEC dbo.USP_XoaTungLoaiDiem @mahs = '"+mahs+"',@tencotdiem = N'"+tencotdiem+"',@idbangdiem ="+id;
            int re = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaDIem(string mahs)
        {
            string query = "EXEC dbo.DeleteBangDiemByMaHS @mahs = '"+mahs+"'";
            int re = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }

        public bool KiemTraMaHSInBangDiem(string mahs)
        {
            string query = "SELECT COUNT(*) FROM dbo.BangDiem WHERE MaHS= '" + mahs + "'";
            int result = (int)DataProvider.Instance.ExecuteSchalar(query);
            return result > 0;
        }

        public DataTable LayDanhSachDiem(string mahs,string malop, string namhoc,int hocki,string mamh)
        {
            string query = "SELECT * FROM dbo.BangDiem bd,CTBD c,CotDiem cd "+
                            "WHERE bd.ID = c.IDBangDiem "+
                            "AND cd.MaCotDiem = bd.MaCotDiem "+
                            "AND bd.MaHS = '"+mahs+"' "+
                            "AND bd.NamHoc = '"+namhoc+"' "+
                            "AND bd.MaLop = '"+malop+"' "+
                            "AND bd.HocKi = "+hocki+" "+
                            "AND c.MaMH = '"+mamh+"'";
            return DataProvider.Instance.ExecuteQuery(query);
        }
        public DataTable LoadSTInBangDiem(string malop)
        {
            string query = "EXEC dbo.USP_GetStudentFromBangDiem @malop = N'" + malop + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool UpdateDiem(string mahs, float diem)
        {
            string query = "UPDATE dbo.BangDiem SET Diem = " + diem + " WHERE MaHS= '" + mahs + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }

        public float DiemTBMonHocKi(string mahs,string malop,string namhoc,int hocki,string mamh)
        {
            DataTable data = LayDanhSachDiem(mahs, malop, namhoc, hocki, mamh);

            float DiemTBMon = 0;
            int TongHeso = 0;
            foreach(DataRow r in data.Rows)
            {
                DiemTBMon += Convert.ToSingle(r["Diem"].ToString()) * Convert.ToInt32(r["HeSo"].ToString());
                TongHeso += Convert.ToInt32(r["HeSo"].ToString());
            }
            if (TongHeso > 0) return DiemTBMon / TongHeso;
            return 0;
        }
        public float DiemTBMonCaNam(string mahs, string malop, string namhoc, string mamh)
        {

            DataTable data = HocKiDAO.Instance.LoadHocKi();

            float DiemTBMon = 0;
            int TongHeso = 0;
            foreach (DataRow r in data.Rows)
            {
                DiemTBMon += DiemTBMonHocKi(mahs, malop, namhoc, Int32.Parse(r["MaHocKi"].ToString()), mamh) * Convert.ToInt32(r["MaHocKi"].ToString());
                TongHeso += Convert.ToInt32(r["MaHocKi"].ToString());
            }
            if (TongHeso > 0) return DiemTBMon / TongHeso;
            return 0;
        }

        public float DiemTBMonHocKiCacMon(string mahs, string malop, string namhoc, int hocki)
        {
            float tongDiemCacMon = 0;
            float diemTBTungMon = 0;
            int tongHeSoCacMon = 0;

            DataTable data = MonHocDAO.Instance.LoadMonHoc();

            foreach (DataRow r in data.Rows)
            {
                diemTBTungMon = DiemTBMonHocKi(mahs,malop,namhoc,hocki,r["MaMH"].ToString());
                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(r["HeSoMon"].ToString());
                tongHeSoCacMon += Convert.ToInt32(r["HeSoMon"].ToString());
            }
            if (tongHeSoCacMon > 0) return tongDiemCacMon / tongHeSoCacMon;
            return 0;
        }
        public float DiemTBCaNamCacMon(string mahs, string malop, string namhoc)
        {
            float tongDiemCacMon = 0;
            float diemTBTungMon = 0;
            int tongHeSoCacMon = 0;

            DataTable data = MonHocDAO.Instance.LoadMonHoc();

            foreach (DataRow r in data.Rows)
            {
                diemTBTungMon = DiemTBMonCaNam(mahs, malop, namhoc, r["MaMH"].ToString());
                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(r["HeSoMon"].ToString());
                tongHeSoCacMon += Convert.ToInt32(r["HeSoMon"].ToString());
            }
            if (tongHeSoCacMon > 0) return tongDiemCacMon / tongHeSoCacMon;
            return 0;
        }
        public bool XoaDIem(int id)
        {
            string query = "EXEC dbo.USP_DeleteBangDiemByID @id = " + id;
            int re = (int)DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }

    }
}
