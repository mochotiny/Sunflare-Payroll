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

namespace WFA_APP.View.Modules.Payroll.Monthly
{
    public partial class Month : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();

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
        public Month()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));

            sda = new SqlDataAdapter("SELECT * FROM Monthly", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Monthly");
            MonthDgv.DataSource = ds.Tables["Monthly"].DefaultView;
        }

        private void RunBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("proc_Monthly", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", StartAt.Value.Date);
            cmd.Parameters.AddWithValue("@End", EndAt.Value.Date);
            cmd.Parameters.AddWithValue("@PhilHealth", Month_PhilHealth.Checked);
            cmd.Parameters.AddWithValue("@PagIbig", Month_PagIbig.Checked);
            cmd.Parameters.AddWithValue("@SSS", Month_SSS.Checked);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Created.");
            con.Close();

            
            sda = new SqlDataAdapter("SELECT * FROM Monthly", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Monthly");
            MonthDgv.DataSource = ds.Tables["Monthly"].DefaultView;
        }
    }
}
