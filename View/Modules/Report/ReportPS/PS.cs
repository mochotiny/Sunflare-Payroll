using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Report.ReportPS
{
    public partial class PS : Form
    {
        public PS()
        {
            InitializeComponent();
        }

        private void PS_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'WeekPS.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.WeekPS.DataTable1);

            this.PSReport.RefreshReport();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.ShowPS(this.WeekPS.DataTable1, Start.Value.ToString("MMM dd"), End.Value.ToString("MMM dd"));
            this.PSReport.RefreshReport();
        }
    }
}
