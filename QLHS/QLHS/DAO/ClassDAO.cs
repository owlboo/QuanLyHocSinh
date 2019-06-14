using QLHS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHS.DAO
{
    class ClassDAO
    {
        private static ClassDAO instance;

        internal static ClassDAO Instance { get { if (instance == null) instance = new ClassDAO(); return ClassDAO.instance; } private set => instance = value; }

        private ClassDAO() { }


        public void InsertClass(string malop, string tenlop, string makhoilop, string namhoc, string gvcn)
        {
            DataProvider.Instance.ExecuteNonQuery("EXEC ThemLop @malop , @tenlop , @makhoilop , @namhoc , @gvcn", new object[] { malop, tenlop, makhoilop, namhoc, gvcn });
        }

        //Get list class is existed, Existed return true else return false
        public bool getStatusClassbyMaLop(string malop)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE MaLop='" + malop + "'");
            if (data.Rows.Count > 0)
                return true;

            return false;
        }
        //Get list class is existed, Existed return true else return false
        public bool getStatusClassbyTenLop(string tenlop)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE TenLop= N'" + tenlop + "'");
            if (data.Rows.Count > 0)
                return true;

            return false;
        }
        public DataTable loadClass()
        {
            string query = "SELECT * FROM Lop";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable loadClassToReport()
        {
            string query = "SELECT MaLop, TenLop, TenGV, TenNamHoc, SiSo FROM dbo.Lop, dbo.GiaoVien, dbo.NamHoc WHERE Lop.GVCN=dbo.GiaoVien.MaGV AND Lop.NamHoc=NamHoc.MaNamHoc";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);  
            return data;
        }
        public DataTable loadClassByNH(string manh)
        {
            string query = "EXEC dbo.LoadCLassByNH @manamhoc = N'" + manh + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable loadClassByKL (string makhoi)
        {
            string query = "EXEC dbo.LoadClassByKL @makhoi = N'" + makhoi + "'";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool updateClass(string malop, string tenlop, string tenkhoilop, string tengiaovien, string tennamhoc)
        {
            string query = "EXEC dbo.USP_UpdateLop @malop = '" + malop + "' , @tenlop = N'" + tenlop + "', @tenkhoilop = N'" + tenkhoilop + "' , @tengiaovien = N'" + tengiaovien + "', @tennamhoc = N'" + tennamhoc + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool deleteClass(string malop)
        {
            string query = "EXEC dbo.USP_DeleteLop @malop = '" + malop + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckGVCNinClass(string magv)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Lop WHERE GVCN ='" + magv + "'");
            if (data.Rows.Count > 0) return true;
            return false;
        }
    }
}