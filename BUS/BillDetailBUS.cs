using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class BillDetailBUS
    {

        private BillDetailDAO billDetailDAO;
        private List<BillDetailDTO> listBillDetailDTO;

        public BillDetailBUS()
        {
            billDetailDAO = new BillDetailDAO();
        }

        public bool Insert(string billID, string customerID, int quantity, double unitPrice)
        {
            return this.billDetailDAO.Insert(billID, customerID, quantity, unitPrice);
        }

        //public List<BillDetailDTO> GetList()
        //{
        //    listBillDetailDTO = new List<BillDetailDTO>();
        //    listBillDetailDTO = billDetailDAO.GetAll();
        //    return listBillDetailDTO;
        //}
        public DataTable Delete(string billID)
        {
            return billDetailDAO.Delete(billID);
        }
    }
}
