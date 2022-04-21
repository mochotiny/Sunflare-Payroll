using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using WFA_APP.View.Modules.Employee.CRUDEmployee;
using WFA_APP.View.Modules.Employee.Account;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Employee
{
    public partial class EmpForm : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        public EmpForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            this.PanelEmp.Controls.Clear();
            CRUDemployee emp = new CRUDemployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            emp.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmp.Controls.Add(emp);
            emp.Show();
        }

        private void BtnEmp_Click(object sender, EventArgs e)
        {
            this.PanelEmp.Controls.Clear();
            CRUDemployee emp = new CRUDemployee() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            emp.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmp.Controls.Add(emp);
            emp.Show();
        }

        private void BtnAccount_Click(object sender, EventArgs e)
        {
            this.PanelEmp.Controls.Clear();
            AccountForm acc = new AccountForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            acc.FormBorderStyle = FormBorderStyle.None;
            this.PanelEmp.Controls.Add(acc);
            acc.Show();
        }
    }
}
