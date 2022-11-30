using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ListCustomer : KryptonForm
    {
        private CustomerBUS customerBUS = new CustomerBUS();
        private Sale _sale;

        public ListCustomer(Sale sale)
        {
            InitializeComponent();
            _sale = sale;
        }

        public ListCustomer()
        {
            InitializeComponent();
        }

        public void ChangeHeader()
        {
            dtgv.Columns["CustomerID1"].HeaderText = "ID";
            dtgv.Columns["CustomerSurname1"].HeaderText = "First Name";
            dtgv.Columns["CustomerName1"].HeaderText = "Last Name";
            dtgv.Columns["PhoneNumber1"].HeaderText = "Phone";
            dtgv.Columns["Address1"].HeaderText = "Address";
            //dtgv.Columns["Image"].HeaderText = "";
        }

        public void DisableColumn()
        {
            dtgv.Columns["Gender1"].Visible = false;
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = customerBUS.GetList();
            DisableColumn();
            ChangeHeader();

            //((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv.AutoGenerateColumns = false;
            //dtgv.Columns["Image"].DisplayIndex = 0;
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _sale.lblName.Text = dtgv.Rows[e.RowIndex].Cells["CustomerSurname1"].Value.ToString()
                + " " + dtgv.Rows[e.RowIndex].Cells["CustomerName1"].Value.ToString();
            _sale.lblAddress.Text = dtgv.Rows[e.RowIndex].Cells["Address1"].Value.ToString();
            _sale.lblPhone.Text = dtgv.Rows[e.RowIndex].Cells["PhoneNumber1"].Value.ToString();

            _sale.customerID = dtgv.Rows[e.RowIndex].Cells["CustomerID1"].Value.ToString();
            this.Hide();
        }
    }
}
