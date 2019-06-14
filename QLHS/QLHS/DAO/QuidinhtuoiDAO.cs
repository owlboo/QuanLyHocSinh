using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    class QuidinhtuoiDAO
    {
        private static QuidinhtuoiDAO instance;

        internal static QuidinhtuoiDAO Instance { get { if (instance == null) instance = new QuidinhtuoiDAO(); return QuidinhtuoiDAO.instance; } private set => instance = value; }

        private QuidinhtuoiDAO() { }

        public bool QuiDinhTuoiHS(string maxage, string minage)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("EXEC dbo.USP_QuiDinhTuoi @maxage = N'" + maxage + "',@minage = N'" + minage + "'");
            return result < 0;
        }
        public string GetAgeMaxByMaTruong()
        {
            string query = "SELECT AgeMax FROM QuyDinhTruong";
            return DataProvider.Instance.ExecuteSchalar(query).ToString();
        }
        public string GetAgeMinByMaTruong()
        {
            string query = "SELECT AgeMin FROM QuyDinhTruong";
            return DataProvider.Instance.ExecuteSchalar(query).ToString();
        }
        public bool UpdateLimitAge(string agemax, string agemin)
        {
            string query = "UPDATE QuyDinhTruong SET AgeMax = '" + agemax + "', AgeMin = '" + agemin + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
    }
}
