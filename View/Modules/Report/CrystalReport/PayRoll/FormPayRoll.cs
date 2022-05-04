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

namespace WFA_APP.View.Modules.Report.CrystalReport.PayRoll
{
    public partial class FormPaySlip : Form
    {
        ReportDocument cryrpt = new ReportDocument();
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        public FormPaySlip()
        {
            InitializeComponent();
        }

        private void FormPayRoll_Load(object sender, EventArgs e)
        {
            //string sqlcmd = "SELECT EmployeeName, BiometricID, DayRate, DaysWorked, BasicPay, OTRate, NoOfOT, OTPay, Holiday, Adjustments, GrossSalary, PhilHealth, PagIbig, SSS, LoanOrCA, UnderTime, Late, Others, TotalDeductions, NetSalary FROM Weekly";
            //SqlDataAdapter da = new SqlDataAdapter(sqlcmd, con);
            //DataSet ds = new DataSet();
            //da.Fill(ds, "PayRollDT");

            //ReportPayRoll reportPay = new ReportPayRoll();
            //reportPay.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = reportPay;
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            
            string strcmd = "SELECT EmployeeName, BiometricID, DayRate, DaysWorked, BasicPay, OTRate, NoOfOT, OTPay, Holiday, Adjustments, GrossSalary, PhilHealth, PagIbig, SSS, LoanOrCA, UnderTime, Late, Others, TotalDeductions, NetSalary FROM Weekly WHERE StartAt = '"+StartAt.Value.Date+"' AND EndAt = '"+ EndAt.Value.Date +"'";
            SqlDataAdapter da = new SqlDataAdapter(strcmd, con);
            //da.SelectCommand.Parameters.AddWithValue("@Start", StartAt.Value.Date);
            //da.SelectCommand.Parameters.AddWithValue("@End", EndAt.Value.Date);
            DataSet sd = new DataSet();
            da.Fill(sd, "PayRollDT");

            ReportPayRoll show = new ReportPayRoll();
            show.SetDataSource(sd);
            crystalReportViewer1.ReportSource = show;
        }
    }
}
