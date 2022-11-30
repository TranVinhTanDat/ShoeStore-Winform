using DAO;
using DTO;


namespace BUS
{
    public class UserBUS
    {
        UserDAO userDAO = new UserDAO();
        public string LoginBUS(UserDTO us)
        {



            if (us.Username1 == "" || us.Password1 == "")
            {
                return "thong bao";
            }


            if (userDAO.LoginDAO(us) != null)

                return "thanh cong";

            else
                return "that bai";


        }
    }
}
