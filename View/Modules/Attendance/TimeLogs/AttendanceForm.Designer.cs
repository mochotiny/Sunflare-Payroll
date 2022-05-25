namespace WFA_APP.View.Modules.Attendance
{
    partial class AttendanceForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.AttDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.EmpDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._pr_appDataSet = new WFA_APP._pr_appDataSet();
            this.StartAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.EndAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.LogBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.UpdateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FilterLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.RefreshBtn = new System.Windows.Forms.PictureBox();
            this.employeesTableAdapter = new WFA_APP._pr_appDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AttDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._pr_appDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // AttDgv
            // 
            this.AttDgv.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.AttDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AttDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AttDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AttDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AttDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AttDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AttDgv.ColumnHeadersHeight = 40;
            this.AttDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.AttDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.AttDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AttDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.AttDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AttDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.AttDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.AttDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.AttDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.AttDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AttDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.AttDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AttDgv.CurrentTheme.Name = null;
            this.AttDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AttDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.AttDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AttDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.AttDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AttDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.AttDgv.EnableHeadersVisualStyles = false;
            this.AttDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.AttDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.AttDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.AttDgv.HeaderForeColor = System.Drawing.Color.White;
            this.AttDgv.Location = new System.Drawing.Point(12, 110);
            this.AttDgv.Name = "AttDgv";
            this.AttDgv.ReadOnly = true;
            this.AttDgv.RowHeadersVisible = false;
            this.AttDgv.RowTemplate.Height = 40;
            this.AttDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AttDgv.Size = new System.Drawing.Size(1144, 517);
            this.AttDgv.TabIndex = 0;
            this.AttDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // EmpDrop
            // 
            this.EmpDrop.BackColor = System.Drawing.Color.Transparent;
            this.EmpDrop.BackgroundColor = System.Drawing.Color.White;
            this.EmpDrop.BorderColor = System.Drawing.Color.Silver;
            this.EmpDrop.BorderRadius = 1;
            this.EmpDrop.Color = System.Drawing.Color.Silver;
            this.EmpDrop.DataSource = this.employeesBindingSource;
            this.EmpDrop.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.EmpDrop.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.EmpDrop.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.EmpDrop.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.EmpDrop.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.EmpDrop.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.EmpDrop.DisplayMember = "Employee_Name";
            this.EmpDrop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EmpDrop.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.EmpDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmpDrop.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.EmpDrop.FillDropDown = true;
            this.EmpDrop.FillIndicator = false;
            this.EmpDrop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmpDrop.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmpDrop.ForeColor = System.Drawing.Color.Black;
            this.EmpDrop.FormattingEnabled = true;
            this.EmpDrop.Icon = null;
            this.EmpDrop.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.EmpDrop.IndicatorColor = System.Drawing.Color.DarkGray;
            this.EmpDrop.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.EmpDrop.IndicatorThickness = 2;
            this.EmpDrop.IntegralHeight = false;
            this.EmpDrop.IsDropdownOpened = false;
            this.EmpDrop.ItemBackColor = System.Drawing.Color.White;
            this.EmpDrop.ItemBorderColor = System.Drawing.Color.White;
            this.EmpDrop.ItemForeColor = System.Drawing.Color.Black;
            this.EmpDrop.ItemHeight = 26;
            this.EmpDrop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.EmpDrop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.EmpDrop.ItemTopMargin = 3;
            this.EmpDrop.Location = new System.Drawing.Point(12, 72);
            this.EmpDrop.MaxDropDownItems = 15;
            this.EmpDrop.Name = "EmpDrop";
            this.EmpDrop.Size = new System.Drawing.Size(260, 32);
            this.EmpDrop.TabIndex = 1;
            this.EmpDrop.Text = null;
            this.EmpDrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.EmpDrop.TextLeftMargin = 5;
            this.EmpDrop.ValueMember = "BiometricID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this._pr_appDataSet;
            // 
            // _pr_appDataSet
            // 
            this._pr_appDataSet.DataSetName = "_pr_appDataSet";
            this._pr_appDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // StartAt
            // 
            this.StartAt.BackColor = System.Drawing.Color.Transparent;
            this.StartAt.BorderColor = System.Drawing.Color.Silver;
            this.StartAt.BorderRadius = 1;
            this.StartAt.Color = System.Drawing.Color.Silver;
            this.StartAt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.StartAt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.StartAt.DisabledColor = System.Drawing.Color.Gray;
            this.StartAt.DisplayWeekNumbers = false;
            this.StartAt.DPHeight = 0;
            this.StartAt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.StartAt.FillDatePicker = false;
            this.StartAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartAt.ForeColor = System.Drawing.Color.Black;
            this.StartAt.Icon = ((System.Drawing.Image)(resources.GetObject("StartAt.Icon")));
            this.StartAt.IconColor = System.Drawing.Color.Gray;
            this.StartAt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.StartAt.LeftTextMargin = 5;
            this.StartAt.Location = new System.Drawing.Point(278, 72);
            this.StartAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.StartAt.Name = "StartAt";
            this.StartAt.Size = new System.Drawing.Size(178, 32);
            this.StartAt.TabIndex = 2;
            // 
            // EndAt
            // 
            this.EndAt.BackColor = System.Drawing.Color.Transparent;
            this.EndAt.BorderColor = System.Drawing.Color.Silver;
            this.EndAt.BorderRadius = 1;
            this.EndAt.Color = System.Drawing.Color.Silver;
            this.EndAt.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.EndAt.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.EndAt.DisabledColor = System.Drawing.Color.Gray;
            this.EndAt.DisplayWeekNumbers = false;
            this.EndAt.DPHeight = 0;
            this.EndAt.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.EndAt.FillDatePicker = false;
            this.EndAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndAt.ForeColor = System.Drawing.Color.Black;
            this.EndAt.Icon = ((System.Drawing.Image)(resources.GetObject("EndAt.Icon")));
            this.EndAt.IconColor = System.Drawing.Color.Gray;
            this.EndAt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.EndAt.LeftTextMargin = 5;
            this.EndAt.Location = new System.Drawing.Point(473, 72);
            this.EndAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.EndAt.Name = "EndAt";
            this.EndAt.Size = new System.Drawing.Size(178, 32);
            this.EndAt.TabIndex = 3;
            // 
            // LogBtn
            // 
            this.LogBtn.AllowAnimations = true;
            this.LogBtn.AllowMouseEffects = true;
            this.LogBtn.AllowToggling = false;
            this.LogBtn.AnimationSpeed = 200;
            this.LogBtn.AutoGenerateColors = false;
            this.LogBtn.AutoRoundBorders = false;
            this.LogBtn.AutoSizeLeftIcon = true;
            this.LogBtn.AutoSizeRightIcon = true;
            this.LogBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.LogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogBtn.BackgroundImage")));
            this.LogBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogBtn.ButtonText = "Log";
            this.LogBtn.ButtonTextMarginLeft = 0;
            this.LogBtn.ColorContrastOnClick = 45;
            this.LogBtn.ColorContrastOnHover = 45;
            this.LogBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.LogBtn.CustomizableEdges = borderEdges1;
            this.LogBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LogBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.LogBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.LogBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LogBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.ForeColor = System.Drawing.Color.White;
            this.LogBtn.IconLeft = null;
            this.LogBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LogBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LogBtn.IconMarginLeft = 11;
            this.LogBtn.IconPadding = 10;
            this.LogBtn.IconRight = null;
            this.LogBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LogBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LogBtn.IconSize = 25;
            this.LogBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.LogBtn.IdleBorderRadius = 0;
            this.LogBtn.IdleBorderThickness = 0;
            this.LogBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.LogBtn.IdleIconLeftImage = null;
            this.LogBtn.IdleIconRightImage = null;
            this.LogBtn.IndicateFocus = false;
            this.LogBtn.Location = new System.Drawing.Point(913, 72);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LogBtn.OnDisabledState.BorderRadius = 1;
            this.LogBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogBtn.OnDisabledState.BorderThickness = 1;
            this.LogBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LogBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LogBtn.OnDisabledState.IconLeftImage = null;
            this.LogBtn.OnDisabledState.IconRightImage = null;
            this.LogBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.LogBtn.onHoverState.BorderRadius = 1;
            this.LogBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogBtn.onHoverState.BorderThickness = 1;
            this.LogBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.LogBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LogBtn.onHoverState.IconLeftImage = null;
            this.LogBtn.onHoverState.IconRightImage = null;
            this.LogBtn.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LogBtn.OnIdleState.BorderRadius = 1;
            this.LogBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogBtn.OnIdleState.BorderThickness = 1;
            this.LogBtn.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.LogBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LogBtn.OnIdleState.IconLeftImage = null;
            this.LogBtn.OnIdleState.IconRightImage = null;
            this.LogBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogBtn.OnPressedState.BorderRadius = 1;
            this.LogBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LogBtn.OnPressedState.BorderThickness = 1;
            this.LogBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.LogBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LogBtn.OnPressedState.IconLeftImage = null;
            this.LogBtn.OnPressedState.IconRightImage = null;
            this.LogBtn.Size = new System.Drawing.Size(117, 29);
            this.LogBtn.TabIndex = 4;
            this.LogBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LogBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogBtn.TextMarginLeft = 0;
            this.LogBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LogBtn.UseDefaultRadiusAndThickness = true;
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.AllowAnimations = true;
            this.UpdateBtn.AllowMouseEffects = true;
            this.UpdateBtn.AllowToggling = false;
            this.UpdateBtn.AnimationSpeed = 200;
            this.UpdateBtn.AutoGenerateColors = false;
            this.UpdateBtn.AutoRoundBorders = false;
            this.UpdateBtn.AutoSizeLeftIcon = true;
            this.UpdateBtn.AutoSizeRightIcon = true;
            this.UpdateBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.UpdateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpdateBtn.BackgroundImage")));
            this.UpdateBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.ButtonText = "Update";
            this.UpdateBtn.ButtonTextMarginLeft = 0;
            this.UpdateBtn.ColorContrastOnClick = 45;
            this.UpdateBtn.ColorContrastOnHover = 45;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.UpdateBtn.CustomizableEdges = borderEdges2;
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.UpdateBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.UpdateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.UpdateBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.IconLeft = null;
            this.UpdateBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpdateBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.UpdateBtn.IconMarginLeft = 11;
            this.UpdateBtn.IconPadding = 10;
            this.UpdateBtn.IconRight = null;
            this.UpdateBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.UpdateBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.UpdateBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.UpdateBtn.IconSize = 25;
            this.UpdateBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.UpdateBtn.IdleBorderRadius = 0;
            this.UpdateBtn.IdleBorderThickness = 0;
            this.UpdateBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.UpdateBtn.IdleIconLeftImage = null;
            this.UpdateBtn.IdleIconRightImage = null;
            this.UpdateBtn.IndicateFocus = false;
            this.UpdateBtn.Location = new System.Drawing.Point(1039, 72);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateBtn.OnDisabledState.BorderRadius = 1;
            this.UpdateBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnDisabledState.BorderThickness = 1;
            this.UpdateBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateBtn.OnDisabledState.IconLeftImage = null;
            this.UpdateBtn.OnDisabledState.IconRightImage = null;
            this.UpdateBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(209)))), ((int)(((byte)(85)))));
            this.UpdateBtn.onHoverState.BorderRadius = 1;
            this.UpdateBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.onHoverState.BorderThickness = 1;
            this.UpdateBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(209)))), ((int)(((byte)(85)))));
            this.UpdateBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.onHoverState.IconLeftImage = null;
            this.UpdateBtn.onHoverState.IconRightImage = null;
            this.UpdateBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(52)))));
            this.UpdateBtn.OnIdleState.BorderRadius = 1;
            this.UpdateBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnIdleState.BorderThickness = 1;
            this.UpdateBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(52)))));
            this.UpdateBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.OnIdleState.IconLeftImage = null;
            this.UpdateBtn.OnIdleState.IconRightImage = null;
            this.UpdateBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(131)))), ((int)(((byte)(36)))));
            this.UpdateBtn.OnPressedState.BorderRadius = 1;
            this.UpdateBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnPressedState.BorderThickness = 1;
            this.UpdateBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(131)))), ((int)(((byte)(36)))));
            this.UpdateBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.OnPressedState.IconLeftImage = null;
            this.UpdateBtn.OnPressedState.IconRightImage = null;
            this.UpdateBtn.Size = new System.Drawing.Size(117, 29);
            this.UpdateBtn.TabIndex = 5;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBtn.TextMarginLeft = 0;
            this.UpdateBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateBtn.UseDefaultRadiusAndThickness = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AllowParentOverrides = false;
            this.FilterLabel.AutoEllipsis = false;
            this.FilterLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilterLabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.FilterLabel.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FilterLabel.Location = new System.Drawing.Point(12, 41);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FilterLabel.Size = new System.Drawing.Size(50, 25);
            this.FilterLabel.TabIndex = 6;
            this.FilterLabel.Text = "Filter";
            this.FilterLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.FilterLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.FilterLabel.Click += new System.EventHandler(this.FilterLabel_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Image = global::WFA_APP.Properties.Resources.refresh;
            this.RefreshBtn.Location = new System.Drawing.Point(694, 72);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(37, 31);
            this.RefreshBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RefreshBtn.TabIndex = 7;
            this.RefreshBtn.TabStop = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // AttendanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 639);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.EndAt);
            this.Controls.Add(this.StartAt);
            this.Controls.Add(this.EmpDrop);
            this.Controls.Add(this.AttDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AttendanceForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendanceForm";
            this.Load += new System.EventHandler(this.AttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AttDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._pr_appDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RefreshBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView AttDgv;
        private Bunifu.UI.WinForms.BunifuDropdown EmpDrop;
        private Bunifu.UI.WinForms.BunifuDatePicker StartAt;
        private Bunifu.UI.WinForms.BunifuDatePicker EndAt;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LogBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateBtn;
        private Bunifu.UI.WinForms.BunifuLabel FilterLabel;
        private System.Windows.Forms.PictureBox RefreshBtn;
        private _pr_appDataSet _pr_appDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _pr_appDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}