using System.Data;

namespace DTO
{
    public class ImportDetailDTO
    {
        private string importID;
        private string productID;
        //private string productName;
        private int quantity;
        private double unitPrice;

        public ImportDetailDTO() { }
        public ImportDetailDTO(DataRow dr)
        {
            this.ImportID = dr["ImportID"].ToString();
            this.ProductID = dr["ProductID"].ToString();
            this.Quantity = int.Parse(dr["Quantity"].ToString());
            this.UnitPrice = double.Parse(dr["UnitPrice"].ToString());

        }

        public ImportDetailDTO(string importID, string productID, int quantity, double unitPrice)
        {
            this.ImportID = importID;
            this.ProductID = productID;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;


        }

        public string ImportID { get => importID; set => importID = value; }
        public string ProductID { get => productID; set => productID = value; }

        public int Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
    }
}
