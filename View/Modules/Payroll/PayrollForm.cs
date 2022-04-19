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

namespace WFA_APP.View.Modules.Payroll
{
    public partial class PayrollForm : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        

        public PayrollForm()
        {
            InitializeComponent();
        }

        private void PayrollBtn_Click(object sender, EventArgs e)
        {
            
            if (Monthly.Checked)
            {
                //15 && 30/31
                //Filter Employees who has weekly = 0
                if (PhilHealth.Checked && PagIbig.Checked && SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM Employees WHERE", conn);
                }
                else if (PhilHealth.Checked && PagIbig.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PhilHealth.Checked && SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PagIbig.Checked && SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PagIbig.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PhilHealth.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }

            }
            //Weekly = 1
            else
            {
                //Between 2 dates
                if (PhilHealth.Checked && PagIbig.Checked && SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("SELECT * FROM Employees WHERE Phil_Health = 1 AND PagIbig = 1 AND SSS = 1", conn);
                }
                else if (PhilHealth.Checked && PagIbig.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PhilHealth.Checked && SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PagIbig.Checked && SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PagIbig.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (PhilHealth.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
            }
        }
    }
}
