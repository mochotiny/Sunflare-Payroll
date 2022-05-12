using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_APP.Presenter;
using WFA_APP.View.Modules.Employee.CRUDEmployee;
using WFA_APP.View.Modules.Department;
using WFA_APP.View.Modules.Job;

namespace WFA_APP.View.Modules.Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeePresenter Presenter { get; set; }
        public EmployeeForm()
        {
            InitializeComponent();
            this.PanelEmployee.Controls.Clear();
            EmpForm emp = new EmpForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            emp.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(emp);
            emp.Show();
        }

        private void BtnEmployee_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point (12, 50);
            PanelDeck.Size = new Size(92, 2);

            this.PanelEmployee.Controls.Clear();
            EmpForm emp = new EmpForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            emp.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(emp);
            emp.Show();
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(129, 50);
            PanelDeck.Size = new Size(113, 2);

            this.PanelEmployee.Controls.Clear();
            CRUDdepartment dept = new CRUDdepartment() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            dept.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(dept);
            dept.Show();
        }

        private void BtnJob_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(267, 50);
            PanelDeck.Size = new Size(36, 2);

            this.PanelEmployee.Controls.Clear();
            CRUDjob job = new CRUDjob() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            job.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(job);
            job.Show();
        }
    }
}
