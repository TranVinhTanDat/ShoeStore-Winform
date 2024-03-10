namespace GUI
{
    partial class CustomerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerGUI));
            this.radWoman = new System.Windows.Forms.RadioButton();
            this.radMan = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUpd = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAdd_item = new Guna.UI2.WinForms.Guna2Button();
            this.btnClear_item = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtAddress_item = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPhone_item = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName_item = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSurname_item = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtID_item = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSeach_item = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // radWoman
            // 
            this.radWoman.AutoSize = true;
            this.radWoman.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radWoman.Location = new System.Drawing.Point(281, 33);
            this.radWoman.Name = "radWoman";
            this.radWoman.Size = new System.Drawing.Size(108, 35);
            this.radWoman.TabIndex = 44;
            this.radWoman.TabStop = true;
            this.radWoman.Text = "Female";
            this.radWoman.UseVisualStyleBackColor = true;
            // 
            // radMan
            // 
            this.radMan.AutoSize = true;
            this.radMan.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMan.Location = new System.Drawing.Point(138, 33);
            this.radMan.Name = "radMan";
            this.radMan.Size = new System.Drawing.Size(86, 35);
            this.radMan.TabIndex = 43;
            this.radMan.TabStop = true;
            this.radMan.Text = "Male";
            this.radMan.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 418);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(96, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 28);
            this.label4.TabIndex = 31;
            this.label4.Text = "Phone";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(96, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 29;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 28);
            this.label2.TabIndex = 27;
            this.label2.Text = "Surname";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 25;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 126);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(586, 537);
            this.listView1.TabIndex = 24;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Surname";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Phone";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Address";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radWoman);
            this.groupBox1.Controls.Add(this.radMan);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(101, 254);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 79);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gender";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.BtnUpd);
            this.groupBox2.Controls.Add(this.BtnAdd_item);
            this.groupBox2.Controls.Add(this.btnClear_item);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 487);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(623, 105);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Button Control";
            // 
            // btnDelete
            // 
            this.btnDelete.BorderRadius = 10;
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(36, 36);
            this.btnDelete.Location = new System.Drawing.Point(475, 47);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(109, 41);
            this.btnDelete.TabIndex = 56;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // BtnUpd
            // 
            this.BtnUpd.BorderRadius = 10;
            this.BtnUpd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUpd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUpd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUpd.FillColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnUpd.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpd.ForeColor = System.Drawing.Color.Black;
            this.BtnUpd.Image = ((System.Drawing.Image)(resources.GetObject("BtnUpd.Image")));
            this.BtnUpd.ImageSize = new System.Drawing.Size(28, 28);
            this.BtnUpd.Location = new System.Drawing.Point(331, 48);
            this.BtnUpd.Name = "BtnUpd";
            this.BtnUpd.Size = new System.Drawing.Size(109, 41);
            this.BtnUpd.TabIndex = 55;
            this.BtnUpd.Text = "Update";
            this.BtnUpd.Click += new System.EventHandler(this.BtnUpd_Click);
            // 
            // BtnAdd_item
            // 
            this.BtnAdd_item.BorderRadius = 10;
            this.BtnAdd_item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd_item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAdd_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAdd_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAdd_item.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd_item.ForeColor = System.Drawing.Color.Black;
            this.BtnAdd_item.Image = ((System.Drawing.Image)(resources.GetObject("BtnAdd_item.Image")));
            this.BtnAdd_item.ImageSize = new System.Drawing.Size(36, 36);
            this.BtnAdd_item.Location = new System.Drawing.Point(186, 48);
            this.BtnAdd_item.Name = "BtnAdd_item";
            this.BtnAdd_item.Size = new System.Drawing.Size(109, 41);
            this.BtnAdd_item.TabIndex = 54;
            this.BtnAdd_item.Text = "Add";
            this.BtnAdd_item.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btnClear_item
            // 
            this.btnClear_item.BackColor = System.Drawing.Color.White;
            this.btnClear_item.BorderRadius = 10;
            this.btnClear_item.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_item.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear_item.FillColor = System.Drawing.Color.Violet;
            this.btnClear_item.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear_item.ForeColor = System.Drawing.Color.Black;
            this.btnClear_item.Image = ((System.Drawing.Image)(resources.GetObject("btnClear_item.Image")));
            this.btnClear_item.ImageSize = new System.Drawing.Size(36, 36);
            this.btnClear_item.Location = new System.Drawing.Point(39, 49);
            this.btnClear_item.Name = "btnClear_item";
            this.btnClear_item.Size = new System.Drawing.Size(109, 41);
            this.btnClear_item.TabIndex = 53;
            this.btnClear_item.Text = "Clear";
            this.btnClear_item.Click += new System.EventHandler(this.btnClear_item_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.FillColor = System.Drawing.Color.DarkOrange;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1254, 24);
            this.guna2Panel1.TabIndex = 50;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listView1);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(3, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 676);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Management Customer";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtAddress_item);
            this.groupBox4.Controls.Add(this.txtPhone_item);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtName_item);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtSurname_item);
            this.groupBox4.Controls.Add(this.txtID_item);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(620, 81);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(646, 676);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Detail";
            // 
            // txtAddress_item
            // 
            this.txtAddress_item.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtAddress_item.BorderRadius = 5;
            this.txtAddress_item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress_item.DefaultText = "";
            this.txtAddress_item.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress_item.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress_item.ForeColor = System.Drawing.Color.Black;
            this.txtAddress_item.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAddress_item.Location = new System.Drawing.Point(239, 412);
            this.txtAddress_item.Margin = new System.Windows.Forms.Padding(4);
            this.txtAddress_item.Name = "txtAddress_item";
            this.txtAddress_item.PasswordChar = '\0';
            this.txtAddress_item.PlaceholderText = "";
            this.txtAddress_item.SelectedText = "";
            this.txtAddress_item.Size = new System.Drawing.Size(308, 34);
            this.txtAddress_item.TabIndex = 58;
            // 
            // txtPhone_item
            // 
            this.txtPhone_item.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPhone_item.BorderRadius = 5;
            this.txtPhone_item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhone_item.DefaultText = "";
            this.txtPhone_item.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhone_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhone_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone_item.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhone_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone_item.ForeColor = System.Drawing.Color.Black;
            this.txtPhone_item.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPhone_item.Location = new System.Drawing.Point(239, 346);
            this.txtPhone_item.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone_item.Name = "txtPhone_item";
            this.txtPhone_item.PasswordChar = '\0';
            this.txtPhone_item.PlaceholderText = "";
            this.txtPhone_item.SelectedText = "";
            this.txtPhone_item.Size = new System.Drawing.Size(308, 34);
            this.txtPhone_item.TabIndex = 57;
            // 
            // txtName_item
            // 
            this.txtName_item.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName_item.BorderRadius = 5;
            this.txtName_item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName_item.DefaultText = "";
            this.txtName_item.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName_item.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName_item.ForeColor = System.Drawing.Color.Black;
            this.txtName_item.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName_item.Location = new System.Drawing.Point(239, 199);
            this.txtName_item.Margin = new System.Windows.Forms.Padding(4);
            this.txtName_item.Name = "txtName_item";
            this.txtName_item.PasswordChar = '\0';
            this.txtName_item.PlaceholderText = "";
            this.txtName_item.SelectedText = "";
            this.txtName_item.Size = new System.Drawing.Size(308, 34);
            this.txtName_item.TabIndex = 56;
            this.txtName_item.TextChanged += new System.EventHandler(this.txtName_item_TextChanged);
            // 
            // txtSurname_item
            // 
            this.txtSurname_item.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSurname_item.BorderRadius = 5;
            this.txtSurname_item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSurname_item.DefaultText = "";
            this.txtSurname_item.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSurname_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSurname_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSurname_item.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSurname_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSurname_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname_item.ForeColor = System.Drawing.Color.Black;
            this.txtSurname_item.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSurname_item.Location = new System.Drawing.Point(239, 142);
            this.txtSurname_item.Margin = new System.Windows.Forms.Padding(4);
            this.txtSurname_item.Name = "txtSurname_item";
            this.txtSurname_item.PasswordChar = '\0';
            this.txtSurname_item.PlaceholderText = "";
            this.txtSurname_item.SelectedText = "";
            this.txtSurname_item.Size = new System.Drawing.Size(308, 34);
            this.txtSurname_item.TabIndex = 55;
            // 
            // txtID_item
            // 
            this.txtID_item.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID_item.BorderRadius = 5;
            this.txtID_item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID_item.DefaultText = "";
            this.txtID_item.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtID_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtID_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID_item.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtID_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_item.ForeColor = System.Drawing.Color.Black;
            this.txtID_item.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtID_item.Location = new System.Drawing.Point(239, 86);
            this.txtID_item.Margin = new System.Windows.Forms.Padding(4);
            this.txtID_item.Name = "txtID_item";
            this.txtID_item.PasswordChar = '\0';
            this.txtID_item.PlaceholderText = "";
            this.txtID_item.SelectedText = "";
            this.txtID_item.Size = new System.Drawing.Size(308, 34);
            this.txtID_item.TabIndex = 54;
            // 
            // txtSeach_item
            // 
            this.txtSeach_item.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSeach_item.BorderRadius = 8;
            this.txtSeach_item.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSeach_item.DefaultText = "";
            this.txtSeach_item.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSeach_item.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSeach_item.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach_item.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSeach_item.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach_item.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeach_item.ForeColor = System.Drawing.Color.Black;
            this.txtSeach_item.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSeach_item.IconRight = ((System.Drawing.Image)(resources.GetObject("txtSeach_item.IconRight")));
            this.txtSeach_item.IconRightSize = new System.Drawing.Size(26, 26);
            this.txtSeach_item.Location = new System.Drawing.Point(15, 142);
            this.txtSeach_item.Margin = new System.Windows.Forms.Padding(4);
            this.txtSeach_item.Name = "txtSeach_item";
            this.txtSeach_item.PasswordChar = '\0';
            this.txtSeach_item.PlaceholderText = "";
            this.txtSeach_item.SelectedText = "";
            this.txtSeach_item.Size = new System.Drawing.Size(586, 36);
            this.txtSeach_item.TabIndex = 53;
            this.txtSeach_item.IconRightClick += new System.EventHandler(this.txtSeach_item_IconRightClick);
            this.txtSeach_item.TextChanged += new System.EventHandler(this.txtSeach_item_TextChanged);
            // 
            // CustomerGUI
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1278, 769);
            this.Controls.Add(this.txtSeach_item);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomerGUI";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton radWoman;
        private System.Windows.Forms.RadioButton radMan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button BtnUpd;
        private Guna.UI2.WinForms.Guna2Button BtnAdd_item;
        private Guna.UI2.WinForms.Guna2Button btnClear_item;
        private Guna.UI2.WinForms.Guna2TextBox txtSeach_item;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress_item;
        private Guna.UI2.WinForms.Guna2TextBox txtPhone_item;
        private Guna.UI2.WinForms.Guna2TextBox txtName_item;
        private Guna.UI2.WinForms.Guna2TextBox txtSurname_item;
        private Guna.UI2.WinForms.Guna2TextBox txtID_item;
    }
}

