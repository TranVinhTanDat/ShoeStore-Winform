using System.Data;

namespace DTO
{
    public class StaffDTO
    {
        private string _idStaff; 
        private string _userId;
        private string _firstName;
        private string _lastName;
        private int _year;
        private string _gender;
        private string _phone;
        private string _address;
        private double _salary;
        private string _roleID;
        private byte[] _image;

        public StaffDTO() { }

        public StaffDTO(DataRow dr)
        {
            _idStaff = dr["StaffID"].ToString();
            _firstName = dr["FirstName"].ToString();
            _lastName = dr["LastName"].ToString();
            _year = int.Parse(dr["YearOfBirth"].ToString());
            _gender = dr["Gender"].ToString();
            _phone = dr["Phone"].ToString();
            _address = dr["Address"].ToString();
            _salary = double.Parse(dr["Salary"].ToString());
            _image = (byte[])dr["IMG"];
        }

        public StaffDTO(string idStaff, string firstName, string lastName, int year, string gender, string phone, string address, double salary, byte[] image)
        {
            _idStaff = idStaff;
            _firstName = firstName;
            _lastName = lastName;
            _year = year;
            _gender = gender;
            _phone = phone;
            _address = address;
            _salary = salary;
            _image = image;
        }
        
        public StaffDTO(string idStaff, string userId, string firstName, string lastName, int year, string gender, string phone, string address, double salary, byte[] image)
        {
            _idStaff = idStaff;
            _userId = userId;
            _firstName = firstName;
            _lastName = lastName;
            _year = year;
            _gender = gender;
            _phone = phone;
            _address = address;
            _salary = salary;
            _image = image;
        }

        public StaffDTO(string idStaff, string firstName, string lastName, string phone, string address)
        {
            _idStaff = idStaff;
            _firstName = firstName;
            _lastName = lastName;
            _phone = phone;
            _address = address;
        }
        public StaffDTO(string idStaff, string userId, string firstName, string lastName, int year, string gender, string phone, string address, double salary, byte[] image, string roleID)
        {
            _idStaff = idStaff;
            _userId = userId;
            _firstName = firstName;
            _lastName = lastName;
            _year = year;
            _gender = gender;
            _phone = phone;
            _address = address;
            _salary = salary;
            _image = image;
            _roleID= roleID;
        }

        public string IdStaff { get => _idStaff; set => _idStaff = value; }
        public string UserId { get => _userId; set => _userId = value; }
        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public int Year { get => _year; set => _year = value; }
        public string Gender { get => _gender; set => _gender = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Address { get => _address; set => _address = value; }
        public double Salary { get => _salary; set => _salary = value; }
        public byte[] Image { get => _image; set => _image = value; }
    }
}
