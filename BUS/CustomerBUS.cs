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
            string result = "";
            if (result.Contains("error"))
                return result;
            result = "success";
            cusDAO.DeleteCus(id);
            return result;

        }
        public string AddCus(string id, string surname, string name, string gender, string phoneNumber, string address)
        {
            if (checkIdCustomer(id)) // Giả sử checkIdCustomer là phương thức kiểm tra ID đã tồn tại
            {
                return "error_CusId_Exists"; // hoặc bất kỳ thông báo lỗi nào bạn chọn
            }

            CustomerDTO cus = new CustomerDTO(id, surname, name, gender, phoneNumber, address);
            cusDAO.AppCus(cus);
            return "success";
        }


        public string UpdateCus(string id, string surname, string name, string gender, string phoneNumber, string address)
        {
            // Loại bỏ các điều kiện kiểm tra
            string result = "success";

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