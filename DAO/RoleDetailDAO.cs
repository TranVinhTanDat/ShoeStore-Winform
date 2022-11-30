using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class RoleDetailDAO
    {
        private static RoleDetailDAO instance;

        public static RoleDetailDAO Instance
        {
            get { if (instance == null) instance = new RoleDetailDAO(); return RoleDetailDAO.instance; }
            private set { RoleDetailDAO.instance = value; }
        }

        public RoleDetailDAO() { }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM RoleDetail";

            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable InsertRoleDetail(string roldID, string functionID)
        {
            string query = string.Format("INSERT INTO RoleDetail(RoleID, FunctionID) VALUES('{0}', '{1}')", roldID, functionID);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable DeleteRoleDetail(string roldID)
        {
            string query = string.Format("DELETE FROM RoleDetail WHERE RoleID = '{0}'", roldID);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
