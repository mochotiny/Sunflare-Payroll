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

namespace WFA_APP.View.Modules.Projects
{
    public partial class FormProject : Form
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
        //Connection db = new Connection();
        SqlConnection con = new SqlConnection(DbConnection.Connect());
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        public FormProject()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            DeleteBtn.Visible = false;
            CheckBtn.Visible = false;
        }
        private void FormProject_Load(object sender, EventArgs e)
        {
            try
            {
                using (con)
                {
                    sda = new SqlDataAdapter("SELECT * FROM Projects", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Projects");
                    ProjectDgv.DataSource = ds.Tables["Projects"].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateProj_Click(object sender, EventArgs e)
        {

            if (ProjName.Text == "")
            {
                MessageBox.Show("Fill up all fields");

            }
            else
            {
                con.Open();
                //cmd = new SqlCommand("INSERT INTO Employees (Biometric_Id, Dept_Name, Contact, Address, Department_Id, Job_Id) VALUES( '" + BioID.Text + "','" + EmpName.Text + "','" + EmpContact.Text + "','" + EmpAddress.Text + "','" + DeptDrop.SelectedValue.ToString() + "','" + JobDrop.SelectedValue.ToString() + "' )", con);
                //cmd = new SqlCommand("INSERT INTO Departments (Department_Name) VALUES ("+ DeptName.Text +")", con);
                cmd = new SqlCommand("proc_CreateProject", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ProjectName", ProjName.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Created.");

                sda = new SqlDataAdapter("SELECT * FROM Projects", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Projects");
                ProjectDgv.DataSource = ds.Tables["Projects"].DefaultView;

                con.Close();
                ProjName.Clear();
                this.Refresh();
            }
            
        }

        private void BtnUpdateProj_Click(object sender, EventArgs e)
        {
            ProjName.Visible = false;
            ProjID.Text = this.ProjectDgv.CurrentRow.Cells[0].Value.ToString();
            Projectname.Text = this.ProjectDgv.CurrentRow.Cells[1].Value.ToString();
            CheckBtn.Visible = true;
        }
        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (ProjID.Text == "" || Projectname.Text == "")
            {
                MessageBox.Show("Fill up all fields");
            }
            else
            {
                con.Open();
                //cmd = new SqlCommand("UPDATE Departments SET Department_Name = '"+ DeptName.Text +"' WHERE DepartmentID = '"+ DeptID.Text +"' ", db.con);
                cmd = new SqlCommand("proc_UpdateProject", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@ProjectID", ProjID.Text);
                cmd.Parameters.AddWithValue("@ProjectName", Projectname.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated.");

                sda = new SqlDataAdapter("SELECT * FROM Projects", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Projects");
                ProjectDgv.DataSource = ds.Tables["Projects"].DefaultView;

                con.Close();
                CheckBtn.Visible = false;
                ProjName.Visible = true;
                this.Refresh();
            }
        }

        private void BtnDeleteProj_Click(object sender, EventArgs e)
        {
            ProjID.Text = this.ProjectDgv.CurrentRow.Cells[0].Value.ToString();
            Projectname.Text = this.ProjectDgv.CurrentRow.Cells[1].Value.ToString();
            DeleteBtn.Visible = true;
            ProjName.Visible = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (ProjectDgv.Rows.Count > 1)
                {
                    if (ProjectDgv.CurrentRow.Index == ProjectDgv.Rows.Count - 1)
                    {
                        MessageBox.Show("Please select data to be deleted.");
                    }
                    else
                    {
                        if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string del = ProjectDgv.CurrentRow.Cells[0].Value.ToString();
                            con.Open();
                            cmd = new SqlCommand("DELETE FROM Projects WHERE ProjectID = '" + del + "' ", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data has been deleted");

                            ProjID.Clear();
                            Projectname.Clear();
                            DeleteBtn.Visible = false;

                            string query = "SELECT * FROM Projects";
                            SqlDataAdapter da = new SqlDataAdapter(query, con);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Projects");
                            ProjectDgv.DataSource = ds;
                            ProjectDgv.DataMember = "Projects";
                            ProjectDgv.DataSource = ProjectDgv.DataSource;
                            con.Close();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No more data to be deleted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ProjName.Visible = true;
        }
    }
}
