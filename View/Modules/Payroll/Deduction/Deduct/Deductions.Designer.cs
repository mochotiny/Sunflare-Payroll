namespace WFA_APP.View.Modules.Payroll.Deduction
{
    partial class Deductions
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deductions));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.DeductDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.DeductBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Startat = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Endat = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.ProjDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this._pr_appDataSet = new WFA_APP._pr_appDataSet();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectsTableAdapter = new WFA_APP._pr_appDataSetTableAdapters.ProjectsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DeductDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pr_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DeductDgv
            // 
            this.DeductDgv.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.DeductDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DeductDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DeductDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DeductDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DeductDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeductDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DeductDgv.ColumnHeadersHeight = 40;
            this.DeductDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DeductDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeductDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DeductDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DeductDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DeductDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DeductDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DeductDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.DeductDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.DeductDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DeductDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.DeductDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DeductDgv.CurrentTheme.Name = null;
            this.DeductDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DeductDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.DeductDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DeductDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DeductDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DeductDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.DeductDgv.EnableHeadersVisualStyles = false;
            this.DeductDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DeductDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.DeductDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.DeductDgv.HeaderForeColor = System.Drawing.Color.White;
            this.DeductDgv.Location = new System.Drawing.Point(12, 65);
            this.DeductDgv.Name = "DeductDgv";
            this.DeductDgv.ReadOnly = true;
            this.DeductDgv.RowHeadersVisible = false;
            this.DeductDgv.RowTemplate.Height = 40;
            this.DeductDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DeductDgv.Size = new System.Drawing.Size(1120, 498);
            this.DeductDgv.TabIndex = 0;
            this.DeductDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // DeductBtn
            // 
            this.DeductBtn.AllowAnimations = true;
            this.DeductBtn.AllowMouseEffects = true;
            this.DeductBtn.AllowToggling = false;
            this.DeductBtn.AnimationSpeed = 200;
            this.DeductBtn.AutoGenerateColors = false;
            this.DeductBtn.AutoRoundBorders = false;
            this.DeductBtn.AutoSizeLeftIcon = true;
            this.DeductBtn.AutoSizeRightIcon = true;
            this.DeductBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeductBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DeductBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeductBtn.BackgroundImage")));
            this.DeductBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeductBtn.ButtonText = "Deduction";
            this.DeductBtn.ButtonTextMarginLeft = 0;
            this.DeductBtn.ColorContrastOnClick = 45;
            this.DeductBtn.ColorContrastOnHover = 45;
            this.DeductBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.DeductBtn.CustomizableEdges = borderEdges2;
            this.DeductBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeductBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeductBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.DeductBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.DeductBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DeductBtn.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeductBtn.ForeColor = System.Drawing.Color.White;
            this.DeductBtn.IconLeft = null;
            this.DeductBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeductBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeductBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeductBtn.IconMarginLeft = 11;
            this.DeductBtn.IconPadding = 10;
            this.DeductBtn.IconRight = null;
            this.DeductBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeductBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeductBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeductBtn.IconSize = 25;
            this.DeductBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.DeductBtn.IdleBorderRadius = 0;
            this.DeductBtn.IdleBorderThickness = 0;
            this.DeductBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.DeductBtn.IdleIconLeftImage = null;
            this.DeductBtn.IdleIconRightImage = null;
            this.DeductBtn.IndicateFocus = false;
            this.DeductBtn.Location = new System.Drawing.Point(12, 27);
            this.DeductBtn.Name = "DeductBtn";
            this.DeductBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeductBtn.OnDisabledState.BorderRadius = 1;
            this.DeductBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeductBtn.OnDisabledState.BorderThickness = 1;
            this.DeductBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeductBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeductBtn.OnDisabledState.IconLeftImage = null;
            this.DeductBtn.OnDisabledState.IconRightImage = null;
            this.DeductBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.DeductBtn.onHoverState.BorderRadius = 1;
            this.DeductBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeductBtn.onHoverState.BorderThickness = 1;
            this.DeductBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.DeductBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DeductBtn.onHoverState.IconLeftImage = null;
            this.DeductBtn.onHoverState.IconRightImage = null;
            this.DeductBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.DeductBtn.OnIdleState.BorderRadius = 1;
            this.DeductBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeductBtn.OnIdleState.BorderThickness = 1;
            this.DeductBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.DeductBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DeductBtn.OnIdleState.IconLeftImage = null;
            this.DeductBtn.OnIdleState.IconRightImage = null;
            this.DeductBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeductBtn.OnPressedState.BorderRadius = 1;
            this.DeductBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeductBtn.OnPressedState.BorderThickness = 1;
            this.DeductBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.DeductBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeductBtn.OnPressedState.IconLeftImage = null;
            this.DeductBtn.OnPressedState.IconRightImage = null;
            this.DeductBtn.Size = new System.Drawing.Size(150, 32);
            this.DeductBtn.TabIndex = 1;
            this.DeductBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeductBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeductBtn.TextMarginLeft = 0;
            this.DeductBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeductBtn.UseDefaultRadiusAndThickness = true;
            this.DeductBtn.Click += new System.EventHandler(this.DeductBtn_Click);
            // 
            // Startat
            // 
            this.Startat.BackColor = System.Drawing.Color.Transparent;
            this.Startat.BorderColor = System.Drawing.Color.Silver;
            this.Startat.BorderRadius = 1;
            this.Startat.Color = System.Drawing.Color.Silver;
            this.Startat.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Startat.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Startat.DisabledColor = System.Drawing.Color.Gray;
            this.Startat.DisplayWeekNumbers = false;
            this.Startat.DPHeight = 0;
            this.Startat.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Startat.FillDatePicker = false;
            this.Startat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Startat.ForeColor = System.Drawing.Color.Black;
            this.Startat.Icon = ((System.Drawing.Image)(resources.GetObject("Startat.Icon")));
            this.Startat.IconColor = System.Drawing.Color.Gray;
            this.Startat.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Startat.LeftTextMargin = 5;
            this.Startat.Location = new System.Drawing.Point(179, 27);
            this.Startat.MinimumSize = new System.Drawing.Size(4, 32);
            this.Startat.Name = "Startat";
            this.Startat.Size = new System.Drawing.Size(178, 32);
            this.Startat.TabIndex = 2;
            // 
            // Endat
            // 
            this.Endat.BackColor = System.Drawing.Color.Transparent;
            this.Endat.BorderColor = System.Drawing.Color.Silver;
            this.Endat.BorderRadius = 1;
            this.Endat.Color = System.Drawing.Color.Silver;
            this.Endat.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Endat.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Endat.DisabledColor = System.Drawing.Color.Gray;
            this.Endat.DisplayWeekNumbers = false;
            this.Endat.DPHeight = 0;
            this.Endat.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Endat.FillDatePicker = false;
            this.Endat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Endat.ForeColor = System.Drawing.Color.Black;
            this.Endat.Icon = ((System.Drawing.Image)(resources.GetObject("Endat.Icon")));
            this.Endat.IconColor = System.Drawing.Color.Gray;
            this.Endat.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Endat.LeftTextMargin = 5;
            this.Endat.Location = new System.Drawing.Point(375, 27);
            this.Endat.MinimumSize = new System.Drawing.Size(4, 32);
            this.Endat.Name = "Endat";
            this.Endat.Size = new System.Drawing.Size(178, 32);
            this.Endat.TabIndex = 3;
            // 
            // ProjDrop
            // 
            this.ProjDrop.BackColor = System.Drawing.Color.Transparent;
            this.ProjDrop.BackgroundColor = System.Drawing.Color.White;
            this.ProjDrop.BorderColor = System.Drawing.Color.Silver;
            this.ProjDrop.BorderRadius = 1;
            this.ProjDrop.Color = System.Drawing.Color.Silver;
            this.ProjDrop.DataSource = this.projectsBindingSource;
            this.ProjDrop.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ProjDrop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ProjDrop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ProjDrop.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ProjDrop.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ProjDrop.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ProjDrop.DisplayMember = "ProjName";
            this.ProjDrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ProjDrop.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ProjDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjDrop.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ProjDrop.FillDropDown = true;
            this.ProjDrop.FillIndicator = false;
            this.ProjDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ProjDrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProjDrop.ForeColor = System.Drawing.Color.Black;
            this.ProjDrop.FormattingEnabled = true;
            this.ProjDrop.Icon = null;
            this.ProjDrop.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ProjDrop.IndicatorColor = System.Drawing.Color.DarkGray;
            this.ProjDrop.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ProjDrop.IndicatorThickness = 2;
            this.ProjDrop.IsDropdownOpened = false;
            this.ProjDrop.ItemBackColor = System.Drawing.Color.White;
            this.ProjDrop.ItemBorderColor = System.Drawing.Color.White;
            this.ProjDrop.ItemForeColor = System.Drawing.Color.Black;
            this.ProjDrop.ItemHeight = 26;
            this.ProjDrop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ProjDrop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ProjDrop.ItemTopMargin = 3;
            this.ProjDrop.Location = new System.Drawing.Point(573, 27);
            this.ProjDrop.Name = "ProjDrop";
            this.ProjDrop.Size = new System.Drawing.Size(177, 32);
            this.ProjDrop.TabIndex = 4;
            this.ProjDrop.Text = null;
            this.ProjDrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ProjDrop.TextLeftMargin = 5;
            this.ProjDrop.ValueMember = "ProjectID";
            // 
            // _pr_appDataSet
            // 
            this._pr_appDataSet.DataSetName = "_pr_appDataSet";
            this._pr_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this._pr_appDataSet;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // Deductions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1144, 575);
            this.Controls.Add(this.ProjDrop);
            this.Controls.Add(this.Endat);
            this.Controls.Add(this.Startat);
            this.Controls.Add(this.DeductBtn);
            this.Controls.Add(this.DeductDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Deductions";
            this.Text = "Deductions";
            this.Load += new System.EventHandler(this.Deductions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DeductDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pr_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView DeductDgv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeductBtn;
        private Bunifu.UI.WinForms.BunifuDatePicker Startat;
        private Bunifu.UI.WinForms.BunifuDatePicker Endat;
        private Bunifu.UI.WinForms.BunifuDropdown ProjDrop;
        private _pr_appDataSet _pr_appDataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private _pr_appDataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        //private DB_Project_DatasetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
    }
}