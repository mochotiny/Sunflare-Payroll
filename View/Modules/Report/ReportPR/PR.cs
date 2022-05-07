using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Report.ReportPR
{
    public partial class PR : Form
    {
        public PR()
        {
            InitializeComponent();
        }

        private void PR_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Department_DataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this._Department_DataSet.Departments);
           
            //this.Weekly2TableAdapter.Fill(this.WeeklyPR.Weekly2);
            //this.reportViewer1.RefreshReport();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            //this.Weekly2TableAdapter.GetWeeklyReport(this.WeeklyPR.Weekly2, Start.Value.ToString(), End.Value.ToString());
            //this.reportViewer1.RefreshReport();

            this.Weekly2TableAdapter.GetMonthlyReport(this.WeeklyPR.Weekly2, Start.Value.ToString(), End.Value.ToString());
            this.reportViewer1.RefreshReport();
            

        }
    }
}
