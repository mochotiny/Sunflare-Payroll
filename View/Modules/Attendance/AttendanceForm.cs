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
        Connection db = new Connection();
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");

        public AttendancePresenter Presenter { get; set; }
        public AttendanceForm()
        {
            InitializeComponent();

        }
        private void AttendanceForm_Load(object sender, EventArgs e)
        {
            FillData();
            // TODO: This line of code loads data into the '_Employee_DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._Employee_DataSet.Employees);

        }

        void FillData()
        {
            using (db.con)
            {
                sda = new SqlDataAdapter("SELECT AttendanceID, E.Employee_Name, WorkedDay, StartAt, EndAt, NoOfOvertime, LogStatus FROM Attendances AS A INNER JOIN Employees AS E ON E.BiometricID = A.BiometricID", db.con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                AttDgv.DataSource = dt;
                this.Refresh();
            }
        }
        void FilterData()
        {
            connect = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            connect.Open();
            string sql = ("SELECT AttendanceID, BiometricID, WorkedDay, StartAt, EndAt, NoOfOvertime, LogStatus FROM Attendances WHERE BiometricID = @EmployeeId AND WorkedDay BETWEEN @Start AND @End");
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, connect);
            sda.SelectCommand.Parameters.AddWithValue("@EmployeeId", EmpDrop.SelectedValue.ToString());
            sda.SelectCommand.Parameters.AddWithValue("@Start", StartAt.Value.Date);
            sda.SelectCommand.Parameters.AddWithValue("@End", EndAt.Value.Date);
            sda.Fill(dt);
            connect.Close();
            AttDgv.DataSource = dt;
            this.Refresh();
            
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
            connect = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT AttendanceID, E.Employee_Name, WorkedDay, StartAt, EndAt, NoOfOvertime, LogStatus FROM Attendances AS A INNER JOIN Employees AS E ON E.BiometricID = A.BiometricID", connect);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            AttDgv.DataSource = dt;
            this.Refresh();
        }
    }  

}
    