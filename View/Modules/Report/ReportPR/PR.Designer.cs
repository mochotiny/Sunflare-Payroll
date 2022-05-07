
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
            ((System.ComponentModel.ISupportInitialize)(this.Weekly2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WeeklyPR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Department_DataSet)).BeginInit();
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
            this.ShowBtn.Location = new System.Drawing.Point(536, 12);
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
            this.Dropdown.ValueMember = "Department_Name";
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
            // PR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 650);
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
    }
}