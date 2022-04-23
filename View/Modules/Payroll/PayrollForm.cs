using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using WFA_APP.View.Modules.Payroll.Deduction;
using WFA_APP.View.Modules.Payroll.Monthly;
using WFA_APP.View.Modules.Payroll.Weekly;

namespace WFA_APP.View.Modules.Payroll
{
    public partial class PayrollForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();


        public PayrollForm()
        {
            InitializeComponent();
            this.PanelPayroll.Controls.Clear();
            PRForm prf = new PRForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            prf.FormBorderStyle = FormBorderStyle.None;
            this.PanelPayroll.Controls.Add(prf);
            prf.Show();

        }

        private void BtnPR_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(11, 45);
            this.PanelPayroll.Controls.Clear();
            PRForm prf = new PRForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            prf.FormBorderStyle = FormBorderStyle.None;
            this.PanelPayroll.Controls.Add(prf);
            prf.Show();
        }
        private void BtnWeekly_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(111, 45);
            this.PanelPayroll.Controls.Clear();
            Week week = new Week() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            week.FormBorderStyle = FormBorderStyle.None;
            this.PanelPayroll.Controls.Add(week);
            week.Show();
        }

        private void BtnMonthly_Click(object sender, EventArgs e)
        {
            PanelDeck.Location = new Point(211, 45);
            this.PanelPayroll.Controls.Clear();
            Month month = new Month() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            month.FormBorderStyle = FormBorderStyle.None;
            this.PanelPayroll.Controls.Add(month);
            month.Show();
        }


        //private void PayrollBtn_Click(object sender, EventArgs e)
        //{

        //    if (Monthly.Checked)
        //    {
        //        //15 && 30/31
        //        //Filter Employees who has weekly = 0
        //        if (PhilHealth.Checked && PagIbig.Checked && SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PhilHealth.Checked && PagIbig.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PhilHealth.Checked && SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PagIbig.Checked && SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PagIbig.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PhilHealth.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }

        //    }
        //    //Weekly = 1
        //    else
        //    {
        //        //Between 2 dates
        //        if (PhilHealth.Checked && PagIbig.Checked && SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PhilHealth.Checked && PagIbig.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PhilHealth.Checked && SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PagIbig.Checked && SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (SSS.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PagIbig.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //        else if (PhilHealth.Checked)
        //        {
        //            conn.Open();
        //            cmd = new SqlCommand("", conn);
        //        }
        //    }
        //}

    }
}
