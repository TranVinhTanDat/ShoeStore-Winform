using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ShowSupplier : KryptonForm
    {
        //List<SupplierDTO> listSupplier = new List<SupplierDTO>();
        private SupplierBUSs supplierBUS = new SupplierBUSs();
        private CreateImport _createImport;
        private BindingSource bds = new BindingSource();
        public ShowSupplier(CreateImport createImport)
        {
            InitializeComponent();
            this._createImport = createImport;
        }
        public void ChangeHeader()
        {
            dtgv.Columns["SupplierID"].HeaderText = "SupplierID";
            dtgv.Columns["SupplierName"].HeaderText = "SupplierName";
            dtgv.Columns["Address"].HeaderText = "Address";
            dtgv.Columns["Phone"].HeaderText = "Phone";
            dtgv.Columns["FaxNumber"].HeaderText = "Fax Number";

        }
        public void LoadDtgv()
        {
            bds.DataSource = supplierBUS.GetList();

        }
        private void ShowSupplier_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            ChangeHeader();

            //((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv.AutoGenerateColumns = false;
            //dtgv.Columns["Image"].DisplayIndex = 0;

        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _createImport.lbSuppilerName.Text = dtgv.Rows[e.RowIndex].Cells["SupplierName"].Value.ToString();
            _createImport.lbSupplierPhone.Text = dtgv.Rows[e.RowIndex].Cells["Phone"].Value.ToString();

            _createImport.lbFax.Text = dtgv.Rows[e.RowIndex].Cells["FaxNumber"].Value.ToString();
            _createImport.supplierID = dtgv.Rows[e.RowIndex].Cells["SupplierID"].Value.ToString();
            this.Hide();
        }


    }
}
