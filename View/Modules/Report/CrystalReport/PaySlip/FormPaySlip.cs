using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Report.CrystalReport.PaySlip
{
    public partial class FormPaySlip : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        public FormPaySlip()
        {
            InitializeComponent();
        }

        private void FormPaySlip_Load(object sender, EventArgs e)
        {
            string sqlcmd = "SELECT * FROM Weekly";
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "PaySlipDS");

            PSReport reportPay = new PSReport();
            reportPay.SetDataSource(ds);
            crystalReportViewer1.ReportSource = reportPay;
        }
    }
}
