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

namespace WFA_APP.View.Modules.Attendance
{
    public partial class Log : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.Connect());
        SqlCommand cmd = new SqlCommand();
        public Log()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Log_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Employee_DataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._Employee_DataSet.Employees);

        }

        private void PunchLog_Click(object sender, EventArgs e)
        {
            con.Open();
            //payrollVB
            cmd = new SqlCommand(" INSERT INTO Attendances (BioID, WorkedDay, StartAt, EndAt, NoOfOvertime) VALUES ('" + EmpDrop.SelectedValue.ToString() + "', '" + DayWork.Value.Date.ToString("dd-MMM-yyyy") + "', '" + TimeIn.Value.ToString("HH:mm") + "', '" + TimeOut.Value.ToString("HH:mm") + "', '"+ Overtime.Text.ToString() +"' ) ", con);
            cmd.ExecuteNonQuery();
            cmd = new SqlCommand("UPDATE Att SET IsHoliday = CASE When WorkedDay = Hol.Day AND Hol.Type = 1 THEN 1 WHEN WorkedDay = Hol.Day AND Hol.Type IS NULL THEN 2 ELSE 0 END FROM Attendances AS Att LEFT JOIN Holidays AS Hol ON Att.WorkedDay = Hol.day", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Logged.");
            con.Close();
            
            this.Close();

        }
    }
}
