using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class BillBUS

    {

        private BillDAO billDAO;
        private List<BillDTO> listBillDTO;
        private static BillBUS instance;

        public static BillBUS Instance
        {
            get { if (instance == null) instance = new BillBUS(); return BillBUS.instance; }
            private set { BillBUS.instance = value; }
        }

        public BillBUS()
        {
            billDAO = new BillDAO();
        }

        public List<BillDTO> GetList()
        {
            listBillDTO = new List<BillDTO>();
            listBillDTO = billDAO.GetAll();
            return listBillDTO;
        }

        public bool Insert(string billID, string customerID, string staffID, double total)
        {
            return this.billDAO.Insert(billID, customerID, staffID, total);
        }

        public bool Update(string billID, string customerID, string staffID, string updateTime, double total)
        {
            return this.billDAO.Update(billID, customerID, staffID, updateTime, total);
        }

        public bool Delete(string billID)
        {
            return this.billDAO.Delete(billID);
        }
        public DataTable ChooseBillDetail(string billID)
        {
            return billDAO.ChooseBillDetail(billID);
        }
        public DataTable FindBill(string billID)
        {
            return billDAO.FindBill(billID);
        }

        public string getIDBill()
        {
            string Id = "";
            int So = 0;

            listBillDTO = GetList();
            // Take id last
            string billID = listBillDTO[listBillDTO.Count - 1].BillID;

            // Cut string use: Substring(int startIndex, int length)
            // Cut string use: Substring(int startIndex, int length)
            So = int.Parse(billID.Substring(3));    // int.Parse(IP001)
            So++;   // 1 -> 2

            if (So < 10)
            {
                Id += "BIL00" + So;
            }
            else
                Id += "BIL0" + So;

            return Id;
        }

    }
}