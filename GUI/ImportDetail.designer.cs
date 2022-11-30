namespace GUI
{
    partial class ImportDetail
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportDetail));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.label5 = new System.Windows.Forms.Label();
            this.dtgvDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnExit = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(30)))));
            this.label5.Location = new System.Drawing.Point(37, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 31);
            this.label5.TabIndex = 51;
            this.label5.Text = "ImportDetail";
            // 
            // dtgvDetail
            // 
            this.dtgvDetail.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvDetail.ColumnHeadersHeight = 20;
            this.dtgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.Location = new System.Drawing.Point(43, 62);
            this.dtgvDetail.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvDetail.Name = "dtgvDetail";
            this.dtgvDetail.RowHeadersVisible = false;
            this.dtgvDetail.RowHeadersWidth = 51;
            this.dtgvDetail.Size = new System.Drawing.Size(1038, 463);
            this.dtgvDetail.TabIndex = 52;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dtgvDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dtgvDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtgvDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgvDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dtgvDetail.ThemeStyle.HeaderStyle.Height = 20;
            this.dtgvDetail.ThemeStyle.ReadOnly = false;
            this.dtgvDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dtgvDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgvDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtgvDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dtgvDetail.ThemeStyle.RowsStyle.Height = 22;
            this.dtgvDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dtgvDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnExit
            // 
            this.btnExit.AllowAnimations = true;
            this.btnExit.AllowMouseEffects = true;
            this.btnExit.AllowToggling = false;
            this.btnExit.AnimationSpeed = 200;
            this.btnExit.AutoGenerateColors = false;
            this.btnExit.AutoRoundBorders = false;
            this.btnExit.AutoSizeLeftIcon = true;
            this.btnExit.AutoSizeRightIcon = true;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackColor1 = System.Drawing.Color.RoyalBlue;
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.ButtonText = "Exit";
            this.btnExit.ButtonTextMarginLeft = 0;
            this.btnExit.ColorContrastOnClick = 45;
            this.btnExit.ColorContrastOnHover = 45;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnExit.CustomizableEdges = borderEdges1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnExit.IconMarginLeft = 11;
            this.btnExit.IconPadding = 10;
            this.btnExit.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnExit.IconSize = 25;
            this.btnExit.IdleBorderColor = System.Drawing.Color.Crimson;
            this.btnExit.IdleBorderRadius = 5;
            this.btnExit.IdleBorderThickness = 1;
            this.btnExit.IdleFillColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.IdleIconLeftImage = null;
            this.btnExit.IdleIconRightImage = null;
            this.btnExit.IndicateFocus = false;
            this.btnExit.Location = new System.Drawing.Point(481, 548);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnExit.OnDisabledState.BorderRadius = 5;
            this.btnExit.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnDisabledState.BorderThickness = 1;
            this.btnExit.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnExit.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnExit.OnDisabledState.IconLeftImage = null;
            this.btnExit.OnDisabledState.IconRightImage = null;
            this.btnExit.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExit.onHoverState.BorderRadius = 5;
            this.btnExit.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.onHoverState.BorderThickness = 1;
            this.btnExit.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnExit.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnExit.onHoverState.IconLeftImage = null;
            this.btnExit.onHoverState.IconRightImage = null;
            this.btnExit.OnIdleState.BorderColor = System.Drawing.Color.Crimson;
            this.btnExit.OnIdleState.BorderRadius = 5;
            this.btnExit.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnIdleState.BorderThickness = 1;
            this.btnExit.OnIdleState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnExit.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnExit.OnIdleState.IconLeftImage = null;
            this.btnExit.OnIdleState.IconRightImage = null;
            this.btnExit.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExit.OnPressedState.BorderRadius = 5;
            this.btnExit.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnExit.OnPressedState.BorderThickness = 1;
            this.btnExit.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnExit.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnExit.OnPressedState.IconLeftImage = null;
            this.btnExit.OnPressedState.IconRightImage = null;
            this.btnExit.Size = new System.Drawing.Size(149, 39);
            this.btnExit.TabIndex = 53;
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnExit.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.TextMarginLeft = 0;
            this.btnExit.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnExit.UseDefaultRadiusAndThickness = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ImportDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 618);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dtgvDetail);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ImportDetail";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ImportDetail";
            this.Load += new System.EventHandler(this.ImportDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public Guna.UI2.WinForms.Guna2DataGridView dtgvDetail;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnExit;
    }
}