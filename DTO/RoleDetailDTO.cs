using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RoleDetailDTO
    {
        private string roleID;
        private string functionID;

        public RoleDetailDTO() { }

        public RoleDetailDTO(string roleID, string functionID)
        {
            this.roleID = roleID;
            this.functionID = functionID;
        }

        public RoleDetailDTO(DataRow dr)
        {
            this.roleID = dr["RoleID"].ToString();
            this.functionID = dr["FunctionID"].ToString();
        }

        public string RoleID { get => roleID; set => roleID = value; }
        public string FunctionID { get => functionID; set => functionID = value; }
    }
}
