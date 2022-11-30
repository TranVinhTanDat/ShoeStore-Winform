using DAO;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI
{
    public partial class SubFuncGUI : Form
    {
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

        public SubFuncGUI()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (RoleFuncGUI.InsertOrUpdate)
            {
                if (FunctionDAO.Instance.InsertFunction(txtID.Text.ToString(), txtName.Text.ToString()) != null)
                {
                    MessageBox.Show("Insert Successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Insert Failed");
                }
            }
            else
            {
                if (FunctionDAO.Instance.UpdateFunction(txtID.Text.ToString(), txtName.Text.ToString()) != null)
                {
                    MessageBox.Show("Update Successful");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Update Failed");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
