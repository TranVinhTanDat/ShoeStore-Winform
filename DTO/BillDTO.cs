using System.Data;

namespace DTO
{
    public class BillDTO
    {
        private string billID;
        private string customerID;
        private string staffID;
        private string createtime;
        private string updatetime;
        private double total;

        public BillDTO() { }

        public BillDTO(DataRow dr)
        {
            this.billID = dr["BillID"].ToString();
            this.customerID = dr["CustomerID"].ToString();
            this.staffID = dr["StaffID"].ToString();
            this.createtime = dr["CreateTime"].ToString();
            this.updatetime = dr["UpdateTime"].ToString();
            this.total = double.Parse(dr["Total"].ToString());

        }

        public BillDTO(string billID, string customerID, string staffID, string date, double total)
        {
            
        }

        public string BillID { get => billID; set => billID = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public string StaffID { get => staffID; set => staffID = value; }
        public string CreateTime { get => createtime; set => createtime = value; }
        public string UpdateTime { get => updatetime; set => updatetime = value; }
        public double Total { get => total; set => total = value; }
    }
}
