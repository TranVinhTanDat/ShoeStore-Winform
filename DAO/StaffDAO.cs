using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using MySql.Data.MySqlClient;

namespace DAO
{
    public class StaffDAO : DataConection
    {
        public StaffDAO() { }

        private static StaffDAO _instance;

        public static StaffDAO Instance 
        { 
            get { if (_instance == null) _instance = new StaffDAO();
                return _instance; }
            set { _instance = value; }
        }

   
        public List<StaffDTO> GetAll()
        {
            DataTable _dt = new DataTable();

            string query = "select * from Staff";

            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<StaffDTO> list = new List<StaffDTO>();

            foreach(DataRow dr in _dt.Rows)
            {
                list.Add(new StaffDTO(dr));
            }

            return list;
        }

        public bool Insert(StaffDTO staffDTO)
        {


            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into Staff(StaffID, UserID, FirstName, LastName, YearOfBirth, Gender, Phone, Address, Salary, Img) Values(@idStaff,@userId,@firstName,@lastName,@year,@gender,@phone,@address,@salary,@img)";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idStaff", MySqlDbType.VarString).Value = staffDTO.IdStaff;
            cmd.Parameters.Add("@userId", MySqlDbType.VarString).Value = "1";  //staffDTO.UserId;
            cmd.Parameters.Add("@firstName", MySqlDbType.VarString).Value = staffDTO.FirstName;
            cmd.Parameters.Add("@lastName", MySqlDbType.VarString).Value = staffDTO.LastName;
            cmd.Parameters.Add("@year", MySqlDbType.Int64).Value = staffDTO.Year;
            cmd.Parameters.Add("@gender", MySqlDbType.VarString).Value = staffDTO.Gender;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = staffDTO.Phone;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = staffDTO.Address;
            cmd.Parameters.Add("@salary", MySqlDbType.VarString).Value = staffDTO.Salary;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = staffDTO.Image;
            int kq = cmd.ExecuteNonQuery();


            return kq > 0;
            
            
            //string query = string.Format("insert into Staff(StaffID, UserID, FirstName, LastName, YearOfBirth, Gender, Phone, Address, Salary, Img) values('{0}', '{9}', '{1}', '{2}', {3}, '{4}', '{5}', '{6}', {7}, '{8}')", staffDTO.IdStaff, staffDTO.FirstName, staffDTO.LastName, staffDTO.Year, staffDTO.Gender, staffDTO.Phone, staffDTO.Address, staffDTO.Salary, staffDTO.Image, staffDTO.UserId);

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
        }


        public bool Update(StaffDTO staffDTO)
        {
            Moketnoi();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Staff set UserID = @userId, FirstName = @firstName, LastName = @lastName, YearOfBirth = @year, Gender = @gender, Phone = @phone, Address = @address, Salary = @salary, Img = @img where StaffID = @idStaff";
            cmd.Connection = conn;
            cmd.Parameters.Add("@idStaff", MySqlDbType.VarString).Value = staffDTO.IdStaff;
            cmd.Parameters.Add("@userId", MySqlDbType.VarString).Value = "1";  //staffDTO.UserId;
            cmd.Parameters.Add("@firstName", MySqlDbType.VarString).Value = staffDTO.FirstName;
            cmd.Parameters.Add("@lastName", MySqlDbType.VarString).Value = staffDTO.LastName;
            cmd.Parameters.Add("@year", MySqlDbType.Int64).Value = staffDTO.Year;
            cmd.Parameters.Add("@gender", MySqlDbType.VarString).Value = staffDTO.Gender;
            cmd.Parameters.Add("@phone", MySqlDbType.VarString).Value = staffDTO.Phone;
            cmd.Parameters.Add("@address", MySqlDbType.VarString).Value = staffDTO.Address;
            cmd.Parameters.Add("@salary", MySqlDbType.VarString).Value = staffDTO.Salary;
            cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = staffDTO.Image;
            int kq = cmd.ExecuteNonQuery();


            return kq > 0;
        }
        
        public bool UpdateProfile(StaffDTO staffDTO)
        {
            string query = string.Format("update Staff set FirstName = '{1}', LastName = '{2}', Phone = '{3}', Address = '{4}' where StaffID = '{0}'", staffDTO.IdStaff, staffDTO.FirstName, staffDTO.LastName, staffDTO.Phone, staffDTO.Address);

            int result = DataProvider.Instance.ExecuteNonQuery(query);

            Console.WriteLine(staffDTO.IdStaff + " " + staffDTO.FirstName + " " + staffDTO.LastName + " " + staffDTO.Phone + " " + staffDTO.Address + " " + staffDTO.Salary + " " + staffDTO.Image);

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

        public bool Delete(string idStaff)
        {
            string query = string.Format("delete from Staff where StaffID = '{0}'", idStaff);

            try
            {
                int result = DataProvider.Instance.ExecuteNonQuery(query);
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
        //        string query = string.Format("select * from Staff where LastName like N'%{0}%' or HoNV like N'%{0}%'", name);
        //        _dt = DataProvider.Instance.ExecuteQuery(query);
        //    } catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    return _dt;
        //}

        public List<StaffDTO> FindName(string name)
        {
            DataTable _dt = new DataTable();
            try
            {
                string query = string.Format("select * from Staff where LastName like N'%{0}%' or FirstName like N'%{0}%'", name);
                _dt = DataProvider.Instance.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            List<StaffDTO> list = new List<StaffDTO>();

            foreach (DataRow dr in _dt.Rows)
            {
                list.Add(new StaffDTO(dr));
            }

            return list;

        }
    }
}
