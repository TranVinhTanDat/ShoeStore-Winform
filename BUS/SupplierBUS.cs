using DAO;
using DTO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace BUS
{
    public class SupplierBUS
    {
        SupplierDAO supDAO = new SupplierDAO();
        public List<SupplierDTO> ShowSup()
        {
            return supDAO.ShowListSuppier();
        }
        public List<SupplierDTO> SeachSup(string strSeach)
        {
            return supDAO.SeachSup(strSeach);
        }
        public string DeleteSup(string id)
        {
            if (id == "")
                return "error_isNull";

            string result = "";
            if (checkIdSuppier(id) == false)
                result = "error_SupID";

            if (result.Contains("error"))
                return result;
            result = "success";
            supDAO.DeleteSup(id);
            return result;

        }
        public string AddSup(string id, string name, string phone, string address, string fax)
        {
            if (!checkIdSuppier(id))
            {
                SupplierDTO sup = new SupplierDTO(id, name, phone, address, fax);
                supDAO.AppSup(sup);
                return "success";
            }
            return "duplicate_id"; // Trả về thông báo nếu ID đã tồn tại
        }

        public string UpdateSup(string id, string name, string phone, string address, string fax)
        {
            if (checkIdSuppier(id))
            {
                SupplierDTO sup = new SupplierDTO(id, name, phone, address, fax);
                supDAO.UpdateSup(sup);
                return "success";
            }
            return "not_found"; // Trả về thông báo nếu không tìm thấy ID cần cập nhật
        }

        public bool checkIdSuppier(string id)
        {
            foreach (SupplierDTO sup in ShowSup())
            {
                if (sup.SuppierID1 == id)
                    return true;
            }
            return false;
        }

    }
}
