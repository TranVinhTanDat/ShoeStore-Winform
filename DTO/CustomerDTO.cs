using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CustomerDTO
    {
        private string CustomerID;
        private string CustomerSurname;
        private string CustomerName;
        private string Gender;
        private string PhoneNumber;
        private string Address;

        public string CustomerID1 { get => CustomerID; set => CustomerID = value; }
        public string CustomerSurname1 { get => CustomerSurname; set => CustomerSurname = value; }
        public string CustomerName1 { get => CustomerName; set => CustomerName = value; }
        public string Gender1 { get => Gender; set => Gender = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Address1 { get => Address; set => Address = value; }

        public CustomerDTO(string customerID, string customerSurname, string customerName, string gender, string phoneNumber, string address)
        {
            CustomerID1 = customerID;
            CustomerSurname1 = customerSurname;
            CustomerName1 = customerName;
            Gender1 = gender;
            PhoneNumber1 = phoneNumber;
            Address1 = address;
        }

        public CustomerDTO()
        {
        }
    }
}
