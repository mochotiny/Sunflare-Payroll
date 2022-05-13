
namespace WFA_APP.View.Modules.Report.ReportPR
{
    partial class PR
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PR));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Weekly2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.WeeklyPR = new WFA_APP.View.Modules.Report.ReportPR.WeeklyPR();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Start = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.End = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.ShowBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Weekly2TableAdapter = new WFA_APP.View.Modules.Report.ReportPR.WeeklyPRTableAdapters.Weekly2TableAdapter();
            this.Dropdown = new Bunifu.UI.WinForms.BunifuDropdown();
            this.departmentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Department_DataSet = new WFA_APP._Department_DataSet();
            this.departmentsTableAdapter = new WFA_APP._Department_DataSetTableAdapters.DepartmentsTableAdapter();
            this.BtnDepartment = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Btn3Param = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Check = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.DropProj = new Bunifu.UI.WinForms.BunifuDropdown();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project_DataSet = new WFA_APP._Project_DataSet();
            this.projectsTableAdapter = new WFA_APP._Project_DataSetTableAdapters.ProjectsTableAdapter();
            this.Btn4Params = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.Weekly2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Department_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Weekly2BindingSource
            // 
            this.Weekly2BindingSource.DataMember = "Weekly2";
            this.Weekly2BindingSource.DataSource = this.WeeklyPR;
            // 
            // WeeklyPR
            // 
            this.WeeklyPR.DataSetName = "WeeklyPR";
            this.WeeklyPR.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.Weekly2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WFA_APP.View.Modules.Report.ReportPR.Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 62);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1170, 588);
            this.reportViewer1.TabIndex = 0;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Transparent;
            this.Start.BorderColor = System.Drawing.Color.Silver;
            this.Start.BorderRadius = 1;
            this.Start.Color = System.Drawing.Color.Silver;
            this.Start.CustomFormat = "yyyy-mm-dd";
            this.Start.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.Start.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.Start.DisabledColor = System.Drawing.Color.Gray;
            this.Start.DisplayWeekNumbers = false;
            this.Start.DPHeight = 0;
            this.Start.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.Start.FillDatePicker = false;
            this.Start.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Start.ForeColor = System.Drawing.Color.Black;
            this.Start.Icon = ((System.Drawing.Image)(resources.GetObject("Start.Icon")));
            this.Start.IconColor = System.Drawing.Color.Gray;
            this.Start.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.Start.LeftTextMargin = 5;
            this.Start.Location = new System.Drawing.Point(12, 12);
            this.Start.MinimumSize = new System.Drawing.Size(4, 32);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(169, 32);
            this.Start.TabIndex = 1;
            this.Start.Value = new System.DateTime(2022, 5, 6, 8, 32, 0, 0);
            // 
            // End
            // 
            this.End.BackColor = System.Drawing.Color.Transparent;
            this.End.BorderColor = System.Drawing.Color.Silver;
            this.End.BorderRadius = 1;
            this.End.Color = System.Drawing.Color.Silver;
            this.End.CustomFormat = "yyyy-mm-dd";
            this.End.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.End.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.End.DisabledColor = System.Drawing.Color.Gray;
            this.End.DisplayWeekNumbers = false;
            this.End.DPHeight = 0;
            this.End.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.End.FillDatePicker = false;
            this.End.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.End.ForeColor = System.Drawing.Color.Black;
            this.End.Icon = ((System.Drawing.Image)(resources.GetObject("End.Icon")));
            this.End.IconColor = System.Drawing.Color.Gray;
            this.End.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.End.LeftTextMargin = 5;
            this.End.Location = new System.Drawing.Point(187, 12);
            this.End.MinimumSize = new System.Drawing.Size(4, 32);
            this.End.Name = "End";
            this.End.Size = new System.Drawing.Size(169, 32);
            this.End.TabIndex = 2;
            // 
            // ShowBtn
            // 
            this.ShowBtn.AllowAnimations = true;
            this.ShowBtn.AllowMouseEffects = true;
            this.ShowBtn.AllowToggling = false;
            this.ShowBtn.AnimationSpeed = 200;
            this.ShowBtn.AutoGenerateColors = false;
            this.ShowBtn.AutoRoundBorders = false;
            this.ShowBtn.AutoSizeLeftIcon = true;
            this.ShowBtn.AutoSizeRightIcon = true;
            this.ShowBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.ShowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowBtn.BackgroundImage")));
            this.ShowBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ShowBtn.ButtonText = "Show";
            this.ShowBtn.ButtonTextMarginLeft = 0;
            this.ShowBtn.ColorContrastOnClick = 45;
            this.ShowBtn.ColorContrastOnHover = 45;
            this.ShowBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ShowBtn.CustomizableEdges = borderEdges1;
            this.ShowBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ShowBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ShowBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.ShowBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.ShowBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ShowBtn.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowBtn.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.IconLeft = null;
            this.ShowBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShowBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.ShowBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.ShowBtn.IconMarginLeft = 11;
            this.ShowBtn.IconPadding = 10;
            this.ShowBtn.IconRight = null;
            this.ShowBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ShowBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.ShowBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.ShowBtn.IconSize = 25;
            this.ShowBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.ShowBtn.IdleBorderRadius = 0;
            this.ShowBtn.IdleBorderThickness = 0;
            this.ShowBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.ShowBtn.IdleIconLeftImage = null;
            this.ShowBtn.IdleIconRightImage = null;
            this.ShowBtn.IndicateFocus = false;
            this.ShowBtn.Location = new System.Drawing.Point(710, 12);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.ShowBtn.OnDisabledState.BorderRadius = 1;
            this.ShowBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ShowBtn.OnDisabledState.BorderThickness = 1;
            this.ShowBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ShowBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ShowBtn.OnDisabledState.IconLeftImage = null;
            this.ShowBtn.OnDisabledState.IconRightImage = null;
            this.ShowBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ShowBtn.onHoverState.BorderRadius = 1;
            this.ShowBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ShowBtn.onHoverState.BorderThickness = 1;
            this.ShowBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.ShowBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.onHoverState.IconLeftImage = null;
            this.ShowBtn.onHoverState.IconRightImage = null;
            this.ShowBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ShowBtn.OnIdleState.BorderRadius = 1;
            this.ShowBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ShowBtn.OnIdleState.BorderThickness = 1;
            this.ShowBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ShowBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.OnIdleState.IconLeftImage = null;
            this.ShowBtn.OnIdleState.IconRightImage = null;
            this.ShowBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ShowBtn.OnPressedState.BorderRadius = 1;
            this.ShowBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ShowBtn.OnPressedState.BorderThickness = 1;
            this.ShowBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.ShowBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.OnPressedState.IconLeftImage = null;
            this.ShowBtn.OnPressedState.IconRightImage = null;
            this.ShowBtn.Size = new System.Drawing.Size(92, 32);
            this.ShowBtn.TabIndex = 3;
            this.ShowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowBtn.TextMarginLeft = 0;
            this.ShowBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.ShowBtn.UseDefaultRadiusAndThickness = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // Weekly2TableAdapter
            // 
            this.Weekly2TableAdapter.ClearBeforeFill = true;
            // 
            // Dropdown
            // 
            this.Dropdown.BackColor = System.Drawing.Color.Transparent;
            this.Dropdown.BackgroundColor = System.Drawing.Color.White;
            this.Dropdown.BorderColor = System.Drawing.Color.Silver;
            this.Dropdown.BorderRadius = 1;
            this.Dropdown.Color = System.Drawing.Color.Silver;
            this.Dropdown.DataSource = this.departmentsBindingSource;
            this.Dropdown.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.Dropdown.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dropdown.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Dropdown.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Dropdown.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Dropdown.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.Dropdown.DisplayMember = "Department_Name";
            this.Dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Dropdown.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.Dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Dropdown.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown.FillDropDown = true;
            this.Dropdown.FillIndicator = false;
            this.Dropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dropdown.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dropdown.ForeColor = System.Drawing.Color.Black;
            this.Dropdown.FormattingEnabled = true;
            this.Dropdown.Icon = null;
            this.Dropdown.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown.IndicatorColor = System.Drawing.Color.DarkGray;
            this.Dropdown.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.Dropdown.IndicatorThickness = 2;
            this.Dropdown.IsDropdownOpened = false;
            this.Dropdown.ItemBackColor = System.Drawing.Color.White;
            this.Dropdown.ItemBorderColor = System.Drawing.Color.White;
            this.Dropdown.ItemForeColor = System.Drawing.Color.Black;
            this.Dropdown.ItemHeight = 26;
            this.Dropdown.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.Dropdown.ItemHighLightForeColor = System.Drawing.Color.White;
            this.Dropdown.ItemTopMargin = 3;
            this.Dropdown.Location = new System.Drawing.Point(362, 12);
            this.Dropdown.Name = "Dropdown";
            this.Dropdown.Size = new System.Drawing.Size(168, 32);
            this.Dropdown.TabIndex = 8;
            this.Dropdown.Text = null;
            this.Dropdown.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.Dropdown.TextLeftMargin = 5;
            this.Dropdown.ValueMember = "DepartmentID";
            this.Dropdown.SelectedValueChanged += new System.EventHandler(this.Dropdown_SelectedValueChanged);
            // 
            // departmentsBindingSource
            // 
            this.departmentsBindingSource.DataMember = "Departments";
            this.departmentsBindingSource.DataSource = this._Department_DataSet;
            // 
            // _Department_DataSet
            // 
            this._Department_DataSet.DataSetName = "_Department_DataSet";
            this._Department_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentsTableAdapter
            // 
            this.departmentsTableAdapter.ClearBeforeFill = true;
            // 
            // BtnDepartment
            // 
            this.BtnDepartment.AllowAnimations = true;
            this.BtnDepartment.AllowMouseEffects = true;
            this.BtnDepartment.AllowToggling = false;
            this.BtnDepartment.AnimationSpeed = 200;
            this.BtnDepartment.AutoGenerateColors = false;
            this.BtnDepartment.AutoRoundBorders = false;
            this.BtnDepartment.AutoSizeLeftIcon = true;
            this.BtnDepartment.AutoSizeRightIcon = true;
            this.BtnDepartment.BackColor = System.Drawing.Color.Transparent;
            this.BtnDepartment.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnDepartment.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDepartment.BackgroundImage")));
            this.BtnDepartment.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDepartment.ButtonText = "Show";
            this.BtnDepartment.ButtonTextMarginLeft = 0;
            this.BtnDepartment.ColorContrastOnClick = 45;
            this.BtnDepartment.ColorContrastOnHover = 45;
            this.BtnDepartment.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnDepartment.CustomizableEdges = borderEdges2;
            this.BtnDepartment.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnDepartment.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDepartment.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnDepartment.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnDepartment.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnDepartment.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDepartment.ForeColor = System.Drawing.Color.White;
            this.BtnDepartment.IconLeft = null;
            this.BtnDepartment.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnDepartment.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnDepartment.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnDepartment.IconMarginLeft = 11;
            this.BtnDepartment.IconPadding = 10;
            this.BtnDepartment.IconRight = null;
            this.BtnDepartment.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnDepartment.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnDepartment.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnDepartment.IconSize = 25;
            this.BtnDepartment.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnDepartment.IdleBorderRadius = 0;
            this.BtnDepartment.IdleBorderThickness = 0;
            this.BtnDepartment.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnDepartment.IdleIconLeftImage = null;
            this.BtnDepartment.IdleIconRightImage = null;
            this.BtnDepartment.IndicateFocus = false;
            this.BtnDepartment.Location = new System.Drawing.Point(710, 12);
            this.BtnDepartment.Name = "BtnDepartment";
            this.BtnDepartment.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnDepartment.OnDisabledState.BorderRadius = 1;
            this.BtnDepartment.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDepartment.OnDisabledState.BorderThickness = 1;
            this.BtnDepartment.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnDepartment.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnDepartment.OnDisabledState.IconLeftImage = null;
            this.BtnDepartment.OnDisabledState.IconRightImage = null;
            this.BtnDepartment.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(209)))), ((int)(((byte)(85)))));
            this.BtnDepartment.onHoverState.BorderRadius = 1;
            this.BtnDepartment.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDepartment.onHoverState.BorderThickness = 1;
            this.BtnDepartment.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(209)))), ((int)(((byte)(85)))));
            this.BtnDepartment.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnDepartment.onHoverState.IconLeftImage = null;
            this.BtnDepartment.onHoverState.IconRightImage = null;
            this.BtnDepartment.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(52)))));
            this.BtnDepartment.OnIdleState.BorderRadius = 1;
            this.BtnDepartment.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDepartment.OnIdleState.BorderThickness = 1;
            this.BtnDepartment.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(52)))));
            this.BtnDepartment.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnDepartment.OnIdleState.IconLeftImage = null;
            this.BtnDepartment.OnIdleState.IconRightImage = null;
            this.BtnDepartment.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(131)))), ((int)(((byte)(36)))));
            this.BtnDepartment.OnPressedState.BorderRadius = 1;
            this.BtnDepartment.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnDepartment.OnPressedState.BorderThickness = 1;
            this.BtnDepartment.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(131)))), ((int)(((byte)(36)))));
            this.BtnDepartment.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnDepartment.OnPressedState.IconLeftImage = null;
            this.BtnDepartment.OnPressedState.IconRightImage = null;
            this.BtnDepartment.Size = new System.Drawing.Size(92, 32);
            this.BtnDepartment.TabIndex = 9;
            this.BtnDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnDepartment.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnDepartment.TextMarginLeft = 0;
            this.BtnDepartment.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnDepartment.UseDefaultRadiusAndThickness = true;
            this.BtnDepartment.Click += new System.EventHandler(this.BtnDepartment_Click);
            // 
            // Btn3Param
            // 
            this.Btn3Param.AllowAnimations = true;
            this.Btn3Param.AllowMouseEffects = true;
            this.Btn3Param.AllowToggling = false;
            this.Btn3Param.AnimationSpeed = 200;
            this.Btn3Param.AutoGenerateColors = false;
            this.Btn3Param.AutoRoundBorders = false;
            this.Btn3Param.AutoSizeLeftIcon = true;
            this.Btn3Param.AutoSizeRightIcon = true;
            this.Btn3Param.BackColor = System.Drawing.Color.Transparent;
            this.Btn3Param.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Btn3Param.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn3Param.BackgroundImage")));
            this.Btn3Param.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn3Param.ButtonText = "Show";
            this.Btn3Param.ButtonTextMarginLeft = 0;
            this.Btn3Param.ColorContrastOnClick = 45;
            this.Btn3Param.ColorContrastOnHover = 45;
            this.Btn3Param.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Btn3Param.CustomizableEdges = borderEdges3;
            this.Btn3Param.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn3Param.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn3Param.DisabledFillColor = System.Drawing.Color.Empty;
            this.Btn3Param.DisabledForecolor = System.Drawing.Color.Empty;
            this.Btn3Param.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn3Param.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn3Param.ForeColor = System.Drawing.Color.White;
            this.Btn3Param.IconLeft = null;
            this.Btn3Param.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn3Param.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn3Param.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn3Param.IconMarginLeft = 11;
            this.Btn3Param.IconPadding = 10;
            this.Btn3Param.IconRight = null;
            this.Btn3Param.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn3Param.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn3Param.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn3Param.IconSize = 25;
            this.Btn3Param.IdleBorderColor = System.Drawing.Color.Empty;
            this.Btn3Param.IdleBorderRadius = 0;
            this.Btn3Param.IdleBorderThickness = 0;
            this.Btn3Param.IdleFillColor = System.Drawing.Color.Empty;
            this.Btn3Param.IdleIconLeftImage = null;
            this.Btn3Param.IdleIconRightImage = null;
            this.Btn3Param.IndicateFocus = false;
            this.Btn3Param.Location = new System.Drawing.Point(710, 12);
            this.Btn3Param.Name = "Btn3Param";
            this.Btn3Param.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn3Param.OnDisabledState.BorderRadius = 1;
            this.Btn3Param.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn3Param.OnDisabledState.BorderThickness = 1;
            this.Btn3Param.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn3Param.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn3Param.OnDisabledState.IconLeftImage = null;
            this.Btn3Param.OnDisabledState.IconRightImage = null;
            this.Btn3Param.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(104)))), ((int)(((byte)(38)))));
            this.Btn3Param.onHoverState.BorderRadius = 1;
            this.Btn3Param.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn3Param.onHoverState.BorderThickness = 1;
            this.Btn3Param.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(104)))), ((int)(((byte)(38)))));
            this.Btn3Param.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn3Param.onHoverState.IconLeftImage = null;
            this.Btn3Param.onHoverState.IconRightImage = null;
            this.Btn3Param.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(120)))), ((int)(((byte)(38)))));
            this.Btn3Param.OnIdleState.BorderRadius = 1;
            this.Btn3Param.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn3Param.OnIdleState.BorderThickness = 1;
            this.Btn3Param.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(120)))), ((int)(((byte)(38)))));
            this.Btn3Param.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Btn3Param.OnIdleState.IconLeftImage = null;
            this.Btn3Param.OnIdleState.IconRightImage = null;
            this.Btn3Param.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(88)))), ((int)(((byte)(38)))));
            this.Btn3Param.OnPressedState.BorderRadius = 1;
            this.Btn3Param.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn3Param.OnPressedState.BorderThickness = 1;
            this.Btn3Param.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(88)))), ((int)(((byte)(38)))));
            this.Btn3Param.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn3Param.OnPressedState.IconLeftImage = null;
            this.Btn3Param.OnPressedState.IconRightImage = null;
            this.Btn3Param.Size = new System.Drawing.Size(92, 32);
            this.Btn3Param.TabIndex = 10;
            this.Btn3Param.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn3Param.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn3Param.TextMarginLeft = 0;
            this.Btn3Param.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn3Param.UseDefaultRadiusAndThickness = true;
            this.Btn3Param.Click += new System.EventHandler(this.Btn3Param_Click);
            // 
            // Check
            // 
            this.Check.AllowBindingControlAnimation = true;
            this.Check.AllowBindingControlColorChanges = false;
            this.Check.AllowBindingControlLocation = true;
            this.Check.AllowCheckBoxAnimation = false;
            this.Check.AllowCheckmarkAnimation = true;
            this.Check.AllowOnHoverStates = true;
            this.Check.AutoCheck = true;
            this.Check.BackColor = System.Drawing.Color.Transparent;
            this.Check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Check.BackgroundImage")));
            this.Check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Check.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Check.BorderRadius = 12;
            this.Check.Checked = false;
            this.Check.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Check.Cursor = System.Windows.Forms.Cursors.Default;
            this.Check.CustomCheckmarkImage = null;
            this.Check.Location = new System.Drawing.Point(808, 18);
            this.Check.MinimumSize = new System.Drawing.Size(17, 17);
            this.Check.Name = "Check";
            this.Check.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Check.OnCheck.BorderRadius = 12;
            this.Check.OnCheck.BorderThickness = 2;
            this.Check.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Check.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Check.OnCheck.CheckmarkThickness = 2;
            this.Check.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Check.OnDisable.BorderRadius = 12;
            this.Check.OnDisable.BorderThickness = 2;
            this.Check.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Check.OnDisable.CheckmarkThickness = 2;
            this.Check.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check.OnHoverChecked.BorderRadius = 12;
            this.Check.OnHoverChecked.BorderThickness = 2;
            this.Check.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Check.OnHoverChecked.CheckmarkThickness = 2;
            this.Check.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Check.OnHoverUnchecked.BorderRadius = 12;
            this.Check.OnHoverUnchecked.BorderThickness = 1;
            this.Check.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Check.OnUncheck.BorderRadius = 12;
            this.Check.OnUncheck.BorderThickness = 1;
            this.Check.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Check.Size = new System.Drawing.Size(21, 21);
            this.Check.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Check.TabIndex = 11;
            this.Check.ThreeState = false;
            this.Check.ToolTipText = null;
            this.Check.CheckStateChanged += new System.EventHandler<Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs>(this.Check_CheckStateChanged);
            // 
            // DropProj
            // 
            this.DropProj.BackColor = System.Drawing.Color.Transparent;
            this.DropProj.BackgroundColor = System.Drawing.Color.White;
            this.DropProj.BorderColor = System.Drawing.Color.Silver;
            this.DropProj.BorderRadius = 1;
            this.DropProj.Color = System.Drawing.Color.Silver;
            this.DropProj.DataSource = this.projectsBindingSource;
            this.DropProj.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.DropProj.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropProj.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DropProj.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DropProj.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.DropProj.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.DropProj.DisplayMember = "ProjName";
            this.DropProj.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DropProj.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.DropProj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropProj.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropProj.FillDropDown = true;
            this.DropProj.FillIndicator = false;
            this.DropProj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DropProj.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DropProj.ForeColor = System.Drawing.Color.Black;
            this.DropProj.FormattingEnabled = true;
            this.DropProj.Icon = null;
            this.DropProj.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropProj.IndicatorColor = System.Drawing.Color.DarkGray;
            this.DropProj.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.DropProj.IndicatorThickness = 2;
            this.DropProj.IsDropdownOpened = false;
            this.DropProj.ItemBackColor = System.Drawing.Color.White;
            this.DropProj.ItemBorderColor = System.Drawing.Color.White;
            this.DropProj.ItemForeColor = System.Drawing.Color.Black;
            this.DropProj.ItemHeight = 26;
            this.DropProj.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.DropProj.ItemHighLightForeColor = System.Drawing.Color.White;
            this.DropProj.ItemTopMargin = 3;
            this.DropProj.Location = new System.Drawing.Point(534, 12);
            this.DropProj.Name = "DropProj";
            this.DropProj.Size = new System.Drawing.Size(168, 32);
            this.DropProj.TabIndex = 12;
            this.DropProj.Text = null;
            this.DropProj.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropProj.TextLeftMargin = 5;
            this.DropProj.ValueMember = "ProjectID";
            this.DropProj.SelectedValueChanged += new System.EventHandler(this.DropProj_SelectedValueChanged);
            // 
            // projectsBindingSource
            // 
            this.projectsBindingSource.DataMember = "Projects";
            this.projectsBindingSource.DataSource = this._Project_DataSet;
            // 
            // _Project_DataSet
            // 
            this._Project_DataSet.DataSetName = "_Project_DataSet";
            this._Project_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsTableAdapter
            // 
            this.projectsTableAdapter.ClearBeforeFill = true;
            // 
            // Btn4Params
            // 
            this.Btn4Params.AllowAnimations = true;
            this.Btn4Params.AllowMouseEffects = true;
            this.Btn4Params.AllowToggling = false;
            this.Btn4Params.AnimationSpeed = 200;
            this.Btn4Params.AutoGenerateColors = false;
            this.Btn4Params.AutoRoundBorders = false;
            this.Btn4Params.AutoSizeLeftIcon = true;
            this.Btn4Params.AutoSizeRightIcon = true;
            this.Btn4Params.BackColor = System.Drawing.Color.Transparent;
            this.Btn4Params.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.Btn4Params.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn4Params.BackgroundImage")));
            this.Btn4Params.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn4Params.ButtonText = "Show";
            this.Btn4Params.ButtonTextMarginLeft = 0;
            this.Btn4Params.ColorContrastOnClick = 45;
            this.Btn4Params.ColorContrastOnHover = 45;
            this.Btn4Params.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.Btn4Params.CustomizableEdges = borderEdges4;
            this.Btn4Params.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Btn4Params.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn4Params.DisabledFillColor = System.Drawing.Color.Empty;
            this.Btn4Params.DisabledForecolor = System.Drawing.Color.Empty;
            this.Btn4Params.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Btn4Params.Font = new System.Drawing.Font("Inter", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn4Params.ForeColor = System.Drawing.Color.White;
            this.Btn4Params.IconLeft = null;
            this.Btn4Params.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn4Params.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Btn4Params.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Btn4Params.IconMarginLeft = 11;
            this.Btn4Params.IconPadding = 10;
            this.Btn4Params.IconRight = null;
            this.Btn4Params.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn4Params.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Btn4Params.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Btn4Params.IconSize = 25;
            this.Btn4Params.IdleBorderColor = System.Drawing.Color.Empty;
            this.Btn4Params.IdleBorderRadius = 0;
            this.Btn4Params.IdleBorderThickness = 0;
            this.Btn4Params.IdleFillColor = System.Drawing.Color.Empty;
            this.Btn4Params.IdleIconLeftImage = null;
            this.Btn4Params.IdleIconRightImage = null;
            this.Btn4Params.IndicateFocus = false;
            this.Btn4Params.Location = new System.Drawing.Point(710, 12);
            this.Btn4Params.Name = "Btn4Params";
            this.Btn4Params.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Btn4Params.OnDisabledState.BorderRadius = 1;
            this.Btn4Params.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn4Params.OnDisabledState.BorderThickness = 1;
            this.Btn4Params.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Btn4Params.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Btn4Params.OnDisabledState.IconLeftImage = null;
            this.Btn4Params.OnDisabledState.IconRightImage = null;
            this.Btn4Params.onHoverState.BorderColor = System.Drawing.Color.DarkCyan;
            this.Btn4Params.onHoverState.BorderRadius = 1;
            this.Btn4Params.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn4Params.onHoverState.BorderThickness = 1;
            this.Btn4Params.onHoverState.FillColor = System.Drawing.Color.DarkCyan;
            this.Btn4Params.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Btn4Params.onHoverState.IconLeftImage = null;
            this.Btn4Params.onHoverState.IconRightImage = null;
            this.Btn4Params.OnIdleState.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.Btn4Params.OnIdleState.BorderRadius = 1;
            this.Btn4Params.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn4Params.OnIdleState.BorderThickness = 1;
            this.Btn4Params.OnIdleState.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Btn4Params.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Btn4Params.OnIdleState.IconLeftImage = null;
            this.Btn4Params.OnIdleState.IconRightImage = null;
            this.Btn4Params.OnPressedState.BorderColor = System.Drawing.Color.DimGray;
            this.Btn4Params.OnPressedState.BorderRadius = 1;
            this.Btn4Params.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Btn4Params.OnPressedState.BorderThickness = 1;
            this.Btn4Params.OnPressedState.FillColor = System.Drawing.Color.DimGray;
            this.Btn4Params.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Btn4Params.OnPressedState.IconLeftImage = null;
            this.Btn4Params.OnPressedState.IconRightImage = null;
            this.Btn4Params.Size = new System.Drawing.Size(92, 32);
            this.Btn4Params.TabIndex = 13;
            this.Btn4Params.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Btn4Params.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Btn4Params.TextMarginLeft = 0;
            this.Btn4Params.TextPadding = new System.Windows.Forms.Padding(0);
            this.Btn4Params.UseDefaultRadiusAndThickness = true;
            this.Btn4Params.Click += new System.EventHandler(this.Btn4Params_Click);
            // 
            // PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 650);
            this.Controls.Add(this.Btn4Params);
            this.Controls.Add(this.DropProj);
            this.Controls.Add(this.Check);
            this.Controls.Add(this.Btn3Param);
            this.Controls.Add(this.BtnDepartment);
            this.Controls.Add(this.Dropdown);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.End);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PR";
            this.Text = "PR";
            this.Load += new System.EventHandler(this.PR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Weekly2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyPR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Department_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private WeeklyPR WeeklyPR;
        private Bunifu.UI.WinForms.BunifuDatePicker Start;
        private Bunifu.UI.WinForms.BunifuDatePicker End;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ShowBtn;
        private System.Windows.Forms.BindingSource Weekly2BindingSource;
        private WeeklyPRTableAdapters.Weekly2TableAdapter Weekly2TableAdapter;
        private Bunifu.UI.WinForms.BunifuDropdown Dropdown;
        private _Department_DataSet _Department_DataSet;
        private System.Windows.Forms.BindingSource departmentsBindingSource;
        private _Department_DataSetTableAdapters.DepartmentsTableAdapter departmentsTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnDepartment;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn3Param;
        private Bunifu.UI.WinForms.BunifuCheckBox Check;
        private Bunifu.UI.WinForms.BunifuDropdown DropProj;
        private _Project_DataSet _Project_DataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private _Project_DataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Btn4Params;
    }
}