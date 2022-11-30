using System.Data;

namespace DAO
{
    public class RoleDAO
    {
        private static RoleDAO instance;

        public static RoleDAO Instance
        {
            get { if (instance == null) instance = new RoleDAO(); return RoleDAO.instance; }
            private set { RoleDAO.instance = value; }
        }

        private RoleDAO() { }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Role";

            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable InsertRole(string roldID, string roleName)
        {
            string query = string.Format("INSERT INTO Role(RoleID, RoleName) VALUES('{0}', '{1}')", roldID, roleName);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable UpdateRole(string roldID, string roleName)
        {
            string query = string.Format("UPDATE Role SET RoleName = '{1}' WHERE RoleID = '{0}'", roldID, roleName);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable DeleteRole(string roldID)
        {
            string query = string.Format("DELETE FROM Role WHERE RoleID = '{0}'", roldID);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
