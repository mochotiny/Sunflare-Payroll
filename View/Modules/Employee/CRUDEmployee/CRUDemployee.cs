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
        Connection db = new Connection();
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
            // TODO: This line of code loads data into the '_Job_DataSet.Jobs' table. You can move, or remove it, as needed.
            this.jobsTableAdapter.Fill(this._Job_DataSet.Jobs);
            // TODO: This line of code loads data into the '_Department_DataSet.Departments' table. You can move, or remove it, as needed.
            this.departmentsTableAdapter.Fill(this._Department_DataSet.Departments);
            try
            {
                using (db.con)
                {
                    sda = new SqlDataAdapter("SELECT * FROM Employees", db.con);
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            if (BioID.Text == "" || EmpName.Text == "" || EmpAddress.Text == "" || EmpContact.Text == "" || DeptDrop.Text == "" || JobDrop.Text == "")
            {
                MessageBox.Show("Fill up all fields");
                
            }
            else
            {
                con.Open();
                //cmd = new SqlCommand("INSERT INTO Employees (Biometric_Id, Dept_Name, Contact, Address, Department_Id, Job_Id) VALUES( '" + BioID.Text + "','" + EmpName.Text + "','" + EmpContact.Text + "','" + EmpAddress.Text + "','" + DeptDrop.SelectedValue.ToString() + "','" + JobDrop.SelectedValue.ToString() + "' )", con);
                cmd = new SqlCommand("proc_CreateEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@BiometricID", BioID.Text);
                cmd.Parameters.AddWithValue("@EmployeeName", EmpName.Text);
                cmd.Parameters.AddWithValue("@EmployeeContact", EmpContact.Text);
                cmd.Parameters.AddWithValue("@EmployeeAddress", EmpAddress.Text);
                cmd.Parameters.AddWithValue("@DepartmentID", DeptDrop.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@JobID", JobDrop.SelectedValue.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved.");
                con.Close();
                this.Refresh();
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
            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            if (BioID.Text == "" || EmpName.Text == "" || EmpAddress.Text == "" || EmpContact.Text == "" || DeptDrop.Text == "" || JobDrop.Text == "")
            {
                MessageBox.Show("Fill up all fields");
                this.Close();
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Employees (Biometric_Id, Employee_Name, Employee_Contact, Employee_Address, DepartmentID, JobID) SET ( '" + BioID.Text + "','" + EmpName.Text + "','" + EmpContact.Text + "','" + EmpAddress.Text + "','" + DeptDrop.SelectedValue.ToString() + "','" + JobDrop.SelectedValue.ToString() + "' )", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Saved.");
                con.Close();
                this.Close();
            }
        }
    }
}
