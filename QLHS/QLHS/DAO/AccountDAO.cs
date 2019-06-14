using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance { get { if (instance == null) instance = new AccountDAO(); return instance; } set => instance = value; }
        private AccountDAO() { }

        public string GetType(string user)
        {
            string query = "SELECT Type FROM Account WHERE UserName = N'" + user + "'";
            string Type = DataProvider.Instance.ExecuteSchalar(query).ToString();
            return Type;
        }
        public bool checkExistAccountbyUsername(string us)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM Account WHERE UserName= N'" + us + "'");
            if (data.Rows.Count > 0)
                return true;
            return false;
        }
        public bool PasswordChange(string username, string password)
        {
            string query = "EXEC dbo.DoiMatKhau @username = N'" + username + "' , @pasword = N'" + password + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public DataTable loadAccount()
        {
            string query = "SELECT TenNguoiDung, Type, UserName FROM dbo.Account";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public bool AddAccount(string username, string tennguoidung, string loai)
        {
            string query = "EXEC dbo.USP_ThemAccount @username = N'" + username + "' , @name = N'" + tennguoidung + "' , @loai = N'" + loai + "'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool DeleteAccount(string username)
        {
            string query = "EXEC dbo.USP_DeleteAccount @username = N'"+username+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool UpdateAccount(string username, string tennguoidung, string loai)
        {
            string query = "EXEC dbo.USP_UpdateAccount @username = N'"+username+"', @name = N'"+tennguoidung+"', @loai = N'"+loai+"'";
            int re = DataProvider.Instance.ExecuteNonQuery(query);
            return re > 0;
        }
        public bool CheckUsernameInDGV(string username, DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                if (username.Equals(dgv.Rows[i].Cells["Username"].Value.ToString())) return true;
            }
            return false;
        }
    }
}
