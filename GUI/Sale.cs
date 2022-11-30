using BUS;
using DAO;
using DTO;
using GUI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class Sale : Form
    {
        private BillDTO billDTO = new BillDTO();
        private BillDetailDTO billDetailDTO;
        private BillBUS billBUS = new BillBUS();
        private BillDetailBUS billDetailBUS = new BillDetailBUS();
        private List<BillDTO> billDTOs = new List<BillDTO>();
        private List<BillDetailDTO> billDetailDTOs = new List<BillDetailDTO>();
        private ProductDAO productDAO= new ProductDAO();

        public string customerID;
        public string staffID;

        public Sale()
        {
            InitializeComponent();
        }


        private void label12_Click(object sender, EventArgs e)
        {
            ListStaff ls = new ListStaff(this);
            ls.Show();
        }

        private void lbNameStaff_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {
            ListProduct ls = new ListProduct(this);
            ls.Show();
        }

        private void bunifuPanel2_Click(object sender, EventArgs e)
        {

        }

        private void dtgv_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgv.CurrentCell.ColumnIndex == 2)
            {
                if (dtgv.Rows[e.RowIndex].Cells[2].Value.ToString() != "")
                {
                    if (System.Text.RegularExpressions.Regex.IsMatch(dtgv.Rows[e.RowIndex].Cells[2].Value.ToString(), @"^[0-9]*(?:\.[0-9]*)?$"))
                    {
                        MessageBox.Show("Gia tri nhap khong hop le");
                        dtgv.Rows[e.RowIndex].Cells[2].Value = "1"; // Fix
                    }
                    else if (int.Parse(dtgv.Rows[e.RowIndex].Cells[2].Value.ToString()) > int.Parse(dtgv.Rows[e.RowIndex].Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("So luong ban nhap nhieu hon san pham trong kho");  // Fix
                        dtgv.Rows[e.RowIndex].Cells[2].Value = "1"; // Fix
                    }
                    //dtgv.Rows[e.RowIndex].Cells[2].Value = 1;
                }
            }

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["Price"].Value);
            }

        }

        private void dtgv_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            double subTotal = 0;

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["Price"].Value);

                subTotal += double.Parse(row.Cells["Total"].Value.ToString());
                lbSubTotal.Text = subTotal.ToString();
            }
            lbTotal.Text = ((subTotal * 1.05) + 9).ToString();
        }

        private void dtgv_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            double subTotal = 0;
            foreach (DataGridViewRow row in dtgv.Rows)
            {
                row.Cells["Total"].Value = Convert.ToInt32(row.Cells["Quantity"].Value) *
                    Convert.ToDouble(row.Cells["Price"].Value);

                subTotal += double.Parse(row.Cells["Total"].Value.ToString());
                lbSubTotal.Text = subTotal.ToString();
            }

            lbTotal.Text = ((subTotal * 1.05) + 9).ToString();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            ListCustomer lc = new ListCustomer(this);
            lc.Show();
        }

        private void Sale_Load(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDateTime.Text = DateTime.Now.ToString("ddd, MMM dd, yyyy, h:mm:ss tt");
        }

        private void btnSaveSale_Click(object sender, EventArgs e)
        {
            // Fix
            if (!(customerID != null))
            {
                MessageBox.Show("Ban chua chon khach hang de nhap");
                return;
            }

            // Fix
            if (!(staffID != null))
            {
                MessageBox.Show("Ban chua chon nhan vien xuat hoa don");
                return;
            }

            // Fix
            if (cbxPayment.SelectedIndex == -1)
            {
                MessageBox.Show("Ban chua chon phuong thuc thanh toan");
                return;
            }

            bool flag = false;
            string billOrder = billBUS.getIDBill();

            billDTO.BillID = billOrder;
            billDTO.CustomerID = customerID;
            billDTO.StaffID = staffID;
            billDTO.Total = double.Parse(lbTotal.Text.ToString());

            foreach (DataGridViewRow row in dtgv.Rows)
            {

                billDetailDTOs.Add(new BillDetailDTO(billOrder,
                    row.Cells["IDProduct"].Value.ToString(),
                    int.Parse(row.Cells["Quantity"].Value.ToString()),
                    double.Parse(row.Cells["Price"].Value.ToString())
                ));

                productDAO.UpdateQuantity(row.Cells["IDProduct"].Value.ToString(),
                    int.Parse(row.Cells["Inventory"].Value.ToString()) - int.Parse(row.Cells["Quantity"].Value.ToString())
                    );
            }

            billBUS.Insert(billDTO.BillID, billDTO.CustomerID, billDTO.StaffID, billDTO.Total);

            foreach (BillDetailDTO billDetail in billDetailDTOs)
            {
                if (billDetailBUS.Insert(billDetail.BillID, billDetail.ProductID, billDetail.Quantity, billDetail.UnitPrice))
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
                MessageBox.Show("Da them hoa don!");
            }

        }

        private void printInvoice_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 14);
            float fontHeight = font.GetHeight();
            int startx = 190;
            int starty = 40;
            int offset = 30;

            float leftmargin = e.MarginBounds.Left;
            float topmargin = e.MarginBounds.Top;
            graphics.DrawString("WELCOME TO SHOES HAWK STORE", new Font("Courier New", 20), new SolidBrush(Color.Black), startx, starty);
            string top = "DATE:" + lbDateTime.Text.PadRight(5);
            graphics.DrawString(top, font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + (int)FontHeight;
            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 50;
            graphics.DrawString("Name Product\t\t\t\t\tQuantity\tPrice\tTotal", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;

            foreach (DataGridViewRow row in dtgv.Rows)
            {
                graphics.DrawString(row.Cells["NameProduct"].Value.ToString() + "\t\t" + row.Cells["Quantity"].Value.ToString() + "\t" + row.Cells["Price"].Value.ToString() + "\t" + row.Cells["Total"].Value.ToString(), new Font("Courier New", 14), new SolidBrush(Color.Black), 20, starty + offset);
                offset = offset + 35;
            }

            offset = offset + (int)FontHeight + 5;
            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;

            graphics.DrawString("SUB TOTAL_Rs-" + lbSubTotal.Text + ".00", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;


            graphics.DrawString("SHIPPING_Rs-9.00", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;

            graphics.DrawString("VAT_Rs-0.05%", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;

            graphics.DrawString("TOTAL SHOES_Rs-" + lbTotal.Text + ".00", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 35;

            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;
            graphics.DrawString("Thanks you buy product hawkShoes", font, new SolidBrush(Color.Black), 20, starty + offset);
        }

        private void bunifuDropdown1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPayment.Text = cbxPayment.SelectedItem.ToString();
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (txtDeliver.Text.Length > 0)
            {
                shippingCost.Text = "9";
            }
            else
            {
                shippingCost.Text = "0";
            }
        }
    }
}
