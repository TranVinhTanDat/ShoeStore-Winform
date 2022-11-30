namespace DTO
{
    public class UserDTO
    {
        private string ID;
        private string Username;

        private string Password;

        public UserDTO(string username, string password)
        {
            Username1 = username;
            Password1 = password;
        }

        public string ID1 { get => ID; set => ID = value; }
        public string Username1 { get => Username; set => Username = value; }
        public string Password1 { get => Password; set => Password = value; }
    }
}
