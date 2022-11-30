using DTO;
using System;
using System.Collections.Generic;
using System.Data;
namespace DAO
{
    public class BillDAO
    {
        public BillDAO() { }

        private static BillDAO instance;

        public static BillDAO Instance
        {
            get { if (instance == null) instance = new BillDAO(); return BillDAO.instance; }
            private set { BillDAO.instance = value; }
        }
        public List<BillDTO> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from bill";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<BillDTO> list = new List<BillDTO>();

            foreach (DataRow dr in _dt.Rows)
            {

                list.Add(new BillDTO(dr));
            }
            return list;
        }

        public bool Insert(string billID, string customerID, string staffID, double total)
        {
            string query = string.Format("insert into bill (BillID, CustomerID, StaffID, Total) values ('{0}', '{1}', '{2}', {3})", billID, customerID, staffID, total);

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


        public bool Update(string billID, string customerID, string staffID, string updatetime, double total)
        {
            string query = string.Format("Update bill Set CustomerID = '{1}',StaffID= '{2}', UpdateTime= '{3}',Total= {4} Where BillID = '{0}'", billID, customerID, staffID, updatetime, total);
            //string query1 = string.Format("Update bill Set Total = '{1}' Where BillID = '{0}'", billID, total);
            try
            {
                Console.WriteLine("before");
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                Console.WriteLine("result: " + result);
                //int result1 = DataProvider.Instance.ExecuteNonQuery(query1);
                if (result > 0 /*|| result1>0|| (result>0&& result1>0)*/) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public bool Delete(string billID)
        {
            string query = string.Format("Delete From bill Where BillID = '{0}'", billID);
            try
            {
                Console.WriteLine("before");
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public DataTable ChooseCustomer()
        {
            string query = string.Format("select * from customer ");
            DataTable b = new DataTable();
            b = DataProvider.Instance.ExecuteQuery(query);
            return b;
        }

        public DataTable ChooseStaff()
        {
            string query = string.Format("select * from staff ");
            DataTable b = new DataTable();
            b = DataProvider.Instance.ExecuteQuery(query);
            return b;
        }
        public DataTable ChooseBillDetail(string billID)
        {
            string query = string.Format("select * from billdetail where billID = '{0}' ", billID);
            DataTable b = new DataTable();
            b = DataProvider.Instance.ExecuteQuery(query);
            return b;
        }

        public DataTable FindBill(string billID)
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = string.Format("select *  from bill where billID like '%{0}%' ", billID);
                _dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _dt;



        }

    }
}


