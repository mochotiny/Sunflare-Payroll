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

namespace WFA_APP.View.Modules.Attendance
{
    public partial class Log : Form
    {
        SqlConnection connect = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
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
            connect.Open();
            //payrollVB
            cmd = new SqlCommand(" INSERT INTO Attendances (BioID, WorkedDay, StartAt, EndAt, NoOfOvertime) VALUES ('" + EmpDrop.SelectedValue.ToString() + "', '" + DayWork.Value.Date.ToString("dd-MMM-yyyy") + "', '" + TimeIn.Value.ToString("HH:mm") + "', '" + TimeOut.Value.ToString("HH:mm") + "', '"+ Overtime.Text.ToString() +"' ) ", connect);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Logged.");
            connect.Close();
            
            this.Close();

        }
    }
}
