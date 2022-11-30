using DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class CustomerDAO : DataConection
    {
        List<CustomerDTO> ListCustomer = new List<CustomerDTO>();
        public List<CustomerDTO> ShowListCus()
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select *from CUSTOMER";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string CustomerID = reader.GetString(0);
                string CustomerSurname = reader.GetString(1);
                string CustomerName = reader.GetString(2);
                string Gender = reader.GetString(3);
                string PhoneNumber = reader.GetString(4);
                string Address = reader.GetString(5);

                CustomerDTO cus = new CustomerDTO();
                cus.CustomerID1 = CustomerID;
                cus.CustomerSurname1 = CustomerSurname;
                cus.CustomerName1 = CustomerName;
                cus.Gender1 = Gender;
                cus.PhoneNumber1 = PhoneNumber;
                cus.Address1 = Address;

                ListCustomer.Add(cus);

            }
            reader.Close();
            return ListCustomer;
        }
        public bool DeleteCus(string id)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from CUSTOMER where CUSTOMERID =@CusID";
            cmd.Connection = conn;
            cmd.Parameters.Add("@CusID", MySqlDbType.VarString).Value = id;
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }

        public bool AppCus(CustomerDTO cus)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into CUSTOMER(CUSTOMERID,CUSTOMERSURNAME,CUSTOMERNAME,GENDER,PHONE,ADDRESS) Values(@id,@surname,@name,@gender,@phone,@address)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@id", MySqlDbType.VarString).Value = cus.CustomerID1;
            cmd.Parameters.Add("@surname", MySqlDbType.VarString).Value = cus.CustomerSurname1;
            cmd.Parameters.Add("@name", MySqlDbType.VarString).Value = cus.CustomerName1;
            cmd.Parameters.Add("@gender", MySqlDbType.VarString).Value = cus.Gender1;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = cus.PhoneNumber1;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = cus.Address1;
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;

        }

        public bool UpdateCus(CustomerDTO cus)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update CUSTOMER set CUSTOMERSURNAME = @surname,CUSTOMERNAME = @name,GENDER=@gender,PHONE=@phone,ADDRESS=@address where CUSTOMERID = @id";
            cmd.Connection = conn;
            cmd.Parameters.Add("@id", MySqlDbType.VarString).Value = cus.CustomerID1;
            cmd.Parameters.Add("@surname", MySqlDbType.VarString).Value = cus.CustomerSurname1;
            cmd.Parameters.Add("@name", MySqlDbType.VarString).Value = cus.CustomerName1;
            cmd.Parameters.Add("@gender", MySqlDbType.VarString).Value = cus.Gender1;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = cus.PhoneNumber1;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = cus.Address1;
            int kq = cmd.ExecuteNonQuery();

            return kq > 0;
        }
        public List<CustomerDTO> SeachCus(string strSeach)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from CUSTOMER where CONCAT(CUSTOMERID,CUSTOMERSURNAME,CUSTOMERNAME,GENDER,PHONE,ADDRESS) like '%" + strSeach + "%'";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string CustomerID = reader.GetString(0);
                string CustomerSurname = reader.GetString(1);
                string CustomerName = reader.GetString(2);
                string Gender = reader.GetString(3);
                string PhoneNumber = reader.GetString(4);
                string Address = reader.GetString(5);

                CustomerDTO cus = new CustomerDTO();
                cus.CustomerID1 = CustomerID;
                cus.CustomerSurname1 = CustomerSurname;
                cus.CustomerName1 = CustomerName;
                cus.Gender1 = Gender;
                cus.PhoneNumber1 = PhoneNumber;
                cus.Address1 = Address;

                ListCustomer.Add(cus);

            }
            reader.Close();
            return ListCustomer;
        }

    }
}
