using System.Data;

namespace DTO
{
    public class ProductDTO
    {
        private string _idProduct;
        private string _nameProduct;
        private string _size;
        private string _color;
        private string _description;
        private int _amount;
        private double _price;
        private string _idCategory;
        private string _idProducer;
        private byte[] _image;

        public ProductDTO(DataRow dr)
        {
            _idProduct = dr["ProductID"].ToString();
            _nameProduct = dr["ProductName"].ToString();
            _size = dr["Size"].ToString();
            _color = dr["Color"].ToString();
            _description = dr["Description"].ToString();
            _amount = int.Parse(dr["Quantity"].ToString());
            _price = double.Parse(dr["ProductPrice"].ToString());
            _idCategory = dr["TypeID"].ToString();
            _idProducer = dr["ProducerID"].ToString();
            _image = (byte[])dr["IMG"];

        }

        public ProductDTO(string idProduct)
        {
            _idProduct = idProduct;
        }

        public ProductDTO(string idProduct, string nameProduct, string size, string color, string description, int amount, double price, string idCategory, string idProducer, byte[] image)
        {
            _idProduct = idProduct;
            _nameProduct = nameProduct;
            _size = size;
            _color = color;
            _description = description;
            _amount = amount;
            _price = price;
            _idCategory = idCategory;
            _idProducer = idProducer;
            _image = image;
        }

        public string IdProduct { get => _idProduct; set => _idProduct = value; }
        public string NameProduct { get => _nameProduct; set => _nameProduct = value; }
        public string Size { get => _size; set => _size = value; }
        public int Amount { get => _amount; set => _amount = value; }
        public double Price { get => _price; set => _price = value; }
        public string IdCategory { get => _idCategory; set => _idCategory = value; }
        public string IdProducer { get => _idProducer; set => _idProducer = value; }
        public byte[] Image { get => _image; set => _image = value; }
        public string Color { get => _color; set => _color = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
