using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ProductBUS
    {
        private ProductDAO productDAO;
        private List<ProductDTO> listProductDTO;
        private static ProductBUS instance;

        public static ProductBUS Instance
        {
            get { if (instance == null) instance = new ProductBUS(); return ProductBUS.instance; }
            private set { ProductBUS.instance = value; }
        }

        public ProductBUS() 
        { 
            this.productDAO = new ProductDAO();
        }

        public List<ProductDTO> GetList()
        {
            listProductDTO = new List<ProductDTO>();
            listProductDTO = productDAO.GetAll();

            return listProductDTO;
        }

        public bool Insert(ProductDTO productDTO)
        {
            return this.productDAO.Insert(productDTO);
        }

        public bool Update(ProductDTO productDTO)
        {
            return this.productDAO.Update(productDTO);
        }

        public bool Delete(ProductDTO productDTO)
        {
            return this.productDAO.Delete(productDTO);
        }

        public DataTable getCategory()
        {
            return productDAO.getCategory();
        }

        public DataTable getProducer()
        {
            return productDAO.getProducer();
        }

        public string getIDProduct()
        {
            string Id = "";
            int So = 0;

            listProductDTO = GetList();
            // Take id last
            string IdProduct = listProductDTO[listProductDTO.Count - 1].IdProduct;

            // Cut string use: Substring(int startIndex, int length)
            So = int.Parse(IdProduct.Substring(3));    // int.Parse(001) -> 1
            So++;   // 1 -> 2
            if (So < 10)
            {
                Id += "PRD00" + So;
            }
            else
                Id += "PRD0" + So;

            return Id;
        }

    }
}
