namespace WFA_APP.View.Modules.Payroll.Weekly
{
    partial class Week
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Week));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.WeekDgv = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.StartAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.EndAt = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.Week_PhilHealth = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Week_PagIbig = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.Week_SSS = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.PhilHealth = new Bunifu.UI.WinForms.BunifuLabel();
            this.PagIbig = new Bunifu.UI.WinForms.BunifuLabel();
            this.SSS = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnWeeklyPayroll = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.FilterBtn = new Bunifu.UI.WinForms.BunifuLabel();
            this.DeleteBtn = new System.Windows.Forms.PictureBox();
            this.DropProj = new Bunifu.UI.WinForms.BunifuDropdown();
            this.projectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Project_DataSet = new WFA_APP._Project_DataSet();
            this.projectsTableAdapter = new WFA_APP._Project_DataSetTableAdapters.ProjectsTableAdapter();
            //this.dB_Project_Dataset = new WFA_APP.DB_Project_Dataset();
            this.projectsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            //this.projectsTableAdapter1 = new WFA_APP.DB_Project_DatasetTableAdapters.ProjectsTableAdapter();
            this.projectsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.IsWeekly = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.LabelWeek = new Bunifu.UI.WinForms.BunifuLabel();
            ((System.ComponentModel.ISupportInitialize)(this.WeekDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_DataSet)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.dB_Project_Dataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // WeekDgv
            // 
            this.WeekDgv.AllowCustomTheming = false;
            this.WeekDgv.AllowUserToResizeColumns = false;
            this.WeekDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.WeekDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WeekDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.WeekDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WeekDgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WeekDgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WeekDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WeekDgv.ColumnHeadersHeight = 40;
            this.WeekDgv.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.WeekDgv.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.WeekDgv.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.WeekDgv.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.WeekDgv.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.WeekDgv.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.WeekDgv.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.WeekDgv.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.WeekDgv.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.WeekDgv.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.WeekDgv.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.WeekDgv.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.WeekDgv.CurrentTheme.Name = null;
            this.WeekDgv.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.WeekDgv.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.WeekDgv.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.WeekDgv.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.WeekDgv.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WeekDgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.WeekDgv.EnableHeadersVisualStyles = false;
            this.WeekDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.WeekDgv.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.WeekDgv.HeaderBgColor = System.Drawing.Color.Empty;
            this.WeekDgv.HeaderForeColor = System.Drawing.Color.White;
            this.WeekDgv.Location = new System.Drawing.Point(12, 81);
            this.WeekDgv.Name = "WeekDgv";
            this.WeekDgv.RowHeadersVisible = false;
            this.WeekDgv.RowTemplate.Height = 40;
            this.WeekDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WeekDgv.Size = new System.Drawing.Size(1144, 564);
            this.WeekDgv.TabIndex = 0;
            this.WeekDgv.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
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
            this.StartAt.Location = new System.Drawing.Point(12, 43);
            this.StartAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.StartAt.Name = "StartAt";
            this.StartAt.Size = new System.Drawing.Size(189, 32);
            this.StartAt.TabIndex = 1;
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
            this.EndAt.Location = new System.Drawing.Point(216, 43);
            this.EndAt.MinimumSize = new System.Drawing.Size(4, 32);
            this.EndAt.Name = "EndAt";
            this.EndAt.Size = new System.Drawing.Size(189, 32);
            this.EndAt.TabIndex = 2;
            // 
            // Week_PhilHealth
            // 
            this.Week_PhilHealth.AllowBindingControlAnimation = true;
            this.Week_PhilHealth.AllowBindingControlColorChanges = false;
            this.Week_PhilHealth.AllowBindingControlLocation = true;
            this.Week_PhilHealth.AllowCheckBoxAnimation = false;
            this.Week_PhilHealth.AllowCheckmarkAnimation = true;
            this.Week_PhilHealth.AllowOnHoverStates = true;
            this.Week_PhilHealth.AutoCheck = true;
            this.Week_PhilHealth.BackColor = System.Drawing.Color.Transparent;
            this.Week_PhilHealth.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Week_PhilHealth.BackgroundImage")));
            this.Week_PhilHealth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Week_PhilHealth.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Week_PhilHealth.BorderRadius = 12;
            this.Week_PhilHealth.Checked = false;
            this.Week_PhilHealth.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Week_PhilHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.Week_PhilHealth.CustomCheckmarkImage = null;
            this.Week_PhilHealth.Location = new System.Drawing.Point(422, 49);
            this.Week_PhilHealth.MinimumSize = new System.Drawing.Size(17, 17);
            this.Week_PhilHealth.Name = "Week_PhilHealth";
            this.Week_PhilHealth.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Week_PhilHealth.OnCheck.BorderRadius = 12;
            this.Week_PhilHealth.OnCheck.BorderThickness = 2;
            this.Week_PhilHealth.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Week_PhilHealth.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Week_PhilHealth.OnCheck.CheckmarkThickness = 2;
            this.Week_PhilHealth.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Week_PhilHealth.OnDisable.BorderRadius = 12;
            this.Week_PhilHealth.OnDisable.BorderThickness = 2;
            this.Week_PhilHealth.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_PhilHealth.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Week_PhilHealth.OnDisable.CheckmarkThickness = 2;
            this.Week_PhilHealth.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_PhilHealth.OnHoverChecked.BorderRadius = 12;
            this.Week_PhilHealth.OnHoverChecked.BorderThickness = 2;
            this.Week_PhilHealth.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_PhilHealth.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Week_PhilHealth.OnHoverChecked.CheckmarkThickness = 2;
            this.Week_PhilHealth.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_PhilHealth.OnHoverUnchecked.BorderRadius = 12;
            this.Week_PhilHealth.OnHoverUnchecked.BorderThickness = 1;
            this.Week_PhilHealth.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_PhilHealth.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Week_PhilHealth.OnUncheck.BorderRadius = 12;
            this.Week_PhilHealth.OnUncheck.BorderThickness = 1;
            this.Week_PhilHealth.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_PhilHealth.Size = new System.Drawing.Size(21, 21);
            this.Week_PhilHealth.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Week_PhilHealth.TabIndex = 3;
            this.Week_PhilHealth.ThreeState = false;
            this.Week_PhilHealth.ToolTipText = null;
            // 
            // Week_PagIbig
            // 
            this.Week_PagIbig.AllowBindingControlAnimation = true;
            this.Week_PagIbig.AllowBindingControlColorChanges = false;
            this.Week_PagIbig.AllowBindingControlLocation = true;
            this.Week_PagIbig.AllowCheckBoxAnimation = false;
            this.Week_PagIbig.AllowCheckmarkAnimation = true;
            this.Week_PagIbig.AllowOnHoverStates = true;
            this.Week_PagIbig.AutoCheck = true;
            this.Week_PagIbig.BackColor = System.Drawing.Color.Transparent;
            this.Week_PagIbig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Week_PagIbig.BackgroundImage")));
            this.Week_PagIbig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Week_PagIbig.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Week_PagIbig.BorderRadius = 12;
            this.Week_PagIbig.Checked = false;
            this.Week_PagIbig.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Week_PagIbig.Cursor = System.Windows.Forms.Cursors.Default;
            this.Week_PagIbig.CustomCheckmarkImage = null;
            this.Week_PagIbig.Location = new System.Drawing.Point(514, 49);
            this.Week_PagIbig.MinimumSize = new System.Drawing.Size(17, 17);
            this.Week_PagIbig.Name = "Week_PagIbig";
            this.Week_PagIbig.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Week_PagIbig.OnCheck.BorderRadius = 12;
            this.Week_PagIbig.OnCheck.BorderThickness = 2;
            this.Week_PagIbig.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Week_PagIbig.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Week_PagIbig.OnCheck.CheckmarkThickness = 2;
            this.Week_PagIbig.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Week_PagIbig.OnDisable.BorderRadius = 12;
            this.Week_PagIbig.OnDisable.BorderThickness = 2;
            this.Week_PagIbig.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_PagIbig.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Week_PagIbig.OnDisable.CheckmarkThickness = 2;
            this.Week_PagIbig.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_PagIbig.OnHoverChecked.BorderRadius = 12;
            this.Week_PagIbig.OnHoverChecked.BorderThickness = 2;
            this.Week_PagIbig.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_PagIbig.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Week_PagIbig.OnHoverChecked.CheckmarkThickness = 2;
            this.Week_PagIbig.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_PagIbig.OnHoverUnchecked.BorderRadius = 12;
            this.Week_PagIbig.OnHoverUnchecked.BorderThickness = 1;
            this.Week_PagIbig.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_PagIbig.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Week_PagIbig.OnUncheck.BorderRadius = 12;
            this.Week_PagIbig.OnUncheck.BorderThickness = 1;
            this.Week_PagIbig.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_PagIbig.Size = new System.Drawing.Size(21, 21);
            this.Week_PagIbig.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Week_PagIbig.TabIndex = 4;
            this.Week_PagIbig.ThreeState = false;
            this.Week_PagIbig.ToolTipText = null;
            // 
            // Week_SSS
            // 
            this.Week_SSS.AllowBindingControlAnimation = true;
            this.Week_SSS.AllowBindingControlColorChanges = false;
            this.Week_SSS.AllowBindingControlLocation = true;
            this.Week_SSS.AllowCheckBoxAnimation = false;
            this.Week_SSS.AllowCheckmarkAnimation = true;
            this.Week_SSS.AllowOnHoverStates = true;
            this.Week_SSS.AutoCheck = true;
            this.Week_SSS.BackColor = System.Drawing.Color.Transparent;
            this.Week_SSS.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Week_SSS.BackgroundImage")));
            this.Week_SSS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Week_SSS.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.Week_SSS.BorderRadius = 12;
            this.Week_SSS.Checked = false;
            this.Week_SSS.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.Week_SSS.Cursor = System.Windows.Forms.Cursors.Default;
            this.Week_SSS.CustomCheckmarkImage = null;
            this.Week_SSS.Location = new System.Drawing.Point(588, 49);
            this.Week_SSS.MinimumSize = new System.Drawing.Size(17, 17);
            this.Week_SSS.Name = "Week_SSS";
            this.Week_SSS.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.Week_SSS.OnCheck.BorderRadius = 12;
            this.Week_SSS.OnCheck.BorderThickness = 2;
            this.Week_SSS.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.Week_SSS.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.Week_SSS.OnCheck.CheckmarkThickness = 2;
            this.Week_SSS.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.Week_SSS.OnDisable.BorderRadius = 12;
            this.Week_SSS.OnDisable.BorderThickness = 2;
            this.Week_SSS.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_SSS.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.Week_SSS.OnDisable.CheckmarkThickness = 2;
            this.Week_SSS.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_SSS.OnHoverChecked.BorderRadius = 12;
            this.Week_SSS.OnHoverChecked.BorderThickness = 2;
            this.Week_SSS.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_SSS.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.Week_SSS.OnHoverChecked.CheckmarkThickness = 2;
            this.Week_SSS.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Week_SSS.OnHoverUnchecked.BorderRadius = 12;
            this.Week_SSS.OnHoverUnchecked.BorderThickness = 1;
            this.Week_SSS.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_SSS.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.Week_SSS.OnUncheck.BorderRadius = 12;
            this.Week_SSS.OnUncheck.BorderThickness = 1;
            this.Week_SSS.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.Week_SSS.Size = new System.Drawing.Size(21, 21);
            this.Week_SSS.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.Week_SSS.TabIndex = 5;
            this.Week_SSS.ThreeState = false;
            this.Week_SSS.ToolTipText = null;
            // 
            // PhilHealth
            // 
            this.PhilHealth.AllowParentOverrides = false;
            this.PhilHealth.AutoEllipsis = false;
            this.PhilHealth.Cursor = System.Windows.Forms.Cursors.Default;
            this.PhilHealth.CursorType = System.Windows.Forms.Cursors.Default;
            this.PhilHealth.Font = new System.Drawing.Font("Inter", 9.75F);
            this.PhilHealth.Location = new System.Drawing.Point(446, 52);
            this.PhilHealth.Name = "PhilHealth";
            this.PhilHealth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PhilHealth.Size = new System.Drawing.Size(63, 16);
            this.PhilHealth.TabIndex = 6;
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
            this.PagIbig.Location = new System.Drawing.Point(538, 52);
            this.PagIbig.Name = "PagIbig";
            this.PagIbig.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.PagIbig.Size = new System.Drawing.Size(45, 16);
            this.PagIbig.TabIndex = 7;
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
            this.SSS.Location = new System.Drawing.Point(612, 52);
            this.SSS.Name = "SSS";
            this.SSS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SSS.Size = new System.Drawing.Size(24, 16);
            this.SSS.TabIndex = 8;
            this.SSS.Text = "SSS";
            this.SSS.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.SSS.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BtnWeeklyPayroll
            // 
            this.BtnWeeklyPayroll.AllowAnimations = true;
            this.BtnWeeklyPayroll.AllowMouseEffects = true;
            this.BtnWeeklyPayroll.AllowToggling = false;
            this.BtnWeeklyPayroll.AnimationSpeed = 200;
            this.BtnWeeklyPayroll.AutoGenerateColors = false;
            this.BtnWeeklyPayroll.AutoRoundBorders = false;
            this.BtnWeeklyPayroll.AutoSizeLeftIcon = true;
            this.BtnWeeklyPayroll.AutoSizeRightIcon = true;
            this.BtnWeeklyPayroll.BackColor = System.Drawing.Color.Transparent;
            this.BtnWeeklyPayroll.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BtnWeeklyPayroll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnWeeklyPayroll.BackgroundImage")));
            this.BtnWeeklyPayroll.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnWeeklyPayroll.ButtonText = "Run Payroll";
            this.BtnWeeklyPayroll.ButtonTextMarginLeft = 0;
            this.BtnWeeklyPayroll.ColorContrastOnClick = 45;
            this.BtnWeeklyPayroll.ColorContrastOnHover = 45;
            this.BtnWeeklyPayroll.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnWeeklyPayroll.CustomizableEdges = borderEdges1;
            this.BtnWeeklyPayroll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnWeeklyPayroll.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnWeeklyPayroll.DisabledFillColor = System.Drawing.Color.Empty;
            this.BtnWeeklyPayroll.DisabledForecolor = System.Drawing.Color.Empty;
            this.BtnWeeklyPayroll.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnWeeklyPayroll.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnWeeklyPayroll.ForeColor = System.Drawing.Color.White;
            this.BtnWeeklyPayroll.IconLeft = null;
            this.BtnWeeklyPayroll.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnWeeklyPayroll.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnWeeklyPayroll.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnWeeklyPayroll.IconMarginLeft = 11;
            this.BtnWeeklyPayroll.IconPadding = 10;
            this.BtnWeeklyPayroll.IconRight = null;
            this.BtnWeeklyPayroll.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnWeeklyPayroll.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnWeeklyPayroll.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnWeeklyPayroll.IconSize = 25;
            this.BtnWeeklyPayroll.IdleBorderColor = System.Drawing.Color.Empty;
            this.BtnWeeklyPayroll.IdleBorderRadius = 0;
            this.BtnWeeklyPayroll.IdleBorderThickness = 0;
            this.BtnWeeklyPayroll.IdleFillColor = System.Drawing.Color.Empty;
            this.BtnWeeklyPayroll.IdleIconLeftImage = null;
            this.BtnWeeklyPayroll.IdleIconRightImage = null;
            this.BtnWeeklyPayroll.IndicateFocus = false;
            this.BtnWeeklyPayroll.Location = new System.Drawing.Point(969, 43);
            this.BtnWeeklyPayroll.Name = "BtnWeeklyPayroll";
            this.BtnWeeklyPayroll.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnWeeklyPayroll.OnDisabledState.BorderRadius = 1;
            this.BtnWeeklyPayroll.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnWeeklyPayroll.OnDisabledState.BorderThickness = 1;
            this.BtnWeeklyPayroll.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnWeeklyPayroll.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnWeeklyPayroll.OnDisabledState.IconLeftImage = null;
            this.BtnWeeklyPayroll.OnDisabledState.IconRightImage = null;
            this.BtnWeeklyPayroll.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnWeeklyPayroll.onHoverState.BorderRadius = 1;
            this.BtnWeeklyPayroll.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnWeeklyPayroll.onHoverState.BorderThickness = 1;
            this.BtnWeeklyPayroll.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.BtnWeeklyPayroll.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnWeeklyPayroll.onHoverState.IconLeftImage = null;
            this.BtnWeeklyPayroll.onHoverState.IconRightImage = null;
            this.BtnWeeklyPayroll.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnWeeklyPayroll.OnIdleState.BorderRadius = 1;
            this.BtnWeeklyPayroll.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnWeeklyPayroll.OnIdleState.BorderThickness = 1;
            this.BtnWeeklyPayroll.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.BtnWeeklyPayroll.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BtnWeeklyPayroll.OnIdleState.IconLeftImage = null;
            this.BtnWeeklyPayroll.OnIdleState.IconRightImage = null;
            this.BtnWeeklyPayroll.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnWeeklyPayroll.OnPressedState.BorderRadius = 1;
            this.BtnWeeklyPayroll.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnWeeklyPayroll.OnPressedState.BorderThickness = 1;
            this.BtnWeeklyPayroll.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.BtnWeeklyPayroll.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnWeeklyPayroll.OnPressedState.IconLeftImage = null;
            this.BtnWeeklyPayroll.OnPressedState.IconRightImage = null;
            this.BtnWeeklyPayroll.Size = new System.Drawing.Size(150, 32);
            this.BtnWeeklyPayroll.TabIndex = 9;
            this.BtnWeeklyPayroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnWeeklyPayroll.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnWeeklyPayroll.TextMarginLeft = 0;
            this.BtnWeeklyPayroll.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnWeeklyPayroll.UseDefaultRadiusAndThickness = true;
            this.BtnWeeklyPayroll.Click += new System.EventHandler(this.BtnWeeklyPayroll_Click);
            // 
            // FilterBtn
            // 
            this.FilterBtn.AllowParentOverrides = false;
            this.FilterBtn.AutoEllipsis = false;
            this.FilterBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.FilterBtn.CursorType = System.Windows.Forms.Cursors.Default;
            this.FilterBtn.Font = new System.Drawing.Font("Inter Medium", 15.75F, System.Drawing.FontStyle.Bold);
            this.FilterBtn.Location = new System.Drawing.Point(15, 15);
            this.FilterBtn.Name = "FilterBtn";
            this.FilterBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FilterBtn.Size = new System.Drawing.Size(56, 25);
            this.FilterBtn.TabIndex = 12;
            this.FilterBtn.Text = "Filter";
            this.FilterBtn.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.FilterBtn.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.FilterBtn.Click += new System.EventHandler(this.FilterBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Image = global::WFA_APP.Properties.Resources.delete;
            this.DeleteBtn.Location = new System.Drawing.Point(1124, 43);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(32, 32);
            this.DeleteBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DeleteBtn.TabIndex = 13;
            this.DeleteBtn.TabStop = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // DropProj
            // 
            this.DropProj.BackColor = System.Drawing.Color.Transparent;
            this.DropProj.BackgroundColor = System.Drawing.Color.White;
            this.DropProj.BorderColor = System.Drawing.Color.Silver;
            this.DropProj.BorderRadius = 1;
            this.DropProj.Color = System.Drawing.Color.Silver;
            this.DropProj.DataSource = this.projectsBindingSource2;
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
            this.DropProj.Location = new System.Drawing.Point(717, 43);
            this.DropProj.Name = "DropProj";
            this.DropProj.Size = new System.Drawing.Size(200, 32);
            this.DropProj.TabIndex = 14;
            this.DropProj.Text = null;
            this.DropProj.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.DropProj.TextLeftMargin = 5;
            this.DropProj.ValueMember = "ProjectID";
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
            // dB_Project_Dataset
            // 
            //this.dB_Project_Dataset.DataSetName = "DB_Project_Dataset";
            //this.dB_Project_Dataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectsBindingSource1
            // 
            this.projectsBindingSource1.DataMember = "Projects";
            //this.projectsBindingSource1.DataSource = this.dB_Project_Dataset;
            // 
            // projectsTableAdapter1
            // 
            //this.projectsTableAdapter1.ClearBeforeFill = true;
            // 
            // projectsBindingSource2
            // 
            this.projectsBindingSource2.DataMember = "Projects";
            //this.projectsBindingSource2.DataSource = this.dB_Project_Dataset;
            // 
            // IsWeekly
            // 
            this.IsWeekly.AllowBindingControlAnimation = true;
            this.IsWeekly.AllowBindingControlColorChanges = false;
            this.IsWeekly.AllowBindingControlLocation = true;
            this.IsWeekly.AllowCheckBoxAnimation = false;
            this.IsWeekly.AllowCheckmarkAnimation = true;
            this.IsWeekly.AllowOnHoverStates = true;
            this.IsWeekly.AutoCheck = true;
            this.IsWeekly.BackColor = System.Drawing.Color.Transparent;
            this.IsWeekly.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IsWeekly.BackgroundImage")));
            this.IsWeekly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.IsWeekly.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.IsWeekly.BorderRadius = 12;
            this.IsWeekly.Checked = false;
            this.IsWeekly.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.IsWeekly.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsWeekly.CustomCheckmarkImage = null;
            this.IsWeekly.Location = new System.Drawing.Point(650, 49);
            this.IsWeekly.MinimumSize = new System.Drawing.Size(17, 17);
            this.IsWeekly.Name = "IsWeekly";
            this.IsWeekly.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.IsWeekly.OnCheck.BorderRadius = 12;
            this.IsWeekly.OnCheck.BorderThickness = 2;
            this.IsWeekly.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.IsWeekly.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.IsWeekly.OnCheck.CheckmarkThickness = 2;
            this.IsWeekly.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.IsWeekly.OnDisable.BorderRadius = 12;
            this.IsWeekly.OnDisable.BorderThickness = 2;
            this.IsWeekly.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.IsWeekly.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.IsWeekly.OnDisable.CheckmarkThickness = 2;
            this.IsWeekly.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.IsWeekly.OnHoverChecked.BorderRadius = 12;
            this.IsWeekly.OnHoverChecked.BorderThickness = 2;
            this.IsWeekly.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.IsWeekly.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.IsWeekly.OnHoverChecked.CheckmarkThickness = 2;
            this.IsWeekly.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.IsWeekly.OnHoverUnchecked.BorderRadius = 12;
            this.IsWeekly.OnHoverUnchecked.BorderThickness = 1;
            this.IsWeekly.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.IsWeekly.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.IsWeekly.OnUncheck.BorderRadius = 12;
            this.IsWeekly.OnUncheck.BorderThickness = 1;
            this.IsWeekly.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.IsWeekly.Size = new System.Drawing.Size(21, 21);
            this.IsWeekly.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.IsWeekly.TabIndex = 15;
            this.IsWeekly.ThreeState = false;
            this.IsWeekly.ToolTipText = null;
            // 
            // LabelWeek
            // 
            this.LabelWeek.AllowParentOverrides = false;
            this.LabelWeek.AutoEllipsis = false;
            this.LabelWeek.CursorType = null;
            this.LabelWeek.Font = new System.Drawing.Font("Inter", 9.75F);
            this.LabelWeek.Location = new System.Drawing.Point(677, 52);
            this.LabelWeek.Name = "LabelWeek";
            this.LabelWeek.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LabelWeek.Size = new System.Drawing.Size(35, 16);
            this.LabelWeek.TabIndex = 16;
            this.LabelWeek.Text = "Week";
            this.LabelWeek.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LabelWeek.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // Week
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1168, 657);
            this.Controls.Add(this.LabelWeek);
            this.Controls.Add(this.IsWeekly);
            this.Controls.Add(this.DropProj);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.FilterBtn);
            this.Controls.Add(this.BtnWeeklyPayroll);
            this.Controls.Add(this.SSS);
            this.Controls.Add(this.PagIbig);
            this.Controls.Add(this.PhilHealth);
            this.Controls.Add(this.Week_SSS);
            this.Controls.Add(this.Week_PagIbig);
            this.Controls.Add(this.Week_PhilHealth);
            this.Controls.Add(this.EndAt);
            this.Controls.Add(this.StartAt);
            this.Controls.Add(this.WeekDgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Week";
            this.Text = "Weekly";
            this.Load += new System.EventHandler(this.Week_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeekDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeleteBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Project_DataSet)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.dB_Project_Dataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDataGridView WeekDgv;
        private Bunifu.UI.WinForms.BunifuDatePicker StartAt;
        private Bunifu.UI.WinForms.BunifuDatePicker EndAt;
        private Bunifu.UI.WinForms.BunifuCheckBox Week_PhilHealth;
        private Bunifu.UI.WinForms.BunifuCheckBox Week_PagIbig;
        private Bunifu.UI.WinForms.BunifuCheckBox Week_SSS;
        private Bunifu.UI.WinForms.BunifuLabel PhilHealth;
        private Bunifu.UI.WinForms.BunifuLabel PagIbig;
        private Bunifu.UI.WinForms.BunifuLabel SSS;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnWeeklyPayroll;
        private Bunifu.UI.WinForms.BunifuLabel FilterBtn;
        private System.Windows.Forms.PictureBox DeleteBtn;
        private Bunifu.UI.WinForms.BunifuDropdown DropProj;
        private _Project_DataSet _Project_DataSet;
        private System.Windows.Forms.BindingSource projectsBindingSource;
        private _Project_DataSetTableAdapters.ProjectsTableAdapter projectsTableAdapter;
        //private DB_Project_Dataset dB_Project_Dataset;
        private System.Windows.Forms.BindingSource projectsBindingSource1;
        //private DB_Project_DatasetTableAdapters.ProjectsTableAdapter projectsTableAdapter1;
        private System.Windows.Forms.BindingSource projectsBindingSource2;
        private Bunifu.UI.WinForms.BunifuCheckBox IsWeekly;
        private Bunifu.UI.WinForms.BunifuLabel LabelWeek;
    }
}