using BUS;
using ComponentFactory.Krypton.Toolkit;
using DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductManager : KryptonForm
    {
        private ProductBUS productBUS;
        private ProductDTO productDTO;
        private Product _product;
        private BindingSource _bds;

        string fileName;

        public ProductManager()
        {
            InitializeComponent();
        }

        public ProductManager(Product product)
        {
            InitializeComponent();
            productBUS = new ProductBUS();
            _product = product;
            btnUpdateProduct.Enabled = false;
            txtID.Visible = false;
        }

        public ProductManager(BindingSource bds, Product product)
        {
            InitializeComponent();
            _bds = bds;
            _product = product;
            productBUS = new ProductBUS();
            //txtID.Visible = false;
        }

        public void LoadDtgv()
        {
            _product.dtgv.DataSource = productBUS.GetList();
        }

        public void AddBinding()
        {
            //txtID.DataBindings.Add("Text", Product.Instance.dtgv.DataSource, "IDProduct", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtNameProduct.DataBindings.Add("Text", Product.Instance.dtgv.DataSource, "NameProduct", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtPrice.DataBindings.Add("Text", Product.Instance.dtgv.DataSource, "Price", true, DataSourceUpdateMode.OnPropertyChanged);
            //pictureAvatar.DataBindings.Add("Image", Product.Instance.dtgv.DataSource, "Image", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtDescription.DataBindings.Add("Text", Product.Instance.dtgv.DataSource, "Description", true, DataSourceUpdateMode.OnPropertyChanged);
            //cbxSize.DataBindings.Add("SelectedItem", Product.Instance.dtgv.DataSource, "Size", true, DataSourceUpdateMode.OnPropertyChanged);
            //cbxColor.DataBindings.Add("SelectedItem", Product.Instance.dtgv.DataSource, "Color", true, DataSourceUpdateMode.OnPropertyChanged);
            //cbxCategory.DataBindings.Add("SelectedValue", Product.Instance.dtgv.DataSource, "IdCategory", true, DataSourceUpdateMode.OnPropertyChanged);
            //cbxProducer.DataBindings.Add("SelectedValue", Product.Instance.dtgv.DataSource, "IdProducer", true, DataSourceUpdateMode.OnPropertyChanged);
            //txtAmount.DataBindings.Add("Text", Product.Instance.dtgv.DataSource, "Amount", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            byte[] arr;
            using (MemoryStream ms = new MemoryStream())
            {
                Bitmap bmp = new Bitmap(imageIn);
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                arr = ms.ToArray();
            }
            return arr;
        }


        private void btnCreateStaff_Click(object sender, EventArgs e)
        {

            MemoryStream ms = new MemoryStream();
            pictureAvatar.Image.Save(ms, pictureAvatar.Image.RawFormat);
            byte[] img = ms.ToArray();

            // 2. Initialize instance object
            productDTO =
                new ProductDTO(productBUS.getIDProduct(),
                    txtNameProduct.Text.ToString(),
                    cbxSize.SelectedItem.ToString(),
                    cbxColor.SelectedItem.ToString(),
                    txtDescription.Text.ToString(),
                    int.Parse(txtAmount.Text.ToString()),
                    double.Parse(txtPrice.Text.ToString()),
                    cbxCategory.SelectedValue.ToString(),
                    cbxProducer.SelectedValue.ToString(),
                    img
                );

            if (productBUS.Insert(productDTO))
            {

                MessageBox.Show("Insert successfull!");
                LoadDtgv();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Xu ly hoa don truoc");
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureAvatar.Image.Save(ms, pictureAvatar.Image.RawFormat);
            byte[] img = ms.ToArray();

            productDTO =
                new ProductDTO(txtID.Text.ToString(),
                    txtNameProduct.Text.ToString(),
                    cbxSize.SelectedItem.ToString(),
                    cbxColor.SelectedItem.ToString(),
                    txtDescription.Text.ToString(),
                    int.Parse(txtAmount.Text.ToString()),
                    double.Parse(txtPrice.Text.ToString()),
                    cbxCategory.SelectedValue.ToString(),
                    cbxProducer.SelectedValue.ToString(),
                    img
                );


            if (productBUS.Update(productDTO))
            {
                MessageBox.Show("Update successfull!");
                LoadDtgv();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Xu ly hoa don truoc");
            }
        }

        private void ProductManager_Load(object sender, EventArgs e)
        {
            txtID.Visible = false;

            cbxCategory.DataSource = productBUS.getCategory();
            cbxCategory.DisplayMember = "TypeName";
            cbxCategory.ValueMember = "TypeID";

            cbxProducer.DataSource = productBUS.getProducer();
            cbxProducer.DisplayMember = "ProducerName";
            cbxProducer.ValueMember = "ProducerID";

            if (_bds != null)
            {
                //LoadDtgv();
                Product.Instance.dtgv.DataSource = _bds;
                AddBinding();
            }

        }

        private void pictureAvatar_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openPicture = new OpenFileDialog();
            openPicture.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";

            if (openPicture.ShowDialog() == DialogResult.OK)
            {
                pictureAvatar.Image = Image.FromFile(openPicture.FileName);
                fileName = openPicture.FileName;
            }
            openPicture.Dispose();
        }
    }
}
