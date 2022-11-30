using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {
        private List<DashboardDTO> dashboardDTOs;
        private DashboardBUS dashboardBUS;

        public Dashboard()
        {
            InitializeComponent();
            dashboardDTOs = new List<DashboardDTO>();
            dashboardBUS = new DashboardBUS();
        }
        public Image byteArrayToImage(byte[] byteBLOBData)
        {
            MemoryStream ms = new MemoryStream(byteBLOBData);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }


        private void Dashboard_Load(object sender, EventArgs e)
        {
            dashboardDTOs = dashboardBUS.TopBestSelling();
            for (int i = 0; i < dashboardDTOs.Count; i++)
            {

            // Dashboard Selling 1
            quantity1ProductSelling.Text = dashboardDTOs[i].Sale.ToString();
            picture1Dashboard.Image = byteArrayToImage(dashboardDTOs[i].Img);
            textNameDashboard.Text = dashboardDTOs[i].NameProduct.ToString();
            textDesDashboard.Text = dashboardDTOs[i].DescriptionProduct.ToString();

            }
            //// Dashboard Selling 2
            //quantity2ProductSelling.Text = dashboardDTOs[1].Sale.ToString();
            //picture2Dashboard.Image = byteArrayToImage(dashboardDTOs[1].Img);

            //// Dashboard Selling 3
            //quantity3ProductSelling.Text = dashboardDTOs[2].Sale.ToString();
            //picture3Dashboard.Image = byteArrayToImage(dashboardDTOs[2].Img);

            //// Dashboard Selling 4
            //quantity4ProductSelling.Text = dashboardDTOs[3].Sale.ToString();
            //picture4Dashboard.Image = byteArrayToImage(dashboardDTOs[3].Img);

        }

        private void guna2ShadowPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
