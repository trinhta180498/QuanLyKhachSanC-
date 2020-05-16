using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;//static

        public static AccountDAO Instance //static 
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set => instance = value;
        }
        private AccountDAO() { }
        public bool Login(string userName, string passWord)
        {
            string query = "EXEC USP_Login @userName , @passWord";//nối chuỗi
            DataTable result = DataProvider.Instance.ExcuteQuery(query, new object[] { userName, passWord });
            return result.Rows.Count > 0;
        }
    }
}
