namespace GUI
{
    partial class ImportManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.headingProduct = new System.Windows.Forms.Label();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.dtgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchImport = new Bunifu.UI.WinForms.BunifuTextBox();
            this.createNewImport = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.exportProduct = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.headingProduct.Location = new System.Drawing.Point(19, 2);
            this.headingProduct.Name = "headingProduct";
            this.headingProduct.Size = new System.Drawing.Size(128, 31);
            this.headingProduct.TabIndex = 17;
            this.headingProduct.Text = "Import list";
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
            this.bunifuPanel2.Controls.Add(this.searchImport);
            this.bunifuPanel2.Location = new System.Drawing.Point(19, 63);
            this.bunifuPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(1229, 716);
            this.bunifuPanel2.TabIndex = 18;
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
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 64);
            this.bunifuPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1229, 652);
            this.bunifuPanel1.TabIndex = 10;
            // 
            // dtgv
            // 
            this.dtgv.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            this.dtgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(46)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgv.ColumnHeadersHeight = 54;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgv.DefaultCellStyle = dataGridViewCellStyle3;
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
            // searchImport
            // 
            this.searchImport.AcceptsReturn = false;
            this.searchImport.AcceptsTab = false;
            this.searchImport.AnimationSpeed = 200;
            this.searchImport.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.searchImport.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.searchImport.BackColor = System.Drawing.Color.Transparent;
            this.searchImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchImport.BackgroundImage")));
            this.searchImport.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.searchImport.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.searchImport.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.searchImport.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            this.searchImport.BorderRadius = 5;
            this.searchImport.BorderThickness = 1;
            this.searchImport.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.searchImport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchImport.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchImport.DefaultText = "Search";
            this.searchImport.FillColor = System.Drawing.Color.White;
            this.searchImport.HideSelection = true;
            this.searchImport.IconLeft = null;
            this.searchImport.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchImport.IconPadding = 10;
            this.searchImport.IconRight = null;
            this.searchImport.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.searchImport.Lines = new string[] {
        "Search"};
            this.searchImport.Location = new System.Drawing.Point(31, 0);
            this.searchImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchImport.MaxLength = 32767;
            this.searchImport.MinimumSize = new System.Drawing.Size(1, 1);
            this.searchImport.Modified = false;
            this.searchImport.Multiline = false;
            this.searchImport.Name = "searchImport";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchImport.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.searchImport.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchImport.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(234)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.searchImport.OnIdleState = stateProperties4;
            this.searchImport.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchImport.PasswordChar = '\0';
            this.searchImport.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.searchImport.PlaceholderText = "Enter ImportID";
            this.searchImport.ReadOnly = false;
            this.searchImport.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchImport.SelectedText = "";
            this.searchImport.SelectionLength = 0;
            this.searchImport.SelectionStart = 6;
            this.searchImport.ShortcutsEnabled = true;
            this.searchImport.Size = new System.Drawing.Size(794, 52);
            this.searchImport.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.searchImport.TabIndex = 3;
            this.searchImport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.searchImport.TextMarginBottom = 0;
            this.searchImport.TextMarginLeft = 20;
            this.searchImport.TextMarginTop = 0;
            this.searchImport.TextPlaceholder = "Enter ImportID";
            this.searchImport.UseSystemPasswordChar = false;
            this.searchImport.WordWrap = true;
            this.searchImport.TextChanged += new System.EventHandler(this.searchImport_TextChanged);
            this.searchImport.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchImport_MouseClick);
            // 
            // createNewImport
            // 
            this.createNewImport.AllowAnimations = true;
            this.createNewImport.AllowMouseEffects = true;
            this.createNewImport.AllowToggling = false;
            this.createNewImport.AnimationSpeed = 200;
            this.createNewImport.AutoGenerateColors = false;
            this.createNewImport.AutoRoundBorders = false;
            this.createNewImport.AutoSizeLeftIcon = true;
            this.createNewImport.AutoSizeRightIcon = true;
            this.createNewImport.BackColor = System.Drawing.Color.Transparent;
            this.createNewImport.BackColor1 = System.Drawing.Color.SteelBlue;
            this.createNewImport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createNewImport.BackgroundImage")));
            this.createNewImport.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewImport.ButtonText = "Create new";
            this.createNewImport.ButtonTextMarginLeft = 0;
            this.createNewImport.ColorContrastOnClick = 45;
            this.createNewImport.ColorContrastOnHover = 45;
            this.createNewImport.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.createNewImport.CustomizableEdges = borderEdges1;
            this.createNewImport.DialogResult = System.Windows.Forms.DialogResult.None;
            this.createNewImport.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.createNewImport.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createNewImport.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.createNewImport.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.createNewImport.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewImport.ForeColor = System.Drawing.Color.White;
            this.createNewImport.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewImport.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.createNewImport.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.createNewImport.IconMarginLeft = 11;
            this.createNewImport.IconPadding = 10;
            this.createNewImport.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.createNewImport.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.createNewImport.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.createNewImport.IconSize = 25;
            this.createNewImport.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.createNewImport.IdleBorderRadius = 1;
            this.createNewImport.IdleBorderThickness = 1;
            this.createNewImport.IdleFillColor = System.Drawing.Color.SteelBlue;
            this.createNewImport.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("createNewImport.IdleIconLeftImage")));
            this.createNewImport.IdleIconRightImage = null;
            this.createNewImport.IndicateFocus = false;
            this.createNewImport.Location = new System.Drawing.Point(900, 20);
            this.createNewImport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.createNewImport.Name = "createNewImport";
            this.createNewImport.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.createNewImport.OnDisabledState.BorderRadius = 1;
            this.createNewImport.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewImport.OnDisabledState.BorderThickness = 1;
            this.createNewImport.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.createNewImport.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.createNewImport.OnDisabledState.IconLeftImage = null;
            this.createNewImport.OnDisabledState.IconRightImage = null;
            this.createNewImport.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.createNewImport.onHoverState.BorderRadius = 1;
            this.createNewImport.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewImport.onHoverState.BorderThickness = 1;
            this.createNewImport.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.createNewImport.onHoverState.ForeColor = System.Drawing.Color.White;
            this.createNewImport.onHoverState.IconLeftImage = null;
            this.createNewImport.onHoverState.IconRightImage = null;
            this.createNewImport.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.createNewImport.OnIdleState.BorderRadius = 1;
            this.createNewImport.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewImport.OnIdleState.BorderThickness = 1;
            this.createNewImport.OnIdleState.FillColor = System.Drawing.Color.SteelBlue;
            this.createNewImport.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.createNewImport.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("createNewImport.OnIdleState.IconLeftImage")));
            this.createNewImport.OnIdleState.IconRightImage = null;
            this.createNewImport.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.createNewImport.OnPressedState.BorderRadius = 1;
            this.createNewImport.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.createNewImport.OnPressedState.BorderThickness = 1;
            this.createNewImport.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.createNewImport.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.createNewImport.OnPressedState.IconLeftImage = null;
            this.createNewImport.OnPressedState.IconRightImage = null;
            this.createNewImport.Size = new System.Drawing.Size(183, 39);
            this.createNewImport.TabIndex = 20;
            this.createNewImport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.createNewImport.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.createNewImport.TextMarginLeft = 0;
            this.createNewImport.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.createNewImport.UseDefaultRadiusAndThickness = true;
            this.createNewImport.Click += new System.EventHandler(this.createNewImport_Click);
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
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.exportProduct.CustomizableEdges = borderEdges2;
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
            this.exportProduct.Location = new System.Drawing.Point(1101, 20);
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
            this.exportProduct.TabIndex = 19;
            this.exportProduct.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exportProduct.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.exportProduct.TextMarginLeft = 0;
            this.exportProduct.TextPadding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.exportProduct.UseDefaultRadiusAndThickness = true;
            this.exportProduct.Click += new System.EventHandler(this.exportProduct_Click);
            // 
            // ImportManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(1282, 773);
            this.Controls.Add(this.bunifuPanel2);
            this.Controls.Add(this.headingProduct);
            this.Controls.Add(this.createNewImport);
            this.Controls.Add(this.exportProduct);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportManager";
            this.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 12;
            this.Text = "ImportManager";
            this.Load += new System.EventHandler(this.CreateImport_Load);
            this.bunifuPanel2.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Guna.UI2.WinForms.Guna2DataGridView dtgv;
        private Bunifu.UI.WinForms.BunifuTextBox searchImport;
        private System.Windows.Forms.Label headingProduct;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton createNewImport;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton exportProduct;
    }
}