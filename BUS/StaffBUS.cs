using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class StaffBUS
    {
        private StaffDAO staffDAO;
        private List<StaffDTO> listStaffDTO;
        private static StaffBUS instance;

        public static StaffBUS Instance
        {
            get { if (instance == null) instance = new StaffBUS(); return StaffBUS.instance; }
            private set { StaffBUS.instance = value; }
        }


        public StaffBUS()
        {
            staffDAO = new StaffDAO();
        }

        public List<StaffDTO> GetList()
        {
            listStaffDTO = new List<StaffDTO>();
            listStaffDTO = staffDAO.GetAll();

            return listStaffDTO;
        }

        public bool Insert(StaffDTO staffDTO)
        {
            return this.staffDAO.Insert(staffDTO);
        }

        public bool Update(StaffDTO staffDTO)
        {
            return this.staffDAO.Update(staffDTO);
        }

        public bool Delete(string idStaff)
        {
            return this.staffDAO.Delete(idStaff);
        }

        public string getIDStaff()
        {
            string Id = "";
            int So = 0;

            listStaffDTO = GetList();

            if (listStaffDTO.Count == 0)
            {
                //foreach (StaffDTO staffDTO in listStaffDTO)
                //{
                    //if (!staffDTO.IdStaff.StartsWith("STF001"))
                    //{
                        Id = "STF001";
                    //}
                //}
            }
            else
            {
                string IdProduct = listStaffDTO[listStaffDTO.Count - 1].IdStaff;

                // Cut string use: Substring(int startIndex, int length)
                So = int.Parse(IdProduct.Substring(3));    // int.Parse(001) -> 1
                So++;   // 1 -> 2
                if (So < 10)
                {
                    Id += "STF00" + So;
                }
                else
                    Id += "STF0" + So;

            }

            // Take id last

            return Id;
        }
    }
}
