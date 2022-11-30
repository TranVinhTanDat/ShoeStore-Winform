using BUS;
using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class StatisticGUI : Form
    {
        private BindingSource bindingSource;
        List<BillDTO> listBill = new List<BillDTO>();
        List<ProductDTO> listProduct = new List<ProductDTO>();
        List<CustomerDTO> listCustomer = new List<CustomerDTO>();
        List<StaffDTO> listStaff = new List<StaffDTO>();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,
           int nTopRect,
           int nRightRect,
           int nBottomRect,
           int nWidthEllipse,
           int nHeightEllipse
        );

        public StatisticGUI()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            chartDefault.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chartDefault.Width, chartDefault.Height, 20, 20));
            chartStatistic.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, chartStatistic.Width, chartStatistic.Height, 20, 20));
            txtAll.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txtAll.Width, txtAll.Height, 20, 20));
            dtgvTop.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtgvTop.Width, dtgvTop.Height, 20, 20));

            listBill = BillBUS.Instance.GetList();
            listProduct = ProductBUS.Instance.GetList();
            listCustomer = CustomerBUS.Instance.GetList();
            listStaff = StaffBUS.Instance.GetList();
        }

        private void StatisticGUI_Load(object sender, EventArgs e)
        {
            DefaultDisplay();
            lblBill.Text = listBill.Count.ToString();
            lblProduct.Text = listProduct.Count.ToString();
            lblCustomer.Text = listCustomer.Count.ToString();
            lblStaff.Text = listStaff.Count.ToString();
        }

        private void btnStatistic_Click(object sender, EventArgs e)
        {
            //txtStatistic.Text = StatisticDAO.Instance.StatisticProduct(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList(), txtID.Text.ToString());
            //txtStatistic.Text = StatisticDAO.Instance.StatisticStaff(BillBUS.Instance.GetList(), txtID.Text.ToString());
            //txtStatistic.Text = StatisticDAO.Instance.StatisticCustomer(BillBUS.Instance.GetList(), txtID.Text.ToString());

            //txtStatistic.Text = StatisticDAO.Instance.StatisticTopProduct(BillBUS.Instance.GetList());
            //txtStatistic.Text = StatisticDAO.Instance.StatisticTopStaff(BillBUS.Instance.GetList());
            //txtStatistic.Text = StatisticDAO.Instance.StatisticTopCustomer(BillBUS.Instance.GetList());

            if (rbNormal.Checked)
            {
                if (rbProduct.Checked)
                {
                    StatisticNormalProduct();
                }
                if (rbStaff.Checked)
                {
                    StatisticNormalStaff();
                }
                if (rbCustomer.Checked)
                {
                    StatisticNormalCustomer();
                }
            }
            if (rbAll.Checked)
            {
                if (rbProduct.Checked)
                {
                    StatisticAllProduct();
                }
                if (rbStaff.Checked)
                {
                    StatisticAllStaff();
                }
                if (rbCustomer.Checked)
                {
                    StatisticAllCustomer();
                }
            }
            if (rbTop.Checked)
            {
                if (rbProduct.Checked)
                {
                    StatisticTopProduct();
                }
                if (rbStaff.Checked)
                {
                    StatisticTopStaff();
                }
                if (rbCustomer.Checked)
                {
                    StatisticTopCustomer();
                }
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DefaultDisplay();
        }

        private void btnChooseStaff_Click(object sender, EventArgs e)
        {
            SubProductGUI form = new SubProductGUI(this);
            if (!form.IsDisposed)
            {
                this.Opacity = 0.5;
            }
            form.ShowDialog();
            if (form.IsDisposed)
            {
                this.Opacity = 1;
            }
        }

        private void StatisticNormalProduct()
        {
            DataTable dt = StatisticDAO.Instance.StatisticEachProductByChart(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList(), txtID.Text.ToString());
            dt.Columns.Add("Product");
            List<AccountDTO> account = AccountBUS.Instance.GetList();
            int size = account.Count;
            foreach (DataRow row in dt.Rows)
            {
                for (int i = 0; i < size; i++)
                {
                    if (account[i].UserID.ToString() == txtID.Text.ToString())
                    {
                        row["Product"] = account[i].UserName.ToString();
                        break;
                    }
                }
            }
            dt.AcceptChanges();
            chartStatistic.DataSource = dt;
            chartStatistic.Series.Clear();
            string seryName = "";
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                if (i != 1 && i != 3 && i != 4)
                {
                    seryName = dt.Columns[i].ColumnName;
                    chartStatistic.Series.Add(seryName);
                    chartStatistic.Series[seryName].XValueMember = dt.Columns[4].ColumnName;
                    chartStatistic.Series[seryName].YValueMembers = seryName;
                    chartStatistic.Series[seryName].IsValueShownAsLabel = true;
                }
            }
            chartStatistic.Series[0].Name = "Amount Out";
            chartStatistic.Series[1].Name = "Amount In";
            chartStatistic.DataBind();
        }

        private void StatisticNormalStaff()
        {
            DataTable dt = StatisticDAO.Instance.StatisticEachStaffByChart(txtID.Text.ToString());
            chartStatistic.DataSource = dt;
            chartStatistic.Series.Clear();
            string seryName = "";
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                seryName = dt.Columns[i].ColumnName;
                chartStatistic.Series.Add(seryName);
                chartStatistic.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
                chartStatistic.Series[seryName].YValueMembers = seryName;
                chartStatistic.Series[seryName].IsValueShownAsLabel = true;
            }
            chartStatistic.Series[0].Name = "Amount Out";
            chartStatistic.ChartAreas[0].AxisX.Interval = 1;
            chartStatistic.DataBind();
        }

        private void StatisticNormalCustomer()
        {
            DataTable dt = StatisticDAO.Instance.StatisticEachCustomerByChart(txtID.Text.ToString());
            chartStatistic.DataSource = dt;
            chartStatistic.Series.Clear();
            string seryName = "";
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                seryName = dt.Columns[i].ColumnName;
                chartStatistic.Series.Add(seryName);
                chartStatistic.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
                chartStatistic.Series[seryName].YValueMembers = seryName;
                chartStatistic.Series[seryName].IsValueShownAsLabel = true;
            }
            chartStatistic.Series[0].Name = "Amount Out";
            chartStatistic.ChartAreas[0].AxisX.Interval = 1;
            chartStatistic.DataBind();
        }

        private void StatisticAllProduct()
        {
            txtAll.Clear();
            txtAll.Text = StatisticDAO.Instance.StatisticAllProduct(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList());
        }

        private void StatisticAllStaff()
        {
            txtAll.Clear();
            txtAll.Text = StatisticDAO.Instance.StatisticAllStaff(BillBUS.Instance.GetList());
        }

        private void StatisticAllCustomer()
        {
            txtAll.Clear();
            txtAll.Text = StatisticDAO.Instance.StatisticAllCustomer(BillBUS.Instance.GetList());
        }

        private void StatisticTopProduct()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatisticDAO.Instance.StatisticTopProduct(BillBUS.Instance.GetList());
            dtgvTop.DataSource = bindingSource;
        }

        private void StatisticTopStaff()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatisticDAO.Instance.StatisticTopStaff(BillBUS.Instance.GetList());
            dtgvTop.DataSource = bindingSource;
        }

        private void StatisticTopCustomer()
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = StatisticDAO.Instance.StatisticTopCustomer(BillBUS.Instance.GetList());
            dtgvTop.DataSource = bindingSource;
        }

        private void DefaultDisplay()
        {
            lblID.Text = "ID";
            txtID.Text = "";

            rbNormal.Checked = false;
            rbAll.Checked = false;
            rbTop.Checked = false;
            rbProduct.Checked = false;
            rbStaff.Checked = false;
            rbCustomer.Checked = false;

            chartDefault.Show();
            chartStatistic.Hide();
            txtAll.Hide();
            dtgvTop.Hide();

            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;

            LoadDefaultChart();
            ActiveStatistic(false);
        }

        private void LoadDefaultChart()
        {
            DataTable dt = StatisticDAO.Instance.StatisticAmountProductEachMonthByChart(BillBUS.Instance.GetList(), ImportBUS.Instance.GetList());
            chartDefault.DataSource = dt;
            chartDefault.Series.Clear();
            string seryName = "";
            for (int i = 1; i < dt.Columns.Count; i++)
            {
                seryName = dt.Columns[i].ColumnName;
                chartDefault.Series.Add(seryName);
                chartDefault.Series[seryName].XValueMember = dt.Columns[0].ColumnName;
                chartDefault.Series[seryName].YValueMembers = seryName;
                chartDefault.Series[seryName].IsValueShownAsLabel = true;
            }
            chartDefault.Series[0].Name = "Amount Out";
            chartDefault.Series[1].Name = "Amount In";
            chartDefault.ChartAreas[0].AxisX.Interval = 1;
            chartDefault.DataBind();
        }

        private void ActiveStatistic(bool active)
        {
            pnl2.Enabled = active;
            txtID.Enabled = false;
            btnChooseStaff.Enabled = false;
            dateFrom.Enabled = active;
            dateTo.Enabled = active;
            btnStatistic.Enabled = active;
            btnView.Enabled = active;
        }

        private void rbNormal_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                chartDefault.Hide();
                chartStatistic.Show();
                txtAll.Hide();
                dtgvTop.Hide();
                ActiveStatistic(true);
                txtID.Enabled = true;
                btnChooseStaff.Enabled = true;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAll.Checked)
            {
                chartDefault.Hide();
                chartStatistic.Hide();
                txtAll.Show();
                dtgvTop.Hide();
                ActiveStatistic(true);
            }
        }

        private void rbTop_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTop.Checked)
            {
                chartDefault.Hide();
                chartStatistic.Hide();
                txtAll.Hide();
                dtgvTop.Show();
                ActiveStatistic(true);
            }
        }

        private void rbProduct_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProduct.Checked)
            {
                lblID.Text = "Product ID";
            }
        }

        private void rbStaff_CheckedChanged(object sender, EventArgs e)
        {
            if (rbStaff.Checked)
            {
                lblID.Text = "Staff ID";
            }
        }

        private void rbCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomer.Checked)
            {
                lblID.Text = "Customer ID";
            }
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
            offset = offset + (int)FontHeight;
            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), startx, starty + offset);
            offset = offset + 50;
            graphics.DrawString("ProductID\t\tProductName\t\t\t\tAmout", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;

            foreach (DataGridViewRow row in dtgvTop.Rows)
            {
                graphics.DrawString(row.Cells["ProductID"].Value.ToString() + "\t\t" + row.Cells["ProductName"].Value.ToString() + "\t" + row.Cells["Amount"].Value.ToString(), new Font("Courier New", 14), new SolidBrush(Color.Black), 20, starty + offset);
                offset = offset + 35;
            }

            offset = offset + (int)FontHeight + 5;
            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;


            graphics.DrawString("---------------------------------------", font, new SolidBrush(Color.Black), 20, starty + offset);
            offset = offset + 50;
            graphics.DrawString("Thanks you buy product hawkShoes", font, new SolidBrush(Color.Black), 20, starty + offset);
        }
    }
}
