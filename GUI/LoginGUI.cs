using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class LoginGUI : Form
    {
        List<AccountDTO> listAcc = new List<AccountDTO>();
        List<RoleDetailDTO> listFunc = new List<RoleDetailDTO>();
        private string roleID;
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public static string MD5Hash(string input)
        {
            StringBuilder hash = new StringBuilder();
            MD5CryptoServiceProvider md5provider = new MD5CryptoServiceProvider();
            byte[] bytes = md5provider.ComputeHash(new UTF8Encoding().GetBytes(input));

            for (int i = 0; i < bytes.Length; i++)
            {
                hash.Append(bytes[i].ToString("x2"));
            }
            return hash.ToString();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserDTO us = new UserDTO(txtUser.Text, MD5Hash(txtPassword.Text));
            UserBUS userBUS = new UserBUS();

            UserDAO user = new UserDAO();

            if (userBUS.LoginBUS(us) == "thong bao")
            {
                messWarning.Show("Vui lòng nhập đầy đủ thông tin");
            }

            if (userBUS.LoginBUS(us) == "thanh cong")
            {
                messInformation.Show("Login Successful\n" + "Hi, " + user.getStaffFromAccount(txtUser.Text.ToString()));
                this.Hide();

                MainGUI f = new MainGUI(user.getStaffFromAccounts(txtUser.Text.ToString()));
                
                f.btnProfile.Text = user.getStaffFromAccount(txtUser.Text.ToString());

                roleID = user.getRoleIDFromAccount(txtUser.Text.ToString());

                listFunc = RoleDetailBUS.Instance.GetList();

                for (int i = 0; i < listFunc.Count; i++)
                {
                    if (listFunc[i].RoleID == roleID)
                    {
                        if (listFunc[i].FunctionID == "FUC001")
                        {
                            f.btnCreateBill.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC002")
                        {
                            f.btnCreateImport.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC003")
                        {
                            f.btnBill.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC004")
                        {
                            f.btnImport.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC005")
                        {
                            f.btnProduct.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC006")
                        {
                            f.btnCustomer.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC007")
                        {
                            f.btnStaff.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC008")
                        {
                            f.btnSupplier.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC009")
                        {
                            f.btnAccount.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC010")
                        {
                            f.btnRoleFunc.Visible = true;
                        }
                        if (listFunc[i].FunctionID == "FUC011")
                        {
                            f.btnStatistic.Visible = true;
                        }
                    }
                }
                f.Show();
            }

            if (userBUS.LoginBUS(us) == "that bai")
            {
                messError.Show("Sai tai khoan hoac mat khau");
            }
            RePASS();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void btnShow_MouseDown(object sender, MouseEventArgs e)
        {
            btnShow.BackgroundImage = Image.FromFile(@"..\..\img\icons8-hide-48.png");
            btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            txtPassword.UseSystemPasswordChar = false;

        }

        private void btnShow_MouseUp(object sender, MouseEventArgs e)
        {
            btnShow.BackgroundImage = Image.FromFile(@"..\..\img\icons8-eye-48.png");
            btnShow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            txtPassword.UseSystemPasswordChar = true;

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            txtUser.Text = Properties.Settings.Default.user;
            txtPassword.Text = Properties.Settings.Default.pass;
            chbRemember.Checked = true;
            ChangeTitle();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void RePASS()
        {
            if (chbRemember.Checked)
            {
                Properties.Settings.Default.user = txtUser.Text;
                Properties.Settings.Default.pass = txtPassword.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.user = "";
                Properties.Settings.Default.pass = "";
                Properties.Settings.Default.Save();

            }
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void ChangeTitle()
        {
            lbTimer.Text = DateTime.Now.ToString("HH");

            int time = int.Parse(lbTimer.Text);
            if (4 <= time && time < 11)
            {
                lbTitle2.Text = "Good Morning";
            }
            if (time >= 11 && time < 18)
            {
                lbTitle2.Text = "Good Afternoon";
            }
            if (time >= 18 && time < 23)
            {
                lbTitle2.Text = "Good Evening";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
