
namespace WFA_APP.View.Modules.Report.CrystalReport.PayRoll
{
    partial class FormPaySlip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPaySlip));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.ShowBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.EndAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.StartAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.TbName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 50);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1170, 600);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
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
            this.ShowBtn.Location = new System.Drawing.Point(382, 12);
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
            this.ShowBtn.TabIndex = 6;
            this.ShowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ShowBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.ShowBtn.TextMarginLeft = 0;
            this.ShowBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.ShowBtn.UseDefaultRadiusAndThickness = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
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
            this.EndAt.Location = new System.Drawing.Point(197, 12);
            this.EndAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.EndAt.Name = "EndAt";
            this.EndAt.Size = new System.Drawing.Size(169, 32);
            this.EndAt.TabIndex = 5;
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
            this.StartAt.Location = new System.Drawing.Point(12, 12);
            this.StartAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.StartAt.Name = "StartAt";
            this.StartAt.Size = new System.Drawing.Size(169, 32);
            this.StartAt.TabIndex = 4;
            // 
            // TbName
            // 
            this.TbName.AcceptsReturn = false;
            this.TbName.AcceptsTab = false;
            this.TbName.AnimationSpeed = 200;
            this.TbName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbName.AutoSizeHeight = true;
            this.TbName.BackColor = System.Drawing.Color.Transparent;
            this.TbName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TbName.BackgroundImage")));
            this.TbName.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TbName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TbName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TbName.BorderColorIdle = System.Drawing.Color.Silver;
            this.TbName.BorderRadius = 1;
            this.TbName.BorderThickness = 1;
            this.TbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbName.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TbName.DefaultText = "";
            this.TbName.FillColor = System.Drawing.Color.White;
            this.TbName.HideSelection = true;
            this.TbName.IconLeft = null;
            this.TbName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TbName.IconPadding = 10;
            this.TbName.IconRight = null;
            this.TbName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TbName.Lines = new string[0];
            this.TbName.Location = new System.Drawing.Point(503, 12);
            this.TbName.MaxLength = 32767;
            this.TbName.MinimumSize = new System.Drawing.Size(1, 1);
            this.TbName.Modified = false;
            this.TbName.Multiline = false;
            this.TbName.Name = "TbName";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TbName.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TbName.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TbName.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TbName.OnIdleState = stateProperties4;
            this.TbName.Padding = new System.Windows.Forms.Padding(3);
            this.TbName.PasswordChar = '\0';
            this.TbName.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbName.PlaceholderText = "Enter text";
            this.TbName.ReadOnly = false;
            this.TbName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbName.SelectedText = "";
            this.TbName.SelectionLength = 0;
            this.TbName.SelectionStart = 0;
            this.TbName.ShortcutsEnabled = true;
            this.TbName.Size = new System.Drawing.Size(260, 32);
            this.TbName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TbName.TabIndex = 7;
            this.TbName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TbName.TextMarginBottom = 0;
            this.TbName.TextMarginLeft = 3;
            this.TbName.TextMarginTop = 1;
            this.TbName.TextPlaceholder = "Enter text";
            this.TbName.UseSystemPasswordChar = false;
            this.TbName.WordWrap = true;
            // 
            // FormPaySlip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 650);
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.EndAt);
            this.Controls.Add(this.StartAt);
            this.Controls.Add(this.crystalReportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPaySlip";
            this.Text = "FormPayRoll";
            this.Load += new System.EventHandler(this.FormPayRoll_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ShowBtn;
        private Bunifu.UI.WinForms.BunifuTextBox TbName;
        public Bunifu.UI.WinForms.BunifuDatePicker EndAt;
        public Bunifu.UI.WinForms.BunifuDatePicker StartAt;
    }
}