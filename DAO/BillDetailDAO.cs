using DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class BillDetailDAO
    {
        public BillDetailDAO() { }

        private static BillDetailDAO instance;

        public static BillDetailDAO Instance
        {
            get { if (instance == null) instance = new BillDetailDAO(); return BillDetailDAO.instance; }
            private set { BillDetailDAO.instance = value; }
        }
        public List<BillDetailDTO> Get()
        {
            DataTable _dt = new DataTable();

            string query = "select * from billdetail";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<BillDetailDTO> list = new List<BillDetailDTO>();

            foreach (DataRow dr in _dt.Rows)
            {

                list.Add(new BillDetailDTO(dr));
            }
            return list;
        }

        public bool Insert(string billID, string productID, int quantity, double unitPrice)
        {
            string query = string.Format("insert into billdetail (BillID, ProductID, Quantity, UnitPrice) values ('{0}', '{1}', {2}, {3})", billID, productID, quantity, unitPrice);

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataTable Delete(string billID)
        {
            string query = string.Format("Delete from billdetail Where BillID = '{0}'", billID);
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public DataTable SearchBill()
        {
            string query = string.Format("select * from billdetail");
            DataTable dt = DataProvider.Instance.ExecuteQuery(query);
            return dt;
        }
    }
}