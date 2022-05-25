using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WFA_APP.DB;

namespace WFA_APP.View.Modules.Job
{
    public partial class CRUDjob : Form
    {
        //readonly Connection db = new Connection();
        SqlConnection con = new SqlConnection(DbConnection.ConnectionString);
        SqlDataAdapter sda = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();

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
        public CRUDjob()
        {
            InitializeComponent();
            CheckBtn.Visible = false;
            DeleteBtn.Visible = false;

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            if (Connection.type == "A")
            {
                BtnDeleteJob.Visible = true;
            }
            else if (Connection.type == "M")
            {
                BtnDeleteJob.Visible = false;
            }
        }

        private void CRUDjob_Load(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    sda = new SqlDataAdapter("SELECT * FROM Jobs", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Jobs");
                    JobDgv.DataSource = ds.Tables["Jobs"].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateJob_Click(object sender, EventArgs e)
        {
            
            if (JobTitle.Text == "" || JobDayRate.Text == "")
            {
                MessageBox.Show("Fill up all fields");

            }
            else
            {
                con.Open();
                cmd = new SqlCommand("proc_CreateJob", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@JobTitle", JobTitle.Text);
                cmd.Parameters.AddWithValue("@DailyRate", JobDayRate.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Created.");

                sda = new SqlDataAdapter("SELECT * FROM Jobs", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Jobs");
                JobDgv.DataSource = ds.Tables["Jobs"].DefaultView;

                con.Close();
                this.Refresh();
            }
        }
        private void BtnUpdateJob_Click(object sender, EventArgs e)
        {
            JobID.Text = this.JobDgv.CurrentRow.Cells[0].Value.ToString();
            JobTitle.Text = this.JobDgv.CurrentRow.Cells[1].Value.ToString();
            JobDayRate.Text = this.JobDgv.CurrentRow.Cells[2].Value.ToString();
            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    if (JobID.Text == "" || JobTitle.Text == "" || JobDayRate.Text == "")
                    {
                        MessageBox.Show("Fill up all fields");
                    }
                    else
                    {
                        con.Open();
                        //cmd = new SqlCommand("UPDATE Departments SET Department_Name = '"+ DeptName.Text +"' WHERE DepartmentID = '"+ DeptID.Text +"' ", db.con);
                        cmd = new SqlCommand("proc_UpdateJob", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@JobID", JobID.Text);
                        cmd.Parameters.AddWithValue("@JobTitle", JobTitle.Text);
                        cmd.Parameters.AddWithValue("@DailyRate", JobDayRate.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Updated.");

                        sda = new SqlDataAdapter("SELECT * FROM Jobs", con);
                        DataSet ds = new DataSet();
                        sda.Fill(ds, "Jobs");
                        JobDgv.DataSource = ds.Tables["Jobs"].DefaultView;

                        con.Close();
                        CheckBtn.Visible = false;
                        this.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnDeleteJob_Click(object sender, EventArgs e)
        {
            JobID.Text = this.JobDgv.CurrentRow.Cells[0].Value.ToString();
            JobTitle.Text = this.JobDgv.CurrentRow.Cells[1].Value.ToString();
            JobDayRate.Text = this.JobDgv.CurrentRow.Cells[2].Value.ToString();
            DeleteBtn.Visible = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    if (JobDgv.Rows.Count > 1)
                    {
                        if (JobDgv.CurrentRow.Index == JobDgv.Rows.Count - 1)
                        {
                            MessageBox.Show("Please select data to be deleted.");
                        }
                        else
                        {
                            if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string del = JobDgv.CurrentRow.Cells[0].Value.ToString();
                                con.Open();
                                cmd = new SqlCommand("DELETE FROM Jobs WHERE JobID = '" + del + "' ", con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data has been deleted");

                                JobID.Clear();
                                JobTitle.Clear();
                                JobDayRate.Clear();
                                DeleteBtn.Visible = false;

                                string query = "SELECT * FROM Jobs";
                                SqlDataAdapter da = new SqlDataAdapter(query, con);
                                DataSet ds = new DataSet();
                                da.Fill(ds, "Jobs");
                                JobDgv.DataSource = ds;
                                JobDgv.DataMember = "Jobs";
                                JobDgv.DataSource = JobDgv.DataSource;
                                con.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No more data to be deleted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }    
        }
    }
}
