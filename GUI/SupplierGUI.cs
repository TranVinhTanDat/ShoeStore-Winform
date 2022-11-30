using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class SupplierGUI : Form
    {
        public SupplierGUI()
        {
            InitializeComponent();
        }

        private void FrmSUP_Load(object sender, EventArgs e)
        {
            ShowListSUP();
            Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //########################
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //###############################################
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //############################################
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //#################################################
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            //#####################################
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            txtID_item.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtName_item.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtPhone_item.Text = listView1.SelectedItems[0].SubItems[2].Text;

            txtAddress_item.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtFax_item.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {
            //###############

        }
        private void ShowListSUP()
        {
            SupplierBUS listSup = new SupplierBUS();

            List<SupplierDTO> livsup = listSup.ShowSup();

            listView1.Items.Clear();

            foreach (SupplierDTO sup in livsup)

            {

                ListViewItem lvi = new ListViewItem(sup.SuppierID1 + "");

                lvi.SubItems.Add(sup.Suppiername1 + "");

                lvi.SubItems.Add(sup.PhoneNumber1 + "");

                lvi.SubItems.Add(sup.Address1 + "");

                lvi.SubItems.Add(sup.FaxNumber1 + "");



                listView1.Items.Add(lvi);

                lvi.Tag = sup;
            }
        }
        private void Clear()
        {
            txtID_item.Text = "";
            txtFax_item.Text = "";
            txtName_item.Text = "";
            txtPhone_item.Text = "";
            txtAddress_item.Text = "";
            txtID_item.Focus();
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            // Khong ghi
        }

        private void btnClear_item_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void BtnAdd_item_Click(object sender, EventArgs e)
        {
            SupplierDTO sup = new SupplierDTO();

            sup.SuppierID1 = txtID_item.Text;

            sup.Suppiername1 = txtName_item.Text;
            sup.PhoneNumber1 = txtPhone_item.Text;
            sup.Address1 = txtAddress_item.Text;
            sup.FaxNumber1 = txtFax_item.Text;

            SupplierBUS supbus = new SupplierBUS();
            string kq = supbus.AddSup(sup.SuppierID1, sup.Suppiername1, sup.PhoneNumber1, sup.Address1, sup.FaxNumber1);
            if (kq == "success")
            {
                ShowListSUP();
                MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (kq == "saidinhdang")
            {
                MessageBox.Show("Sai định dạng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_SupId_isNull" || kq == "error_Supname" || kq == "error_Phonenull" || kq == "error_Faxnull" || kq == "error_Address")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_phone")
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_fax")
            {
                MessageBox.Show("Sai định dạng số Fax", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_SupId")
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnUpd_Click(object sender, EventArgs e)
        {
            SupplierDTO sup = new SupplierDTO();

            sup.SuppierID1 = txtID_item.Text;

            sup.Suppiername1 = txtName_item.Text;
            sup.PhoneNumber1 = txtPhone_item.Text;
            sup.Address1 = txtAddress_item.Text;
            sup.FaxNumber1 = txtFax_item.Text;

            SupplierBUS supbus = new SupplierBUS();
            string kq = supbus.UpdateSup(sup.SuppierID1, sup.Suppiername1, sup.PhoneNumber1, sup.Address1, sup.FaxNumber1);
            if (kq == "success")
            {
                ShowListSUP();
                MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (kq == "saidinhdang")
            {
                MessageBox.Show("Sai định dạng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_SupId_isNull" || kq == "error_Supname" || kq == "error_Phonenull" || kq == "error_Faxnull" || kq == "error_Address")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_phone")
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_fax")
            {
                MessageBox.Show("Sai định dạng số Fax", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_SupId")
            {
                MessageBox.Show("ID không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            SupplierBUS supBus = new SupplierBUS();
            if (txtID_item.Text == "")
            {
                MessageBox.Show("ID không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rt = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rt == DialogResult.Yes)
                {
                    string kq = supBus.DeleteSup(txtID_item.Text);




                    if (kq == "error_SupID")
                    {
                        MessageBox.Show("ID không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (kq == "success")
                    {
                        ShowListSUP();
                        MessageBox.Show("Delete thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                    }
                }

            }



            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSeach_item_TextChanged(object sender, EventArgs e)
        {
            if (txtSeach_item.Text == "")
            {
                ShowListSUP();
            }
        }

        private void txtSeach_item_IconRightClick(object sender, EventArgs e)
        {
            SupplierBUS listSup = new SupplierBUS();
            if (txtSeach_item.Text == "")
            {
                MessageBox.Show("Ô tìm kiếm đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<SupplierDTO> livsup = listSup.SeachSup(txtSeach_item.Text);

                listView1.Items.Clear();

                foreach (SupplierDTO sup in livsup)

                {

                    ListViewItem lvi = new ListViewItem(sup.SuppierID1 + "");

                    lvi.SubItems.Add(sup.Suppiername1 + "");

                    lvi.SubItems.Add(sup.PhoneNumber1 + "");

                    lvi.SubItems.Add(sup.Address1 + "");

                    lvi.SubItems.Add(sup.FaxNumber1 + "");

                    listView1.Items.Add(lvi);
                }



            }
        }
    }
}
