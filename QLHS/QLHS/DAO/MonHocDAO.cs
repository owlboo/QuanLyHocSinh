using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class MonHocDAO
    {
        private static MonHocDAO instance;

        public static MonHocDAO Instance { get { if (instance == null) instance = new MonHocDAO(); return instance; } set => instance = value; }
        private MonHocDAO() { }

        public DataTable LoadMonHoc()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM MonHoc");
        }
        public bool ThemMonHoc(string mamh, string tenmh, int heso)
        {
            string query = "INSERT INTO dbo.MonHoc( MaMH, TenMon, HeSoMon ) VALUES  ( '" + mamh + "',N'" + tenmh + "'," + heso + ")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaMonHoc(string mamh)
        {
            string query = "DELETE dbo.MonHoc WHERE MaMH = '" + mamh + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaMonHoc(string mamh, string tenmh, int heso)
        {
            string query = "UPDATE dbo.MonHoc SET TenMon = N'" + tenmh + "', HeSoMon = " + heso + " WHERE MaMH = '" + mamh + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckMonHocExist(string mamh)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM MonHoc WHERE MaMH = '" + mamh + "'");
            return data.Rows.Count > 0;
        }
        public bool CheckMonHocInGridView(string mamon, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (mamon.Equals(dgv.Rows[i].Cells["colManamhoc"].Value.ToString())) return true;
            }
            return false;
        }
    }
}
