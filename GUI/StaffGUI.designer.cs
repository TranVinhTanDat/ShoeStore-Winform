namespace GUI
{
    partial class StaffGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffGUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.headingProduct = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dtgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchStaff = new Bunifu.UI.WinForms.BunifuTextBox();
            this.createNewProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exportProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.bunifuPanel2.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // headingProduct
            // 
            this.headingProduct.AutoSize = true;
            this.headingProduct.BackColor = System.Drawing.Color.Transparent;
            this.headingProduct.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headingProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.headingProduct.Location = new System.Drawing.Point(27, 14);
            this.headingProduct.Name = "headingProduct";
            this.headingProduct.Size = new System.Drawing.Size(65, 31);
            this.headingProduct.TabIndex = 5;
            this.headingProduct.Text = "Staff";
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 5;
            this.bunifuPanel2.BorderThickness = 1;
            this.bunifuPanel2.Controls.Add(this.bunifuPanel1);
            this.bunifuPanel2.Controls.Add(this.searchStaff);
            this.bunifuPanel2.Location = new System.Drawing.Point(27, 57);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1244, 734);
            this.bunifuPanel2.TabIndex = 6;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.dtgv);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 82);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1244, 652);
            this.bunifuPanel1.TabIndex = 10;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgv.ColumnHeadersHeight = 54;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.dtgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv.Location = new System.Drawing.Point(31, 25);
            this.dtgv.Name = "dtgv";
            this.dtgv.RowHeadersVisible = false;
            this.dtgv.RowHeadersWidth = 51;
            this.dtgv.RowTemplate.Height = 50;
            this.dtgv.Size = new System.Drawing.Size(1180, 607);
            this.dtgv.TabIndex = 0;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgv.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtgv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtgv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.dtgv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgv.ThemeStyle.HeaderStyle.Height = 54;
            this.dtgv.ThemeStyle.ReadOnly = false;
            this.dtgv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv.ThemeStyle.RowsStyle.Height = 50;
            this.dtgv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellContentClick);
            this.dtgv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgv_CellDoubleClick);
            // 
            // searchStaff
            // 
            this.searchStaff.AcceptsReturn = false;
            this.searchStaff.AcceptsTab = false;
            this.searchStaff.AnimationSpeed = 200;
            this.searchStaff.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchStaff.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchStaff.BackColor = System.Drawing.Color.Transparent;
            this.searchStaff.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchStaff.BackgroundImage")));
            this.searchStaff.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchStaff.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchStaff.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchStaff.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.searchStaff.BorderRadius = 5;
            this.searchStaff.BorderThickness = 1;
            this.searchStaff.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchStaff.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchStaff.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchStaff.DefaultText = "";
            this.searchStaff.FillColor = System.Drawing.Color.White;
            this.searchStaff.HideSelection = true;
            this.searchStaff.IconLeft = null;
            this.searchStaff.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchStaff.IconPadding = 10;
            this.searchStaff.IconRight = null;
            this.searchStaff.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchStaff.Lines = new string[0];
            this.searchStaff.Location = new System.Drawing.Point(31, 14);
            this.searchStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchStaff.MaxLength = 32767;
            this.searchStaff.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchStaff.Modified = false;
            this.searchStaff.Multiline = false;
            this.searchStaff.Name = "searchStaff";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchStaff.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchStaff.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchStaff.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchStaff.OnIdleState = stateProperties8;
            this.searchStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchStaff.PasswordChar = '\0';
            this.searchStaff.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchStaff.PlaceholderText = "Search";
            this.searchStaff.ReadOnly = false;
            this.searchStaff.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchStaff.SelectedText = "";
            this.searchStaff.SelectionLength = 0;
            this.searchStaff.SelectionStart = 0;
            this.searchStaff.ShortcutsEnabled = true;
            this.searchStaff.Size = new System.Drawing.Size(825, 52);
            this.searchStaff.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchStaff.TabIndex = 3;
            this.searchStaff.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchStaff.TextMarginBottom = 0;
            this.searchStaff.TextMarginLeft = 20;
            this.searchStaff.TextMarginTop = 0;
            this.searchStaff.TextPlaceholder = "Search";
            this.searchStaff.UseSystemPasswordChar = false;
            this.searchStaff.WordWrap = true;
            this.searchStaff.TextChanged += new System.EventHandler(this.searchStaff_TextChanged);
            // 
            // createNewProduct
            // 
            this.createNewProduct.AllowAnimations = true;
            this.createNewProduct.AllowMouseEffects = true;
            this.createNewProduct.AllowToggling = false;
            this.createNewProduct.AnimationSpeed = 200;
            this.createNewProduct.AutoGenerateColors = false;
            this.createNewProduct.AutoRoundBorders = false;
            this.createNewProduct.AutoSizeLeftIcon = true;
            this.createNewProduct.AutoSizeRightIcon = true;
            this.createNewProduct.BackColor = System.Drawing.Color.Transparent;
            this.createNewProduct.BackColor1 = System.Drawing.Color.SteelBlue;
            this.createNewProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createNewProduct.BackgroundImage")));
            this.createNewProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewProduct.ButtonText = "Create new";
            this.createNewProduct.ButtonTextMarginLeft = 0;
            this.createNewProduct.ColorContrastOnClick = 45;
            this.createNewProduct.ColorContrastOnHover = 45;
            this.createNewProduct.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.createNewProduct.CustomizableEdges = borderEdges3;
            this.createNewProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createNewProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.createNewProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createNewProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.createNewProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.createNewProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewProduct.ForeColor = System.Drawing.Color.White;
            this.createNewProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.createNewProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.createNewProduct.IconMarginLeft = 11;
            this.createNewProduct.IconPadding = 10;
            this.createNewProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.createNewProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.createNewProduct.IconSize = 25;
            this.createNewProduct.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.createNewProduct.IdleBorderRadius = 1;
            this.createNewProduct.IdleBorderThickness = 1;
            this.createNewProduct.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.createNewProduct.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("createNewProduct.IdleIconLeftImage")));
            this.createNewProduct.IdleIconRightImage = null;
            this.createNewProduct.IndicateFocus = false;
            this.createNewProduct.Location = new System.Drawing.Point(1060, 5);
            this.createNewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNewProduct.Name = "createNewProduct";
            this.createNewProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.createNewProduct.OnDisabledState.BorderRadius = 1;
            this.createNewProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewProduct.OnDisabledState.BorderThickness = 1;
            this.createNewProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createNewProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.createNewProduct.OnDisabledState.IconLeftImage = null;
            this.createNewProduct.OnDisabledState.IconRightImage = null;
            this.createNewProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.createNewProduct.onHoverState.BorderRadius = 1;
            this.createNewProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewProduct.onHoverState.BorderThickness = 1;
            this.createNewProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.createNewProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.createNewProduct.onHoverState.IconLeftImage = null;
            this.createNewProduct.onHoverState.IconRightImage = null;
            this.createNewProduct.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.createNewProduct.OnIdleState.BorderRadius = 1;
            this.createNewProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewProduct.OnIdleState.BorderThickness = 1;
            this.createNewProduct.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.createNewProduct.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.createNewProduct.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("createNewProduct.OnIdleState.IconLeftImage")));
            this.createNewProduct.OnIdleState.IconRightImage = null;
            this.createNewProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.createNewProduct.OnPressedState.BorderRadius = 1;
            this.createNewProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewProduct.OnPressedState.BorderThickness = 1;
            this.createNewProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.createNewProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.createNewProduct.OnPressedState.IconLeftImage = null;
            this.createNewProduct.OnPressedState.IconRightImage = null;
            this.createNewProduct.Size = new System.Drawing.Size(183, 39);
            this.createNewProduct.TabIndex = 12;
            this.createNewProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.createNewProduct.TextMarginLeft = 0;
            this.createNewProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.createNewProduct.UseDefaultRadiusAndThickness = true;
            this.createNewProduct.Click += new System.EventHandler(this.createNewProduct_Click);
            // 
            // exportProduct
            // 
            this.exportProduct.AllowAnimations = true;
            this.exportProduct.AllowMouseEffects = true;
            this.exportProduct.AllowToggling = false;
            this.exportProduct.AnimationSpeed = 200;
            this.exportProduct.AutoGenerateColors = false;
            this.exportProduct.AutoRoundBorders = false;
            this.exportProduct.AutoSizeLeftIcon = true;
            this.exportProduct.AutoSizeRightIcon = true;
            this.exportProduct.BackColor = System.Drawing.Color.Transparent;
            this.exportProduct.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.exportProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exportProduct.BackgroundImage")));
            this.exportProduct.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportProduct.ButtonText = "Export";
            this.exportProduct.ButtonTextMarginLeft = 0;
            this.exportProduct.ColorContrastOnClick = 45;
            this.exportProduct.ColorContrastOnHover = 45;
            this.exportProduct.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.exportProduct.CustomizableEdges = borderEdges4;
            this.exportProduct.DialogResult = System.Windows.Forms.DialogResult.None;
            this.exportProduct.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exportProduct.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exportProduct.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exportProduct.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.exportProduct.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportProduct.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.exportProduct.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportProduct.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.exportProduct.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.exportProduct.IconMarginLeft = 11;
            this.exportProduct.IconPadding = 10;
            this.exportProduct.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exportProduct.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.exportProduct.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.exportProduct.IconSize = 25;
            this.exportProduct.IdleBorderColor = System.Drawing.Color.LightGray;
            this.exportProduct.IdleBorderRadius = 5;
            this.exportProduct.IdleBorderThickness = 1;
            this.exportProduct.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.exportProduct.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("exportProduct.IdleIconLeftImage")));
            this.exportProduct.IdleIconRightImage = null;
            this.exportProduct.IndicateFocus = false;
            this.exportProduct.Location = new System.Drawing.Point(890, 5);
            this.exportProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exportProduct.Name = "exportProduct";
            this.exportProduct.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.exportProduct.OnDisabledState.BorderRadius = 5;
            this.exportProduct.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportProduct.OnDisabledState.BorderThickness = 1;
            this.exportProduct.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.exportProduct.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.exportProduct.OnDisabledState.IconLeftImage = null;
            this.exportProduct.OnDisabledState.IconRightImage = null;
            this.exportProduct.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.exportProduct.onHoverState.BorderRadius = 5;
            this.exportProduct.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportProduct.onHoverState.BorderThickness = 1;
            this.exportProduct.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.exportProduct.onHoverState.ForeColor = System.Drawing.Color.White;
            this.exportProduct.onHoverState.IconLeftImage = null;
            this.exportProduct.onHoverState.IconRightImage = null;
            this.exportProduct.OnIdleState.BorderColor = System.Drawing.Color.LightGray;
            this.exportProduct.OnIdleState.BorderRadius = 5;
            this.exportProduct.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportProduct.OnIdleState.BorderThickness = 1;
            this.exportProduct.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.exportProduct.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            this.exportProduct.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("exportProduct.OnIdleState.IconLeftImage")));
            this.exportProduct.OnIdleState.IconRightImage = null;
            this.exportProduct.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.exportProduct.OnPressedState.BorderRadius = 5;
            this.exportProduct.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.exportProduct.OnPressedState.BorderThickness = 1;
            this.exportProduct.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.exportProduct.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.exportProduct.OnPressedState.IconLeftImage = null;
            this.exportProduct.OnPressedState.IconRightImage = null;
            this.exportProduct.Size = new System.Drawing.Size(147, 39);
            this.exportProduct.TabIndex = 11;
            this.exportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.exportProduct.TextMarginLeft = 0;
            this.exportProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.exportProduct.UseDefaultRadiusAndThickness = true;
            this.exportProduct.Click += new System.EventHandler(this.exportProduct_Click);
            // 
            // StaffGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 820);
            this.Controls.Add(this.createNewProduct);
            this.Controls.Add(this.exportProduct);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.headingProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffGUI";
            this.Text = "Staff";
            this.Load += new System.EventHandler(this.Staff_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuTextBox searchStaff;
        private System.Windows.Forms.Label headingProduct;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton createNewProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exportProduct;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}