using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DashboardDTO
    {
        
        public DashboardDTO() { }

        private string idProduct;
        private string nameProduct;
        private string descriptionProduct;
        private double price;
        private byte[] img;
        private int sale;

        public string IdProduct { get => idProduct; set => idProduct = value; }
        public string NameProduct { get => nameProduct; set => nameProduct = value; }
        public string DescriptionProduct { get => descriptionProduct; set => descriptionProduct = value; }
        public double Price { get => price; set => price = value; }
        public int Sale { get => sale; set => sale = value; }
        public byte[] Img { get => img; set => img = value; }

        public DashboardDTO(DataRow dr)
        {
            idProduct = dr["ProductID"].ToString();
            img = (byte[])dr["Img"];
            nameProduct = dr["ProductName"].ToString();
            price = double.Parse(dr["ProductPrice"].ToString());
            descriptionProduct = dr["Description"].ToString();
            sale = int.Parse(dr["sale"].ToString());
        }


    }
}
