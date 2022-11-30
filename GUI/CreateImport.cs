using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateImport : KryptonForm
    {
        private ImportDTO importDTO = new ImportDTO();
        private ImportDetailDTO importDetailDTO;
        private ImportBUS importBUS = new ImportBUS();
        private ImportDetailBUS importDetailBUS = new ImportDetailBUS();
        private List<ImportDTO> importDTOs = new List<ImportDTO>();
        private List<ImportDetailDTO> importDetailDTOs = new List<ImportDetailDTO>();
        public string supplierID;
        public string staffID;
        public CreateImport()
        {
            InitializeComponent();
        }
        public static CreateImport _instance;

        public static CreateImport Instance
        {
            get { if (_instance == null) _instance = new CreateImport(); return _instance; }
            private set { _instance = value; }
        }
        private void CreateImport_Load(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
            dtgv.AutoGenerateColumns = false;
        }

        private void labSupplier_Click(object sender, EventArgs e)
        {
            ShowSupplier sp = new ShowSupplier(this);
            sp.Show();
        }

        private void labStaff_Click(object sender, EventArgs e)
        {
            ShowStaff st = new ShowStaff(this);
            st.Show();

        }

        private void lbProduct_Click(object sender, EventArgs e)
        {
            ProductLists p = new ProductLists(this);
            //this.Hide();
            p.Show();

        }
        private void dtgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv.CurrentCell.ColumnIndex == 2)
            {
                if (dtgv.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(dtgv.Rows[e.RowIndex].Cells[0].Value.ToString(), @"^[0-9]*(?:\.[0-9]*)?$"))
                    {
                        MessageBox.Show("Gia tri nhap khong hop le");
                    }
                    else
                    {
                        //dtgv.Rows[e.RowIndex].Cells[2].Value = "0";
                    }
                }
            }

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["UnitPrice"].Value);
            }
        }

        private void dtgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double subTotal = 0;

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["UnitPrice"].Value);

                subTotal += double.Parse(row.Cells["Total"].Value.ToString());
                lbSubTotal.Text = subTotal.ToString();
            }
            lblTotal.Text = ((subTotal * 1.05) + 10).ToString();
        }



        private void dtgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            double subTotal = 0;
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["UnitPrice"].Value);

                subTotal += double.Parse(row.Cells["Total"].Value.ToString());
                lbSubTotal.Text = subTotal.ToString();
            }

            lblTotal.Text = ((subTotal * 1.05) + 10).ToString();
        }

        private void Import_Save_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string importOrder = importBUS.getIDImport();

            importDTO.ImportID = importOrder;
            importDTO.SupplierID = supplierID;
            //importDTO.StaffID = staffID;
            importDTO.StaffID = lbStaffID.Text;
            importDTO.Total = double.Parse(lblTotal.Text.ToString());

            foreach (DataGridViewRow row in dtgv.Rows)
            {

                importDetailDTOs.Add(new ImportDetailDTO(importOrder,
                    row.Cells["ProductID"].Value.ToString(),
                    int.Parse(row.Cells["Quantity"].Value.ToString()),
                    double.Parse(row.Cells["UnitPrice"].Value.ToString())
                ));
            }

            importBUS.Insert(importDTO.ImportID, importDTO.SupplierID, importDTO.StaffID, importDTO.Total);

            foreach (ImportDetailDTO importDetail in importDetailDTOs)
            {
                if (importDetailBUS.Insert(importDetail.ImportID, importDetail.ProductID, importDetail.Quantity, importDetail.UnitPrice))
                {
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Xu ly hoa don truoc");
                }
            }

            if (flag)
            {
                MessageBox.Show("Da them phieu nhap!");
            }

        }

        private void btnImportSave_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string importOrder = importBUS.getIDImport();

            importDTO.ImportID = importOrder;
            importDTO.SupplierID = supplierID;
            //importDTO.StaffID = staffID;
            importDTO.StaffID = lbStaffID.Text;
            importDTO.Total = double.Parse(lblTotal.Text.ToString());

            foreach (DataGridViewRow row in dtgv.Rows)
            {

                importDetailDTOs.Add(new ImportDetailDTO(importOrder,
                    row.Cells["ProductID"].Value.ToString(),
                    int.Parse(row.Cells["Quantity"].Value.ToString()),
                    double.Parse(row.Cells["UnitPrice"].Value.ToString())
                ));
            }

            importBUS.Insert(importDTO.ImportID, importDTO.SupplierID, importDTO.StaffID, importDTO.Total);

            foreach (ImportDetailDTO importDetail in importDetailDTOs)
            {
                if (importDetailBUS.Insert(importDetail.ImportID, importDetail.ProductID, importDetail.Quantity, importDetail.UnitPrice))
                {
                    flag = true;
                }
                else
                {
                    MessageBox.Show("Xu ly hoa don truoc");
                }
            }

            if (flag)
            {
                MessageBox.Show("Da them phieu nhap!");
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
        }

        private void bunifuPanel6_Click(object sender, EventArgs e)
        {

        }
    }
}
