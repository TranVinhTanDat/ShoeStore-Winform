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
using DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComponentFactory.Krypton.Toolkit;
using BUS;


namespace GUI
{
    public partial class BillUpdate : KryptonForm
    {
        private BillBUS billBUS = new BillBUS();
        public BillUpdate()
        {
            InitializeComponent();
            //btnUpdateBill.Enabled = false;
           

        }
        private BindingSource _bds;
        public BillUpdate(BindingSource bds)
        {
            
           
                InitializeComponent();
                this._bds = bds;
                txtBillID.Enabled = false;

        }
       
        private void BillUpdate_Load(object sender, EventArgs e)
        {
            txtBillID.Enabled=false;   
            txtTotal.Enabled=false;

            //LoadDtgv();
            BillManagerGUI.Instance.dtgv.DataSource = _bds;
             
            //AddBinding();

        }
        //public void LoadDtgv()
        //{
            //_bds.DataSource = BillDAO.Instance.GetAll();
       // }
       /* public void AddBinding()
        {
            txtBillID.DataBindings.Add("Text", Bills.Instance.dtgv.DataSource, "BillID");
            //txtCustomerID.DataBindings.Add("Text", Bills.Instance.dtgv.DataSource, "CustomerID");
            //txtStaffID.DataBindings.Add("Text", Bills.Instance.dtgv.DataSource, "StaffID");
            txtCreateTime.DataBindings.Add("Text", Bills.Instance.dtgv.DataSource, "CreateTime");
            txtTotal.DataBindings.Add("Text", Bills.Instance.dtgv.DataSource, "Total");*/
        private void ChooseCustomer_Click_1(object sender, EventArgs e)
        {
            ChooseCustomer a = new ChooseCustomer(this);
            //a.BillID = txtBillID.Text;
            //a.Total = txtTotal.Text;
            //a.StaffID=txtStaffID.Text;
            this.Hide();
            a.ShowDialog();
            this.Show();

        }

        
        private void ChooseStaff_Click(object sender, EventArgs e)
        {
            ChooseStaff a = new ChooseStaff(this);
            // a.BillID=txtBillID.Text;
            //a.Total=txtTotal.Text;
            // a.CustomerID=txtCustomerID.Text;
            this.Hide();
            a.ShowDialog();
            this.Show();
        }

        private void btnUpdateBill_Click_1(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            //DateTime now = new DateTime ();
            //now= DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
            //Console.WriteLine(now.ToString());
            //Console.WriteLine(now.ToString());
            if (billBUS.Update(txtBillID.Text, txtCustomerID.Text, txtStaffID.Text, 
                DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), double.Parse(txtTotal.Text)))
            {
                MessageBox.Show("Update successfull!");
                this.Hide();

            }
            else
            {
                MessageBox.Show("Xu ly hoa don truoc");
            }
        }
    }
}
