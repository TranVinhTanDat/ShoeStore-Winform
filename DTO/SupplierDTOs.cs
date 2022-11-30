using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SupplierDTOs
    {
        private string supplierID;
        private string supplierName;
        private string address;
        private string phone;
        private string faxNumber;
        
        public SupplierDTOs() { }
        public SupplierDTOs(DataRow dr)
        {
            SupplierID = dr["SupplierID"].ToString();
            SupplierName = dr["SupplierName"].ToString();
            Address = dr["Address"].ToString();
            Phone = dr["Phone"].ToString();
            FaxNumber = dr["FaxNumber"].ToString();
            

        }

        public SupplierDTOs(string supplierID, string supplierName, string address, string phone,string faxNumber)
        {
            SupplierID = supplierID;
            SupplierName = supplierName;
            Address = address;
            Phone = phone;
            FaxNumber = faxNumber;
        

        }

        public string SupplierID { get => supplierID; set => supplierID = value; }
        public string SupplierName { get => supplierName; set => supplierName = value; }
        public string Address { get => address; set => address = value; }
        public string Phone { get => phone; set => phone = value; }
        public string FaxNumber { get => faxNumber; set => faxNumber = value; }
        
    }
}
