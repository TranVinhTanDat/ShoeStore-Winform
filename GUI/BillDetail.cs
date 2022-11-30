using ComponentFactory.Krypton.Toolkit;
using System;

namespace GUI
{
    public partial class BillDetail : KryptonForm
    {
        public static BillDetail _instance;

        public static BillDetail Instance
        {
            get { if (_instance == null) _instance = new BillDetail(); return _instance; }
            private set { _instance = value; }
        }


        /* public DataTable CreateDataTable()
         {
             DataTable dataTable = new DataTable();
             dataTable = BillDetailDAO.Instance.SearchBill();
             return dataTable;

         }*/
        public BillDetail()
        {
            InitializeComponent();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BillDetail_Load(object sender, EventArgs e)
        {

            dtgv.Columns[0].Width = 20; // billid
            dtgv.Columns[1].Width = 20; // productid
            dtgv.Columns[2].Width = 20; // quantity
            dtgv.Columns[3].Width = 100; //unitprice
            ChangeHeader();

        }
        public void ChangeHeader()
        {
            dtgv.Columns["BillID"].HeaderText = "BillID";
            dtgv.Columns["ProductID"].HeaderText = "ProductID";
            dtgv.Columns["Quantity"].HeaderText = "Quantity";
            dtgv.Columns["UnitPrice"].HeaderText = "UnitPrice";

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dtgv_CellContentClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

        }
    }
}
