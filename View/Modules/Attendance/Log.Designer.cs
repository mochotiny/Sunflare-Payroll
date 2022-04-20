namespace WFA_APP.View.Modules.Attendance
{
    partial class Log
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.EmpDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Employee_DataSet = new WFA_APP._Employee_DataSet();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DayWork = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Inlabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.OutLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.DayLabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.Overtime = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PunchLog = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.CloseBtn = new System.Windows.Forms.PictureBox();
            this.employeesTableAdapter = new WFA_APP._Employee_DataSetTableAdapters.EmployeesTableAdapter();
            this.TimeIn = new System.Windows.Forms.DateTimePicker();
            this.TimeOut = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Employee_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            this.SuspendLayout();
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
            this.EmpDrop.IsDropdownOpened = false;
            this.EmpDrop.ItemBackColor = System.Drawing.Color.White;
            this.EmpDrop.ItemBorderColor = System.Drawing.Color.White;
            this.EmpDrop.ItemForeColor = System.Drawing.Color.Black;
            this.EmpDrop.ItemHeight = 26;
            this.EmpDrop.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.EmpDrop.ItemHighLightForeColor = System.Drawing.Color.White;
            this.EmpDrop.ItemTopMargin = 3;
            this.EmpDrop.Location = new System.Drawing.Point(41, 77);
            this.EmpDrop.Name = "EmpDrop";
            this.EmpDrop.Size = new System.Drawing.Size(230, 32);
            this.EmpDrop.TabIndex = 0;
            this.EmpDrop.Text = null;
            this.EmpDrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.EmpDrop.TextLeftMargin = 5;
            this.EmpDrop.ValueMember = "BiometricID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this._Employee_DataSet;
            // 
            // _Employee_DataSet
            // 
            this._Employee_DataSet.DataSetName = "_Employee_DataSet";
            this._Employee_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = null;
            this.bunifuDragControl1.Vertical = true;
            // 
            // DayWork
            // 
            this.DayWork.BackColor = System.Drawing.Color.Transparent;
            this.DayWork.BorderColor = System.Drawing.Color.Silver;
            this.DayWork.BorderRadius = 1;
            this.DayWork.Color = System.Drawing.Color.Silver;
            this.DayWork.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DayWork.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DayWork.DisabledColor = System.Drawing.Color.Gray;
            this.DayWork.DisplayWeekNumbers = false;
            this.DayWork.DPHeight = 0;
            this.DayWork.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DayWork.FillDatePicker = false;
            this.DayWork.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DayWork.ForeColor = System.Drawing.Color.Black;
            this.DayWork.Icon = ((System.Drawing.Image)(resources.GetObject("DayWork.Icon")));
            this.DayWork.IconColor = System.Drawing.Color.Gray;
            this.DayWork.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DayWork.LeftTextMargin = 5;
            this.DayWork.Location = new System.Drawing.Point(41, 139);
            this.DayWork.MinimumSize = new System.Drawing.Size(4, 32);
            this.DayWork.Name = "DayWork";
            this.DayWork.Size = new System.Drawing.Size(230, 32);
            this.DayWork.TabIndex = 1;
            // 
            // Inlabel
            // 
            this.Inlabel.AllowParentOverrides = false;
            this.Inlabel.AutoEllipsis = false;
            this.Inlabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.Inlabel.CursorType = System.Windows.Forms.Cursors.Default;
            this.Inlabel.Font = new System.Drawing.Font("Inter", 9.75F);
            this.Inlabel.Location = new System.Drawing.Point(316, 56);
            this.Inlabel.Name = "Inlabel";
            this.Inlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Inlabel.Size = new System.Drawing.Size(45, 16);
            this.Inlabel.TabIndex = 4;
            this.Inlabel.Text = "Time In";
            this.Inlabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.Inlabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // OutLabel
            // 
            this.OutLabel.AllowParentOverrides = false;
            this.OutLabel.AutoEllipsis = false;
            this.OutLabel.CursorType = null;
            this.OutLabel.Font = new System.Drawing.Font("Inter", 9.75F);
            this.OutLabel.Location = new System.Drawing.Point(316, 120);
            this.OutLabel.Name = "OutLabel";
            this.OutLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.OutLabel.Size = new System.Drawing.Size(57, 16);
            this.OutLabel.TabIndex = 5;
            this.OutLabel.Text = "Time Out";
            this.OutLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.OutLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DayLabel
            // 
            this.DayLabel.AllowParentOverrides = false;
            this.DayLabel.AutoEllipsis = false;
            this.DayLabel.CursorType = null;
            this.DayLabel.Font = new System.Drawing.Font("Inter", 9.75F);
            this.DayLabel.Location = new System.Drawing.Point(41, 120);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DayLabel.Size = new System.Drawing.Size(23, 16);
            this.DayLabel.TabIndex = 6;
            this.DayLabel.Text = "Day";
            this.DayLabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.DayLabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Overtime
            // 
            this.Overtime.AcceptsReturn = false;
            this.Overtime.AcceptsTab = false;
            this.Overtime.AnimationSpeed = 200;
            this.Overtime.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Overtime.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Overtime.AutoSizeHeight = true;
            this.Overtime.BackColor = System.Drawing.Color.Transparent;
            this.Overtime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Overtime.BackgroundImage")));
            this.Overtime.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Overtime.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Overtime.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Overtime.BorderColorIdle = System.Drawing.Color.Silver;
            this.Overtime.BorderRadius = 1;
            this.Overtime.BorderThickness = 1;
            this.Overtime.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Overtime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Overtime.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.Overtime.DefaultText = "";
            this.Overtime.FillColor = System.Drawing.Color.White;
            this.Overtime.HideSelection = true;
            this.Overtime.IconLeft = null;
            this.Overtime.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Overtime.IconPadding = 10;
            this.Overtime.IconRight = null;
            this.Overtime.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Overtime.Lines = new string[0];
            this.Overtime.Location = new System.Drawing.Point(602, 77);
            this.Overtime.MaxLength = 32767;
            this.Overtime.MinimumSize = new System.Drawing.Size(1, 1);
            this.Overtime.Modified = false;
            this.Overtime.Multiline = false;
            this.Overtime.Name = "Overtime";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Overtime.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Overtime.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Overtime.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Overtime.OnIdleState = stateProperties4;
            this.Overtime.Padding = new System.Windows.Forms.Padding(3);
            this.Overtime.PasswordChar = '\0';
            this.Overtime.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Overtime.PlaceholderText = "Overtime (0.00)";
            this.Overtime.ReadOnly = false;
            this.Overtime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Overtime.SelectedText = "";
            this.Overtime.SelectionLength = 0;
            this.Overtime.SelectionStart = 0;
            this.Overtime.ShortcutsEnabled = true;
            this.Overtime.Size = new System.Drawing.Size(207, 32);
            this.Overtime.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Overtime.TabIndex = 7;
            this.Overtime.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Overtime.TextMarginBottom = 0;
            this.Overtime.TextMarginLeft = 3;
            this.Overtime.TextMarginTop = 1;
            this.Overtime.TextPlaceholder = "Overtime (0.00)";
            this.Overtime.UseSystemPasswordChar = false;
            this.Overtime.WordWrap = true;
            // 
            // PunchLog
            // 
            this.PunchLog.AllowAnimations = true;
            this.PunchLog.AllowMouseEffects = true;
            this.PunchLog.AllowToggling = false;
            this.PunchLog.AnimationSpeed = 200;
            this.PunchLog.AutoGenerateColors = false;
            this.PunchLog.AutoRoundBorders = false;
            this.PunchLog.AutoSizeLeftIcon = true;
            this.PunchLog.AutoSizeRightIcon = true;
            this.PunchLog.BackColor = System.Drawing.Color.Transparent;
            this.PunchLog.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.PunchLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PunchLog.BackgroundImage")));
            this.PunchLog.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PunchLog.ButtonText = "Log";
            this.PunchLog.ButtonTextMarginLeft = 0;
            this.PunchLog.ColorContrastOnClick = 45;
            this.PunchLog.ColorContrastOnHover = 45;
            this.PunchLog.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.PunchLog.CustomizableEdges = borderEdges1;
            this.PunchLog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.PunchLog.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PunchLog.DisabledFillColor = System.Drawing.Color.Empty;
            this.PunchLog.DisabledForecolor = System.Drawing.Color.Empty;
            this.PunchLog.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.PunchLog.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.PunchLog.ForeColor = System.Drawing.Color.White;
            this.PunchLog.IconLeft = null;
            this.PunchLog.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PunchLog.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.PunchLog.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.PunchLog.IconMarginLeft = 11;
            this.PunchLog.IconPadding = 10;
            this.PunchLog.IconRight = null;
            this.PunchLog.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PunchLog.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.PunchLog.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.PunchLog.IconSize = 25;
            this.PunchLog.IdleBorderColor = System.Drawing.Color.Empty;
            this.PunchLog.IdleBorderRadius = 0;
            this.PunchLog.IdleBorderThickness = 0;
            this.PunchLog.IdleFillColor = System.Drawing.Color.Empty;
            this.PunchLog.IdleIconLeftImage = null;
            this.PunchLog.IdleIconRightImage = null;
            this.PunchLog.IndicateFocus = false;
            this.PunchLog.Location = new System.Drawing.Point(602, 139);
            this.PunchLog.Name = "PunchLog";
            this.PunchLog.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.PunchLog.OnDisabledState.BorderRadius = 1;
            this.PunchLog.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PunchLog.OnDisabledState.BorderThickness = 1;
            this.PunchLog.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PunchLog.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.PunchLog.OnDisabledState.IconLeftImage = null;
            this.PunchLog.OnDisabledState.IconRightImage = null;
            this.PunchLog.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.PunchLog.onHoverState.BorderRadius = 1;
            this.PunchLog.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PunchLog.onHoverState.BorderThickness = 1;
            this.PunchLog.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.PunchLog.onHoverState.ForeColor = System.Drawing.Color.White;
            this.PunchLog.onHoverState.IconLeftImage = null;
            this.PunchLog.onHoverState.IconRightImage = null;
            this.PunchLog.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.PunchLog.OnIdleState.BorderRadius = 1;
            this.PunchLog.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PunchLog.OnIdleState.BorderThickness = 1;
            this.PunchLog.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.PunchLog.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.PunchLog.OnIdleState.IconLeftImage = null;
            this.PunchLog.OnIdleState.IconRightImage = null;
            this.PunchLog.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.PunchLog.OnPressedState.BorderRadius = 1;
            this.PunchLog.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.PunchLog.OnPressedState.BorderThickness = 1;
            this.PunchLog.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.PunchLog.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.PunchLog.OnPressedState.IconLeftImage = null;
            this.PunchLog.OnPressedState.IconRightImage = null;
            this.PunchLog.Size = new System.Drawing.Size(207, 32);
            this.PunchLog.TabIndex = 8;
            this.PunchLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PunchLog.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.PunchLog.TextMarginLeft = 0;
            this.PunchLog.TextPadding = new System.Windows.Forms.Padding(0);
            this.PunchLog.UseDefaultRadiusAndThickness = true;
            this.PunchLog.Click += new System.EventHandler(this.PunchLog_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::WFA_APP.Properties.Resources.cancel;
            this.CloseBtn.Location = new System.Drawing.Point(816, 7);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(38, 32);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CloseBtn.TabIndex = 9;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // TimeIn
            // 
            this.TimeIn.CustomFormat = "hh:mm:ss";
            this.TimeIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeIn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeIn.Location = new System.Drawing.Point(316, 78);
            this.TimeIn.Name = "TimeIn";
            this.TimeIn.ShowUpDown = true;
            this.TimeIn.Size = new System.Drawing.Size(230, 29);
            this.TimeIn.TabIndex = 7;
            this.TimeIn.Value = new System.DateTime(2022, 4, 20, 2, 40, 0, 0);
            // 
            // TimeOut
            // 
            this.TimeOut.CustomFormat = "hh:mm:ss";
            this.TimeOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeOut.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeOut.Location = new System.Drawing.Point(316, 139);
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ShowUpDown = true;
            this.TimeOut.Size = new System.Drawing.Size(230, 29);
            this.TimeOut.TabIndex = 10;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 227);
            this.Controls.Add(this.TimeOut);
            this.Controls.Add(this.TimeIn);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.PunchLog);
            this.Controls.Add(this.Overtime);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.OutLabel);
            this.Controls.Add(this.Inlabel);
            this.Controls.Add(this.DayWork);
            this.Controls.Add(this.EmpDrop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Log";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Log";
            this.Load += new System.EventHandler(this.Log_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Employee_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown EmpDrop;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuDatePicker DayWork;
        private Bunifu.UI.WinForms.BunifuLabel Inlabel;
        private Bunifu.UI.WinForms.BunifuLabel OutLabel;
        private Bunifu.UI.WinForms.BunifuLabel DayLabel;
        private Bunifu.UI.WinForms.BunifuTextBox Overtime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton PunchLog;
        private System.Windows.Forms.PictureBox CloseBtn;
        private _Employee_DataSet _Employee_DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _Employee_DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.DateTimePicker TimeIn;
        private System.Windows.Forms.DateTimePicker TimeOut;
    }
}