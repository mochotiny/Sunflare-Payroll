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

namespace WFA_APP.View.Modules.Employee.Account
{
    public partial class AccountForm : Form
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
        public AccountForm()
        {
            InitializeComponent();
            CheckBtn.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Account_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_pr_appDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this._pr_appDataSet.Employees);
            


            sda = new SqlDataAdapter("SELECT E.Employee_Name, Balance, Pay FROM Balance INNER JOIN Employees AS E ON Balance.BiometricID = E.BiometricID", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Balance");
            AccountDgv.DataSource = ds.Tables["Balance"].DefaultView;
        }

        private void BtnCreateBalance_Click(object sender, EventArgs e)
        {
            if (EmpDrop.Text == "" || CA.Text == "" || Pay.Text == "")
            {
                MessageBox.Show("Fill up all fields");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Balance (BiometricID, Balance, Pay) VALUES ('"+ EmpDrop.SelectedValue.ToString() +"', '"+ CA.Text +"', '"+ Pay.Text +"')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Created.");
                this.Refresh();
                con.Close();
            }
        }

        private void BtnUpdateBalance_Click(object sender, EventArgs e)
        {
            
            CA.Text = this.AccountDgv.CurrentRow.Cells[1].Value.ToString();
            Pay.Text = this.AccountDgv.CurrentRow.Cells[2].Value.ToString();

            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (EmpDrop.Text == "" || CA.Text == "" || Pay.Text == "")
            {
                MessageBox.Show("Fill up all fields");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Balance SET Balance = '" + CA.Text + "', Pay = '" + Pay.Text + "' WHERE BiometricID = '" + EmpDrop.SelectedValue.ToString() + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated.");
                this.Refresh();
                con.Close();
                CheckBtn.Visible = false;

                sda = new SqlDataAdapter("SELECT E.Employee_Name, Balance, Pay FROM Balance INNER JOIN Employees AS E ON Balance.BiometricID = E.BiometricID", con);
                DataSet ds = new DataSet();
                sda.Fill(ds, "Balance");
                AccountDgv.DataSource = ds.Tables["Balance"].DefaultView;
            }
        }

        
    }
}
