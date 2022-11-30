using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class ImportDetailDAO
    {
        public ImportDetailDAO() { }
        private static ImportDetailDAO instance;

        public static ImportDetailDAO Instance
        {
            get { if (instance == null) instance = new ImportDetailDAO(); return ImportDetailDAO.instance; }
            private set { ImportDetailDAO.instance = value; }
        }
        public List<ImportDetailDTO> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from importdetail";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<ImportDetailDTO> list = new List<ImportDetailDTO>();

            foreach (DataRow dr in _dt.Rows)
            {

                list.Add(new ImportDetailDTO(dr));
            }
            return list;
        }
        public bool Insert(string importID, string productID, int quantity, double unitPrice)
        {
            string query = string.Format("insert into importdetail (ImportID, ProductID, Quantity, UnitPrice) values ('{0}', '{1}', {2}, {3})", importID, productID, quantity, unitPrice);
            //DataTable a = new DataTable();
            //a = DataProvider.Instance.ExecuteNonQuery(query);
            //return a;
            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                Console.WriteLine("connect: " + result);
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
