using ComponentFactory.Krypton.Toolkit;
using System;

namespace GUI
{
    public partial class ImportDetail : KryptonForm
    {
        public static ImportDetail _instance;
        //List<ImportDetailDTO> listImportDetail = new List<ImportDetailDTO>();
        public static ImportDetail Instance
        {
            get { if (_instance == null) _instance = new ImportDetail(); return _instance; }
            private set { _instance = value; }
        }

        public ImportDetail()
        {
            InitializeComponent();
        }

        public void ChangeHeader()
        {
            dtgvDetail.Columns["ImportID"].HeaderText = "ImportID";
            dtgvDetail.Columns["ProductID"].HeaderText = "ProductID";
            dtgvDetail.Columns["Quantity"].HeaderText = "Quantity";
            dtgvDetail.Columns["UnitPrice"].HeaderText = "UnitPrice";
        }

        /*public string ImportID;
        public string Unitprice;
        public string ProductID;
        public string Quantity;*/

        private void ImportDetail_Load(object sender, EventArgs e)
        {
            //dtgvDetail.Columns[0].Width = 20; // IDimport
            //dtgvDetail.Columns[1].Width = 20; // IDproduct
            //dtgvDetail.Columns[2].Width = 20; //  quantity
            //dtgvDetail.Columns[3].Width = 100; // unitprice
            //ChangeHeader();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
