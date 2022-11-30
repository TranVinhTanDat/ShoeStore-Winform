using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class SupplierBUSs
    {
        private SupplierDAOs supplierDAO;
        private List<SupplierDTOs> listSupplierDTO;

        public SupplierBUSs()
        {
            supplierDAO = new SupplierDAOs();
        }
        public List<SupplierDTOs> GetList()
        {
            listSupplierDTO = new List<SupplierDTOs>();
            listSupplierDTO = supplierDAO.GetAll();

            return listSupplierDTO;
        }

    }
}
