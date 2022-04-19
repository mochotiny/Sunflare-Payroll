using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WFA_APP.DB;


namespace WFA_APP.View.Modules.Department
{
    public partial class CRUDdepartment : Form
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
        public CRUDdepartment()
        {
            InitializeComponent();
            CheckBtn.Visible = false;
            DeleteBtn.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            if (Connection.type == "A")
            {
                BtnDeleteDept.Visible = true;
            }
            else if (Connection.type == "M")
            {
                BtnDeleteDept.Visible = false;
            }
        }

        private void CRUDdepartment_Load(object sender, EventArgs e)
        {
            try
            {
                using (db.con)
                {
                    sda = new SqlDataAdapter("SELECT * FROM Departments", db.con);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "Departments");
                    DeptDgv.DataSource = ds.Tables["Departments"].DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCreateDept_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
            if ( DeptName.Text == "")
            {
                MessageBox.Show("Fill up all fields");

            }
            else
            {
                con.Open();
                //cmd = new SqlCommand("INSERT INTO Employees (Biometric_Id, Dept_Name, Contact, Address, Department_Id, Job_Id) VALUES( '" + BioID.Text + "','" + EmpName.Text + "','" + EmpContact.Text + "','" + EmpAddress.Text + "','" + DeptDrop.SelectedValue.ToString() + "','" + JobDrop.SelectedValue.ToString() + "' )", con);
                cmd = new SqlCommand("INSERT INTO Departments (Department_Name) VALUES ("+ DeptName.Text +")", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Created.");
                con.Close();
                this.Refresh();
            }
        }

        private void BtnUpdateDept_Click(object sender, EventArgs e)
        {
            DeptID.Text = this.DeptDgv.CurrentRow.Cells[0].Value.ToString();
            DeptName.Text = this.DeptDgv.CurrentRow.Cells[1].Value.ToString();
            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            using (db.con)
            {
                if (DeptID.Text == "" || DeptName.Text == "")
                {
                    MessageBox.Show("Fill up all fields");
                }
                else
                {
                    cmd = new SqlCommand("UPDATE Departments SET Department_Name = '"+ DeptName.Text +"' WHERE DepartmentID = '"+ DeptID.Text +"' ", db.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated.");
                    db.con.Close();
                    this.Refresh();
                }
            }
        }

        private void BtnDeleteDept_Click(object sender, EventArgs e)
        {
            DeptID.Text = this.DeptDgv.CurrentRow.Cells[0].Value.ToString();
            DeptName.Text = this.DeptDgv.CurrentRow.Cells[1].Value.ToString();
            DeleteBtn.Visible = true;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            using (db.con)
            {
                try
                {
                    if (DeptDgv.Rows.Count > 1)
                    {
                        if (DeptDgv.CurrentRow.Index == DeptDgv.Rows.Count - 1)
                        {
                            MessageBox.Show("Please select data to be deleted.");
                        }
                        else
                        {
                            if (MessageBox.Show("Do you want to delete this data?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                string del = DeptDgv.CurrentRow.Cells[0].Value.ToString();
                                db.con.Open();
                                cmd = new SqlCommand("DELETE FROM Departments WHERE DepartmentID = '" + del + "' ", db.con);
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Data has been deleted");


                                string query = "SELECT * FROM Departments";
                                SqlDataAdapter da = new SqlDataAdapter(query, db.con);
                                DataSet ds = new DataSet();
                                da.Fill(ds, "Departments");
                                DeptDgv.DataSource = ds;
                                DeptDgv.DataMember = "Departments";
                                DeptDgv.DataSource = DeptDgv.DataSource;
                                db.con.Close();
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
        }
    }
}
