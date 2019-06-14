using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    public class QuyDinhSiSoDAO
    {
        private static QuyDinhSiSoDAO instance;

        public static QuyDinhSiSoDAO Instance { get { if (instance == null) instance = new QuyDinhSiSoDAO(); return instance; } set => instance = value; }
        private QuyDinhSiSoDAO() { }

        public bool ChangeSiSoMaxMin(int SisoMax, int SisoMin)
        {
            string query = "EXEC dbo.USP_ChangeSiSo @maxsiso = N'" + SisoMax + "',@minsiso = N'" + SisoMin + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re < 0;
        }
        public string GetSiSoMaxByMaTruong()
        {
            string query = "SELECT SiSoMax FROM QuyDinhTruong";
            return DataProvider.Instance.ExecuteSchalar(query).ToString();
        }
        public string GetSiSoMinByMaTruong()
        {
            string query = "SELECT SiSoMin FROM QuyDinhTruong";
            return DataProvider.Instance.ExecuteSchalar(query).ToString();
        }
        public bool UpdateLimitSiSo(int sisomax, int sisomin)
        {
            string query = "UPDATE QuyDinhTruong SET SiSoMax = '" + sisomax + "', SiSoMin = '" + sisomin + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public int GetSiSoMax()
        {
            string query = "SELECT SiSoMax FROM QuyDinhTruong";
            string sisomax = DataProvider.Instance.ExecuteSchalar(query).ToString();
            return int.Parse(sisomax);
        }
    }
}
