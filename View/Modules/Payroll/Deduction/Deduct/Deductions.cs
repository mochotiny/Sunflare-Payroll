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

namespace WFA_APP.View.Modules.Payroll.Deduction
{
    public partial class Deductions : Form
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
        public Deductions()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            sda = new SqlDataAdapter("SELECT * FROM Deductions", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Deductions");
            DeductDgv.DataSource = ds.Tables["Deductions"].DefaultView;
            con.Close();
        }

        private void DeductBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand("proc_Work", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", Startat.Value.Date.ToString("dd-MMM-yyyy"));
            cmd.Parameters.AddWithValue("@End", Endat.Value.Date.ToString("dd-MMM-yyyy"));

            
            cmd.ExecuteNonQuery();

            cmd = new SqlCommand("proc_Deduction", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", Startat.Value.Date.ToString("dd-MMM-yyyy"));
            cmd.Parameters.AddWithValue("@End", Endat.Value.Date.ToString("dd-MMM-yyyy"));

            cmd.ExecuteNonQuery();


            sda = new SqlDataAdapter("SELECT * FROM Deductions", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Deductions");
            DeductDgv.DataSource = ds.Tables["Deductions"].DefaultView;
            con.Close();
        }
    }
}
