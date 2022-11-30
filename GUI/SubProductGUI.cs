using BUS;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubProductGUI : Form
    {
        private StatisticGUI statisticGUI;
        BindingSource bindingSource;
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

        public SubProductGUI(StatisticGUI statisticGUI)
        {
            InitializeComponent();
            this.statisticGUI = statisticGUI;
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

        private void SubStaffGUI_Load(object sender, EventArgs e)
        {
            bindingSource = new BindingSource();
            bindingSource.DataSource = ProductBUS.Instance.GetList();
            dtgvProduct.DataSource = bindingSource;
            ((DataGridViewImageColumn)dtgvProduct.Columns["Image"]).ImageLayout = DataGridViewImageCellLayout.Stretch;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            statisticGUI.txtID.Text = dtgvProduct.CurrentRow.Cells["idProduct"].Value.ToString();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
