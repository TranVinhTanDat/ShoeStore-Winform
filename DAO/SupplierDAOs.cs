using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class SupplierDAOs
    {
        public SupplierDAOs() { }
        private static SupplierDAOs instance;

        public static SupplierDAOs Instance
        {
            get { if (instance == null) instance = new SupplierDAOs(); return SupplierDAOs.instance; }
            private set { SupplierDAOs.instance = value; }
        }
        public List<SupplierDTOs> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from supplier";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<SupplierDTOs> list = new List<SupplierDTOs>();

            foreach (DataRow dr in _dt.Rows)
            {

                list.Add(new SupplierDTOs(dr));
            }
            return list;
        }

    }
}
