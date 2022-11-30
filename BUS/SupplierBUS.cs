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
            Regex rexNumber = new Regex(@"^[0-9]{10}$");
            if (id == "")
            {
                return "error_SupId_isNull";
            }
            if (id.Contains("SUPP") == false)
            {
                return "saidinhdang";
            }


            if (name == "")
            {
                return "error_Supname";
            }
            if (phone == "")
            {
                return "error_Phonenull";
            }
            if (fax == "")
            {
                return "error_Faxnull";
            }

            string result = "";
            if (checkIdSuppier(id) == true)
            {
                result = "error_SupId";
            }
            if (address == "")
            {
                result = "error_Address";
            }


            if (rexNumber.Match(phone).Success == false)
                result = "error_phone";
            if (rexNumber.Match(fax).Success == false)
                result = "error_fax";


            if (result.Contains("error"))
                return result;
            result = "success";

            SupplierDTO sup = new SupplierDTO(id, name, phone, address, fax);
            supDAO.AppSup(sup);
            return result;
        }

        public string UpdateSup(string id, string name, string phone, string address, string fax)
        {
            Regex rexNumber = new Regex(@"^[0-9]{10}$");
            if (id == "")
            {
                return "error_SupId_isNull";
            }
            if (id.Contains("SUPP") == false)
            {
                return "saidinhdang";
            }


            if (name == "")
            {
                return "error_Supname";
            }
            if (phone == "")
            {
                return "error_Phonenull";
            }
            if (fax == "")
            {
                return "error_Faxnull";
            }

            string result = "";
            if (checkIdSuppier(id) == false)
            {
                result = "error_SupId";
            }
            if (address == "")
            {
                result = "error_Address";
            }


            if (rexNumber.Match(phone).Success == false)
                result = "error_phone";
            if (rexNumber.Match(fax).Success == false)
                result = "error_fax";


            if (result.Contains("error"))
                return result;
            result = "success";

            SupplierDTO sup = new SupplierDTO(id, name, phone, address, fax);
            supDAO.UpdateSup(sup);
            return result;
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
