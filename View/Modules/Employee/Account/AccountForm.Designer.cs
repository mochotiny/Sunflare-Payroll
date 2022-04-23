namespace WFA_APP.View.Modules.Employee.Account
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.AccountDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.CA = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnUpdateBalance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnCreateBalance = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Pay = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CheckBtn = new System.Windows.Forms.PictureBox();
            this.EmpDrop = new Bunifu.UI.WinForms.BunifuDropdown();
            this._Employee_DataSet = new WFA_APP._Employee_DataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WFA_APP._Employee_DataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.AccountDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Employee_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountDgv
            // 
            this.AccountDgv.AllowCustomTheming = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.AccountDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.AccountDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AccountDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AccountDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AccountDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.AccountDgv.ColumnHeadersHeight = 40;
            this.AccountDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.AccountDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.AccountDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AccountDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.AccountDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.AccountDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.AccountDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.AccountDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.AccountDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.AccountDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AccountDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.AccountDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.AccountDgv.CurrentTheme.Name = null;
            this.AccountDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AccountDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.AccountDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.AccountDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.AccountDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AccountDgv.DefaultCellStyle = dataGridViewCellStyle6;
            this.AccountDgv.EnableHeadersVisualStyles = false;
            this.AccountDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.AccountDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.AccountDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.AccountDgv.HeaderForeColor = System.Drawing.Color.White;
            this.AccountDgv.Location = new System.Drawing.Point(465, 12);
            this.AccountDgv.Name = "AccountDgv";
            this.AccountDgv.RowHeadersVisible = false;
            this.AccountDgv.RowTemplate.Height = 40;
            this.AccountDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountDgv.Size = new System.Drawing.Size(602, 465);
            this.AccountDgv.TabIndex = 0;
            this.AccountDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // CA
            // 
            this.CA.AcceptsReturn = false;
            this.CA.AcceptsTab = false;
            this.CA.AnimationSpeed = 200;
            this.CA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CA.AutoSizeHeight = true;
            this.CA.BackColor = System.Drawing.Color.Transparent;
            this.CA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CA.BackgroundImage")));
            this.CA.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.CA.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CA.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.CA.BorderColorIdle = System.Drawing.Color.Silver;
            this.CA.BorderRadius = 1;
            this.CA.BorderThickness = 1;
            this.CA.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CA.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CA.DefaultFont = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CA.DefaultText = "";
            this.CA.FillColor = System.Drawing.Color.White;
            this.CA.HideSelection = true;
            this.CA.IconLeft = null;
            this.CA.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.CA.IconPadding = 10;
            this.CA.IconRight = null;
            this.CA.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.CA.Lines = new string[0];
            this.CA.Location = new System.Drawing.Point(37, 111);
            this.CA.MaxLength = 32767;
            this.CA.MinimumSize = new System.Drawing.Size(1, 1);
            this.CA.Modified = false;
            this.CA.Multiline = false;
            this.CA.Name = "CA";
            stateProperties9.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CA.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.CA.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CA.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Silver;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.CA.OnIdleState = stateProperties12;
            this.CA.Padding = new System.Windows.Forms.Padding(3);
            this.CA.PasswordChar = '\0';
            this.CA.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.CA.PlaceholderText = "CA (0.00)";
            this.CA.ReadOnly = false;
            this.CA.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CA.SelectedText = "";
            this.CA.SelectionLength = 0;
            this.CA.SelectionStart = 0;
            this.CA.ShortcutsEnabled = true;
            this.CA.Size = new System.Drawing.Size(209, 35);
            this.CA.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.CA.TabIndex = 2;
            this.CA.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CA.TextMarginBottom = 0;
            this.CA.TextMarginLeft = 3;
            this.CA.TextMarginTop = 1;
            this.CA.TextPlaceholder = "CA (0.00)";
            this.CA.UseSystemPasswordChar = false;
            this.CA.WordWrap = true;
            // 
            // BtnUpdateBalance
            // 
            this.BtnUpdateBalance.AllowAnimations = true;
            this.BtnUpdateBalance.AllowMouseEffects = true;
            this.BtnUpdateBalance.AllowToggling = false;
            this.BtnUpdateBalance.AnimationSpeed = 200;
            this.BtnUpdateBalance.AutoGenerateColors = false;
            this.BtnUpdateBalance.AutoRoundBorders = false;
            this.BtnUpdateBalance.AutoSizeLeftIcon = true;
            this.BtnUpdateBalance.AutoSizeRightIcon = true;
            this.BtnUpdateBalance.BackColor = System.Drawing.Color.Transparent;
            this.BtnUpdateBalance.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnUpdateBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnUpdateBalance.BackgroundImage")));
            this.BtnUpdateBalance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnUpdateBalance.ButtonText = "Update";
            this.BtnUpdateBalance.ButtonTextMarginLeft = 0;
            this.BtnUpdateBalance.ColorContrastOnClick = 45;
            this.BtnUpdateBalance.ColorContrastOnHover = 45;
            this.BtnUpdateBalance.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BtnUpdateBalance.CustomizableEdges = borderEdges3;
            this.BtnUpdateBalance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnUpdateBalance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnUpdateBalance.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnUpdateBalance.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnUpdateBalance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnUpdateBalance.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateBalance.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateBalance.IconLeft = null;
            this.BtnUpdateBalance.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnUpdateBalance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnUpdateBalance.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnUpdateBalance.IconMarginLeft = 11;
            this.BtnUpdateBalance.IconPadding = 10;
            this.BtnUpdateBalance.IconRight = null;
            this.BtnUpdateBalance.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnUpdateBalance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnUpdateBalance.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnUpdateBalance.IconSize = 25;
            this.BtnUpdateBalance.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnUpdateBalance.IdleBorderRadius = 0;
            this.BtnUpdateBalance.IdleBorderThickness = 0;
            this.BtnUpdateBalance.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnUpdateBalance.IdleIconLeftImage = null;
            this.BtnUpdateBalance.IdleIconRightImage = null;
            this.BtnUpdateBalance.IndicateFocus = false;
            this.BtnUpdateBalance.Location = new System.Drawing.Point(37, 289);
            this.BtnUpdateBalance.Name = "BtnUpdateBalance";
            this.BtnUpdateBalance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnUpdateBalance.OnDisabledState.BorderRadius = 1;
            this.BtnUpdateBalance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnUpdateBalance.OnDisabledState.BorderThickness = 1;
            this.BtnUpdateBalance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnUpdateBalance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnUpdateBalance.OnDisabledState.IconLeftImage = null;
            this.BtnUpdateBalance.OnDisabledState.IconRightImage = null;
            this.BtnUpdateBalance.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(209)))), ((int)(((byte)(85)))));
            this.BtnUpdateBalance.onHoverState.BorderRadius = 1;
            this.BtnUpdateBalance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnUpdateBalance.onHoverState.BorderThickness = 1;
            this.BtnUpdateBalance.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(209)))), ((int)(((byte)(85)))));
            this.BtnUpdateBalance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateBalance.onHoverState.IconLeftImage = null;
            this.BtnUpdateBalance.onHoverState.IconRightImage = null;
            this.BtnUpdateBalance.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(52)))));
            this.BtnUpdateBalance.OnIdleState.BorderRadius = 1;
            this.BtnUpdateBalance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnUpdateBalance.OnIdleState.BorderThickness = 1;
            this.BtnUpdateBalance.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(191)))), ((int)(((byte)(52)))));
            this.BtnUpdateBalance.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateBalance.OnIdleState.IconLeftImage = null;
            this.BtnUpdateBalance.OnIdleState.IconRightImage = null;
            this.BtnUpdateBalance.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(131)))), ((int)(((byte)(36)))));
            this.BtnUpdateBalance.OnPressedState.BorderRadius = 1;
            this.BtnUpdateBalance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnUpdateBalance.OnPressedState.BorderThickness = 1;
            this.BtnUpdateBalance.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(131)))), ((int)(((byte)(36)))));
            this.BtnUpdateBalance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateBalance.OnPressedState.IconLeftImage = null;
            this.BtnUpdateBalance.OnPressedState.IconRightImage = null;
            this.BtnUpdateBalance.Size = new System.Drawing.Size(209, 36);
            this.BtnUpdateBalance.TabIndex = 12;
            this.BtnUpdateBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnUpdateBalance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnUpdateBalance.TextMarginLeft = 0;
            this.BtnUpdateBalance.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnUpdateBalance.UseDefaultRadiusAndThickness = true;
            this.BtnUpdateBalance.Click += new System.EventHandler(this.BtnUpdateBalance_Click);
            // 
            // BtnCreateBalance
            // 
            this.BtnCreateBalance.AllowAnimations = true;
            this.BtnCreateBalance.AllowMouseEffects = true;
            this.BtnCreateBalance.AllowToggling = false;
            this.BtnCreateBalance.AnimationSpeed = 200;
            this.BtnCreateBalance.AutoGenerateColors = false;
            this.BtnCreateBalance.AutoRoundBorders = false;
            this.BtnCreateBalance.AutoSizeLeftIcon = true;
            this.BtnCreateBalance.AutoSizeRightIcon = true;
            this.BtnCreateBalance.BackColor = System.Drawing.Color.Transparent;
            this.BtnCreateBalance.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnCreateBalance.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCreateBalance.BackgroundImage")));
            this.BtnCreateBalance.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCreateBalance.ButtonText = "Create";
            this.BtnCreateBalance.ButtonTextMarginLeft = 0;
            this.BtnCreateBalance.ColorContrastOnClick = 45;
            this.BtnCreateBalance.ColorContrastOnHover = 45;
            this.BtnCreateBalance.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.BtnCreateBalance.CustomizableEdges = borderEdges4;
            this.BtnCreateBalance.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnCreateBalance.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCreateBalance.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnCreateBalance.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnCreateBalance.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnCreateBalance.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateBalance.ForeColor = System.Drawing.Color.White;
            this.BtnCreateBalance.IconLeft = null;
            this.BtnCreateBalance.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCreateBalance.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnCreateBalance.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnCreateBalance.IconMarginLeft = 11;
            this.BtnCreateBalance.IconPadding = 10;
            this.BtnCreateBalance.IconRight = null;
            this.BtnCreateBalance.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnCreateBalance.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnCreateBalance.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnCreateBalance.IconSize = 25;
            this.BtnCreateBalance.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnCreateBalance.IdleBorderRadius = 0;
            this.BtnCreateBalance.IdleBorderThickness = 0;
            this.BtnCreateBalance.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnCreateBalance.IdleIconLeftImage = null;
            this.BtnCreateBalance.IdleIconRightImage = null;
            this.BtnCreateBalance.IndicateFocus = false;
            this.BtnCreateBalance.Location = new System.Drawing.Point(37, 239);
            this.BtnCreateBalance.Name = "BtnCreateBalance";
            this.BtnCreateBalance.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnCreateBalance.OnDisabledState.BorderRadius = 1;
            this.BtnCreateBalance.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCreateBalance.OnDisabledState.BorderThickness = 1;
            this.BtnCreateBalance.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnCreateBalance.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnCreateBalance.OnDisabledState.IconLeftImage = null;
            this.BtnCreateBalance.OnDisabledState.IconRightImage = null;
            this.BtnCreateBalance.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnCreateBalance.onHoverState.BorderRadius = 1;
            this.BtnCreateBalance.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCreateBalance.onHoverState.BorderThickness = 1;
            this.BtnCreateBalance.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnCreateBalance.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnCreateBalance.onHoverState.IconLeftImage = null;
            this.BtnCreateBalance.onHoverState.IconRightImage = null;
            this.BtnCreateBalance.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnCreateBalance.OnIdleState.BorderRadius = 1;
            this.BtnCreateBalance.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCreateBalance.OnIdleState.BorderThickness = 1;
            this.BtnCreateBalance.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnCreateBalance.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnCreateBalance.OnIdleState.IconLeftImage = null;
            this.BtnCreateBalance.OnIdleState.IconRightImage = null;
            this.BtnCreateBalance.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnCreateBalance.OnPressedState.BorderRadius = 1;
            this.BtnCreateBalance.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnCreateBalance.OnPressedState.BorderThickness = 1;
            this.BtnCreateBalance.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnCreateBalance.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnCreateBalance.OnPressedState.IconLeftImage = null;
            this.BtnCreateBalance.OnPressedState.IconRightImage = null;
            this.BtnCreateBalance.Size = new System.Drawing.Size(209, 36);
            this.BtnCreateBalance.TabIndex = 11;
            this.BtnCreateBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnCreateBalance.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnCreateBalance.TextMarginLeft = 0;
            this.BtnCreateBalance.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnCreateBalance.UseDefaultRadiusAndThickness = true;
            this.BtnCreateBalance.Click += new System.EventHandler(this.BtnCreateBalance_Click);
            // 
            // Pay
            // 
            this.Pay.AcceptsReturn = false;
            this.Pay.AcceptsTab = false;
            this.Pay.AnimationSpeed = 200;
            this.Pay.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Pay.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Pay.AutoSizeHeight = true;
            this.Pay.BackColor = System.Drawing.Color.Transparent;
            this.Pay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pay.BackgroundImage")));
            this.Pay.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Pay.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Pay.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Pay.BorderColorIdle = System.Drawing.Color.Silver;
            this.Pay.BorderRadius = 1;
            this.Pay.BorderThickness = 1;
            this.Pay.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Pay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pay.DefaultFont = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pay.DefaultText = "";
            this.Pay.FillColor = System.Drawing.Color.White;
            this.Pay.HideSelection = true;
            this.Pay.IconLeft = null;
            this.Pay.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Pay.IconPadding = 10;
            this.Pay.IconRight = null;
            this.Pay.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Pay.Lines = new string[0];
            this.Pay.Location = new System.Drawing.Point(37, 173);
            this.Pay.MaxLength = 32767;
            this.Pay.MinimumSize = new System.Drawing.Size(1, 1);
            this.Pay.Modified = false;
            this.Pay.Multiline = false;
            this.Pay.Name = "Pay";
            stateProperties13.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Pay.OnActiveState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Pay.OnDisabledState = stateProperties14;
            stateProperties15.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Pay.OnHoverState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Silver;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Pay.OnIdleState = stateProperties16;
            this.Pay.Padding = new System.Windows.Forms.Padding(3);
            this.Pay.PasswordChar = '\0';
            this.Pay.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Pay.PlaceholderText = "Payment (0.00)";
            this.Pay.ReadOnly = false;
            this.Pay.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pay.SelectedText = "";
            this.Pay.SelectionLength = 0;
            this.Pay.SelectionStart = 0;
            this.Pay.ShortcutsEnabled = true;
            this.Pay.Size = new System.Drawing.Size(209, 35);
            this.Pay.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Pay.TabIndex = 13;
            this.Pay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pay.TextMarginBottom = 0;
            this.Pay.TextMarginLeft = 3;
            this.Pay.TextMarginTop = 1;
            this.Pay.TextPlaceholder = "Payment (0.00)";
            this.Pay.UseSystemPasswordChar = false;
            this.Pay.WordWrap = true;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Image = global::WFA_APP.Properties.Resources.check;
            this.CheckBtn.Location = new System.Drawing.Point(290, 176);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(32, 32);
            this.CheckBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckBtn.TabIndex = 14;
            this.CheckBtn.TabStop = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
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
            this.EmpDrop.Location = new System.Drawing.Point(37, 49);
            this.EmpDrop.Name = "EmpDrop";
            this.EmpDrop.Size = new System.Drawing.Size(209, 32);
            this.EmpDrop.TabIndex = 15;
            this.EmpDrop.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.EmpDrop.TextLeftMargin = 5;
            this.EmpDrop.ValueMember = "BiometricID";
            // 
            // _Employee_DataSet
            // 
            this._Employee_DataSet.DataSetName = "_Employee_DataSet";
            this._Employee_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this._Employee_DataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 489);
            this.Controls.Add(this.EmpDrop);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.BtnUpdateBalance);
            this.Controls.Add(this.BtnCreateBalance);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.AccountDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "Account";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Employee_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView AccountDgv;
        private Bunifu.UI.WinForms.BunifuTextBox CA;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnUpdateBalance;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnCreateBalance;
        private Bunifu.UI.WinForms.BunifuTextBox Pay;
        private System.Windows.Forms.PictureBox CheckBtn;
        private Bunifu.UI.WinForms.BunifuDropdown EmpDrop;
        private _Employee_DataSet _Employee_DataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private _Employee_DataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}