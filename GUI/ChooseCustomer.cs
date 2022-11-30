using ComponentFactory.Krypton.Toolkit;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class ChooseCustomer : KryptonForm
    {
        private BillUpdate _billUpdate;
        public static ChooseCustomer _instance;

        /*public static ChooseCustomer Instance
        {
            get { if (_instance == null) _instance = new ChooseCustomer(); return _instance; }
            private set { _instance = value; }
        }*/
        List<CustomersDTO> listCustomer = new List<CustomersDTO>();
        public ChooseCustomer(BillUpdate billUpdate)
        {
            InitializeComponent();
            _billUpdate = billUpdate;
        }
        private BindingSource bds = new BindingSource();
        public void LoadDtgv()
        {
            listCustomer = CustomersDAO.Instance.GetAll();
            bds.DataSource = listCustomer;
        }

        private void ChooseCustomer_Load(object sender, EventArgs e)
        {
            LoadDtgv();
            dtgv.DataSource = bds;
            dtgv.Columns["CustomerID"].Width = 100; // id
            dtgv.Columns["CustomerSurname"].Width = 100; // firstname
            dtgv.Columns["CustomerName"].Width = 100; //  ln
            dtgv.Columns["Gender"].Visible = false;
            dtgv.Columns["Phone"].Visible = false;
            dtgv.Columns["Address"].Visible = false;
            ChangeHeader();

        }
        public void ChangeHeader()
        {
            dtgv.Columns["CustomerID"].HeaderText = "CustomerID";
            dtgv.Columns["CustomerSurname"].HeaderText = "CustomerSurname";
            dtgv.Columns["CustomerName"].HeaderText = "CustomerName";

        }
        public string BillID;
        public string StaffID;
        public string Total;
        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //BillUpdate p = new BillUpdate();
            //p.txtCustomerID.Text = dtgv.Rows[e.RowIndex].Cells[0].Value.ToString();

            // p.txtBillID.Text = BillID;
            // p.txtTotal.Text = Total;
            // p.txtStaffID.Text = StaffID;
            _billUpdate.txtCustomerID.Text = dtgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            this.Hide();
            _billUpdate.Show();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            _billUpdate.Show();
        }


    }
}
