using DAO;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace GUI
{
    public partial class Profile : Form
    {
        StaffDTO staffDTO = new StaffDTO();
        StaffDTO staffDTO1;
        private string idProfile;

        public Profile()
        {
            InitializeComponent();
            idProfile = staffDTO.IdStaff;

        }

        public Profile(StaffDTO staffDTO)
        {
            InitializeComponent();
            this.staffDTO = staffDTO;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        public static Image GetImageFromByte(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            idProfile = staffDTO.IdStaff;
            txtFirstName.Text = staffDTO.FirstName;
            txtLastName.Text = staffDTO.LastName;
            txtEmail.Text = "";
            txtPhone.Text = staffDTO.Phone;
            txtAddress.Text = staffDTO.Address;
            //avatarProfile.Image = GetImageFromByte(staffDTO.Image);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StaffDAO staffDAO = new StaffDAO();
            staffDTO1 = new StaffDTO(idProfile, txtFirstName.Text.ToString(), txtLastName.Text.ToString(), txtPhone.Text.ToString(), txtAddress.Text.ToString());

            if (staffDAO.UpdateProfile(staffDTO1))
            {
                MessageBox.Show("Update Successful");
            }
            else
            {
                MessageBox.Show("Update Failed");
            }

        }

    }
}
