using BUS;
using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace GUI
{
    public partial class ListStaff : KryptonForm
    {
        private StaffBUS staffBUS = new StaffBUS();
        private Sale _sale;
        public ListStaff()
        {
            InitializeComponent();
        }

        public ListStaff(Sale sale)
        {
            InitializeComponent();
            _sale = sale;
        }

        public void ChangeHeader()
        {
            dtgv.Columns["IDStaff"].HeaderText = "ID";
            dtgv.Columns["FirstName"].HeaderText = "First Name";
            dtgv.Columns["LastName"].HeaderText = "Last Name";
            dtgv.Columns["Image"].HeaderText = "";
        }

        public void DisableColumn()
        {
            dtgv.Columns["Year"].Visible = false;
            dtgv.Columns["Gender"].Visible = false;
            dtgv.Columns["Salary"].Visible = false;
            dtgv.Columns["Image"].Visible = false;
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListStaff_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = staffBUS.GetList();
            DisableColumn();
            ChangeHeader();

            //((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
            dtgv.AutoGenerateColumns = false;
            dtgv.Columns["Image"].DisplayIndex = 0;
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _sale.lbNameStaff.Text = dtgv.Rows[e.RowIndex].Cells["FirstName"].Value.ToString()
                + " " + dtgv.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
            _sale.lbAddressStaff.Text = dtgv.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            _sale.lbPhoneStaff.Text = dtgv.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
            _sale.staffID = dtgv.Rows[e.RowIndex].Cells["IDStaff"].Value.ToString();
            this.Hide();
        }
    }
}
