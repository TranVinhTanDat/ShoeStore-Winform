using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class RoleBUS
    {
        private static RoleBUS instance;

        public static RoleBUS Instance
        {
            get { if (instance == null) instance = new RoleBUS(); return RoleBUS.instance; }
            private set { RoleBUS.instance = value; }
        }

        public RoleBUS() { }

        public List<RoleDTO> GetList()
        {
            DataTable dt = RoleDAO.Instance.GetData();

            List<RoleDTO> list = new List<RoleDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new RoleDTO(dr));
            }
            return list;
        }

        public string SetAutoRoleID()
        {
            string roleID = "Role";
            int num = 0;
            List<RoleDTO> list = RoleBUS.Instance.GetList();
            string lastID = list[list.Count - 1].RoleID.ToString();
            num = int.Parse(lastID.Substring(4, 2));
            num++;
            if (num < 10) roleID += "0" + num;
            else roleID += num.ToString();
            return roleID;
        }
    }
}
