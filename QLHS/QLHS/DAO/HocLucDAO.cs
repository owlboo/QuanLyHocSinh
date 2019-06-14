using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class HocLucDAO
    {
        private static HocLucDAO instance;

        public static HocLucDAO Instance { get { if (instance == null) instance = new HocLucDAO(); return instance; } set => instance = value; }
        private HocLucDAO() { }

        public DataTable LoadHocLuc()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocLuc");
            return data;
        }
        public bool ThemHocLuc(string mahocluc, string tenhocluc,float diemtoithieu, float diemtoida)
        {
            string query = "INSERT INTO dbo.HocLuc( MaHocLuc, TenHocLuc,DiemToiDa,DiemToiThieu) VALUES  ( '" + mahocluc + "',N'" + tenhocluc + "',"+diemtoithieu+","+diemtoida+")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaHocLuc(string mahocluc)
        {
            string query = "DELETE dbo.HocLuc WHERE MaHocLuc = '" + mahocluc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaHocLuc(string mahocluc, string tenhocluc, float diemtoithieu, float diemtoida)
        {
            string query = "UPDATE dbo.HocLuc SET TenHocLuc = N'" + tenhocluc + "', DiemToiThieu = "+diemtoithieu+", DiemToiDa = "+diemtoida+" WHERE MaHocLuc = '" + mahocluc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckHocLucExist(string mahocluc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocLuc WHERE MaHocLuc = '" + mahocluc + "'");
            return data.Rows.Count > 0;
        }
        public string XepLoaiHocLucMonHoc(float[] arrBangDiemTBcacMon, float Tongdiem)
        {
            string xeploai = "";
            float diemTBmonMIN = arrBangDiemTBcacMon[0];

            for(int i=1;i<arrBangDiemTBcacMon.Length;i++)
            {
                if (diemTBmonMIN > arrBangDiemTBcacMon[i])
                    diemTBmonMIN = arrBangDiemTBcacMon[i];
            }

            DataTable data = LoadHocLuc();
            string[] maHocLuc = new String[data.Rows.Count]; // danh sách mã học lực
            float[] diemCanDuoi = new float[data.Rows.Count];// danh sách điểm  tối thiểu
            //Lấy danh sách điểm tối thiểu và mã học lực
            int index = 0;
            foreach(DataRow r in data.Rows)
            {
                maHocLuc[index] = r["MaHocLuc"].ToString();
                diemCanDuoi[index] = float.Parse(r["DiemToiThieu"].ToString());
                index++;
            }
            for (int i = 0; i < index - 1; i++)
            {
                if (Tongdiem >= diemCanDuoi[i] && diemTBmonMIN >= diemCanDuoi[i + 1])
                {
                    xeploai = maHocLuc[i];
                    break;
                }
            }

            if (xeploai == "")
                xeploai = maHocLuc[index - 1].ToString();
            return xeploai;

        }

        public string XepLoaiHocLucHocKy(string mahs,string malop,string namhoc,int mahocki)
        {
            float tongDiem = 0;
            float tongDiemCacMon = 0;
            float diemTBTungMon = 0;
            int tongHeSoCacMon = 0;

            DataTable dataMonHoc = MonHocDAO.Instance.LoadMonHoc();

            float[] arrBangDiemTungMon = new float[dataMonHoc.Rows.Count];

            int countMonhoc = 0; 
            foreach(DataRow r in dataMonHoc.Rows)
            {
                diemTBTungMon = DiemDAO.Instance.DiemTBMonHocKi(mahs, malop, namhoc, mahocki, r["MaMH"].ToString());
                arrBangDiemTungMon[countMonhoc++] = diemTBTungMon;

                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(r["HeSoMon"].ToString());
                tongHeSoCacMon += Convert.ToInt32(r["HeSoMon"].ToString());
            }

            if (tongHeSoCacMon > 0) tongDiem = tongDiemCacMon / tongHeSoCacMon;
            else tongDiem = 0;

            return XepLoaiHocLucMonHoc(arrBangDiemTungMon, tongDiem);
        }

        public string XepLoaiHocLucCaNam(string mahs, string malop, string namhoc)
        {
            float tongDiem = 0;
            float tongDiemCacMon = 0;
            float diemTBTungMon = 0;
            int tongHeSoCacMon = 0;

            DataTable dataMonHoc = MonHocDAO.Instance.LoadMonHoc();

            float[] arrBangDiemTungMon = new float[dataMonHoc.Rows.Count];

            int countMonhoc = 0;
            foreach (DataRow r in dataMonHoc.Rows)
            {
                diemTBTungMon = DiemDAO.Instance.DiemTBMonCaNam(mahs, malop, namhoc,r["MaMH"].ToString());
                arrBangDiemTungMon[countMonhoc++] = diemTBTungMon;

                tongDiemCacMon += diemTBTungMon * Convert.ToInt32(r["HeSoMon"].ToString());
                tongHeSoCacMon += Convert.ToInt32(r["HeSoMon"].ToString());
            }

            if (tongHeSoCacMon > 0) tongDiem = tongDiemCacMon / tongHeSoCacMon;
            else tongDiem = 0;

            return XepLoaiHocLucMonHoc(arrBangDiemTungMon, tongDiem);
        }
        public bool CheckHocLucInGridView(string mahocluc, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (mahocluc.Equals(dgv.Rows[i].Cells["colMahocluc"].Value.ToString())) return true;
            }
            return false;
        }
    }
}
