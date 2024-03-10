using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
using Microsoft.SqlServer.Management.Sdk.Sfc;

namespace BUS
{
    public class ImportBUS
    {
        private ImportDAO importDAO;
        private List<ImportDTO> listImportDTO;
        private static ImportBUS instance;

        public static ImportBUS Instance
        {
            get { if (instance == null) instance = new ImportBUS(); return ImportBUS.instance; }
            private set { ImportBUS.instance = value; }
        }
        public ImportBUS()
        {
            importDAO = new ImportDAO();
        }



        public List<ImportDTO> GetList()
        {
            listImportDTO = new List<ImportDTO>();
            listImportDTO = importDAO.GetAll();
            return listImportDTO;
        }
        public bool Update(string importID, string supplierID, string staffID, string updateTime, double total)
        {
            return this.importDAO.Update(importID, supplierID, staffID, updateTime, total);
        }
        public bool Insert(string importID, string supplierID, string staffID, double total)
        {
            return this.importDAO.Insert(importID, supplierID, staffID, total);
        }
        public bool CheckStaffExistence(string staffID)
        {
            // Gọi đến phương thức từ DAO để kiểm tra sự tồn tại của StaffID trong bảng staff
            return importDAO.CheckStaffExistence(staffID);
        }

        public DataTable Delete(string importID)
        {
            return this.importDAO.Delete(importID);
        }
        public DataTable ChooseImportDetail(string importID)
        {
            return importDAO.ChooseImportDetail(importID);
        }
        public DataTable FindImport(string importID)
        {
            return importDAO.FindImport(importID);
        }
        // Trong class ImportBUS
       

        public string getIDImport()
        {
            string Id = "";
            int So = 0;

            listImportDTO = GetList();
            // Take id last
            string ImportID = listImportDTO[listImportDTO.Count - 1].ImportID;

            // Cut string use: Substring(int startIndex, int length)
            // Cut string use: Substring(int startIndex, int length)
            So = int.Parse(ImportID.Substring(3));    // int.Parse(IP001)
            So++;   // 1 -> 2

            if (So < 10)
            {
                Id += "IMP00" + So;
            }
            else
            Id += "IMP0" + So;

            return Id;
        }

    }
}
