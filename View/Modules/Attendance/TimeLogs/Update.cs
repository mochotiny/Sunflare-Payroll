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
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.Connect());
        SqlCommand cmd = new SqlCommand();
        public Update()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PunchLog_Click(object sender, EventArgs e)
        {
            if (ID.Text == "" || Name.Text == "" || DayWork.Text == "" || TimeIn.Text == "" || TimeOut.Text == "" || Overtime.Text == "")
            {
                MessageBox.Show("Fill up all fields");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Attendances SET WorkedDay = '" + DayWork.Value.Date.ToString("dd-MMM-yyyy") + "', StartAt = '" + TimeIn.Value.ToString("HH:mm") + "', EndAt = '" + TimeOut.Value.ToString("HH:mm") + "' , NoOfOvertime = '" + Overtime.Text + "'  WHERE AttendanceID = '" + ID.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
                con.Close();
                this.Close();
            }
        }

    }
}
