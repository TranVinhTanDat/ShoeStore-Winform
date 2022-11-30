using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class CustomersDAO
    {
        private CustomersDAO() { }
        private static CustomersDAO instance;

        public static CustomersDAO Instance
        {
            get { if (instance == null) instance = new CustomersDAO(); return CustomersDAO.instance; }
            private set { CustomersDAO.instance = value; }
        }
        public List<CustomersDTO> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from customer";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<CustomersDTO> list = new List<CustomersDTO>();

            foreach (DataRow dr in _dt.Rows)
            {

                list.Add(new CustomersDTO(dr));
            }
            return list;
        }
    }
}
