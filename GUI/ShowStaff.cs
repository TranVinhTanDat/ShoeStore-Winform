using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ShowStaff : KryptonForm

    {
        // List<StaffDTO> listStaff = new List<StaffDTO>();
        private StaffBUS staffBUS = new StaffBUS();
        //private CreateImports _createImport;
        private CreateImport _createImport;
        public ShowStaff(CreateImport createImport)
        {
            InitializeComponent();
            _createImport = createImport;
        }
        public void ChangeHeader()
        {
            dtgv.Columns["IDStaff"].HeaderText = "ID";
            dtgv.Columns["FirstName"].HeaderText = "First Name";
            dtgv.Columns["LastName"].HeaderText = "Last Name";
            //dtgv.Columns["Image"].HeaderText = "";
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

        private BindingSource bds = new BindingSource();
        public void LoadDtgv()
        {
            //listStaff = StaffDAO.Instance.GetAll();
            //bds.DataSource = listStaff;
            dtgv.DataSource = staffBUS.GetList();
        }
        private void ShowStaff_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            //dtgv.DataSource = bds;
            DisableColumn();
            ChangeHeader();

            //((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv.AutoGenerateColumns = false;
            //dtgv.Columns["Image"].DisplayIndex = 0;
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            _createImport.lbStaffID.Text = dtgv.Rows[e.RowIndex].Cells["IDStaff"].Value.ToString();
            _createImport.lbNameStaff.Text = dtgv.Rows[e.RowIndex].Cells["FirstName"].Value.ToString()
                + " " + dtgv.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            // _createImport.lbAddressStaff.Text = dtgv.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            _createImport.lbPhoneStaff.Text = dtgv.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            //_createImport.staffID=
            this.Hide();
        }


    }
}
