using DAO;
using DTO;
using System.Collections.Generic;
using System.Data;

namespace BUS
{
    public class FunctionBUS
    {
        private static FunctionBUS instance;

        public static FunctionBUS Instance
        {
            get { if (instance == null) instance = new FunctionBUS(); return FunctionBUS.instance; }
            private set { FunctionBUS.instance = value; }
        }

        public FunctionBUS() { }

        public List<FunctionDTO> GetList()
        {
            DataTable dt = FunctionDAO.Instance.GetData();

            List<FunctionDTO> list = new List<FunctionDTO>();

            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new FunctionDTO(dr));
            }
            return list;
        }

        public string SetAutoRoleID()
        {
            string funcID = "Func";
            int num = 0;
            List<FunctionDTO> list = FunctionBUS.Instance.GetList();
            string lastID = list[list.Count - 1].FunctionID.ToString();
            num = int.Parse(lastID.Substring(4, 2));
            num++;
            if (num < 10) funcID += "0" + num;
            else funcID += num.ToString();
            return funcID;
        }
    }
}
