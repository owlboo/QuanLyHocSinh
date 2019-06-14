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
    public class NamHocDAO
    {
        private static NamHocDAO instance;

        public static NamHocDAO Instance { get { if (instance == null) instance = new NamHocDAO(); return instance; } set => instance = value; }
        private NamHocDAO() { }

        public DataTable LoadNamHoc()
        {
            string query = "SELECT * FROM NamHoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool ThemNamHoc(string manamhoc,string tennamhoc)
        {
            string query = "EXEC dbo.USP_ThemNamHoc @manamhoc = N'"+manamhoc+"',@tennamhoc = N'"+tennamhoc+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaNamHoc(string manamhoc)
        {
            string query = "EXEC dbo.USP_XoaNamHoc @manamhoc = N'"+manamhoc+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaNamHoc(string manamhoc,string tennamhoc)
        {
            string query = "EXEC dbo.USP_SuaNamHoc @tennh = N'" + tennamhoc + "',@manh = N'" + manamhoc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckNamHocExist(string manamhoc)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc WHERE MaNamHoc = N'" + manamhoc + "'");
            return data.Rows.Count > 0;
        }
        public bool CheckNamHocInGridView(string manamhoc,DataGridView dgv)
        {
            for(int i=0;i<dgv.Rows.Count-1;i++)
            {
                if (manamhoc.Equals(dgv.Rows[i].Cells["colManamhoc"].Value.ToString())) return true;
            }
            return false;
        }
        public List<NamHoc> getListNamHoc()
        {
            List<NamHoc> list = new List<NamHoc>();

            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM NamHoc");

            foreach (DataRow item in data.Rows)
            {
                NamHoc nh = new NamHoc(item);
                list.Add(nh);
            }
            return list;
        }
    }
}
