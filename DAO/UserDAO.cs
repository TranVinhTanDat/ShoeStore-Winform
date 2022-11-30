﻿using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.IO;

namespace DAO
{
    public class UserDAO : DataConection
    {
        public string LoginDAO(UserDTO us)
        {

            Moketnoi();

            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = conn;

            cmd.CommandText = "select userID, UserName,Password from ACCOUNT where UserName = @username AND Password = @password";
            cmd.Parameters.AddWithValue("@username", us.Username1);
            cmd.Parameters.AddWithValue("@password", us.Password1);



            MySqlDataReader reader = cmd.ExecuteReader();
            string kq = null;
            if (reader.Read())
            {
                kq = "dmm";

            }
            reader.Close();
            Dongketnoi();
            return kq;

        }

        public string getStaffFromAccount(string username)
        {
            StaffDTO staffDTO = new StaffDTO();
            DataTable _dt = new DataTable();
            string query = string.Format("select FirstName, LastName from Staff, Account where Staff.UserId = Account.UserId and Account.Username = '{0}'", username);
            _dt = DataProvider.Instance.ExecuteQuery(query);

            staffDTO.LastName = _dt.Rows[0]["LastName"].ToString();
            staffDTO.FirstName = _dt.Rows[0]["FirstName"].ToString();

            return staffDTO.FirstName + " " + staffDTO.LastName;
        }
        
        public string getRoleIDFromAccount(string username)
        {
            DataTable _dt = new DataTable();
            string query = string.Format("select Account.RoleID from Staff, Account where Staff.UserId = Account.UserId and Account.Username = '{0}'", username);
            _dt = DataProvider.Instance.ExecuteQuery(query);


            return _dt.Rows[0]["RoleID"].ToString();

        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }
        public StaffDTO getStaffFromAccounts(string username)
        {
            StaffDTO staffDTO = new StaffDTO();
            DataTable _dt = new DataTable();
            string query = string.Format("select * from Staff, Account where Staff.UserId = Account.UserId and Account.Username = '{0}'", username);
            _dt = DataProvider.Instance.ExecuteQuery(query);

            staffDTO.IdStaff = _dt.Rows[0]["StaffID"].ToString();
            staffDTO.FirstName = _dt.Rows[0]["FirstName"].ToString();
            staffDTO.LastName = _dt.Rows[0]["LastName"].ToString();
            staffDTO.Phone = _dt.Rows[0]["Phone"].ToString();
            staffDTO.Address = _dt.Rows[0]["Address"].ToString();
            //staffDTO.Image = _dt.Rows[0]["Img"];

            return staffDTO;

        }


    }

}