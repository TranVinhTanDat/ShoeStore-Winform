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
    public partial class StaffGUI : Form
    {
        private StaffBUS staffBUS;
        public static StaffGUI _instance;

        public static StaffGUI Instance
        {
            get { if (_instance == null) _instance = new StaffGUI(); return _instance; }
            private set { _instance = value; }
        }

        List<StaffDTO> listStaff = new List<StaffDTO>();

        public StaffGUI()
        {
            InitializeComponent();
            staffBUS = new StaffBUS();
        }

        private BindingSource bds = new BindingSource();

        public void LoadDtgv()
        {
            listStaff = staffBUS.GetList();
            dtgv.DataSource = listStaff;
        }

        public void ChangeHeader()
        {
            dtgv.Columns["IDStaff"].HeaderText = "ID";
            dtgv.Columns["FirstName"].HeaderText = "First Name";
            dtgv.Columns["LastName"].HeaderText = "Last Name";
            dtgv.Columns["Image"].HeaderText = "";
        }


        private void Staff_Load(object sender, EventArgs e)
        {
            LoadDtgv();
          //  dtgv.DataSource = listStaff;

            //DataGridViewImageColumn image = new DataGridViewImageColumn();
            DataGridViewImageColumn update = new DataGridViewImageColumn();
            DataGridViewImageColumn delete = new DataGridViewImageColumn();

            // Avatar
            //image.Name = "Data";
            //image.DataPropertyName = "Data";
            //image.HeaderText = "";
            //image.ImageLayout = DataGridViewImageCellLayout.Normal;
            //image.Image = null;
            //dtgv.Columns.Insert(0, image);

            dtgv.Columns["Year"].Visible = false;
            dtgv.Columns["Gender"].Visible = false;
            //dtgv.Columns["Image"].Visible = false;
            dtgv.Columns["UserID"].Visible = false; // Fix

            // Update
            update.Name = "Data1";
            update.DataPropertyName = "Data1";
            update.HeaderText = "";
            update.ImageLayout = DataGridViewImageCellLayout.Normal;
            dtgv.Columns.Add(update);
            update.Image = Resources.icons8_pencil_drawing_30;

            // Delete
            delete.Name = "Data2";
            delete.DataPropertyName = "Data2";
            delete.HeaderText = "";
            delete.ImageLayout = DataGridViewImageCellLayout.Normal;
            dtgv.Columns.Add(delete);
            delete.Image = Resources.icons8_remove_30;

            dtgv.AutoGenerateColumns = false;
            dtgv.Columns["Image"].DisplayIndex = 0;
            ((DataGridViewImageColumn)dtgv.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Normal;

            dtgv.Columns[0].Width = 70; // id
            dtgv.Columns[1].Width = 200; // fn
            dtgv.Columns[2].Width = 100; // ln
            dtgv.Columns[3].Width = 100; // phone
            dtgv.Columns[4].Width = 100;
            dtgv.Columns[5].Width = 100; // phone
            dtgv.Columns[6].Width = 350; // address
            dtgv.Columns[7].Width = 100;
            dtgv.Columns[8].Width = 50; // avatar
            ChangeHeader();
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
        public static Image GetImageFromByte(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            Image returnImage = Image.FromStream(ms);
            return returnImage;
        }
        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgv.Columns[e.ColumnIndex].Name;

            if (colName == "Data1")
            {
                StaffManager p = new StaffManager(bds, this);
                //this.Hide();

                p.txtID.Text = dtgv.Rows[e.RowIndex].Cells["IDStaff"].Value.ToString();
                p.txtFirstName.Text = dtgv.Rows[e.RowIndex].Cells["FirstName"].Value.ToString();
                p.txtLastName.Text = dtgv.Rows[e.RowIndex].Cells["LastName"].Value.ToString();
                p.txtYear.Text = dtgv.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                p.cbxGender.SelectedItem = dtgv.Rows[e.RowIndex].Cells["Gender"].Value.ToString();
                p.txtPhone.Text = dtgv.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                p.txtAddress.Text = dtgv.Rows[e.RowIndex].Cells["Address"].Value.ToString();
                p.txtSalary.Text = dtgv.Rows[e.RowIndex].Cells["Salary"].Value.ToString();
                p.pictureAvatar.Image = GetImageFromByte((byte[])dtgv.Rows[e.RowIndex].Cells["Image"].Value);

                p.btnCreateStaff.Enabled = false;
                p.ShowDialog();
                //this.Show();
            }
            else if (colName == "Data2")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (StaffDAO.Instance.Delete(dtgv.Rows[e.RowIndex].Cells["IDStaff"].Value.ToString())) ;
                    {
                        MessageBox.Show("Bạn đã xóa thành công!");
                        LoadDtgv();
                    }
                }
                {
                    // Cell 1 is ID columns

                }
            }
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
                worksheet.Name = "Staff Management";

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

        private void createNewProduct_Click(object sender, EventArgs e)
        {
            StaffManager sm = new StaffManager(this);
            sm.ShowDialog();
        }

        private void searchStaff_TextChanged(object sender, EventArgs e)
        {
            //bds.DataSource = StaffDAO.Instance.FindName(searchProduct.Text);
            //string col = dtgv.Columns[4].Name;
            //string search = string.Format(col + " LIKE '%{0}%'", searchStaff.Text);

            //(dtgv.DataSource as DataTable).DefaultView.RowFilter = string.Format(col + " LIKE '%{0}%'", searchStaff.Text);

            //bds.Filter = search;
            //dtgv.DataSource = bds;

          //  string sKeyword = searchStaff.Text.Trim();

            dtgv.DataSource = StaffDAO.Instance.FindName(searchStaff.Text); // Fix


        }

        private void dtgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
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
