using System.Data;


namespace DTO
{
    public class BillDetailDTO
    {
        private string billID;
        private string productID;
        private byte[] image;
        private string productName;
        private int quantity;
        private double unitPrice;
        private int inventory;

        public BillDetailDTO() { }

        public BillDetailDTO(DataRow dr) {
            this.BillID = dr["BillID"].ToString();
            this.ProductID = dr["ProductID"].ToString();
            this.Quantity = int.Parse(dr["Quantity"].ToString());
            this.UnitPrice = double.Parse(dr["UnitPrice"].ToString());
        }
        public BillDetailDTO (string billID, string productID, int quantity, double unitprice) 
        {
            this.billID = billID;
            this.productID = productID;
            this.quantity = quantity;
            this.unitPrice = unitprice;
        }

        public string BillID { get => billID; set => billID = value; }
        public string ProductID { get => productID; set => productID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public byte[] Image { get => image; set => image = value; }
        public string ProductName { get => productName; set => productName = value; }
        public int Inventory { get => inventory; set => inventory = value; }
    }
    
}
