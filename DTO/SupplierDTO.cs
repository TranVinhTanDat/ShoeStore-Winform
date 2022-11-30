namespace DTO
{
    public class SupplierDTO
    {
        public SupplierDTO()
        {
        }

        private string SuppierID;
        private string Suppiername;
        private string PhoneNumber;
        private string Address;

        private string FaxNumber;

        public string SuppierID1 { get => SuppierID; set => SuppierID = value; }
        public string Suppiername1 { get => Suppiername; set => Suppiername = value; }
        public string PhoneNumber1 { get => PhoneNumber; set => PhoneNumber = value; }
        public string Address1 { get => Address; set => Address = value; }
        public string FaxNumber1 { get => FaxNumber; set => FaxNumber = value; }

        public SupplierDTO(string suppierID, string suppiername, string phoneNumber, string address, string faxNumber)
        {
            SuppierID1 = suppierID;
            Suppiername1 = suppiername;
            PhoneNumber1 = phoneNumber;
            Address1 = address;
            FaxNumber1 = faxNumber;
        }



    }
}
