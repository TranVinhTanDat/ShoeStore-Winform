using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainGUI : Form
    {
        Form activeForm;
        StaffDTO staffDTO1 = new StaffDTO();
       


        public MainGUI()
        {
            InitializeComponent();
            

        }

        public MainGUI(StaffDTO staffDTO)
        {
            InitializeComponent();

            staffDTO1 = staffDTO;
        }

        int IntListImg = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnLine.Width = 0;
            OpenChildForm(new Dashboard());

            
            
        }

        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
        }

        private void timer_Date_Tick(object sender, EventArgs e)
        {
            txtDate.Text = DateTime.Now.ToString("dddd, dd/MM/yyyy");
            txtTime.Text = DateTime.Now.ToString("HH:mm:ss tt");

            if (IntListImg == 0)
            {
                PicBoxQC.BackgroundImage = Image.FromFile(@"..\..\img\qc1.jpg");
                PicBoxQC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                IntListImg = 1;
            }
            else
            {
                PicBoxQC.BackgroundImage = Image.FromFile(@"..\..\img\qc2.jpg");
                PicBoxQC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
                IntListImg = 0;
            }
        }

        private void timerLine_Tick(object sender, EventArgs e)
        {
            if (btnLine.Width < 240)
            {
                btnLine.Width += 20;
            }
            if (btnLine.Width >= 240)
            {
                btnLine.Width = 240;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = messQuestion.Show("Are you sure exit?");
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Dashboard());
        }

        private void btnCreateBill_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Sale());
        }

        private void btnCreateImport_Click(object sender, EventArgs e)
        {

            OpenChildForm(new CreateImport());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {

            OpenChildForm(new BillManagerGUI());
        }

        private void btnImport_Click(object sender, EventArgs e)
        {

            OpenChildForm(new ImportManager());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Product());
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

            OpenChildForm(new CustomerGUI());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {

            OpenChildForm(new StaffGUI());
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SupplierGUI());

        }

        private void btnAccount_Click(object sender, EventArgs e)
        {

            OpenChildForm(new AccountGUI());
        }

        private void btnRoleFunc_Click(object sender, EventArgs e)
        {

            OpenChildForm(new RoleFuncGUI());
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {

            OpenChildForm(new StatisticGUI());
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Profile(staffDTO1));
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void txtDate_Click(object sender, EventArgs e)
        {

        }
    }
}
