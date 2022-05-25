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
using WFA_APP.Presenter;
using WFA_APP.DB;

namespace WFA_APP.View.Modules.Attendance
{
    public partial class AttendanceForm : Form
    {
        //Connection db = new Connection();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlConnection con = new SqlConnection(DbConnection.ConnectionString);

        public AttendancePresenter Presenter { get; set; }
        public AttendanceForm()
        {
            InitializeComponent();

        }
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            FillData();
            // TODO: This line of code loads data into the '_pr_appDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._pr_appDataSet.Employees);
        }

        void FillData()
        {
            using (con)
            {
                sda = new SqlDataAdapter("SELECT AttendanceID, E.Employee_Name, WorkedDay, StartAt, EndAt, NoOfOvertime, LogStatus FROM Attendances AS A INNER JOIN Employees AS E ON E.BiometricID = A.BioID", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttDgv.DataSource = dt;
                this.Refresh();
            }
        }
        void FilterData()
        {
            SqlConnection con = new SqlConnection(DbConnection.ConnectionString);
            con.Open();
            string sql = ("SELECT AttendanceID, BioID, WorkedDay, StartAt, EndAt, NoOfOvertime, LogStatus FROM Attendances WHERE BioID = @EmployeeId AND WorkedDay BETWEEN @Start AND @End");
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.Parameters.AddWithValue("@EmployeeId", EmpDrop.SelectedValue.ToString());
            sda.SelectCommand.Parameters.AddWithValue("@Start", StartAt.Value.Date);
            sda.SelectCommand.Parameters.AddWithValue("@End", EndAt.Value.Date);
            sda.Fill(dt);
            con.Close();
            AttDgv.DataSource = dt;
            this.Refresh();
            con.Close();
        }

        private void FilterLabel_Click(object sender, EventArgs e)
        {
            FilterData();
        }

        private void LogBtn_Click(object sender, EventArgs e)
        {
            Log att = new Log();
            att.ShowDialog();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Update edit = new Update(); //this is the change, code for redirect  
            edit.ID.Text = this.AttDgv.CurrentRow.Cells[0].Value.ToString();
            edit.Name.Text = this.AttDgv.CurrentRow.Cells[1].Value.ToString();
            edit.DayWork.Text = this.AttDgv.CurrentRow.Cells[2].Value.ToString();
            edit.TimeIn.Text = this.AttDgv.CurrentRow.Cells[3].Value.ToString();
            edit.TimeOut.Text = this.AttDgv.CurrentRow.Cells[4].Value.ToString();
            edit.Overtime.Text = this.AttDgv.CurrentRow.Cells[5].Value.ToString();
            edit.ShowDialog();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT AttendanceID, E.Employee_Name, WorkedDay, StartAt, EndAt, NoOfOvertime, LogStatus FROM Attendances AS A INNER JOIN Employees AS E ON E.BiometricID = A.BioID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AttDgv.DataSource = dt;
            this.Refresh();
            
        }
    }  

}
    