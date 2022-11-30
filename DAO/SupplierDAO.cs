using DTO;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class SupplierDAO : DataConection
    {
        List<SupplierDTO> ListSuppier = new List<SupplierDTO>();
        public List<SupplierDTO> ShowListSuppier()
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select *from SUPPLIER";
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string SuppierID = reader.GetString(0);
                string SuppierName = reader.GetString(1);
                string Address = reader.GetString(2);
                string PhoneNumber = reader.GetString(3);
                string Faxnumber = reader.GetString(4);


                SupplierDTO sup = new SupplierDTO();
                sup.SuppierID1 = SuppierID;
                sup.Suppiername1 = SuppierName;
                sup.Address1 = Address;
                sup.PhoneNumber1 = PhoneNumber;
                sup.FaxNumber1 = Faxnumber;

                ListSuppier.Add(sup);

            }
            reader.Close();
            return ListSuppier;
        }
        public bool DeleteSup(string id)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from SUPPLIER where SUPPLIERID =@SupID";
            cmd.Connection = conn;
            cmd.Parameters.Add("@SupID", MySqlDbType.VarString).Value = id;
            int kq = cmd.ExecuteNonQuery();
            return kq > 0;
        }

        public bool AppSup(SupplierDTO sup)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into SUPPLIER(SUPPLIERID,SUPPIERNAME,ADDRESS,PHONE,FAXNUMBER) Values(@id,@supname,@address,@phone,@faxnumber)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@id", MySqlDbType.VarString).Value = sup.SuppierID1;
            cmd.Parameters.Add("@supname", MySqlDbType.VarString).Value = sup.Suppiername1;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = sup.Address1;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = sup.PhoneNumber1;
            cmd.Parameters.Add("@faxnumber", MySqlDbType.VarString).Value = sup.FaxNumber1;

            int kq = cmd.ExecuteNonQuery();
            return kq > 0;

        }

        public bool UpdateSup(SupplierDTO sup)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update SUPPLIER set SUPPLIERNAME = @supname,ADDRESS = @address,PHONE=@phone,FAXNUMBER=@faxnumber where SUPPLIERID = @id";
            cmd.Connection = conn;
            cmd.Parameters.Add("@id", MySqlDbType.VarString).Value = sup.SuppierID1;
            cmd.Parameters.Add("@supname", MySqlDbType.VarString).Value = sup.Suppiername1;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = sup.Address1;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = sup.PhoneNumber1;
            cmd.Parameters.Add("@faxnumber", MySqlDbType.VarString).Value = sup.FaxNumber1;
            int kq = cmd.ExecuteNonQuery();

            return kq > 0;
        }
        public List<SupplierDTO> SeachSup(string strSeach)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *from SUPPLIER where CONCAT(SUPPIERID,SUPPIERNAME,ADDRESS,PHONE,FAXNUMBER) like '%" + strSeach + "%'"; ;
            cmd.Connection = conn;
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string SuppierID = reader.GetString(0);
                string SuppierName = reader.GetString(1);
                string Address = reader.GetString(2);
                string PhoneNumber = reader.GetString(3);
                string Faxnumber = reader.GetString(4);


                SupplierDTO sup = new SupplierDTO();
                sup.SuppierID1 = SuppierID;
                sup.Suppiername1 = SuppierName;
                sup.Address1 = Address;
                sup.PhoneNumber1 = PhoneNumber;
                sup.FaxNumber1 = Faxnumber;

                ListSuppier.Add(sup);

            }
            reader.Close();
            return ListSuppier;
        }
    }
}

