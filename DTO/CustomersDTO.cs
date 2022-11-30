using System.Data;

namespace DTO
{
    public class CustomersDTO
    {
        private string customerID;
        private string customerSurname;
        private string customerName;
        private string gender;
        private string phone;
        private string address;

        public CustomersDTO() { }
        public CustomersDTO(DataRow dr)
        {
            CustomerID = dr["CustomerID"].ToString();
            CustomerSurname = dr["CustomerSurname"].ToString();
            CustomerName = dr["CustomerName"].ToString();
            Gender = dr["Gender"].ToString();
            Phone = dr["Phone"].ToString();
            Address = dr["Address"].ToString();

        }

        public CustomersDTO(string customerID, string customerSurname, string customerName, string gender, string phone, string address)
        {
            CustomerID = customerID;
            CustomerSurname = customerSurname;
            CustomerName = customerName;
            Gender = gender;
            Phone = phone;
            Address = address;


        }

        public string CustomerID { get => customerID; set => customerID = value; }
        public string CustomerSurname { get => customerSurname; set => customerSurname = value; }
        public string CustomerName { get => customerName; set => customerName = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
    }
}
