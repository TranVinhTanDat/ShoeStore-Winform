using DAO;
using DTO;
using System.Collections.Generic;

namespace BUS
{
    public class DashboardBUS
    {
        private DashboardDAO dashboardDAO;
        private List<DashboardDTO> listDashBoardDTO;

        public DashboardBUS()
        {
            this.dashboardDAO = new DashboardDAO();
        }

        public List<DashboardDTO> TopBestSelling()
        {
            listDashBoardDTO = new List<DashboardDTO>();
            listDashBoardDTO = dashboardDAO.TopBestSelling();

            return listDashBoardDTO;
        }
    }
}
