using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Payroll.Weekly
{
    public partial class Week : Form
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
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public Week()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void BtnWeeklyPayroll_Click(object sender, EventArgs e)
        {
            if (Week_PhilHealth.Checked && Week_PagIbig.Checked && Week_SSS.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }
            else if (Week_PhilHealth.Checked && Week_PagIbig.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }
            else if (Week_PhilHealth.Checked && Week_SSS.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }
            else if (Week_PagIbig.Checked && Week_SSS.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }
            else if (Week_SSS.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }
            else if (Week_PagIbig.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }
            else if (Week_PhilHealth.Checked)
            {
                conn.Open();
                cmd = new SqlCommand("", conn);
            }

        }
    }
}
