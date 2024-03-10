using BUS;
using DAO;
using DTO;
using GUI.Properties;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountGUI : Form
    {
        private bool InsertOrUpdate;
        private BindingSource bindingSource;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        public AccountGUI()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            pnlInfo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlInfo.Width, pnlInfo.Height, 20, 20));
            pnlList.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlList.Width, pnlList.Height, 20, 20));
            //dtgvAccount.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtgvAccount.Width, dtgvAccount.Height, 10, 10));
        }

        private void AccountGUI_Load(object sender, EventArgs e)
        {
            DefaultDisplay();
        }

        public void LoadListAccount()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = AccountBUS.Instance.GetList();
            dtgvAccount.DataSource = bindingSource;

            DataGridViewImageColumn update = new DataGridViewImageColumn();
            update.Name = "colUpdate";
            update.DataPropertyName = "colUpdate";
            update.HeaderText = "";
            update.ImageLayout = DataGridViewImageCellLayout.Normal;
            update.Image = Resources.icon_update;
            dtgvAccount.Columns.Add(update);

            DataGridViewImageColumn delete = new DataGridViewImageColumn();
            delete.Name = "colDelete";
            delete.DataPropertyName = "colDelete";
            delete.HeaderText = "";
            delete.ImageLayout = DataGridViewImageCellLayout.Normal;
            delete.Image = Resources.icon_delete;
            dtgvAccount.Columns.Add(delete);

            ChangeColHeader();
            ChangeColWidth();
        }

        public void LoadComboBoxRole()
        {
            cmbRole.DataSource = RoleBUS.Instance.GetList();
            cmbRole.DisplayMember = "RoleName";
            cmbRole.ValueMember = "RoleID";
            cmbRole.SelectedItem = null;
        }

        private void ChangeColHeader()
        {
            dtgvAccount.Columns["UserID"].HeaderText = "ID";
            dtgvAccount.Columns["UserName"].HeaderText = "Username";
            dtgvAccount.Columns["PassWord"].HeaderText = "Password";
            dtgvAccount.Columns["RoleID"].HeaderText = "Role ID";
            dtgvAccount.Columns["Email"].HeaderText = "Email";
            dtgvAccount.Columns["Enable"].HeaderText = "Enable";
        }

        private void ChangeColWidth()
        {
            dtgvAccount.Columns[0].Width = 100;
            dtgvAccount.Columns[1].Width = 200;
            dtgvAccount.Columns[2].Width = 200;
            dtgvAccount.Columns[3].Width = 200;
            dtgvAccount.Columns[4].Width = 200;
            dtgvAccount.Columns[5].Width = 100;
            dtgvAccount.Columns[6].Width = 100;
            dtgvAccount.Columns[7].Width = 100;
        }

        private void ActiveEditMode(bool active)
        {
            txtUserID.Enabled = !active;
            txtUserID.ReadOnly = !active;
            txtUsername.ReadOnly = !active;
            txtPassword.ReadOnly = !active;
            txtEmail.ReadOnly = !active;

            btnInsert.Enabled = !active;
            btnOK.Enabled = active;
            btnCancel.Enabled = active;

            dtgvAccount.Enabled = !active;
            dtgvAccount.ClearSelection();
        }

        private void DefaultDisplay()
        {
            txtUserID.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            
            LoadComboBoxRole();
            cmbEnable.Enabled = true;
            cmbEnable.SelectedItem = null;

            dtgvAccount.Columns.Clear();
            LoadListAccount();

            ActiveEditMode(false);
        }

        private void dtgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.ColumnIndex != dtgvAccount.Columns[6].Index && e.ColumnIndex != dtgvAccount.Columns[7].Index)
            {
                txtUserID.Text = dtgvAccount.CurrentRow.Cells["UserID"].Value.ToString();
                txtUsername.Text = dtgvAccount.CurrentRow.Cells["UserName"].Value.ToString();
                txtPassword.Text = dtgvAccount.CurrentRow.Cells["PassWord"].Value.ToString();
                txtEmail.Text = dtgvAccount.CurrentRow.Cells["Email"].Value.ToString();
                cmbRole.SelectedValue = dtgvAccount.CurrentRow.Cells["RoleID"].Value.ToString();
                cmbEnable.SelectedItem = dtgvAccount.CurrentRow.Cells["Enable"].Value.ToString();
            }
        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgvAccount.Columns[e.ColumnIndex].Name;
            if (colName == "colUpdate")
            {
                InsertOrUpdate = false;
                ActiveEditMode(true);

                txtUserID.Text = dtgvAccount.CurrentRow.Cells["UserID"].Value.ToString();
                txtUsername.Text = dtgvAccount.CurrentRow.Cells["UserName"].Value.ToString();
                txtPassword.Text = dtgvAccount.CurrentRow.Cells["PassWord"].Value.ToString();
                txtEmail.Text = dtgvAccount.CurrentRow.Cells["Email"].Value.ToString();
                cmbRole.SelectedValue = dtgvAccount.CurrentRow.Cells["RoleID"].Value.ToString();
                cmbEnable.SelectedItem = dtgvAccount.CurrentRow.Cells["Enable"].Value.ToString();
            }
            if (colName == "colDelete")
            {
                try
                {
                    DialogResult result = messQuestion.Show("Do you want to delete?");
                    if (result == DialogResult.Yes)
                    {
                        if (AccountDAO.Instance.DeleteAccount(dtgvAccount.CurrentRow.Cells["UserID"].Value.ToString()) != null)
                        {
                            LoadListAccount();
                            string message = "Delete Successful";
                            MessageBox.Show(message, "Information", MessageBoxButtons.OK);
                        }
                    }
                }
                catch (Exception)
                {
                    messError.Show("Delete Failed");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = AccountDAO.Instance.GetData();
            dtgvAccount.DataSource = dt;

            dt.DefaultView.RowFilter = string.Format("UserName LIKE '%{0}%' OR Email LIKE '%{0}%' OR Enable LIKE '%{0}%'", txtSearch.Text);
            dtgvAccount.ClearSelection();
        }

        private void txtSearch_IconRightClick(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InsertOrUpdate = true;
            ActiveEditMode(true);

            txtUserID.Text = AccountBUS.Instance.SetAutoUserID();
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();

            LoadComboBoxRole();

            cmbEnable.SelectedItem = "1";
            cmbEnable.Enabled = false;
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
        public byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    DialogResult result = MessageBox.Show("Do you want to insert?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (AccountDAO.Instance.InsertAccount(txtUserID.Text, txtUsername.Text, MD5Hash(txtPassword.Text), cmbRole.SelectedValue.ToString(), txtEmail.Text, cmbEnable.SelectedItem.ToString()) != null)
                        {
                            string staffID;
                            string userID = txtUserID.Text;

                            // Lấy ba chữ số cuối cùng của userID
                            string lastThreeDigits = userID.Substring(userID.Length - 3);
                            staffID = "STF" + lastThreeDigits;

                            StaffDTO staffDTO = new StaffDTO
                            {
                                IdStaff = staffID,
                                UserId = userID,
                                FirstName = "",
                                LastName = "",
                                Year = DateTime.Now.Year,
                                Gender = "",
                                Phone = "",
                                Address = "",
                                Salary = 0,
                                Image = ImageToByteArray(Resources.about_black_n6)
                            };

                            StaffDAO staffDAO = new StaffDAO();
                            staffDAO.Insert(staffDTO);

                            DefaultDisplay();
                            MessageBox.Show("Insert Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Do you want to update?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        if (AccountDAO.Instance.UpdateAccount(txtUserID.Text, txtUsername.Text, txtPassword.Text, cmbRole.SelectedValue.ToString(), txtEmail.Text, cmbEnable.SelectedItem.ToString()) != null)
                        {
                            DefaultDisplay();
                            MessageBox.Show("Update Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (InsertOrUpdate)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Insert Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Update Failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

 




        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = messQuestion.Show("Do you want to cancel?");
            if (result == DialogResult.Yes)
            {
                DefaultDisplay();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

		private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
		{

		}


    }
}
