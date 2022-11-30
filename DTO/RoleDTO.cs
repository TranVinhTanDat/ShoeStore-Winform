using System.Data;

namespace DTO
{
    public class RoleDTO
    {
        private string roleID;
        private string roleName;

        public RoleDTO() { }

        public RoleDTO(string roleID, string roleName)
        {
            this.roleID = roleID;
            this.roleName = roleName;
        }

        public RoleDTO(DataRow dr)
        {
            this.roleID = dr["RoleID"].ToString();
            this.roleName = dr["RoleName"].ToString();
        }

        public string RoleID { get => roleID; set => roleID = value; }
        public string RoleName { get => roleName; set => roleName = value; }
    }
}
