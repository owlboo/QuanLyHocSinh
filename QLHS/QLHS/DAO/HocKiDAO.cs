using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class HocKiDAO
    {
        private static HocKiDAO instance;

        public static HocKiDAO Instance
        {
            get { if (instance == null) instance = new HocKiDAO(); return instance; }
            set => instance = value;
        }
        private HocKiDAO() { }
        
        public DataTable LoadHocKi()
        {
            string query = "SELECT * FROM dbo.HocKi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool ThemHocKi(string mahk, string tenhk,int heso)
        {
            string query = "INSERT INTO dbo.HocKi( MaHocKi, TenHocKi, HeSo) VALUES  ( '" + mahk + "',N'" + tenhk + "',"+heso+")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaHocKi(string mahk)
        {
            string query = "DELETE dbo.HocKi WHERE MaHocKi = '" + mahk + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaHocKi(string mahk, string tenhk,int heso)
        {
            string query = "UPDATE dbo.HocKi SET TenHocKi = N'" + tenhk + "', HeSo = "+heso+" WHERE MaHocKi = '" + mahk + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckHocKiExist(string mahk)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM HocKi WHERE MaHocKi = '" + mahk + "'");
            return data.Rows.Count > 0;
        }
        public bool CheckHocKiInGridView(string mahocki, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (mahocki.Equals(dgv.Rows[i].Cells["colMahocki"].Value.ToString())) return true;
            }
            return false;
        }
    }
}
