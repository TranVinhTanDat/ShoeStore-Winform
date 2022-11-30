using BUS;
using ComponentFactory.Krypton.Toolkit;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChooseSupplier_Import : KryptonForm
    {
        private SupplierBUS supplierBUS = new SupplierBUS();
        private UpdateImport _updateImport;
        private BindingSource bds = new BindingSource();
        List<SupplierDTOs> listSupplier = new List<SupplierDTOs>();
        public ChooseSupplier_Import(UpdateImport updateImport)
        {
            InitializeComponent();
            this._updateImport = updateImport;
        }
        public void ChangeHeader()
        {
            dtgv.Columns["SupplierID"].HeaderText = "SupplierID";
            dtgv.Columns["SupplierName"].HeaderText = "SupplierName";

        }
        public void LoadDtgv()
        {
            listSupplier = SupplierDAOs.Instance.GetAll();
            bds.DataSource = listSupplier;
        }
        private void ChooseSupplier_Import_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            dtgv.Columns["SupplierID"].Width = 100; // id
            dtgv.Columns["SupplierName"].Width = 100; // name
            dtgv.Columns["Address"].Visible = false;
            dtgv.Columns["Phone"].Visible = false;
            dtgv.Columns["FaxNumber"].Visible = false;
            ChangeHeader();
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _updateImport.txtSupplierID.Text = dtgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
        }
    }
}
