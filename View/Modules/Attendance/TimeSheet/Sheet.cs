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

namespace WFA_APP.View.Modules.Attendance.TimeSheet
{
    public partial class Sheet : Form
    {
        SqlConnection con = new SqlConnection(DbConnection.Connect());
        SqlDataAdapter sda = new SqlDataAdapter();
        public Sheet()
        {
            InitializeComponent();
        }

        private void Sheet_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT E.Employee_Name, StartAt, EndAt, DaysWorked, Lates, Undertime, Overtime FROM Work AS W INNER JOIN Employees AS E ON W.BiometricID = E.BiometricID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SheetDgv.DataSource = dt;
            this.Refresh();
        }
    }
}
