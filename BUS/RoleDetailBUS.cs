using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class RoleDetailBUS
    {
        private static RoleDetailBUS instance;

        public static RoleDetailBUS Instance
        {
            get { if (instance == null) instance = new RoleDetailBUS(); return RoleDetailBUS.instance; }
            private set { RoleDetailBUS.instance = value; }
        }

        public RoleDetailBUS() { }

        public List<RoleDetailDTO> GetList()
        {
            DataTable dt = RoleDetailDAO.Instance.GetData();

            List<RoleDetailDTO> list = new List<RoleDetailDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new RoleDetailDTO(dr));
            }
            return list;
        }
    }
}
