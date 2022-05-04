namespace WFA_APP.View.Modules.Payroll.Deduction.Sheet
{
    partial class SheetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SheetForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.LblSheet = new Bunifu.UI.WinForms.BunifuLabel();
            this.SheetDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.UpdateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Adjustments = new Bunifu.UI.WinForms.BunifuTextBox();
            this.CheckBtn = new System.Windows.Forms.PictureBox();
            this.ID = new Bunifu.UI.WinForms.BunifuTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SheetDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // LblSheet
            // 
            this.LblSheet.AllowParentOverrides = false;
            this.LblSheet.AutoEllipsis = false;
            this.LblSheet.Cursor = System.Windows.Forms.Cursors.Default;
            this.LblSheet.CursorType = System.Windows.Forms.Cursors.Default;
            this.LblSheet.Font = new System.Drawing.Font("Inter", 15.75F);
            this.LblSheet.Location = new System.Drawing.Point(12, 26);
            this.LblSheet.Name = "LblSheet";
            this.LblSheet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblSheet.Size = new System.Drawing.Size(57, 25);
            this.LblSheet.TabIndex = 0;
            this.LblSheet.Text = "Sheet";
            this.LblSheet.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblSheet.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SheetDgv
            // 
            this.SheetDgv.AllowCustomTheming = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.SheetDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SheetDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.SheetDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SheetDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.SheetDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SheetDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SheetDgv.ColumnHeadersHeight = 40;
            this.SheetDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.SheetDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SheetDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SheetDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SheetDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.SheetDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.SheetDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SheetDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.SheetDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.SheetDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.SheetDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.SheetDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.SheetDgv.CurrentTheme.Name = null;
            this.SheetDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.SheetDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SheetDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.SheetDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.SheetDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SheetDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.SheetDgv.EnableHeadersVisualStyles = false;
            this.SheetDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.SheetDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.SheetDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.SheetDgv.HeaderForeColor = System.Drawing.Color.White;
            this.SheetDgv.Location = new System.Drawing.Point(12, 57);
            this.SheetDgv.Name = "SheetDgv";
            this.SheetDgv.RowHeadersVisible = false;
            this.SheetDgv.RowTemplate.Height = 40;
            this.SheetDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SheetDgv.Size = new System.Drawing.Size(1120, 506);
            this.SheetDgv.TabIndex = 1;
            this.SheetDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.UpdateBtn.CustomizableEdges = borderEdges1;
            this.UpdateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.UpdateBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.UpdateBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.UpdateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.UpdateBtn.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.Gray;
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
            this.UpdateBtn.Location = new System.Drawing.Point(982, 13);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.UpdateBtn.OnDisabledState.BorderRadius = 1;
            this.UpdateBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnDisabledState.BorderThickness = 1;
            this.UpdateBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UpdateBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.UpdateBtn.OnDisabledState.IconLeftImage = null;
            this.UpdateBtn.OnDisabledState.IconRightImage = null;
            this.UpdateBtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.UpdateBtn.onHoverState.BorderRadius = 1;
            this.UpdateBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.onHoverState.BorderThickness = 1;
            this.UpdateBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.UpdateBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.onHoverState.IconLeftImage = null;
            this.UpdateBtn.onHoverState.IconRightImage = null;
            this.UpdateBtn.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.OnIdleState.BorderRadius = 1;
            this.UpdateBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnIdleState.BorderThickness = 1;
            this.UpdateBtn.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.OnIdleState.ForeColor = System.Drawing.Color.Gray;
            this.UpdateBtn.OnIdleState.IconLeftImage = null;
            this.UpdateBtn.OnIdleState.IconRightImage = null;
            this.UpdateBtn.OnPressedState.BorderColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.OnPressedState.BorderRadius = 1;
            this.UpdateBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.UpdateBtn.OnPressedState.BorderThickness = 1;
            this.UpdateBtn.OnPressedState.FillColor = System.Drawing.Color.Transparent;
            this.UpdateBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.OnPressedState.IconLeftImage = null;
            this.UpdateBtn.OnPressedState.IconRightImage = null;
            this.UpdateBtn.Size = new System.Drawing.Size(150, 39);
            this.UpdateBtn.TabIndex = 2;
            this.UpdateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.UpdateBtn.TextMarginLeft = 0;
            this.UpdateBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.UpdateBtn.UseDefaultRadiusAndThickness = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // Adjustments
            // 
            this.Adjustments.AcceptsReturn = false;
            this.Adjustments.AcceptsTab = false;
            this.Adjustments.AnimationSpeed = 200;
            this.Adjustments.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Adjustments.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Adjustments.AutoSizeHeight = true;
            this.Adjustments.BackColor = System.Drawing.Color.Transparent;
            this.Adjustments.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Adjustments.BackgroundImage")));
            this.Adjustments.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Adjustments.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Adjustments.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Adjustments.BorderColorIdle = System.Drawing.Color.Silver;
            this.Adjustments.BorderRadius = 1;
            this.Adjustments.BorderThickness = 1;
            this.Adjustments.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Adjustments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Adjustments.DefaultFont = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Adjustments.DefaultText = "";
            this.Adjustments.FillColor = System.Drawing.Color.White;
            this.Adjustments.HideSelection = true;
            this.Adjustments.IconLeft = null;
            this.Adjustments.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Adjustments.IconPadding = 10;
            this.Adjustments.IconRight = null;
            this.Adjustments.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Adjustments.Lines = new string[0];
            this.Adjustments.Location = new System.Drawing.Point(741, 14);
            this.Adjustments.MaxLength = 32767;
            this.Adjustments.MinimumSize = new System.Drawing.Size(1, 1);
            this.Adjustments.Modified = false;
            this.Adjustments.Multiline = false;
            this.Adjustments.Name = "Adjustments";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Adjustments.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Adjustments.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Adjustments.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Adjustments.OnIdleState = stateProperties4;
            this.Adjustments.Padding = new System.Windows.Forms.Padding(3);
            this.Adjustments.PasswordChar = '\0';
            this.Adjustments.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Adjustments.PlaceholderText = "Adjustments (0.00)";
            this.Adjustments.ReadOnly = false;
            this.Adjustments.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Adjustments.SelectedText = "";
            this.Adjustments.SelectionLength = 0;
            this.Adjustments.SelectionStart = 0;
            this.Adjustments.ShortcutsEnabled = true;
            this.Adjustments.Size = new System.Drawing.Size(193, 37);
            this.Adjustments.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Adjustments.TabIndex = 5;
            this.Adjustments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Adjustments.TextMarginBottom = 0;
            this.Adjustments.TextMarginLeft = 3;
            this.Adjustments.TextMarginTop = 1;
            this.Adjustments.TextPlaceholder = "Adjustments (0.00)";
            this.Adjustments.UseSystemPasswordChar = false;
            this.Adjustments.WordWrap = true;
            // 
            // CheckBtn
            // 
            this.CheckBtn.Image = global::WFA_APP.Properties.Resources.check;
            this.CheckBtn.Location = new System.Drawing.Point(943, 16);
            this.CheckBtn.Name = "CheckBtn";
            this.CheckBtn.Size = new System.Drawing.Size(32, 32);
            this.CheckBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CheckBtn.TabIndex = 6;
            this.CheckBtn.TabStop = false;
            this.CheckBtn.Click += new System.EventHandler(this.CheckBtn_Click);
            // 
            // ID
            // 
            this.ID.AcceptsReturn = false;
            this.ID.AcceptsTab = false;
            this.ID.AnimationSpeed = 200;
            this.ID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ID.AutoSizeHeight = true;
            this.ID.BackColor = System.Drawing.Color.Transparent;
            this.ID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ID.BackgroundImage")));
            this.ID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.ID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ID.BorderColorIdle = System.Drawing.Color.Silver;
            this.ID.BorderRadius = 1;
            this.ID.BorderThickness = 1;
            this.ID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.DefaultFont = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultText = "";
            this.ID.FillColor = System.Drawing.Color.White;
            this.ID.HideSelection = true;
            this.ID.IconLeft = null;
            this.ID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.IconPadding = 10;
            this.ID.IconRight = null;
            this.ID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.Lines = new string[0];
            this.ID.Location = new System.Drawing.Point(542, 14);
            this.ID.MaxLength = 32767;
            this.ID.MinimumSize = new System.Drawing.Size(1, 1);
            this.ID.Modified = false;
            this.ID.Multiline = false;
            this.ID.Name = "ID";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ID.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.ID.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ID.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ID.OnIdleState = stateProperties8;
            this.ID.Padding = new System.Windows.Forms.Padding(3);
            this.ID.PasswordChar = '\0';
            this.ID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ID.PlaceholderText = "ID";
            this.ID.ReadOnly = false;
            this.ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ID.SelectedText = "";
            this.ID.SelectionLength = 0;
            this.ID.SelectionStart = 0;
            this.ID.ShortcutsEnabled = true;
            this.ID.Size = new System.Drawing.Size(193, 37);
            this.ID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.ID.TabIndex = 7;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ID.TextMarginBottom = 0;
            this.ID.TextMarginLeft = 3;
            this.ID.TextMarginTop = 1;
            this.ID.TextPlaceholder = "ID";
            this.ID.UseSystemPasswordChar = false;
            this.ID.WordWrap = true;
            // 
            // SheetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1144, 575);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.CheckBtn);
            this.Controls.Add(this.Adjustments);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.SheetDgv);
            this.Controls.Add(this.LblSheet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SheetForm";
            this.Text = "Sheet";
            ((System.ComponentModel.ISupportInitialize)(this.SheetDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel LblSheet;
        private Bunifu.UI.WinForms.BunifuDataGridView SheetDgv;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton UpdateBtn;
        private Bunifu.UI.WinForms.BunifuTextBox Adjustments;
        private System.Windows.Forms.PictureBox CheckBtn;
        private Bunifu.UI.WinForms.BunifuTextBox ID;
    }
}