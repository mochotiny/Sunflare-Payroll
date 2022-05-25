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
using WFA_APP.DB;

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
        SqlConnection conn = new SqlConnection(DbConnection.ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        public Week()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            DeleteBtn.Visible = false;
            sda = new SqlDataAdapter("SELECT * FROM PayRoll WHERE Weekly = 1", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Weekly");
            WeekDgv.DataSource = ds.Tables["Weekly"].DefaultView;
        }
        

        private void BtnWeeklyPayroll_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("proc_PayRoll", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Start", StartAt.Value.Date);
            cmd.Parameters.AddWithValue("@End", EndAt.Value.Date);
            cmd.Parameters.AddWithValue("@PhilHealth", Week_PhilHealth.Checked);
            cmd.Parameters.AddWithValue("@PagIbig", Week_PagIbig.Checked);
            cmd.Parameters.AddWithValue("@SSS", Week_SSS.Checked);
            cmd.Parameters.AddWithValue("@ProjectID", DropProj.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Weekly", IsWeekly.Checked);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Created.");
            conn.Close();

            DeleteBtn.Visible = true;
            sda = new SqlDataAdapter("SELECT * FROM PayRoll WHERE Weekly = 1", conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Weekly");
            WeekDgv.DataSource = ds.Tables["Weekly"].DefaultView;
        }
        void FilterData()
        {
            conn.Open();
            string sql = ("SELECT * FROM Weekly WHERE Weekly = 1 AND StartAt = @Start AND EndAt = @End");
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

        private void Week_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pr_appDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this._pr_appDataSet.Projects);
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            conn.Open();
            cmd = new SqlCommand("DELETE FROM Weekly", conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            conn.Close();
            DeleteBtn.Visible=false;
        }
    }
}
