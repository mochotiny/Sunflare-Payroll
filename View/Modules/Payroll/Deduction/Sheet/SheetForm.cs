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

namespace WFA_APP.View.Modules.Payroll.Deduction.Sheet
{
    public partial class SheetForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter();
        public SheetForm()
        {
            InitializeComponent();
            sda = new SqlDataAdapter("SELECT E.Employee_Name, StartAt, EndAt, DaysWorked, Lates, Undertime, Overtime FROM Work AS W INNER JOIN Employees AS E ON W.BiometricID = E.BiometricID", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            SheetDgv.DataSource = dt;
            this.Refresh();
        }
    }
}
