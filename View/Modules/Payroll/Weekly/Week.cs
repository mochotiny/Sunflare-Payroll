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
                conn.Open();
                cmd = new SqlCommand("" +
                    "CASE" +
                    "   WHEN @Start TO @End")
            }
            else 
            { 
            
            }

        }
        void FilterData()
        {
            conn = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            conn.Open();
            string sql = ("SELECT * FROM Weekly WHERE  StartAt = @Start AND EndAt = @End");
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
            sda.SelectCommand.Parameters.AddWithValue("@Start", StartAt.Value.Date);
            sda.SelectCommand.Parameters.AddWithValue("@End", EndAt.Value.Date);
            sda.Fill(dt);
            conn.Close();
            WeekDgv.DataSource = dt;
            this.Refresh();

        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            FilterData();
        }
    }
}
