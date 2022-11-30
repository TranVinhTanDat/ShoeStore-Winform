using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class AccountBUS
    {
        private AccountDAO accountDAO;
        private static AccountBUS instance;

        public static AccountBUS Instance
        {
            get { if (instance == null) instance = new AccountBUS(); return AccountBUS.instance; }
            private set { AccountBUS.instance = value; }
        }

        public AccountBUS() 
        {
            accountDAO = new AccountDAO();
        }

        public List<AccountDTO> GetList()
        {
            DataTable dt = AccountDAO.Instance.GetData();

            List<AccountDTO> list = new List<AccountDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new AccountDTO(dr));
            }
            return list;
        }

        public bool Insert(string userID, string userName, string passWord, string roleID, string email, string enable)
        {
            return accountDAO.InsertAccount(userID, userName, passWord, roleID, email, enable);
        }

        public string SetAutoUserID()
        {
            string userID = "USR";
            int num = 0;
            List<AccountDTO> list = AccountBUS.Instance.GetList();
            string lastID = list[list.Count - 1].UserID.ToString();
            num = int.Parse(lastID.Substring(3));
            num++;
            if (num < 10) userID += "00" + num;
            else userID += "0" + num;
            return userID;
        }

        public string SetAutoUsername()
        {
            string userName = "Username";
            int num = 0;
            List<AccountDTO> list = AccountBUS.Instance.GetList();
            string lastUsername = "";

            foreach (AccountDTO accountDTO in list)
            {
                if (!accountDTO.UserName.StartsWith("Username01"))
                {
                    lastUsername = "Username01";
                }
            }

            for (var i = list.Count - 1; i >= 0; i--) 
            {
                if (list[i].UserName.StartsWith("Username"))
                {
                    lastUsername = list[i].UserName;
                    break;
                }
            }

            num = int.Parse(lastUsername.Substring(8));
            num++;

            if (num < 10) userName += "0" + num;
            else userName += num.ToString();

            return userName;
        }
    }
}
