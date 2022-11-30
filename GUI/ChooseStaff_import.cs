using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GUI
{

    public partial class ChooseStaff_import : KryptonForm
    {
        public ChooseStaff_import()
        {
            InitializeComponent();
        }
        private UpdateImport _updateImport;
        private StaffBUS staffBUS = new StaffBUS();
        public static ChooseStaff_import _instance;
        private BindingSource bds = new BindingSource();
        public void ChangeHeader()
        {
            dtgv.Columns["IDStaff"].HeaderText = "ID";
            dtgv.Columns["FirstName"].HeaderText = "First Name";
            dtgv.Columns["LastName"].HeaderText = "Last Name";

        }

        public void DisableColumn()
        {
            dtgv.Columns["Year"].Visible = false;
            dtgv.Columns["Gender"].Visible = false;
            dtgv.Columns["Phone"].Visible = false;
            dtgv.Columns["Address"].Visible = false;
            dtgv.Columns["Salary"].Visible = false;
            dtgv.Columns["Image"].Visible = false;
        }
        public void LoadDtgv()
        {
            dtgv.DataSource = staffBUS.GetList();
        }
        public ChooseStaff_import(UpdateImport updateImport)
        {
            InitializeComponent();
            _updateImport = updateImport;
        }
        private void ChooseStafff_import_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            DisableColumn();
            ChangeHeader();
            dtgv.AutoGenerateColumns = false;
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _updateImport.txtStaffID.Text = dtgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }
    }
}

