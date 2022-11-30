using DAO;
using DTO;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace BUS
{
    public class CustomerBUS
    {
        CustomerDAO cusDAO = new CustomerDAO();
        private static CustomerBUS instance;

        public static CustomerBUS Instance
        {
            get { if (instance == null) instance = new CustomerBUS(); return CustomerBUS.instance; }
            private set { CustomerBUS.instance = value; }
        }

        public List<CustomerDTO> GetList()
        {
            return cusDAO.ShowListCus();
        }
        public List<CustomerDTO> SeachCus(string strSeach)
        {

            return cusDAO.SeachCus(strSeach);


        }
        public string DeleteCus(string id)
        {
            if (id == "")
                return "error_isNull";

            string result = "";
            if (checkIdCustomer(id) == false)
                result = "error_CusID";

            if (result.Contains("error"))
                return result;
            result = "success";
            cusDAO.DeleteCus(id);
            return result;

        }
        public string AddCus(string id, string surname, string name, string gender, string phoneNumber, string address)
        {
            Regex rexNumber = new Regex(@"^[0-9]{10}$");
            if (id == "")
            {
                return "error_CusId_isNull";
            }
            if (id.Contains("CUS") == false)
            {
                return "saidinhdang";
            }
            if (surname == "")
            {
                return "error_surname";
            }

            if (name == "")
            {
                return "error_Cusname";
            }
            if (phoneNumber == "")
            {
                return "error_Phonenull";
            }
            string result = "";
            if (checkIdCustomer(id) == true)
            {
                result = "error_CusId";
            }
            if (address == "")
            {
                result = "error_Address";
            }


            if (rexNumber.Match(phoneNumber).Success == false)
                result = "error_phone";


            if (result.Contains("error"))
                return result;
            result = "success";

            CustomerDTO cus = new CustomerDTO(id, surname, name, gender, phoneNumber, address);
            cusDAO.AppCus(cus);
            return result;
        }
        public string UpdateCus(string id, string surname, string name, string gender, string phoneNumber, string address)
        {
            Regex rexNumber = new Regex(@"^[0-9]{10}$");
            if (id == "")
            {
                return "error_CusId_isNull";
            }
            if (surname == "")
            {
                return "error_surname";
            }

            if (name == "")
            {
                return "error_Cusname";
            }
            if (id.Contains("CUS") == false)
            {
                return "saidinhdang";
            }
            string result = "";
            if (checkIdCustomer(id) == false)
            {
                result = "error_CusId";
            }
            if (address == "")
            {
                result = "error_Address";
            }


            if (rexNumber.Match(phoneNumber).Success == false)
                result = "error_phone";


            if (result.Contains("error"))
                return result;
            result = "success";

            CustomerDTO cus = new CustomerDTO(id, surname, name, gender, phoneNumber, address);
            cusDAO.UpdateCus(cus);
            return result;

        }
        public bool checkIdCustomer(string id)
        {
            foreach (CustomerDTO cus in GetList())
            {
                if (cus.CustomerID1 == id)
                    return true;
            }
            return false;
        }


    }
}