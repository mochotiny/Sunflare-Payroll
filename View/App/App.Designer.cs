namespace WFA_APP.View.App
{
    partial class App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(App));
            this.PanelForm = new Bunifu.UI.WinForms.BunifuPanel();
            this.SidePanelBar = new Bunifu.UI.WinForms.BunifuPanel();
            this.BtnSetting = new System.Windows.Forms.Button();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnReports = new System.Windows.Forms.Button();
            this.BtnPayroll = new System.Windows.Forms.Button();
            this.BtnAttendance = new System.Windows.Forms.Button();
            this.BtnEmployee = new System.Windows.Forms.Button();
            this.BtnHome = new System.Windows.Forms.Button();
            this.SidePanelBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelForm
            // 
            this.PanelForm.BackgroundColor = System.Drawing.Color.Transparent;
            this.PanelForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelForm.BackgroundImage")));
            this.PanelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelForm.BorderColor = System.Drawing.Color.Transparent;
            this.PanelForm.BorderRadius = 3;
            this.PanelForm.BorderThickness = 1;
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(88, 0);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.ShowBorders = true;
            this.PanelForm.Size = new System.Drawing.Size(1192, 720);
            this.PanelForm.TabIndex = 1;
            // 
            // SidePanelBar
            // 
            this.SidePanelBar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.SidePanelBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SidePanelBar.BackgroundImage")));
            this.SidePanelBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SidePanelBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.SidePanelBar.BorderRadius = 3;
            this.SidePanelBar.BorderThickness = 0;
            this.SidePanelBar.Controls.Add(this.BtnSetting);
            this.SidePanelBar.Controls.Add(this.BtnLogout);
            this.SidePanelBar.Controls.Add(this.BtnReports);
            this.SidePanelBar.Controls.Add(this.BtnPayroll);
            this.SidePanelBar.Controls.Add(this.BtnAttendance);
            this.SidePanelBar.Controls.Add(this.BtnEmployee);
            this.SidePanelBar.Controls.Add(this.BtnHome);
            this.SidePanelBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanelBar.Location = new System.Drawing.Point(0, 0);
            this.SidePanelBar.Name = "SidePanelBar";
            this.SidePanelBar.ShowBorders = true;
            this.SidePanelBar.Size = new System.Drawing.Size(88, 720);
            this.SidePanelBar.TabIndex = 0;
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnSetting.BackgroundImage = global::WFA_APP.Properties.Resources._1420666496;
            this.BtnSetting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnSetting.FlatAppearance.BorderSize = 0;
            this.BtnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSetting.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnSetting.Location = new System.Drawing.Point(0, 300);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(88, 60);
            this.BtnSetting.TabIndex = 8;
            this.BtnSetting.Text = "Project";
            this.BtnSetting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSetting.UseVisualStyleBackColor = false;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnLogout.BackgroundImage = global::WFA_APP.Properties.Resources.Multimedia__130___Converted_1;
            this.BtnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnLogout.FlatAppearance.BorderSize = 0;
            this.BtnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogout.Font = new System.Drawing.Font("Inter Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnLogout.Location = new System.Drawing.Point(-1, 658);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(88, 60);
            this.BtnLogout.TabIndex = 7;
            this.BtnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnReports
            // 
            this.BtnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnReports.BackgroundImage = global::WFA_APP.Properties.Resources.report;
            this.BtnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnReports.FlatAppearance.BorderSize = 0;
            this.BtnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReports.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnReports.Location = new System.Drawing.Point(0, 240);
            this.BtnReports.Name = "BtnReports";
            this.BtnReports.Size = new System.Drawing.Size(88, 60);
            this.BtnReports.TabIndex = 6;
            this.BtnReports.Text = "Reports";
            this.BtnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnReports.UseVisualStyleBackColor = false;
            this.BtnReports.Click += new System.EventHandler(this.BtnReports_Click);
            // 
            // BtnPayroll
            // 
            this.BtnPayroll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnPayroll.BackgroundImage = global::WFA_APP.Properties.Resources.payroll;
            this.BtnPayroll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnPayroll.FlatAppearance.BorderSize = 0;
            this.BtnPayroll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPayroll.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPayroll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnPayroll.Location = new System.Drawing.Point(0, 180);
            this.BtnPayroll.Name = "BtnPayroll";
            this.BtnPayroll.Size = new System.Drawing.Size(88, 60);
            this.BtnPayroll.TabIndex = 5;
            this.BtnPayroll.Text = "Payroll";
            this.BtnPayroll.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPayroll.UseVisualStyleBackColor = false;
            this.BtnPayroll.Click += new System.EventHandler(this.BtnPayroll_Click);
            // 
            // BtnAttendance
            // 
            this.BtnAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnAttendance.BackgroundImage = global::WFA_APP.Properties.Resources.Attendance;
            this.BtnAttendance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnAttendance.FlatAppearance.BorderSize = 0;
            this.BtnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAttendance.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttendance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnAttendance.Location = new System.Drawing.Point(0, 120);
            this.BtnAttendance.Name = "BtnAttendance";
            this.BtnAttendance.Size = new System.Drawing.Size(88, 60);
            this.BtnAttendance.TabIndex = 4;
            this.BtnAttendance.Text = "Attendance";
            this.BtnAttendance.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnAttendance.UseVisualStyleBackColor = false;
            this.BtnAttendance.Click += new System.EventHandler(this.BtnAttendance_Click);
            // 
            // BtnEmployee
            // 
            this.BtnEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnEmployee.BackgroundImage = global::WFA_APP.Properties.Resources.users;
            this.BtnEmployee.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnEmployee.FlatAppearance.BorderSize = 0;
            this.BtnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEmployee.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnEmployee.Location = new System.Drawing.Point(0, 60);
            this.BtnEmployee.Name = "BtnEmployee";
            this.BtnEmployee.Size = new System.Drawing.Size(88, 60);
            this.BtnEmployee.TabIndex = 3;
            this.BtnEmployee.Text = "Employee";
            this.BtnEmployee.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnEmployee.UseVisualStyleBackColor = false;
            this.BtnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // BtnHome
            // 
            this.BtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(25)))), ((int)(((byte)(35)))));
            this.BtnHome.BackgroundImage = global::WFA_APP.Properties.Resources.home_icon;
            this.BtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnHome.FlatAppearance.BorderSize = 0;
            this.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHome.Font = new System.Drawing.Font("Inter Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BtnHome.Location = new System.Drawing.Point(0, 0);
            this.BtnHome.Name = "BtnHome";
            this.BtnHome.Size = new System.Drawing.Size(88, 60);
            this.BtnHome.TabIndex = 2;
            this.BtnHome.Text = "Home";
            this.BtnHome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnHome.UseVisualStyleBackColor = false;
            this.BtnHome.Click += new System.EventHandler(this.BtnHome_Click);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.SidePanelBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "APP";
            this.SidePanelBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel SidePanelBar;
        private System.Windows.Forms.Button BtnHome;
        private System.Windows.Forms.Button BtnReports;
        private System.Windows.Forms.Button BtnPayroll;
        private System.Windows.Forms.Button BtnAttendance;
        private System.Windows.Forms.Button BtnEmployee;
        private Bunifu.UI.WinForms.BunifuPanel PanelForm;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Button BtnSetting;
    }
}