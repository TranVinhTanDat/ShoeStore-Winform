using DTO;
using System.Collections.Generic;
using System.Data;

namespace DAO
{
    public class DashboardDAO
    {
        public List<DashboardDTO> TopBestSelling()
        {
            DataTable _dt = new DataTable();
            string query = string.Format("select pro.ProductID, pro.IMG, pro.ProductName, pro.ProductPrice, pro.Description, sum(bd.Quantity) sale from product as pro inner join billdetail as bd on pro.ProductID = bd.ProductID group by pro.ProductID ORDER by sum(bd.Quantity) desc limit 0, 4;");

            _dt = DataProvider.Instance.ExecuteQuery(query);

            List<DashboardDTO> list = new List<DashboardDTO>();

            foreach (DataRow row in _dt.Rows)
            {
                list.Add(new DashboardDTO(row));
            }

            return list;
        }
    }
}
