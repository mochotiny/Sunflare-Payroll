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
            // TODO: This line of code loads data into the 'dB_Employee_Dataset.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter1.Fill(this.dB_Employee_Dataset.Employees);
            // TODO: This line of code loads data into the '_Employee_DataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this._Employee_DataSet.Employees);
            // TODO: This line of code loads data into the '_Employee_DataSet.Employees' table. You can move, or remove it, as needed.
            //this.employeesTableAdapter.Fill(this._Employee_DataSet.Employees);
            // TODO: This line of code loads data into the 'WeekPS.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.WeekPS.DataTable1);

            this.PSReport.RefreshReport();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.ShowPS(this.WeekPS.DataTable1, Start.Value.ToString(), End.Value.ToString());
            this.PSReport.RefreshReport();

            this.DataTable1TableAdapter.GetPaySlipByID(this.WeekPS.DataTable1, int.Parse(Dropdown.SelectedValue.ToString()), Start.Value.ToString()) ;
            this.PSReport.RefreshReport();
        }

       
    }
}
