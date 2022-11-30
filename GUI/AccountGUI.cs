using BUS;
using DAO;
using GUI.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
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
            //cmbRole.DataSource = RoleBUS.Instance.GetList();
            //cmbRole.DisplayMember = "RoleName";
            //cmbRole.ValueMember = "RoleID";
            //cmbRole.SelectedItem = null;
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
                            messInformation.Show("Delete Successful");
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

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (InsertOrUpdate)
                {
                    DialogResult result =  messQuestion.Show("Do you want to insert?");
                    if (result == DialogResult.Yes)
                    {
                        if (AccountDAO.Instance.InsertAccount(txtUserID.Text.ToString(), txtUsername.Text.ToString(), txtPassword.Text.ToString(), cmbRole.SelectedValue.ToString(), txtEmail.Text.ToString(), cmbEnable.SelectedItem.ToString()) != null)
                        {
                            DefaultDisplay();
                            messInformation.Show("Insert Successful");
                        }
                    }
                }
                else
                {
                    DialogResult result = messQuestion.Show("Do you want to update?");
                    if (result == DialogResult.Yes)
                    {
                        if (AccountDAO.Instance.UpdateAccount(txtUserID.Text.ToString(), txtUsername.Text.ToString(), txtPassword.Text.ToString(), cmbRole.SelectedValue.ToString(), txtEmail.Text.ToString(), cmbEnable.SelectedItem.ToString()) != null)
                        {
                            DefaultDisplay();
                            messInformation.Show("Update Successful");
                        }
                    }
                }
            }
            catch (Exception)
            {
                if (InsertOrUpdate)
                {
                    messError.Show("Insert Failed");
                }
                else
                {
                    messError.Show("Update Failed");
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
    }
}
