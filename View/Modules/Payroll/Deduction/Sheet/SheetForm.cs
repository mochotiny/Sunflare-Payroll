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
using WFA_APP.DB;

namespace WFA_APP.View.Modules.Payroll.Deduction.Sheet
{
    public partial class SheetForm : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.ConnectionString);
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        public SheetForm()
        {
            InitializeComponent();
            CheckBtn.Visible = false;
            ID.Visible = false;
            sda = new SqlDataAdapter("SELECT E.BiometricID, E.Employee_Name, StartAt, EndAt, DaysWorked, Lates, Undertime, Overtime, Holidayss, Adjustmentss FROM Work AS W INNER JOIN Employees AS E ON W.BiometricID = E.BiometricID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SheetDgv.DataSource = dt;
            this.Refresh();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            //sda = new SqlDataAdapter("SELECT BiometricID, StartAt, EndAt, DaysWorked, Lates, Undertime, Overtime, Holidayss, Adjustmentss FROM Work", con);
            //DataTable dt = new DataTable();
            //sda.Fill(dt);
            //SheetDgv.DataSource = dt;
            //this.Refresh();

            Adjustments.Text = this.SheetDgv.CurrentRow.Cells[9].Value.ToString();
            ID.Text = this.SheetDgv.CurrentRow.Cells[0].Value.ToString();
            ID.Visible = true;
            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("UPDATE Work SET Adjustmentss = '"+ Adjustments.Text +"' WHERE BiometricID = '"+ ID.Text +"' ",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated.");
            this.Refresh();
            con.Close();
            CheckBtn.Visible = false;
        }
    }
}
