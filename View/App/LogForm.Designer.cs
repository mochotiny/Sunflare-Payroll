namespace WFA_APP.View.App
{
    partial class LogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogForm));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.User_TB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.Pass_TB = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnLog = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnEllipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.BtnClose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // User_TB
            // 
            this.User_TB.AcceptsReturn = false;
            this.User_TB.AcceptsTab = false;
            this.User_TB.AnimationSpeed = 200;
            this.User_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.User_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.User_TB.AutoSizeHeight = true;
            this.User_TB.BackColor = System.Drawing.Color.Transparent;
            this.User_TB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("User_TB.BackgroundImage")));
            this.User_TB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.User_TB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.User_TB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.User_TB.BorderColorIdle = System.Drawing.Color.Silver;
            this.User_TB.BorderRadius = 1;
            this.User_TB.BorderThickness = 1;
            this.User_TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.User_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User_TB.DefaultFont = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User_TB.DefaultText = "admin";
            this.User_TB.FillColor = System.Drawing.Color.White;
            this.User_TB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.User_TB.HideSelection = true;
            this.User_TB.IconLeft = null;
            this.User_TB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.User_TB.IconPadding = 10;
            this.User_TB.IconRight = null;
            this.User_TB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.User_TB.Lines = new string[] {
        "admin"};
            this.User_TB.Location = new System.Drawing.Point(67, 342);
            this.User_TB.MaxLength = 32767;
            this.User_TB.MinimumSize = new System.Drawing.Size(1, 1);
            this.User_TB.Modified = false;
            this.User_TB.Multiline = false;
            this.User_TB.Name = "User_TB";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.User_TB.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.User_TB.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.User_TB.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.User_TB.OnIdleState = stateProperties4;
            this.User_TB.Padding = new System.Windows.Forms.Padding(3);
            this.User_TB.PasswordChar = '\0';
            this.User_TB.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.User_TB.PlaceholderText = "Username";
            this.User_TB.ReadOnly = false;
            this.User_TB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.User_TB.SelectedText = "";
            this.User_TB.SelectionLength = 0;
            this.User_TB.SelectionStart = 5;
            this.User_TB.ShortcutsEnabled = true;
            this.User_TB.Size = new System.Drawing.Size(253, 41);
            this.User_TB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.User_TB.TabIndex = 0;
            this.User_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.User_TB.TextMarginBottom = 0;
            this.User_TB.TextMarginLeft = 3;
            this.User_TB.TextMarginTop = 1;
            this.User_TB.TextPlaceholder = "Username";
            this.User_TB.UseSystemPasswordChar = false;
            this.User_TB.WordWrap = true;
            // 
            // Pass_TB
            // 
            this.Pass_TB.AcceptsReturn = false;
            this.Pass_TB.AcceptsTab = false;
            this.Pass_TB.AnimationSpeed = 200;
            this.Pass_TB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Pass_TB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Pass_TB.AutoSizeHeight = true;
            this.Pass_TB.BackColor = System.Drawing.Color.White;
            this.Pass_TB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pass_TB.BackgroundImage")));
            this.Pass_TB.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.Pass_TB.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Pass_TB.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Pass_TB.BorderColorIdle = System.Drawing.Color.Silver;
            this.Pass_TB.BorderRadius = 1;
            this.Pass_TB.BorderThickness = 1;
            this.Pass_TB.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.Pass_TB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_TB.DefaultFont = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_TB.DefaultText = "admin";
            this.Pass_TB.FillColor = System.Drawing.Color.White;
            this.Pass_TB.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Pass_TB.HideSelection = true;
            this.Pass_TB.IconLeft = null;
            this.Pass_TB.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_TB.IconPadding = 10;
            this.Pass_TB.IconRight = null;
            this.Pass_TB.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass_TB.Lines = new string[] {
        "admin"};
            this.Pass_TB.Location = new System.Drawing.Point(67, 407);
            this.Pass_TB.MaxLength = 32767;
            this.Pass_TB.MinimumSize = new System.Drawing.Size(1, 1);
            this.Pass_TB.Modified = false;
            this.Pass_TB.Multiline = false;
            this.Pass_TB.Name = "Pass_TB";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Pass_TB.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.Pass_TB.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Pass_TB.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.Pass_TB.OnIdleState = stateProperties8;
            this.Pass_TB.Padding = new System.Windows.Forms.Padding(3);
            this.Pass_TB.PasswordChar = '*';
            this.Pass_TB.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.Pass_TB.PlaceholderText = "Password";
            this.Pass_TB.ReadOnly = false;
            this.Pass_TB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Pass_TB.SelectedText = "";
            this.Pass_TB.SelectionLength = 0;
            this.Pass_TB.SelectionStart = 5;
            this.Pass_TB.ShortcutsEnabled = true;
            this.Pass_TB.Size = new System.Drawing.Size(253, 41);
            this.Pass_TB.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.Pass_TB.TabIndex = 1;
            this.Pass_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Pass_TB.TextMarginBottom = 0;
            this.Pass_TB.TextMarginLeft = 3;
            this.Pass_TB.TextMarginTop = 1;
            this.Pass_TB.TextPlaceholder = "Password";
            this.Pass_TB.UseSystemPasswordChar = false;
            this.Pass_TB.WordWrap = true;
            // 
            // BtnLog
            // 
            this.BtnLog.AllowAnimations = true;
            this.BtnLog.AllowMouseEffects = true;
            this.BtnLog.AllowToggling = false;
            this.BtnLog.AnimationSpeed = 200;
            this.BtnLog.AutoGenerateColors = false;
            this.BtnLog.AutoRoundBorders = false;
            this.BtnLog.AutoSizeLeftIcon = true;
            this.BtnLog.AutoSizeRightIcon = true;
            this.BtnLog.BackColor = System.Drawing.Color.Transparent;
            this.BtnLog.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnLog.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLog.BackgroundImage")));
            this.BtnLog.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLog.ButtonText = "Log";
            this.BtnLog.ButtonTextMarginLeft = 0;
            this.BtnLog.ColorContrastOnClick = 45;
            this.BtnLog.ColorContrastOnHover = 45;
            this.BtnLog.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnLog.CustomizableEdges = borderEdges1;
            this.BtnLog.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnLog.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnLog.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnLog.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnLog.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnLog.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLog.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLog.IconLeft = null;
            this.BtnLog.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLog.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnLog.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnLog.IconMarginLeft = 11;
            this.BtnLog.IconPadding = 10;
            this.BtnLog.IconRight = null;
            this.BtnLog.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnLog.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnLog.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnLog.IconSize = 25;
            this.BtnLog.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnLog.IdleBorderRadius = 0;
            this.BtnLog.IdleBorderThickness = 0;
            this.BtnLog.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnLog.IdleIconLeftImage = null;
            this.BtnLog.IdleIconRightImage = null;
            this.BtnLog.IndicateFocus = false;
            this.BtnLog.Location = new System.Drawing.Point(67, 472);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnLog.OnDisabledState.BorderRadius = 1;
            this.BtnLog.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLog.OnDisabledState.BorderThickness = 1;
            this.BtnLog.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnLog.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnLog.OnDisabledState.IconLeftImage = null;
            this.BtnLog.OnDisabledState.IconRightImage = null;
            this.BtnLog.onHoverState.BorderColor = System.Drawing.Color.Gray;
            this.BtnLog.onHoverState.BorderRadius = 1;
            this.BtnLog.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLog.onHoverState.BorderThickness = 1;
            this.BtnLog.onHoverState.FillColor = System.Drawing.Color.Gray;
            this.BtnLog.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnLog.onHoverState.IconLeftImage = null;
            this.BtnLog.onHoverState.IconRightImage = null;
            this.BtnLog.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnLog.OnIdleState.BorderRadius = 1;
            this.BtnLog.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLog.OnIdleState.BorderThickness = 1;
            this.BtnLog.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnLog.OnIdleState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnLog.OnIdleState.IconLeftImage = null;
            this.BtnLog.OnIdleState.IconRightImage = null;
            this.BtnLog.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.BtnLog.OnPressedState.BorderRadius = 1;
            this.BtnLog.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnLog.OnPressedState.BorderThickness = 1;
            this.BtnLog.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(128)))), ((int)(((byte)(150)))));
            this.BtnLog.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnLog.OnPressedState.IconLeftImage = null;
            this.BtnLog.OnPressedState.IconRightImage = null;
            this.BtnLog.Size = new System.Drawing.Size(253, 41);
            this.BtnLog.TabIndex = 2;
            this.BtnLog.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLog.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnLog.TextMarginLeft = 0;
            this.BtnLog.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnLog.UseDefaultRadiusAndThickness = true;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.ElipseRadius = 15;
            this.BtnEllipse.TargetControl = this.BtnLog;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 0;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(83, 66);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(220, 220);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 3;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            // 
            // BtnClose
            // 
            this.BtnClose.Image = global::WFA_APP.Properties.Resources.cancel;
            this.BtnClose.Location = new System.Drawing.Point(348, 5);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(35, 35);
            this.BtnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnClose.TabIndex = 4;
            this.BtnClose.TabStop = false;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(389, 599);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.Pass_TB);
            this.Controls.Add(this.User_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogForm";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuTextBox Pass_TB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnLog;
        private Bunifu.Framework.UI.BunifuElipse BtnEllipse;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.PictureBox BtnClose;
        public Bunifu.UI.WinForms.BunifuTextBox User_TB;
    }
}