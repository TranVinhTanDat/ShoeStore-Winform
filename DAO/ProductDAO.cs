using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class ProductDAO : DataConection
    {
        public ProductDAO() { }


        private static ProductDAO _instance;

        public static ProductDAO Instance
        {
            get
            {
                if (_instance == null) _instance = new ProductDAO();
                return _instance;
            }
            set { _instance = value; }
        }

        public List<ProductDTO> GetAll()
        {
            DataTable _dt = new DataTable();
            string query = "select * from Product";
            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<ProductDTO> list = new List<ProductDTO>();

            foreach (DataRow row in _dt.Rows)
            {
                list.Add(new ProductDTO(row));
            }

            return list;
        }
        public bool Insert(ProductDTO productDTO)
        {
            //string query = string.Format("insert into Product(ProductID, ProductName, Size, Quantity, ProductPrice, TypeID, ProducerID, Img, Color, Description) values('{0}', '{1}', {2}, {3}, {4}, '{5}', '{6}', '{7}', '{8}', '{9}')", productDTO.IdProduct, productDTO.NameProduct, productDTO.Size, productDTO.Amount, productDTO.Price, productDTO.IdCategory, productDTO.IdProducer, productDTO.Image, productDTO.Color, productDTO.Description);

            //int result = DataProvider.Instance.ExecuteNonQuery(query);

            //try
            //{
            //    if (result > 0) return true;
            //    return false;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}

            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Product(ProductID, ProductName, Size, Quantity, ProductPrice, TypeID, ProducerID, Img, Color, Description) Values(@idProduct,@productName,@size,@quantity,@productPrice,@typeId,@producerId,@img,@color,@description)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idProduct", MySqlDbType.VarString).Value = productDTO.IdProduct;
            cmd.Parameters.Add("@typeId", MySqlDbType.VarString).Value = productDTO.IdCategory;
            cmd.Parameters.Add("@productName", MySqlDbType.VarString).Value = productDTO.NameProduct;
            cmd.Parameters.Add("@size", MySqlDbType.VarString).Value = productDTO.Size;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = productDTO.Amount;
            cmd.Parameters.Add("@productPrice", MySqlDbType.Int64).Value = productDTO.Price;
            cmd.Parameters.Add("@producerId", MySqlDbType.VarString).Value = productDTO.IdProducer;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = productDTO.Image;
            cmd.Parameters.Add("@color", MySqlDbType.VarString).Value = productDTO.Color;
            cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = productDTO.Description;
            int kq = cmd.ExecuteNonQuery();

            return kq > 0;
        }


        public bool Update(ProductDTO productDTO)
        {
            //string query = string.Format("update Product set ProductName = '{1}', Size = {2}, Quantity = {3}, ProductPrice = {4}, TypeID = '{5}', ProducerID = '{6}', Img = '{7}', Color = '{8}', Description = '{9}' where ProductID = '{0}'", productDTO.IdProduct, productDTO.NameProduct, productDTO.Size, productDTO.Amount, productDTO.Price, productDTO.IdCategory, productDTO.IdProducer, productDTO.Image, productDTO.Color, productDTO.Description);

            //int result = DataProvider.Instance.ExecuteNonQuery(query);

            //try
            //{
            //    if (result > 0) return true;
            //    return false;
            //}
            //catch (Exception)
            //{
            //    return false;
            //}

            //Moketnoi();
            //MySqlCommand cmd = new MySqlCommand();
            //cmd.CommandType = CommandType.Text;
            //cmd.CommandText = "update Product set ProductName = @productName, Size = @size, Quantity = @quantity, ProductPrice = @productPrice, TypeID = @typeId, ProducerID = producerId, Img = @img, Color = @color, Description = @description where ProductID = @idProduct";
            //cmd.Connection = conn;
            //cmd.Parameters.Add("@idProduct", MySqlDbType.VarString).Value = productDTO.IdProduct;
            //cmd.Parameters.Add("@typeId", MySqlDbType.VarString).Value = productDTO.IdCategory;
            //cmd.Parameters.Add("@productName", MySqlDbType.VarString).Value = productDTO.NameProduct;
            //cmd.Parameters.Add("@size", MySqlDbType.VarString).Value = productDTO.Size;
            //cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = productDTO.Amount;
            //cmd.Parameters.Add("@productPrice", MySqlDbType.Int64).Value = productDTO.Price;
            //cmd.Parameters.Add("@producerId", MySqlDbType.VarString).Value = productDTO.IdProducer;
            //cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = productDTO.Image;
            //cmd.Parameters.Add("@color", MySqlDbType.VarString).Value = productDTO.Color;
            //cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = productDTO.Description;
            //int kq = cmd.ExecuteNonQuery();

            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Product set ProductName = @productName, Size = @size, Quantity = @quantity, ProductPrice = @productPrice, TypeID = @typeId, ProducerID = producerId, Img = @img, Color = @color, Description = @description where ProductID = @idProduct";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idProduct", MySqlDbType.VarString).Value = productDTO.IdProduct;
            cmd.Parameters.Add("@typeId", MySqlDbType.VarString).Value = productDTO.IdCategory;
            cmd.Parameters.Add("@productName", MySqlDbType.VarString).Value = productDTO.NameProduct;
            cmd.Parameters.Add("@size", MySqlDbType.VarString).Value = productDTO.Size;
            cmd.Parameters.Add("@quantity", MySqlDbType.Int64).Value = productDTO.Amount;
            cmd.Parameters.Add("@productPrice", MySqlDbType.Int64).Value = productDTO.Price;
            cmd.Parameters.Add("@producerId", MySqlDbType.VarString).Value = productDTO.IdProducer;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = productDTO.Image;
            cmd.Parameters.Add("@color", MySqlDbType.VarString).Value = productDTO.Color;
            cmd.Parameters.Add("@description", MySqlDbType.VarString).Value = productDTO.Description;
            int kq = cmd.ExecuteNonQuery();


            return kq > 0;
        }
        public bool UpdateQuantity(string idProduct, int quantity)
        {
            string query = string.Format("update Product set Quantity = {1} where ProductID = '{0}'", idProduct, quantity);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            try
            {
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool Delete(ProductDTO productDTO)
        {
            string query = string.Format("delete from Product where ProductID = '{0}'", productDTO.IdProduct);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            try
            {
                if (result > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //public DataTable FindName(string name)
        //{
        //    DataTable _dt = new DataTable();
        //    try
        //    {
        //        string query = string.Format("select * from Product where ProductName like N'%{0}%'", name);
        //        _dt = DataProvider.Instance.ExecuteQuery(query);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return _dt;
        //}
        public List<ProductDTO> FilterPrice(string name)
        {
            DataTable _dt = new DataTable();
            try
            {
                if (name == "< 5000")
                {
                    string query = string.Format("select * from Product where ProductPrice between 0 and 5000");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }
                else if (name == "5000 - 10000")
                {
                    string query = string.Format("select * from Product where ProductPrice between 5000 and 10000");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }
                else if (name == "> 10000")
                {
                    string query = string.Format("select * from Product where ProductPrice > 10000");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }
                else
                {
                    string query = string.Format("select * from Product");
                    _dt = DataProvider.Instance.ExecuteQuery(query);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<ProductDTO> list = new List<ProductDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new ProductDTO(dr));
            }

            return list;
        }

        public List<ProductDTO> FindName(string name)
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = string.Format("select * from Product where ProductName like N'%{0}%'", name);
                _dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<ProductDTO> list = new List<ProductDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new ProductDTO(dr));
            }

            return list;
        }

        public DataTable getCategory()
        {
            string query = string.Format("select * from Category");

            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

        public DataTable getProducer()
        {
            string query = string.Format("select * from Producer");

            DataTable dt = new DataTable();
            dt = DataProvider.Instance.ExecuteQuery(query);

            return dt;
        }

    }
}
