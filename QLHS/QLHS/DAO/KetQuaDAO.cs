using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class KetQuaDAO
    {
        private static KetQuaDAO instance;

        public static KetQuaDAO Instance { get { if (instance == null) instance = new KetQuaDAO(); return instance; } set => instance = value; }

        private KetQuaDAO() { }

        public DataTable LoadKetQua()
        {
            return DataProvider.Instance.ExecuteQuery("SELECT * FROM KetQua");
        }
        public bool ThemKetQua(string maketqua, string tenketqua)
        {
            string query = "INSERT INTO dbo.KetQua( MaKQ, TenKQ) VALUES  ( '" + maketqua + "',N'" + tenketqua + "')";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool XoaKetQua(string maketqua)
        {
            string query = "DELETE dbo.KetQua WHERE MaKQ = '" + maketqua + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool SuaKetQua(string maketqua, string tenketqua)
        {
            string query = "UPDATE dbo.KetQua SET TenKQ = N'" + tenketqua + "' WHERE MaKQ = '" + maketqua + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckKetQuaExist(string maketqua)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM KetQua WHERE MaKQ = '" + maketqua + "'");
            return data.Rows.Count > 0;
        }
        public bool CheckKetQuaInGridView(string maketqua, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (maketqua.Equals(dgv.Rows[i].Cells["colMaketqua"].Value.ToString())) return true;
            }
            return false;
        }
        public string XepLoaiKetQua(string mahs, string malop, string manamhoc)
        {
            string result = "";
            string hocluc = HocLucDAO.Instance.XepLoaiHocLucCaNam(mahs, malop, manamhoc);
            if (hocluc == "YEU" || hocluc == "KEM")
            {
                result = DataProvider.Instance.ExecuteSchalar("SELECT MaKQ FROM KetQua WHERE MaKQ='OLAI'").ToString();
            }
            else result = DataProvider.Instance.ExecuteSchalar("SELECt MaKQ FROM KetQua WHERE MaKQ='LENLOP'").ToString();
            return result;
        }
    }
}
