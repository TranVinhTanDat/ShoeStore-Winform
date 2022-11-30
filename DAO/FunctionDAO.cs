using System.Data;

namespace DAO
{
    public class FunctionDAO
    {
        private static FunctionDAO instance;

        public static FunctionDAO Instance
        {
            get { if (instance == null) instance = new FunctionDAO(); return FunctionDAO.instance; }
            private set { FunctionDAO.instance = value; }
        }

        private FunctionDAO() { }

        public DataTable GetData()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Function";

            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable InsertFunction(string functionID, string functionName)
        {
            string query = string.Format("INSERT INTO Function(FunctionID, FunctionName) VALUES('{0}', '{1}')", functionID, functionName);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable UpdateFunction(string functionID, string functionName)
        {
            string query = string.Format("UPDATE Function SET FunctionName = '{1}' WHERE FunctionID = '{0}'", functionID, functionName);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable DeleteFunction(string functionID)
        {
            string query = string.Format("DELETE FROM Function WHERE FunctionID = '{0}'", functionID);
            return DataProvider.Instance.ExecuteQuery(query);
        }
    }
}
