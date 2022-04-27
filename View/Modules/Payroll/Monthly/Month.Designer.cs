namespace WFA_APP.View.Modules.Payroll.Monthly
{
    partial class Month
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Month));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnMonthlyPayroll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MonthDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.Month_PhilHealth = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Month_PagIbig = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Month_SSS = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.PhilHealth = new Bunifu.UI.WinForms.BunifuLabel();
            this.PagIbig = new Bunifu.UI.WinForms.BunifuLabel();
            this.SSS = new Bunifu.UI.WinForms.BunifuLabel();
            this.StartAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.EndAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.MonthDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnMonthlyPayroll
            // 
            this.BtnMonthlyPayroll.AllowAnimations = true;
            this.BtnMonthlyPayroll.AllowMouseEffects = true;
            this.BtnMonthlyPayroll.AllowToggling = false;
            this.BtnMonthlyPayroll.AnimationSpeed = 200;
            this.BtnMonthlyPayroll.AutoGenerateColors = false;
            this.BtnMonthlyPayroll.AutoRoundBorders = false;
            this.BtnMonthlyPayroll.AutoSizeLeftIcon = true;
            this.BtnMonthlyPayroll.AutoSizeRightIcon = true;
            this.BtnMonthlyPayroll.BackColor = System.Drawing.Color.Transparent;
            this.BtnMonthlyPayroll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnMonthlyPayroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMonthlyPayroll.BackgroundImage")));
            this.BtnMonthlyPayroll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMonthlyPayroll.ButtonText = "Run Payroll";
            this.BtnMonthlyPayroll.ButtonTextMarginLeft = 0;
            this.BtnMonthlyPayroll.ColorContrastOnClick = 45;
            this.BtnMonthlyPayroll.ColorContrastOnHover = 45;
            this.BtnMonthlyPayroll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnMonthlyPayroll.CustomizableEdges = borderEdges1;
            this.BtnMonthlyPayroll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMonthlyPayroll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMonthlyPayroll.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnMonthlyPayroll.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnMonthlyPayroll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnMonthlyPayroll.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMonthlyPayroll.ForeColor = System.Drawing.Color.White;
            this.BtnMonthlyPayroll.IconLeft = null;
            this.BtnMonthlyPayroll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMonthlyPayroll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnMonthlyPayroll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnMonthlyPayroll.IconMarginLeft = 11;
            this.BtnMonthlyPayroll.IconPadding = 10;
            this.BtnMonthlyPayroll.IconRight = null;
            this.BtnMonthlyPayroll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMonthlyPayroll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnMonthlyPayroll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnMonthlyPayroll.IconSize = 25;
            this.BtnMonthlyPayroll.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnMonthlyPayroll.IdleBorderRadius = 0;
            this.BtnMonthlyPayroll.IdleBorderThickness = 0;
            this.BtnMonthlyPayroll.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnMonthlyPayroll.IdleIconLeftImage = null;
            this.BtnMonthlyPayroll.IdleIconRightImage = null;
            this.BtnMonthlyPayroll.IndicateFocus = false;
            this.BtnMonthlyPayroll.Location = new System.Drawing.Point(12, 60);
            this.BtnMonthlyPayroll.Name = "BtnMonthlyPayroll";
            this.BtnMonthlyPayroll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMonthlyPayroll.OnDisabledState.BorderRadius = 1;
            this.BtnMonthlyPayroll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMonthlyPayroll.OnDisabledState.BorderThickness = 1;
            this.BtnMonthlyPayroll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnMonthlyPayroll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnMonthlyPayroll.OnDisabledState.IconLeftImage = null;
            this.BtnMonthlyPayroll.OnDisabledState.IconRightImage = null;
            this.BtnMonthlyPayroll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnMonthlyPayroll.onHoverState.BorderRadius = 1;
            this.BtnMonthlyPayroll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMonthlyPayroll.onHoverState.BorderThickness = 1;
            this.BtnMonthlyPayroll.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnMonthlyPayroll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnMonthlyPayroll.onHoverState.IconLeftImage = null;
            this.BtnMonthlyPayroll.onHoverState.IconRightImage = null;
            this.BtnMonthlyPayroll.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnMonthlyPayroll.OnIdleState.BorderRadius = 1;
            this.BtnMonthlyPayroll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMonthlyPayroll.OnIdleState.BorderThickness = 1;
            this.BtnMonthlyPayroll.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnMonthlyPayroll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnMonthlyPayroll.OnIdleState.IconLeftImage = null;
            this.BtnMonthlyPayroll.OnIdleState.IconRightImage = null;
            this.BtnMonthlyPayroll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnMonthlyPayroll.OnPressedState.BorderRadius = 1;
            this.BtnMonthlyPayroll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMonthlyPayroll.OnPressedState.BorderThickness = 1;
            this.BtnMonthlyPayroll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnMonthlyPayroll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnMonthlyPayroll.OnPressedState.IconLeftImage = null;
            this.BtnMonthlyPayroll.OnPressedState.IconRightImage = null;
            this.BtnMonthlyPayroll.Size = new System.Drawing.Size(150, 32);
            this.BtnMonthlyPayroll.TabIndex = 19;
            this.BtnMonthlyPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnMonthlyPayroll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnMonthlyPayroll.TextMarginLeft = 0;
            this.BtnMonthlyPayroll.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnMonthlyPayroll.UseDefaultRadiusAndThickness = true;
            this.BtnMonthlyPayroll.Click += new System.EventHandler(this.RunBtn_Click);
            // 
            // MonthDgv
            // 
            this.MonthDgv.AllowCustomTheming = false;
            this.MonthDgv.AllowUserToResizeColumns = false;
            this.MonthDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.MonthDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.MonthDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.MonthDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MonthDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MonthDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.MonthDgv.ColumnHeadersHeight = 40;
            this.MonthDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.MonthDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MonthDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MonthDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MonthDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.MonthDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.MonthDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MonthDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.MonthDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.MonthDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.MonthDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.MonthDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.MonthDgv.CurrentTheme.Name = null;
            this.MonthDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MonthDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MonthDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.MonthDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.MonthDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MonthDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.MonthDgv.EnableHeadersVisualStyles = false;
            this.MonthDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.MonthDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.MonthDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.MonthDgv.HeaderForeColor = System.Drawing.Color.White;
            this.MonthDgv.Location = new System.Drawing.Point(12, 98);
            this.MonthDgv.Name = "MonthDgv";
            this.MonthDgv.RowHeadersVisible = false;
            this.MonthDgv.RowTemplate.Height = 40;
            this.MonthDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MonthDgv.Size = new System.Drawing.Size(1144, 547);
            this.MonthDgv.TabIndex = 10;
            this.MonthDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // Month_PhilHealth
            // 
            this.Month_PhilHealth.AllowBindingControlAnimation = true;
            this.Month_PhilHealth.AllowBindingControlColorChanges = false;
            this.Month_PhilHealth.AllowBindingControlLocation = true;
            this.Month_PhilHealth.AllowCheckBoxAnimation = false;
            this.Month_PhilHealth.AllowCheckmarkAnimation = true;
            this.Month_PhilHealth.AllowOnHoverStates = true;
            this.Month_PhilHealth.AutoCheck = true;
            this.Month_PhilHealth.BackColor = System.Drawing.Color.Transparent;
            this.Month_PhilHealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Month_PhilHealth.BackgroundImage")));
            this.Month_PhilHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Month_PhilHealth.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Month_PhilHealth.BorderRadius = 12;
            this.Month_PhilHealth.Checked = false;
            this.Month_PhilHealth.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Month_PhilHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.Month_PhilHealth.CustomCheckmarkImage = null;
            this.Month_PhilHealth.Location = new System.Drawing.Point(177, 66);
            this.Month_PhilHealth.MinimumSize = new System.Drawing.Size(17, 17);
            this.Month_PhilHealth.Name = "Month_PhilHealth";
            this.Month_PhilHealth.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Month_PhilHealth.OnCheck.BorderRadius = 12;
            this.Month_PhilHealth.OnCheck.BorderThickness = 2;
            this.Month_PhilHealth.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Month_PhilHealth.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Month_PhilHealth.OnCheck.CheckmarkThickness = 2;
            this.Month_PhilHealth.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Month_PhilHealth.OnDisable.BorderRadius = 12;
            this.Month_PhilHealth.OnDisable.BorderThickness = 2;
            this.Month_PhilHealth.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_PhilHealth.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Month_PhilHealth.OnDisable.CheckmarkThickness = 2;
            this.Month_PhilHealth.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_PhilHealth.OnHoverChecked.BorderRadius = 12;
            this.Month_PhilHealth.OnHoverChecked.BorderThickness = 2;
            this.Month_PhilHealth.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_PhilHealth.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Month_PhilHealth.OnHoverChecked.CheckmarkThickness = 2;
            this.Month_PhilHealth.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_PhilHealth.OnHoverUnchecked.BorderRadius = 12;
            this.Month_PhilHealth.OnHoverUnchecked.BorderThickness = 1;
            this.Month_PhilHealth.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_PhilHealth.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Month_PhilHealth.OnUncheck.BorderRadius = 12;
            this.Month_PhilHealth.OnUncheck.BorderThickness = 1;
            this.Month_PhilHealth.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_PhilHealth.Size = new System.Drawing.Size(21, 21);
            this.Month_PhilHealth.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Month_PhilHealth.TabIndex = 13;
            this.Month_PhilHealth.ThreeState = false;
            this.Month_PhilHealth.ToolTipText = null;
            // 
            // Month_PagIbig
            // 
            this.Month_PagIbig.AllowBindingControlAnimation = true;
            this.Month_PagIbig.AllowBindingControlColorChanges = false;
            this.Month_PagIbig.AllowBindingControlLocation = true;
            this.Month_PagIbig.AllowCheckBoxAnimation = false;
            this.Month_PagIbig.AllowCheckmarkAnimation = true;
            this.Month_PagIbig.AllowOnHoverStates = true;
            this.Month_PagIbig.AutoCheck = true;
            this.Month_PagIbig.BackColor = System.Drawing.Color.Transparent;
            this.Month_PagIbig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Month_PagIbig.BackgroundImage")));
            this.Month_PagIbig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Month_PagIbig.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Month_PagIbig.BorderRadius = 12;
            this.Month_PagIbig.Checked = false;
            this.Month_PagIbig.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Month_PagIbig.Cursor = System.Windows.Forms.Cursors.Default;
            this.Month_PagIbig.CustomCheckmarkImage = null;
            this.Month_PagIbig.Location = new System.Drawing.Point(269, 66);
            this.Month_PagIbig.MinimumSize = new System.Drawing.Size(17, 17);
            this.Month_PagIbig.Name = "Month_PagIbig";
            this.Month_PagIbig.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Month_PagIbig.OnCheck.BorderRadius = 12;
            this.Month_PagIbig.OnCheck.BorderThickness = 2;
            this.Month_PagIbig.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Month_PagIbig.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Month_PagIbig.OnCheck.CheckmarkThickness = 2;
            this.Month_PagIbig.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Month_PagIbig.OnDisable.BorderRadius = 12;
            this.Month_PagIbig.OnDisable.BorderThickness = 2;
            this.Month_PagIbig.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_PagIbig.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Month_PagIbig.OnDisable.CheckmarkThickness = 2;
            this.Month_PagIbig.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_PagIbig.OnHoverChecked.BorderRadius = 12;
            this.Month_PagIbig.OnHoverChecked.BorderThickness = 2;
            this.Month_PagIbig.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_PagIbig.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Month_PagIbig.OnHoverChecked.CheckmarkThickness = 2;
            this.Month_PagIbig.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_PagIbig.OnHoverUnchecked.BorderRadius = 12;
            this.Month_PagIbig.OnHoverUnchecked.BorderThickness = 1;
            this.Month_PagIbig.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_PagIbig.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Month_PagIbig.OnUncheck.BorderRadius = 12;
            this.Month_PagIbig.OnUncheck.BorderThickness = 1;
            this.Month_PagIbig.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_PagIbig.Size = new System.Drawing.Size(21, 21);
            this.Month_PagIbig.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Month_PagIbig.TabIndex = 14;
            this.Month_PagIbig.ThreeState = false;
            this.Month_PagIbig.ToolTipText = null;
            // 
            // Month_SSS
            // 
            this.Month_SSS.AllowBindingControlAnimation = true;
            this.Month_SSS.AllowBindingControlColorChanges = false;
            this.Month_SSS.AllowBindingControlLocation = true;
            this.Month_SSS.AllowCheckBoxAnimation = false;
            this.Month_SSS.AllowCheckmarkAnimation = true;
            this.Month_SSS.AllowOnHoverStates = true;
            this.Month_SSS.AutoCheck = true;
            this.Month_SSS.BackColor = System.Drawing.Color.Transparent;
            this.Month_SSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Month_SSS.BackgroundImage")));
            this.Month_SSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Month_SSS.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Month_SSS.BorderRadius = 12;
            this.Month_SSS.Checked = false;
            this.Month_SSS.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Month_SSS.Cursor = System.Windows.Forms.Cursors.Default;
            this.Month_SSS.CustomCheckmarkImage = null;
            this.Month_SSS.Location = new System.Drawing.Point(361, 66);
            this.Month_SSS.MinimumSize = new System.Drawing.Size(17, 17);
            this.Month_SSS.Name = "Month_SSS";
            this.Month_SSS.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Month_SSS.OnCheck.BorderRadius = 12;
            this.Month_SSS.OnCheck.BorderThickness = 2;
            this.Month_SSS.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Month_SSS.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Month_SSS.OnCheck.CheckmarkThickness = 2;
            this.Month_SSS.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Month_SSS.OnDisable.BorderRadius = 12;
            this.Month_SSS.OnDisable.BorderThickness = 2;
            this.Month_SSS.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_SSS.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Month_SSS.OnDisable.CheckmarkThickness = 2;
            this.Month_SSS.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_SSS.OnHoverChecked.BorderRadius = 12;
            this.Month_SSS.OnHoverChecked.BorderThickness = 2;
            this.Month_SSS.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_SSS.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Month_SSS.OnHoverChecked.CheckmarkThickness = 2;
            this.Month_SSS.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Month_SSS.OnHoverUnchecked.BorderRadius = 12;
            this.Month_SSS.OnHoverUnchecked.BorderThickness = 1;
            this.Month_SSS.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_SSS.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Month_SSS.OnUncheck.BorderRadius = 12;
            this.Month_SSS.OnUncheck.BorderThickness = 1;
            this.Month_SSS.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Month_SSS.Size = new System.Drawing.Size(21, 21);
            this.Month_SSS.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Month_SSS.TabIndex = 15;
            this.Month_SSS.ThreeState = false;
            this.Month_SSS.ToolTipText = null;
            // 
            // PhilHealth
            // 
            this.PhilHealth.AllowParentOverrides = false;
            this.PhilHealth.AutoEllipsis = false;
            this.PhilHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhilHealth.CursorType = System.Windows.Forms.Cursors.Default;
            this.PhilHealth.Font = new System.Drawing.Font("Inter", 9.75F);
            this.PhilHealth.Location = new System.Drawing.Point(200, 68);
            this.PhilHealth.Name = "PhilHealth";
            this.PhilHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhilHealth.Size = new System.Drawing.Size(63, 16);
            this.PhilHealth.TabIndex = 16;
            this.PhilHealth.Text = "PhilHealth";
            this.PhilHealth.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PhilHealth.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PagIbig
            // 
            this.PagIbig.AllowParentOverrides = false;
            this.PagIbig.AutoEllipsis = false;
            this.PagIbig.CursorType = null;
            this.PagIbig.Font = new System.Drawing.Font("Inter", 9.75F);
            this.PagIbig.Location = new System.Drawing.Point(292, 68);
            this.PagIbig.Name = "PagIbig";
            this.PagIbig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PagIbig.Size = new System.Drawing.Size(45, 16);
            this.PagIbig.TabIndex = 17;
            this.PagIbig.Text = "PagIbig";
            this.PagIbig.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.PagIbig.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SSS
            // 
            this.SSS.AllowParentOverrides = false;
            this.SSS.AutoEllipsis = false;
            this.SSS.CursorType = null;
            this.SSS.Font = new System.Drawing.Font("Inter", 9.75F);
            this.SSS.Location = new System.Drawing.Point(384, 68);
            this.SSS.Name = "SSS";
            this.SSS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SSS.Size = new System.Drawing.Size(24, 16);
            this.SSS.TabIndex = 18;
            this.SSS.Text = "SSS";
            this.SSS.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SSS.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.StartAt.FillDatePicker = false;
            this.StartAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.StartAt.ForeColor = System.Drawing.Color.Black;
            this.StartAt.Icon = ((System.Drawing.Image)(resources.GetObject("StartAt.Icon")));
            this.StartAt.IconColor = System.Drawing.Color.Gray;
            this.StartAt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.StartAt.LeftTextMargin = 5;
            this.StartAt.Location = new System.Drawing.Point(12, 12);
            this.StartAt.MinimumSize = new System.Drawing.Size(0, 32);
            this.StartAt.Name = "StartAt";
            this.StartAt.Size = new System.Drawing.Size(184, 32);
            this.StartAt.TabIndex = 20;
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
            this.EndAt.FillDatePicker = false;
            this.EndAt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EndAt.ForeColor = System.Drawing.Color.Black;
            this.EndAt.Icon = ((System.Drawing.Image)(resources.GetObject("EndAt.Icon")));
            this.EndAt.IconColor = System.Drawing.Color.Gray;
            this.EndAt.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.EndAt.LeftTextMargin = 5;
            this.EndAt.Location = new System.Drawing.Point(224, 12);
            this.EndAt.MinimumSize = new System.Drawing.Size(0, 32);
            this.EndAt.Name = "EndAt";
            this.EndAt.Size = new System.Drawing.Size(184, 32);
            this.EndAt.TabIndex = 21;
            // 
            // Month
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1168, 657);
            this.Controls.Add(this.EndAt);
            this.Controls.Add(this.StartAt);
            this.Controls.Add(this.BtnMonthlyPayroll);
            this.Controls.Add(this.SSS);
            this.Controls.Add(this.PagIbig);
            this.Controls.Add(this.PhilHealth);
            this.Controls.Add(this.Month_SSS);
            this.Controls.Add(this.Month_PagIbig);
            this.Controls.Add(this.Month_PhilHealth);
            this.Controls.Add(this.MonthDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Month";
            this.Text = "Monthly";
            ((System.ComponentModel.ISupportInitialize)(this.MonthDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnMonthlyPayroll;
        private Bunifu.UI.WinForms.BunifuDataGridView MonthDgv;
        private Bunifu.UI.WinForms.BunifuCheckBox Month_PhilHealth;
        private Bunifu.UI.WinForms.BunifuCheckBox Month_PagIbig;
        private Bunifu.UI.WinForms.BunifuCheckBox Month_SSS;
        private Bunifu.UI.WinForms.BunifuLabel PhilHealth;
        private Bunifu.UI.WinForms.BunifuLabel PagIbig;
        private Bunifu.UI.WinForms.BunifuLabel SSS;
        private Bunifu.UI.WinForms.BunifuDatePicker StartAt;
        private Bunifu.UI.WinForms.BunifuDatePicker EndAt;
    }
}