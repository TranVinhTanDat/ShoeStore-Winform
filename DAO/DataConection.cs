using MySql.Data.MySqlClient;
using System.Data;

namespace DAO
{
    public class DataConection
    {
        public MySqlConnection conn = null;
        string strConn = @"SERVER=localhost; uid=root; DATABASE=shoestoremanager; port=3306";

        public void Moketnoi()
        {
            if (conn == null)
            {
                conn = new MySqlConnection(strConn);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void Dongketnoi()
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}

