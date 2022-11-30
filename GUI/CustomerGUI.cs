using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class CustomerGUI : Form
    {
        public CustomerGUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowListCUS();
            radMan.Checked = true;
        }

        //Ham hien danh sach khach hang

        private void ShowListCUS()
        {
            CustomerBUS listCus = new CustomerBUS();

            List<CustomerDTO> livcus = listCus.GetList();

            listView1.Items.Clear();

            foreach (CustomerDTO cus in livcus)

            {

                ListViewItem lvi = new ListViewItem(cus.CustomerID1 + "");

                lvi.SubItems.Add(cus.CustomerSurname1 + "");

                lvi.SubItems.Add(cus.CustomerName1 + "");

                lvi.SubItems.Add(cus.Gender1 + "");

                lvi.SubItems.Add(cus.PhoneNumber1 + "");

                lvi.SubItems.Add(cus.Address1 + "");

                listView1.Items.Add(lvi);

                lvi.Tag = cus;
            }
        }

        //Ham clear noi dung trong text box
        private void Clear()
        {
            txtID_item.Text = "";
            txtSurname_item.Text = "";
            txtName_item.Text = "";
            txtPhone_item.Text = "";
            txtAddress_item.Text = "";
            txtID_item.Focus();
        }


        // su kien hien thong tin len textbox khi click chuot vao listview

        private void listView1_MouseClick_1(object sender, MouseEventArgs e)
        {
            txtID_item.Text = listView1.SelectedItems[0].SubItems[0].Text;
            txtSurname_item.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtName_item.Text = listView1.SelectedItems[0].SubItems[2].Text;
            if (listView1.SelectedItems[0].SubItems[3].Text == "Male")
            {
                radMan.Checked = true;
            }
            else
            {
                radWoman.Checked = true;
            }
            txtPhone_item.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txtAddress_item.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }






        //btn addd

        private void guna2Button2_Click(object sender, EventArgs e)
        {


            CustomerDTO cus = new CustomerDTO();

            cus.CustomerID1 = txtID_item.Text;
            cus.CustomerSurname1 = txtSurname_item.Text;
            cus.CustomerName1 = txtName_item.Text;
            cus.PhoneNumber1 = txtPhone_item.Text;
            cus.Address1 = txtAddress_item.Text;

            if (radMan.Checked == true)
            {
                cus.Gender1 = "Male";
            }
            else
            {
                cus.Gender1 = "Female";
            }

            CustomerBUS cusbus = new CustomerBUS();
            string kq = cusbus.AddCus(cus.CustomerID1, cus.CustomerSurname1, cus.CustomerName1, cus.Gender1, cus.PhoneNumber1, cus.Address1);
            if (kq == "success")
            {
                ShowListCUS();
                MessageBox.Show("Add thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (kq == "saidinhdang")
            {
                MessageBox.Show("Sai định dạng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_CusId_isNull" || kq == "error_surname" || kq == "error_Cusname" || kq == "error_Address" || kq == "error_Phonenull")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_phone")
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_CusId")
            {
                MessageBox.Show("ID đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        //btn clear
        private void btnClear_item_Click(object sender, EventArgs e)
        {
            Clear();
        }

        //btn Update
        private void BtnUpd_Click(object sender, EventArgs e)
        {
            CustomerDTO cus = new CustomerDTO();

            cus.CustomerID1 = txtID_item.Text;
            cus.CustomerSurname1 = txtSurname_item.Text;
            cus.CustomerName1 = txtName_item.Text;
            cus.PhoneNumber1 = txtPhone_item.Text;
            cus.Address1 = txtAddress_item.Text;

            if (radMan.Checked == true)
            {
                cus.Gender1 = "Male";
            }
            else
            {
                cus.Gender1 = "Female";
            }

            CustomerBUS cusbus = new CustomerBUS();
            string kq = cusbus.UpdateCus(cus.CustomerID1, cus.CustomerSurname1, cus.CustomerName1, cus.Gender1, cus.PhoneNumber1, cus.Address1);
            if (kq == "success")
            {
                ShowListCUS();
                MessageBox.Show("Update thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            if (kq == "saidinhdang")
            {
                MessageBox.Show("Sai định dạng mã", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_CusId_isNull" || kq == "error_surname" || kq == "error_Cusname" || kq == "error_Address" || kq == "error_Phonenull")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_phone")
            {
                MessageBox.Show("Sai định dạng số điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (kq == "error_CusId")
            {
                MessageBox.Show("ID không tồn tại trong danh sách", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //btnXoa

        private void btnDelete_Click(object sender, EventArgs e)
        {
            CustomerBUS cusBus = new CustomerBUS();
            if (txtID_item.Text == "")
            {
                MessageBox.Show("ID không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult rt = MessageBox.Show("Bạn có chắc muốn xóa dữ liệu này không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (rt == DialogResult.Yes)
                {
                    string kq = cusBus.DeleteCus(txtID_item.Text);




                    if (kq == "error_CusID")
                    {
                        MessageBox.Show("ID không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (kq == "success")
                    {
                        ShowListCUS();
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

        // btn seach

        private void txtSeach_item_IconRightClick(object sender, EventArgs e)
        {
            CustomerBUS listCus = new CustomerBUS();
            if (txtSeach_item.Text == "")
            {
                MessageBox.Show("Ô tìm kiếm đang trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                List<CustomerDTO> livcus = listCus.SeachCus(txtSeach_item.Text);

                listView1.Items.Clear();

                foreach (CustomerDTO cus in livcus)

                {

                    ListViewItem lvi = new ListViewItem(cus.CustomerID1 + "");

                    lvi.SubItems.Add(cus.CustomerSurname1 + "");

                    lvi.SubItems.Add(cus.CustomerName1 + "");

                    lvi.SubItems.Add(cus.Gender1 + "");

                    lvi.SubItems.Add(cus.PhoneNumber1 + "");

                    lvi.SubItems.Add(cus.Address1 + "");

                    listView1.Items.Add(lvi);
                }



            }
        }



        private void txtSeach_item_TextChanged(object sender, EventArgs e)
        {
            if (txtSeach_item.Text == "")
            {
                ShowListCUS();
            }
        }


        private void txtName_item_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDel_Click_1(object sender, EventArgs e)
        {




        }


        private void btnFind_Click_1(object sender, EventArgs e)
        {

        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {

        }

        private void txtSeach_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}

