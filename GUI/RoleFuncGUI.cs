using BUS;
using DAO;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class RoleFuncGUI : Form
    {
        private int count;
        private CheckBox[] box;
        internal static bool InsertOrUpdate;
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

        public RoleFuncGUI()
        {
            InitializeComponent();

            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            pnlRole.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlRole.Width, pnlRole.Height, 20, 20));
            pnlFunc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlFunc.Width, pnlFunc.Height, 20, 20));
            pnlRoleFunc.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnlRoleFunc.Width, pnlRoleFunc.Height, 20, 20));
            dtgvRole.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtgvRole.Width, dtgvRole.Height, 10, 10));
            dtgvFunction.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtgvFunction.Width, dtgvFunction.Height, 10, 10));
        }

        public void LoadDataListRole()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = RoleBUS.Instance.GetList();
            dtgvRole.DataSource = bindingSource;
        }

        public void LoadDataListFunction()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = FunctionBUS.Instance.GetList();
            dtgvFunction.DataSource = bindingSource;
        }

        public void ChangeHeader()
        {
            dtgvRole.Columns["RoleID"].HeaderText = "ID";
            dtgvRole.Columns["RoleName"].HeaderText = "Name";
            dtgvFunction.Columns["FunctionID"].HeaderText = "ID";
            dtgvFunction.Columns["FunctionName"].HeaderText = "Name";
        }

        public void LoadComboBoxRole()
        {
            cmbChooseRole.Items.Clear();
            List<RoleDTO> role = RoleBUS.Instance.GetList();
            int size = role.Count;
            for (int i = 0; i < size; i++)
            {
                cmbChooseRole.Items.Add(role[i].RoleName.ToString());
            }
        }

        public void LoadCheckBox()
        {
            List<FunctionDTO> function = FunctionBUS.Instance.GetList();
            count = function.Count;
            box = new CheckBox[count];

            int toadox = 100, toadoy = 20;
            for (int i = 0; i < count; i++)
            {
                box[i] = new CheckBox();
                box[i].Tag = i.ToString();
                box[i].Text = function[i].FunctionName.ToString();
                box[i].AutoSize = true;
                box[i].Location = new Point(toadox, toadoy);
                box[i].Enabled = false;
                pnlChooseFunc.Controls.Add(box[i]);
                toadoy = toadoy + 40;
            }
        }

        public void ResetCheckBox()
        {
            for (int i = 0; i < count; i++)
            {
                box[i].Checked = false;
                box[i].Enabled = false;
            }
        }

        private void FormRole_Load(object sender, EventArgs e)
        {
            LoadDataListRole();
            LoadDataListFunction();
            ChangeHeader();
            LoadComboBoxRole();
            LoadCheckBox();

            DataGridViewImageColumn updateRole = new DataGridViewImageColumn();
            updateRole.Name = "colUpdate";
            updateRole.DataPropertyName = "colUpdate";
            updateRole.HeaderText = "";
            updateRole.ImageLayout = DataGridViewImageCellLayout.Normal;
            updateRole.Image = Resources.icon_update;
            dtgvRole.Columns.Add(updateRole);

            DataGridViewImageColumn deleteRole = new DataGridViewImageColumn();
            deleteRole.Name = "colDelete";
            deleteRole.DataPropertyName = "colDelete";
            deleteRole.HeaderText = "";
            deleteRole.ImageLayout = DataGridViewImageCellLayout.Normal;
            deleteRole.Image = Resources.icon_delete;
            dtgvRole.Columns.Add(deleteRole);

            DataGridViewImageColumn updateFunc = new DataGridViewImageColumn();
            updateFunc.Name = "colUpdate";
            updateFunc.DataPropertyName = "colUpdate";
            updateFunc.HeaderText = "";
            updateFunc.ImageLayout = DataGridViewImageCellLayout.Normal;
            updateFunc.Image = Resources.icon_update;
            dtgvFunction.Columns.Add(updateFunc);

            DataGridViewImageColumn deleteFunc = new DataGridViewImageColumn();
            deleteFunc.Name = "colDelete";
            deleteFunc.DataPropertyName = "colDelete";
            deleteFunc.HeaderText = "";
            deleteFunc.ImageLayout = DataGridViewImageCellLayout.Normal;
            deleteFunc.Image = Resources.icon_delete;
            dtgvFunction.Columns.Add(deleteFunc);
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadDataListRole();
            LoadDataListFunction();
            LoadComboBoxRole();
            LoadCheckBox();
            ResetCheckBox();
        }

        private void dtgvRole_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgvRole.Columns[e.ColumnIndex].Name;
            if (colName == "colUpdate")
            {
                InsertOrUpdate = false;
                SubRoleGUI form = new SubRoleGUI();
                form.txtID.Text = dtgvRole.CurrentRow.Cells["RoleID"].Value.ToString();
                form.txtName.Text = dtgvRole.CurrentRow.Cells["RoleName"].Value.ToString();
                form.Show();
                form.txtName.Focus();
                form.FormClosed += Form_FormClosed;
            }
            if (colName == "colDelete")
            {
                if (RoleDAO.Instance.DeleteRole(dtgvRole.CurrentRow.Cells["RoleID"].Value.ToString()) != null)
                {
                    LoadDataListRole();
                    LoadComboBoxRole();
                    messInformation.Show("Delete Successful");
                }
                else
                {
                    messError.Show("Delete Failed");
                }
            }
        }

        private void dtgvFunction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgvFunction.Columns[e.ColumnIndex].Name;
            if (colName == "colUpdate")
            {
                InsertOrUpdate = false;
                SubFuncGUI form = new SubFuncGUI();
                form.txtID.Text = dtgvFunction.CurrentRow.Cells["FunctionID"].Value.ToString();
                form.txtName.Text = dtgvFunction.CurrentRow.Cells["FunctionName"].Value.ToString();
                form.Show();
                form.txtName.Focus();
                form.FormClosed += Form_FormClosed;
            }
            if (colName == "colDelete")
            {
                if (FunctionDAO.Instance.DeleteFunction(dtgvFunction.CurrentRow.Cells["FunctionID"].Value.ToString()) != null)
                {
                    LoadDataListFunction();
                    LoadCheckBox();
                    messInformation.Show("Delete Successful");
                }
                else
                {
                    messError.Show("Delete Failed");
                }
            }
        }

        private void btnInsertRole_Click(object sender, EventArgs e)
        {
            InsertOrUpdate = true;
            SubRoleGUI form = new SubRoleGUI();
            form.txtID.Text = RoleBUS.Instance.SetAutoRoleID();
            form.ShowDialog();
            form.txtName.Focus();
            form.FormClosed += Form_FormClosed;
            form.Dispose();
        }

        private void btnInsertFunc_Click(object sender, EventArgs e)
        {
            InsertOrUpdate = true;
            SubFuncGUI form = new SubFuncGUI();
            form.txtID.Text = FunctionBUS.Instance.SetAutoRoleID();
            form.ShowDialog();
            form.txtName.Focus();
            form.FormClosed += Form_FormClosed;
            form.Dispose();
        }

        private void cmbChooseRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCheckBox();
            List<RoleDTO> role = RoleBUS.Instance.GetList();
            string roleID = cmbChooseRole.SelectedIndex != null ? role[cmbChooseRole.SelectedIndex].RoleID.ToString() : null;
            List<RoleDetailDTO> roleDetail = RoleDetailBUS.Instance.GetList();
            List<FunctionDTO> function = FunctionBUS.Instance.GetList();
            foreach (RoleDetailDTO detail in roleDetail)
            {
                for (int i = 0; i < count; i++)
                {
                    if (detail.RoleID.ToString() == roleID)
                    {
                        if (detail.FunctionID.ToString() == function[i].FunctionID.ToString())
                        {
                            box[i].Enabled = true;
                            box[i].Checked = true;
                        }
                    }
                    else box[i].Enabled = true;
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            List<RoleDTO> role = RoleBUS.Instance.GetList();
            List<FunctionDTO> function = FunctionBUS.Instance.GetList();
            string roleID = cmbChooseRole.SelectedIndex != null ? role[cmbChooseRole.SelectedIndex].RoleID.ToString() : null;
            RoleDetailDAO.Instance.DeleteRoleDetail(roleID);
            for (int i = 0; i < count; i++)
            {
                if (box[i].Checked)
                {
                    RoleDetailDAO.Instance.InsertRoleDetail(roleID, function[i].FunctionID.ToString());
                }
            }
            messInformation.Show("Update Successful");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
