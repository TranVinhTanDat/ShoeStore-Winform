using System.Data;

namespace DTO
{
    public class AccountDTO
    {
        private string userID;
        private string userName;
        private string passWord;
        private string roleID;
        private string email;
        private string enable;

        public AccountDTO() { }

        public AccountDTO(string userID, string userName, string passWord, string roleID, string email, string enable)
        {
            this.userID = userID;
            this.userName = userName;
            this.passWord = passWord;
            this.roleID = roleID;
            this.email = email;
            this.enable = enable;
        }

        public AccountDTO(DataRow dr)
        {
            this.userID = dr["UserID"].ToString();
            this.userName = dr["UserName"].ToString();
            this.passWord = dr["PassWord"].ToString();
            this.roleID = dr["RoleID"].ToString();
            this.email = dr["Email"].ToString();
            this.enable = dr["Enable"].ToString();
        }

        public string UserID { get => userID; set => userID = value; }
        public string UserName { get => userName; set => userName = value; }
        public string PassWord { get => passWord; set => passWord = value; }
        public string RoleID { get => roleID; set => roleID = value; }
        public string Email { get => email; set => email = value; }
        public string Enable { get => enable; set => enable = value; }
    }
}
