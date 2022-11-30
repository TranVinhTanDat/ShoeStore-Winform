using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ComponentFactory.Krypton.Toolkit;
using DAO;

namespace GUI
{
    public partial class UpdateImport : KryptonForm
    {
        private ImportBUS importBUS = new ImportBUS();
        public UpdateImport()
        {
            InitializeComponent();
        }
        private BindingSource _bds;
        public UpdateImport(BindingSource bds)
        {

            InitializeComponent();
            this._bds = bds;

        }
        private void UpdateImport_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            ImportManager.Instance.dtgv.DataSource = _bds;
            AddBinding();
            txtImportID.Enabled = false;
            txtTotal.Enabled = false;
        }
        public void LoadDtgv()
        {
            _bds.DataSource = ImportDAO.Instance.GetAll();
        }

        public void AddBinding()
        {
            txtImportID.DataBindings.Add("Text", ImportManager.Instance.dtgv.DataSource, "ImportID");
            txtSupplierID.DataBindings.Add("Text", ImportManager.Instance.dtgv.DataSource, "SupplierID");
            txtStaffID.DataBindings.Add("Text", ImportManager.Instance.dtgv.DataSource, "StaffID");
            txtTotal.DataBindings.Add("Text", ImportManager.Instance.dtgv.DataSource, "Total");

        }
        private void ChooseSupplier_Click(object sender, EventArgs e)
        {
            ChooseSupplier_Import a = new ChooseSupplier_Import(this);
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void ChooseStaff_Click(object sender, EventArgs e)
        {
            ChooseStaff_import a = new ChooseStaff_import(this);
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btnUpdateBill_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();

            if (importBUS.Update(txtImportID.Text, txtSupplierID.Text, txtStaffID.Text, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), double.Parse(txtTotal.Text)))
            {
                MessageBox.Show("Update successfull!");
                this.Hide();
                LoadDtgv();
            }
            else
            {
                MessageBox.Show("Xu ly phieu nhap truoc");
            }
        }
    }
}
