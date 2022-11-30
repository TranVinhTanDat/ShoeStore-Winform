using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;

namespace DAO
{
    public class ImportDAO
    {
        public ImportDAO() { }
        private static ImportDAO instance;

        public static ImportDAO Instance
        {
            get { if (instance == null) instance = new ImportDAO(); return ImportDAO.instance; }
            private set { ImportDAO.instance = value; }
        }

        public List<ImportDTO> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from import";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<ImportDTO> list = new List<ImportDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                Debug.WriteLine("aaaaaaaaaaa");
                list.Add(new ImportDTO(dr));
            }
            return list;
        }

        public DataTable Insert(string importID, string supplierID, string staffID, double total)
        {
            string query = string.Format("insert into import (ImportID, SupplierID, StaffID, Total) values ('{0}', '{1}', '{2}', {3})", importID, supplierID, staffID, total);
            DataTable a = new DataTable();
            a = DataProvider.Instance.ExecuteQuery(query);
            return a;

            /*try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query);

                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }*/
        }


        public bool Update(string importID, string supplierID, string staffID, string updatetime, double total)
        {
            string query = string.Format("Update import Set SupplierID = '{1}', StaffID = '{2}', UpdateTime = '{3}',Total= {4} Where ImportID = '{0}'", importID, supplierID, staffID, updatetime, total);
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            try
            {
                //int result1 = DataProvider.Instance.ExecuteNonQuery(query1);
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }

        }
        public DataTable Delete(string importID)
        {
            string query = string.Format("Delete From import Where ImportID = '{0}'", importID);
            //try
            //{
            Console.WriteLine("before");
            return DataProvider.Instance.ExecuteQuery(query);
            /*int result = DataProvider.Instance.ExecuteNonQuery(query);

            if (result > 0) return true;
            return false;
        }
        catch (Exception)
        {
            return false;
        }*/

        }
        public DataTable FindImport(string importID)
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = string.Format("select * from import where ImportID like '%{0}%'", importID);
                _dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _dt;

        }
        public DataTable ChooseImportDetail(string importID)
        {
            string query = string.Format("select * from importdetail where ImportID = '{0}' ", importID);
            DataTable b = new DataTable();
            b = DataProvider.Instance.ExecuteQuery(query);
            return b;
        }


    }
}


