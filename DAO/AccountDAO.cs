using System;
using System.Data;

namespace DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return AccountDAO.instance; }
            private set { AccountDAO.instance = value; }
        }

        public AccountDAO() { }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Account";

            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public bool InsertAccount(string userID, string userName, string passWord, string roleID, string email, string enable)
        {
            string query = string.Format("INSERT INTO Account(UserID, UserName, PassWord, RoleID, Email, Enable) VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", userID, userName, passWord, roleID, email, enable);
            //return DataProvider.Instance.ExecuteQuery(query);


            int result = DataProvider.Instance.ExecuteNonQuery(query);

            try
            {
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable UpdateAccount(string userID, string userName, string passWord, string roleID, string email, string enable)
        {
            string query = string.Format("UPDATE Account SET UserName = '{1}', PassWord = '{2}', RoleID = '{3}', Email = '{4}', Enable = '{5}' WHERE UserID = '{0}'", userID, userName, passWord, roleID, email, enable);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable DeleteAccount(string userID)
        {
            string query = string.Format("DELETE FROM Account WHERE UserID = '{0}'", userID);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
