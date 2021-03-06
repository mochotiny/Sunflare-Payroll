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
            // TODO: This line of code loads data into the '_pr_appDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this._pr_appDataSet.Projects);
            // TODO: This line of code loads data into the '_pr_appDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this._pr_appDataSet.Departments);

            BtnDepartment.Visible = false;
            Btn3Param.Visible = false;
            Btn4Params.Visible = false;

           
            //this.Weekly2TableAdapter.Fill(this.WeeklyPR.Weekly2);
            //this.reportViewer1.RefreshReport();
        }

        private void ShowBtn_Click(object sender, EventArgs e)
        {
            this.Weekly2TableAdapter.GetWeeklyReport(this.WeeklyPR.Weekly2, Start.Value.ToString(), End.Value.ToString());
            this.reportViewer1.RefreshReport();
        }

        private void Dropdown_SelectedValueChanged(object sender, EventArgs e)
        {
            BtnDepartment.Visible = true;
        }

        private void BtnDepartment_Click(object sender, EventArgs e)
        {
            this.Weekly2TableAdapter.GetByDepartment(this.WeeklyPR.Weekly2, int.Parse(Dropdown.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void Check_CheckStateChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (Check.Checked)
            {
                Btn3Param.Visible = true;
            }
            else
            {
                Btn3Param.Visible = false;
            }
        }

        private void Btn3Param_Click(object sender, EventArgs e)
        {
            this.Weekly2TableAdapter.GetBy3Params(this.WeeklyPR.Weekly2, Start.Value.ToString(), End.Value.ToString(), int.Parse(Dropdown.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void Btn4Params_Click(object sender, EventArgs e)
        {
            this.Weekly2TableAdapter.GetBy4Params(this.WeeklyPR.Weekly2, Start.Value.ToString(), End.Value.ToString(), int.Parse(Dropdown.SelectedValue.ToString()), int.Parse(DropProj.SelectedValue.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void DropProj_SelectedValueChanged(object sender, EventArgs e)
        {
            Btn4Params.Visible = true;
        }
    }
}
