using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Payroll.Weekly
{
    public partial class Week : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public Week()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            sda = new SqlDataAdapter("SELECT * FROM Weekly", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Weekly");
            WeekDgv.DataSource = ds.Tables["Weekly"].DefaultView;
        }

        private void BtnWeeklyPayroll_Click(object sender, EventArgs e)
        {
            if (Holiday.Checked)
            {
                if (Week_PhilHealth.Checked && Week_PagIbig.Checked && Week_SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("INSERT INTO Weekly (EmployeeName, BiometricID, DayRate, StartAt, EndAt, DaysWorked, NoOfOT, Holiday, Adjustments PhilHealth, PagIbig, SSS, LoanOrCA, UnderTime, Late, Others)" +
                        "SELECT " +
                        "E.Employee_Name," +
                        "E.BiometricID," +
                        "DayRate," +
                        "@Start," +
                        "@End," +
                        "Work.DaysWorked," +
                        "Work.Overtime," +
                        "DayRate," +
                        "0.00" +
                        "(CASE WHEN Phil_Health = 1 THEN (((DayRate*6)*4)*0.04) ELSE 0.00 END) AS PhilHealth," +
                        "(CASE WHEN PagIbig = 1 THEN (((DayRate*6)*4)*0.04) ELSE 0.00 END) AS PagIbig," +
                        "(CASE WHEN SSS = 1 THEN (((DayRate*6)*4)*0.12) ELSE 0.00 END) AS SSS," +
                        "Deductions.LoanOrCA," +
                        "Deductions.UnderTime," +
                        "Deductions.Late," +
                        "Deductions.Others" +
                        "FROM Employees AS E" +
                        "INNER JOIN Work ON Work.BiometricID = E.BiometricID" +
                        "INNER JOIN Deductions ON Deductions.BiometricID = Work.BiometricID", conn);
                    cmd.Parameters.AddWithValue("@Start", StartAt.Value.Date);
                    cmd.Parameters.AddWithValue("@End", EndAt.Value.Date);
                    cmd.ExecuteNonQuery();

                    sda = new SqlDataAdapter("SELECT * FROM Weekly", conn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Weekly");
                    WeekDgv.DataSource = ds.Tables["Weekly"].DefaultView;

                }
                else if (Week_PhilHealth.Checked && Week_PagIbig.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (Week_PhilHealth.Checked && Week_SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (Week_PagIbig.Checked && Week_SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (Week_SSS.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (Week_PagIbig.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
                else if (Week_PhilHealth.Checked)
                {
                    conn.Open();
                    cmd = new SqlCommand("", conn);
                }
            }
            else
            {

            }

        }
    }
}
