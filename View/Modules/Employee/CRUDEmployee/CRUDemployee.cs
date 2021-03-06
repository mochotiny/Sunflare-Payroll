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


namespace WFA_APP.View.Modules.Employee.CRUDEmployee
{

    public partial class CRUDemployee : Form
    {
        //readonly Connection db = new Connection();
        SqlConnection con = new SqlConnection(DbConnection.ConnectionString);
        
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
        public CRUDemployee()
        {
            InitializeComponent();
            CheckBtn.Visible = false;
            DeleteBtn.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            if (Connection.type == "A")
            {
                BtnDeleteEmp.Visible = true;
            }
            else if (Connection.type == "M")
            {
                BtnDeleteEmp.Visible = false;
            }


        }

        private void CRUDemployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pr_appDataSet.Projects' table. You can move, or remove it, as needed.
            this.projectsTableAdapter.Fill(this._pr_appDataSet.Projects);
            // TODO: This line of code loads data into the '_pr_appDataSet.Jobs' table. You can move, or remove it, as needed.
            this.jobsTableAdapter.Fill(this._pr_appDataSet.Jobs);
            // TODO: This line of code loads data into the '_pr_appDataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this._pr_appDataSet.Departments);

            // TODO: This line of code loads data into the '_Project_DataSet.Projects' table. You can move, or remove it, as needed.
            //this.projectsTableAdapter.Fill(this._Project_DataSet.Projects);
            // TODO: This line of code loads data into the '_Job_DataSet.Jobs' table. You can move, or remove it, as needed.
            //this.jobsTableAdapter.Fill(this._Job_DataSet.Jobs);
            // TODO: This line of code loads data into the '_Department_DataSet.Departments' table. You can move, or remove it, as needed.
            //this.departmentsTableAdapter.Fill(this._Department_DataSet.Departments);
            try
            {
                using (con)
                {
                    sda = new SqlDataAdapter("SELECT EmployeeID, BiometricID, Employee_Name, Employee_Contact, Employee_Address, Department_Name, JobTitle, Phil_Health, PagIbig, SSS, Weekly, ProjName FROM Employees INNER JOIN Departments AS D ON Employees.DepartmentID = D.DepartmentID INNER JOIN Jobs AS J ON Employees.JobID = J.JobID INNER JOIN Projects AS P ON Employees.ProjectID = P.ProjectID ", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Employees");
                    EmpDgv.DataSource = ds.Tables["Employees"].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateEmp_Click(object sender, EventArgs e)
        {
            try
            {
                if (BioID.Text == "" || EmpName.Text == "" || EmpAddress.Text == "" || EmpContact.Text == "" || DeptDrop.Text == "" || JobDrop.Text == "")
                {
                    MessageBox.Show("Fill up all fields");

                }
                else
                {

                    //cmd = new SqlCommand("INSERT INTO Employees (Biometric_Id, Dept_Name, Contact, Address, Department_Id, Job_Id) VALUES( '" + BioID.Text + "','" + EmpName.Text + "','" + EmpContact.Text + "','" + EmpAddress.Text + "','" + DeptDrop.SelectedValue.ToString() + "','" + JobDrop.SelectedValue.ToString() + "' )", con);

                    con.Open();
                    cmd = new SqlCommand("proc_CreateEmployee", con)
                    {
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.AddWithValue("@BiometricID", BioID.Text);
                    cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
                    cmd.Parameters.AddWithValue("@EmployeeContact", EmpContact.Text);
                    cmd.Parameters.AddWithValue("@EmployeeAddress", EmpAddress.Text);
                    cmd.Parameters.AddWithValue("@DepartmentID", DeptDrop.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@JobID", JobDrop.SelectedValue.ToString());

                    cmd.Parameters.AddWithValue("@PhilHealth", PhilHealth.Checked);
                    cmd.Parameters.AddWithValue("@PagIbig", PagIbig.Checked);
                    cmd.Parameters.AddWithValue("@SSS", SSS.Checked);
                    cmd.Parameters.AddWithValue("@Weekly", Weekly.Checked);

                    cmd.Parameters.AddWithValue("@ProjectID", DropProject.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();

                    cmd = new SqlCommand("INSERT INTO Balance (BiometricID, Balance, Pay) VALUES ('" + BioID.Text + "', '" + 0.00 + "', '" + 0.00 + "')", con);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Saved.");

                    sda = new SqlDataAdapter("SELECT EmployeeID, BiometricID, Employee_Name, Employee_Contact, Employee_Address, Department_Name, JobTitle, Phil_Health, PagIbig, SSS, Weekly, ProjName FROM Employees INNER JOIN Departments AS D ON Employees.DepartmentID = D.DepartmentID INNER JOIN Jobs AS J ON Employees.JobID = J.JobID INNER JOIN Projects AS P ON Employees.ProjectID = P.ProjectID", con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Employees");
                    EmpDgv.DataSource = ds.Tables["Employees"].DefaultView;

                    con.Close();
                }
                BioID.Clear();
                EmpName.Clear();
                EmpContact.Clear();
                EmpAddress.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BioID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnUpdateEmp_Click(object sender, EventArgs e)
        {

            BioID.Text = this.EmpDgv.CurrentRow.Cells[1].Value.ToString();
            EmpName.Text = this.EmpDgv.CurrentRow.Cells[2].Value.ToString();
            EmpContact.Text = this.EmpDgv.CurrentRow.Cells[3].Value.ToString();
            EmpAddress.Text = this.EmpDgv.CurrentRow.Cells[4].Value.ToString();
            DeptDrop.Text = this.EmpDgv.CurrentRow.Cells[5].Value.ToString();
            JobDrop.Text = this.EmpDgv.CurrentRow.Cells[6].Value.ToString();


            PhilHealth.Checked = Convert.ToBoolean(this.EmpDgv.CurrentRow.Cells[7].Value);
            PagIbig.Checked = Convert.ToBoolean(this.EmpDgv.CurrentRow.Cells[8].Value);
            SSS.Checked = Convert.ToBoolean(this.EmpDgv.CurrentRow.Cells[9].Value);
            Weekly.Checked = Convert.ToBoolean(this.EmpDgv.CurrentRow.Cells[10].Value);

            DropProject.Text = this.EmpDgv.CurrentRow.Cells[11].Value.ToString();

            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            

            if (BioID.Text == "" || EmpName.Text == "" || EmpAddress.Text == "" || EmpContact.Text == "" || DeptDrop.Text == "" || JobDrop.Text == "" || DropProject.Text == "")
            {
                MessageBox.Show("Fill up all fields");
                this.Close();
            }
            else
            {
                con.Open();
                //cmd = new SqlCommand("UPDATE Employees SET (Biometric_Id, Employee_Name, Employee_Contact, Employee_Address, DepartmentID, JobID) VALUES ( '" + BioID.Text + "','" + EmpName.Text + "','" + EmpContact.Text + "','" + EmpAddress.Text + "','" + DeptDrop.SelectedValue.ToString() + "','" + JobDrop.SelectedValue.ToString() + "' )", con);

                cmd = new SqlCommand("proc_UpdateEmployee", con)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("@EmployeeId", EmpDgv.CurrentRow.Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@BiometricId", BioID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
                cmd.Parameters.AddWithValue("@EmployeeContact", EmpContact.Text);
                cmd.Parameters.AddWithValue("@EmployeeAddress", EmpAddress.Text);
                cmd.Parameters.AddWithValue("@DepartmentId", DeptDrop.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@JobID", JobDrop.SelectedValue.ToString());

                cmd.Parameters.AddWithValue("@PhilHealth", PhilHealth.Checked);
                cmd.Parameters.AddWithValue("@PagIbig", PagIbig.Checked);
                cmd.Parameters.AddWithValue("@SSS", SSS.Checked);
                cmd.Parameters.AddWithValue("@Weekly", Weekly.Checked);

                cmd.Parameters.AddWithValue("@ProjectID", DropProject.SelectedValue.ToString());

                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved.");

                sda = new SqlDataAdapter("SELECT EmployeeID, BiometricID, Employee_Name, Employee_Contact, Employee_Address, Department_Name, JobTitle, Phil_Health, PagIbig, SSS, Weekly, ProjName FROM Employees INNER JOIN Departments AS D ON Employees.DepartmentID = D.DepartmentID INNER JOIN Jobs AS J ON Employees.JobID = J.JobID INNER JOIN Projects AS P ON Employees.ProjectID = P.ProjectID", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Employees");
                EmpDgv.DataSource = ds.Tables["Employees"].DefaultView;

                con.Close();

            }
            CheckBtn.Visible = false;
            BioID.Clear();
            EmpName.Clear();
            EmpContact.Clear();
            EmpAddress.Clear();
            

        }

        private void BtnDeleteEmp_Click(object sender, EventArgs e)
        {
            BioID.Text = this.EmpDgv.CurrentRow.Cells[0].Value.ToString();
            DeleteBtn.Visible = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            try
            {
                if (EmpDgv.Rows.Count > 1)
                {
                    if (EmpDgv.CurrentRow.Index == EmpDgv.Rows.Count - 1)
                    {
                        MessageBox.Show("Please select data to be deleted.");
                    }
                    else
                    {
                        if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            string del = EmpDgv.CurrentRow.Cells[0].Value.ToString();
                            con.Open();
                            cmd = new SqlCommand("DELETE FROM Employees WHERE EmployeeID = '" + del + "' ", con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Data has been deleted");


                            string query = "SELECT * FROM Employees";
                            SqlDataAdapter da = new SqlDataAdapter(query, con);
                            DataSet ds = new DataSet();
                            da.Fill(ds, "Employees");
                            EmpDgv.DataSource = ds;
                            EmpDgv.DataMember = "Employees";
                            EmpDgv.DataSource = EmpDgv.DataSource;
                            con.Close();
                            BioID.Clear();
                            this.Refresh();
                            DeleteBtn.Visible = false;
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

        }

        private void FilterLabel_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            sda = new SqlDataAdapter("SELECT EmployeeID, BiometricID, Employee_Name, Employee_Contact, Employee_Address, Department_Name, JobTitle, Phil_Health, PagIbig, SSS, Weekly, ProjName FROM Employees INNER JOIN Departments AS D ON Employees.DepartmentID = D.DepartmentID INNER JOIN Jobs AS J ON Employees.JobID = J.JobID INNER JOIN Projects AS P ON Employees.ProjectID = P.ProjectID WHERE Department_Name = '" + FilterDrop.SelectedValue.ToString() + "' ", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Employees");
            EmpDgv.DataSource = ds.Tables["Employees"].DefaultView;
        }
    }
}
