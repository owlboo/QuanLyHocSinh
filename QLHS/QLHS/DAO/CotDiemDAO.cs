using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class CotDiemDAO
    {
        private static CotDiemDAO instance;

        public static CotDiemDAO Instance { get { if (instance == null) instance = new CotDiemDAO(); return instance; } set => instance = value; }

        private CotDiemDAO() { }

        public bool ThemCotDiem(string macotdiem,string tencotdiem,int heso)
        {
            string query = "INSERT INTO dbo.CotDiem( MaCotDiem, TenCotDiem, HeSo ) VALUES  ( '" + macotdiem + "',N'" + tencotdiem + "'," + heso + ")";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaCotDiem(string macotdiem)
        {
            string query = "DELETE dbo.CotDiem WHERE MaCotDiem = '"+macotdiem+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaCotDiem(string macotdiem,string tencotdiem,int heso)
        {
            string query = "UPDATE dbo.CotDiem SET TenCotDiem = N'" + tencotdiem + "', HeSo = "+heso+" WHERE MaCotDiem = '"+macotdiem+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckCotDiemExist(string macotdiem)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM CotDiem WHERE MaCotDiem = '" + macotdiem + "'");
            return data.Rows.Count > 0;
        }
        public bool CheckCotDiemInGridView(string macotdiem, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (macotdiem.Equals(dgv.Rows[i].Cells["colMacotdiem"].Value.ToString())) return true;
            }
            return false;
        }
    }
}
