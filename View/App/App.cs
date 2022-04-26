using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_APP.View.App;
using WFA_APP.View.Modules.Attendance;
using WFA_APP.View.Modules.Employee;
using WFA_APP.View.Modules.Home;
using WFA_APP.View.Modules.Payroll;
using WFA_APP.View.Modules.Report;

namespace WFA_APP.View.App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            ControlBox = false;

            this.PanelForm.Controls.Clear();
            HomeForm home = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            this.PanelForm.Controls.Add(home);
            home.Show();
        }

        private void BtnHome_Click(object sender, EventArgs e)
        {
            this.PanelForm.Controls.Clear();
            HomeForm home = new HomeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            home.FormBorderStyle = FormBorderStyle.None;
            this.PanelForm.Controls.Add(home);
            home.Show();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            this.PanelForm.Controls.Clear();
            EmployeeForm emp = new EmployeeForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            emp.FormBorderStyle = FormBorderStyle.None;
            this.PanelForm.Controls.Add(emp);
            emp.Show();
        }

        private void BtnAttendance_Click(object sender, EventArgs e)
        {
            this.PanelForm.Controls.Clear();
            Attendance att = new Attendance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            att.FormBorderStyle = FormBorderStyle.None;
            this.PanelForm.Controls.Add(att);
            att.Show();
        }

        private void BtnPayroll_Click(object sender, EventArgs e)
        {
            this.PanelForm.Controls.Clear();
            PayrollForm pr = new PayrollForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pr.FormBorderStyle = FormBorderStyle.None;
            this.PanelForm.Controls.Add(pr);
            pr.Show();
        }

        private void BtnReports_Click(object sender, EventArgs e)
        {
            this.PanelForm.Controls.Clear();
            ReportForm rp = new ReportForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            rp.FormBorderStyle = FormBorderStyle.None;
            this.PanelForm.Controls.Add(rp);
            rp.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            LogForm log = new LogForm();
            log.Show();
        }
    }
}
