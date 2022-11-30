using BUS;
using DAO;
using DTO;
using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;


namespace GUI
{
    public partial class Product : Form
    {
        private ProductBUS productBUS = new ProductBUS();
        private ProductDTO productDTO;
        private List<ProductDTO> listProduct = new List<ProductDTO>();

        public static Product _instance;

        public static Product Instance
        {
            get { if (_instance == null) _instance = new Product(); return _instance; }
            private set { _instance = value; }
        }

        public Product()
        {
            InitializeComponent();
        }

        private BindingSource _bds = new BindingSource();

        public void LoadDtgv()
        {
            listProduct = productBUS.GetList();
            _bds.DataSource = listProduct;
        }

        public void ChangeHeader()
        {
            dtgv.Columns["IDProduct"].HeaderText = "ID";
            dtgv.Columns["NameProduct"].HeaderText = "Name Product";
            dtgv.Columns["Image"].HeaderText = "";
        }

        private void createNewProduct_Click(object sender, EventArgs e)
        {

        }

        private void productPanel_Click(object sender, EventArgs e)
        {

        }

        private void Product_Load(object sender, EventArgs e)
        {
            LoadDtgv();

            dtgv.DataSource = _bds;
            dtgv.Columns["IdCategory"].Visible = false;
            dtgv.Columns["IdProducer"].Visible = false;
            dtgv.Columns["description"].Visible = false;
           // dtgv.Columns["image"].Visible = false;


            ((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;

            DataGridViewImageColumn update = new DataGridViewImageColumn();
            DataGridViewImageColumn delete = new DataGridViewImageColumn();

            // Update
            update.Name = "Data1";
            update.DataPropertyName = "Data1";
            update.HeaderText = "";
            update.ImageLayout = DataGridViewImageCellLayout.Normal;
            update.Image = Resources.icons8_pencil_drawing_30;

            // Delete
            delete.Name = "Data2";
            delete.DataPropertyName = "Data2";
            delete.HeaderText = "";
            delete.ImageLayout = DataGridViewImageCellLayout.Normal;
            delete.Image = Resources.icons8_remove_30;

            dtgv.Columns.Add(update);
            dtgv.Columns.Add(delete);

            dtgv.Columns["Image"].DisplayIndex = 0;
            dtgv.AutoGenerateColumns = false;

            dtgv.Columns[0].Width = 70; // id
            dtgv.Columns[1].Width = 350; // tensp
            dtgv.Columns[2].Width = 70; // kichthuoc
            dtgv.Columns[3].Width = 100; // soluong
            dtgv.Columns[4].Width = 100; // gia
            dtgv.Columns[5].Width = 70; // image
            dtgv.Columns[6].Width = 100; // color
            dtgv.Columns[7].Width = 50; // edit icon
            dtgv.Columns[8].Width = 50; // remove
            ChangeHeader();


        }

        public static Image GetImageFromByte(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductDetail pd = new ProductDetail();
            pd.txtNameProduct.Text = dtgv.Rows[e.RowIndex].Cells["NameProduct"].Value.ToString();
            pd.txtDescription.Text = dtgv.Rows[e.RowIndex].Cells["description"].Value.ToString();
            pd.txtColor.Text = dtgv.Rows[e.RowIndex].Cells["Color"].Value.ToString();
            pd.pbImage.Image = GetImageFromByte((byte[])dtgv.Rows[e.RowIndex].Cells["Image"].Value);
            pd.txtSize.Text = dtgv.Rows[e.RowIndex].Cells["Size"].Value.ToString();
            pd.txtPrice.Text = dtgv.Rows[e.RowIndex].Cells["Price"].Value.ToString();
            pd.panelColor.BackgroundColor = (Color)new ColorConverter().ConvertFromString(dtgv.Rows[e.RowIndex].Cells["Color"].Value.ToString());
            pd.panelSize.BackgroundColor = (Color)new ColorConverter().ConvertFromString(dtgv.Rows[e.RowIndex].Cells["Color"].Value.ToString());
            pd.ShowDialog();
        }

        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgv.Columns[e.ColumnIndex].Name;

            if (colName == "Data1")
            {
                ProductManager pm = new ProductManager(_bds, this);
                pm.btnCreateProduct.Enabled = false;
                pm.txtID.Text = dtgv.Rows[e.RowIndex].Cells["IDProduct"].Value.ToString();
                pm.txtNameProduct.Text = dtgv.Rows[e.RowIndex].Cells["NameProduct"].Value.ToString();
                pm.txtPrice.Text = dtgv.Rows[e.RowIndex].Cells["Price"].Value.ToString();
                pm.pictureAvatar.Image = GetImageFromByte((byte[])dtgv.Rows[e.RowIndex].Cells["Image"].Value);
                pm.txtDescription.Text = dtgv.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                pm.cbxSize.SelectedItem = dtgv.Rows[e.RowIndex].Cells["Size"].Value.ToString();
                pm.cbxColor.SelectedItem = dtgv.Rows[e.RowIndex].Cells["Color"].Value.ToString();
                pm.cbxCategory.Text = dtgv.Rows[e.RowIndex].Cells["IdCategory"].Value.ToString();
                pm.cbxProducer.Text = dtgv.Rows[e.RowIndex].Cells["IdProducer"].Value.ToString();
                pm.txtAmount.Text = dtgv.Rows[e.RowIndex].Cells["Amount"].Value.ToString();
                pm.ShowDialog();

            }
            else if (colName == "Data2")
            {
                if (MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productDTO = new ProductDTO(dtgv.Rows[e.RowIndex].Cells["IDProduct"].Value.ToString());
                    productBUS.Delete(productDTO);
                    MessageBox.Show("Bạn đã xóa thành công!");
                    LoadDtgv();
                }
            }
        }

        private void createNewProduct_Click_1(object sender, EventArgs e)
        {
            ProductManager pm = new ProductManager(this);
            pm.btnUpdateProduct.Enabled = false;
            pm.Show();
        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    (dtgv.DataSource as DataTable).DefaultView.RowFilter = 
            //        String.Format("NameProduct LIKE '{0}' ", searchProduct.Text);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.StackTrace);
            //}

            //_bds.Filter = dtgv.Columns[1].HeaderText.ToString() + " LIKE '%" + searchProduct.Text + "%'";
            //Console.WriteLine(dtgv.Columns[1].HeaderText.ToString() + " LIKE '%" + searchProduct.Text + "%'");
            //dtgv.DataSource = _bds;

            dtgv.DataSource = ProductDAO.Instance.FindName(searchProduct.Text); // Fix
        }

        private void priceProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtgv.DataSource = ProductDAO.Instance.FilterPrice(priceProduct.SelectedItem.ToString());
        }

        private void ToExcel(DataGridView dataGridView1, string fileName)
        {
            //khai báo thư viện hỗ trợ Microsoft.Office.Interop.Excel
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                //Tạo đối tượng COM.
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;
                //tạo mới một Workbooks bằng phương thức add()
                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];
                //đặt tên cho sheet
                worksheet.Name = "Product Management";

                // export header trong DataGridView
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                }
                // export nội dung trong DataGridView
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }
                // sử dụng phương thức SaveAs() để lưu workbook với filename
                workbook.SaveAs(fileName);
                //đóng workbook
                workbook.Close();
                excel.Quit();
                MessageBox.Show("Xuất dữ liệu ra Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }

        private void exportProduct_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //gọi hàm ToExcel() với tham số là dtgDSHS và filename từ SaveFileDialog
                ToExcel(dtgv, saveFileDialog1.FileName);
            }
        }
    }
}
