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
            PanelDeck.Location = new Point (50, 97);
            PanelDeck.Size = new Size(1092, 2);

            this.PanelEmployee.Controls.Clear();
            EmpForm emp = new EmpForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            emp.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(emp);
            emp.Show();
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(167, 97);
            PanelDeck.Size = new Size(975, 2);

            this.PanelEmployee.Controls.Clear();
            CRUDdepartment dept = new CRUDdepartment() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            dept.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(dept);
            dept.Show();
        }

        private void BtnJob_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(305, 97);
            PanelDeck.Size = new Size(838, 2);

            this.PanelEmployee.Controls.Clear();
            CRUDjob job = new CRUDjob() { Dock = DockStyle.Right, TopLevel = false, TopMost = true };
            job.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmployee.Controls.Add(job);
            job.Show();
        }
    }
}
