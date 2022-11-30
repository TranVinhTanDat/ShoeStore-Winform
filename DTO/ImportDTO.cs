using System.Data;

namespace DTO
{
    public class ImportDTO
    {
        private string importID;
        private string supplierID;
        private string staffID;
        private string createtime;
        private string updatetime;
        private double total;

        public ImportDTO() { }

        public ImportDTO(DataRow dr)
        {
            this.importID = dr["ImportID"].ToString();
            this.supplierID = dr["SupplierID"].ToString();
            this.staffID = dr["StaffID"].ToString();
            this.Createtime = dr["CreateTime"].ToString();
            this.Updatetime = dr["UpdateTime"].ToString();
            this.total = double.Parse(dr["Total"].ToString());

        }

        public ImportDTO(string importID, string supplierID, string staffID, string createtime, string updatetime, double total)
        {
            this.importID = importID;
            this.supplierID = supplierID;
            this.staffID = staffID;
            this.createtime = createtime;
            this.updatetime = updatetime;
            this.total = total;
        }

        public string ImportID { get => importID; set => importID = value; }
        public string SupplierID { get => supplierID; set => supplierID = value; }
        public string Createtime { get => createtime; set => createtime = value; }
        public string Updatetime { get => updatetime; set => updatetime = value; }
        public double Total { get => total; set => total = value; }
        public string StaffID { get => staffID; set => staffID = value; }
    }
}
