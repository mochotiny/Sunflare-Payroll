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
using WFA_APP.View.Modules.Report.ReportPR;
using WFA_APP.View.Modules.Report.ReportPS;
using WFA_APP.View.Modules.Report.CrystalReport.PaySlip;

namespace WFA_APP.View.Modules.Report
{
    public partial class ReportForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();  

        public ReportForm()
        {
            InitializeComponent();
        }

        private void ReportForm_Load(object sender, EventArgs e)
        {

        }

        private void ReportPR_Click(object sender, EventArgs e)
        {
            PanelBoard.Location = new Point(12, 50);
            this.PanelReport.Controls.Clear();
            PR pr = new PR() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            pr.FormBorderStyle = FormBorderStyle.None;
            this.PanelReport.Controls.Add(pr);
            pr.Show();
        }

        private void ReportPS_Click(object sender, EventArgs e)
        {
            PanelBoard.Location = new Point(128, 50);
            this.PanelReport.Controls.Clear();
            PS ps = new PS() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            ps.FormBorderStyle = FormBorderStyle.None;
            this.PanelReport.Controls.Add(ps);
            ps.Show();
        }
    }
}
