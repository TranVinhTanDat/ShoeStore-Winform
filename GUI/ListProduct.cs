using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class ListProduct : KryptonForm
    {
        private ProductBUS productBUS;
        private BillDetailDTO billDetailDTO;
        private List<BillDetailDTO> billDetailList;
        private Sale _sale;
        public ListProduct()
        {
            InitializeComponent();
            productBUS = new ProductBUS();
        }

        public ListProduct(Sale sale)
        {
            InitializeComponent();
            productBUS = new ProductBUS();
            billDetailDTO = new BillDetailDTO();
            billDetailList = new List<BillDetailDTO>();

            _sale = sale;
        }

        //public ListProduct(CreateImport import)
        //{
        //    InitializeComponent();
        //    productBUS = new ProductBUS();
        //    billDetailDTO = new BillDetailDTO();
        //    billDetailList = new List<BillDetailDTO>();

        //    _sale = sale;
        //}

        public void ChangeHeader()
        {
            dtgv.Columns["IDProduct"].HeaderText = "ID";
            dtgv.Columns["NameProduct"].HeaderText = "Name Product";
            dtgv.Columns["Image"].HeaderText = "";
        }

        public void DisableColumn()
        {
            dtgv.Columns["Size"].Visible = false;
            dtgv.Columns["Color"].Visible = false;
            dtgv.Columns["Amount"].Visible = false;
            dtgv.Columns["Description"].Visible = false;
            dtgv.Columns["IDCategory"].Visible = false;
            dtgv.Columns["IDProducer"].Visible = false;
        }

        private void ListProduct_Load(object sender, EventArgs e)
        {
            dtgv.DataSource = productBUS.GetList();
            ChangeHeader();
            DisableColumn();

            ((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;


            dtgv.AutoGenerateColumns = false;
            dtgv.Columns["Image"].DisplayIndex = 0;

            dtgv.Columns[0].FillWeight = 70;
            dtgv.Columns[1].FillWeight = 270;
            dtgv.Columns[2].FillWeight = 190;
            dtgv.Columns[3].FillWeight = 20;
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }


        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ind = e.RowIndex;
            int quantity = 1;
            bool inCart = true;

            DataGridViewRow selectedRows = dtgv.Rows[ind];

            billDetailDTO.ProductID = selectedRows.Cells["IDProduct"].Value.ToString();
            billDetailDTO.ProductName = selectedRows.Cells["NameProduct"].Value.ToString();
            //billDetailDTO.Image = Encoding.ASCII.GetBytes(selectedRows.Cells["Image"].Value.ToString());
            billDetailDTO.UnitPrice = double.Parse(selectedRows.Cells["Price"].Value.ToString());
            billDetailDTO.Quantity = quantity;
            billDetailDTO.Inventory = int.Parse(selectedRows.Cells["Amount"].Value.ToString());   // Fix inventory


            foreach (DataGridViewRow row in _sale.dtgv.Rows)
            {
                if (row.Cells["IDProduct"].Value == null)
                {
                    row.Cells["IDProduct"].Value = "";
                }

                if (row.Cells["IDProduct"].Value.ToString() == selectedRows.Cells["IDProduct"].Value.ToString())
                {
                    row.Cells["Quantity"].Value = int.Parse(row.Cells["Quantity"].Value.ToString()) + 1;
                    inCart = false;
                }
            }

            if (inCart)
            {
                billDetailList.Add(billDetailDTO);
            }

            foreach (BillDetailDTO billDetail in billDetailList)
            {
                _sale.dtgv.Rows.Add(
                    billDetail.ProductID,
                    billDetail.ProductName,
                    billDetail.Quantity,
                    billDetail.Inventory,   // Fix inventory
                    billDetail.UnitPrice,
                    billDetail.Quantity * billDetail.UnitPrice
                );
            }
            this.Hide();

        }
    }
}
