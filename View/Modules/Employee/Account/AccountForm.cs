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

namespace WFA_APP.View.Modules.Employee.Account
{
    public partial class AccountForm : Form
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
        public AccountForm()
        {
            InitializeComponent();
            CheckBtn.Visible = false;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Account_Load(object sender, EventArgs e)
        {
            sda = new SqlDataAdapter("SELECT * FROM Balance", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "Balance");
            AccountDgv.DataSource = ds.Tables["Balance"].DefaultView;
        }

        private void BtnCreateBalance_Click(object sender, EventArgs e)
        {
            if (BioID.Text == "" || CA.Text == "" || Pay.Text == "")
            {
                MessageBox.Show("Fill up all fields");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("INSERT INTO Balance (BiometricID, Balance, Pay) VALUES ('"+ BioID.Text +"', '"+ CA.Text +"', '"+ Pay.Text +"')", con);
                cmd.ExecuteNonQuery();
                this.Refresh();
                con.Close();
            }
        }

        private void BtnUpdateBalance_Click(object sender, EventArgs e)
        {
            BioID.Text = this.AccountDgv.CurrentRow.Cells[1].Value.ToString();
            CA.Text = this.AccountDgv.CurrentRow.Cells[2].Value.ToString();
            Pay.Text = this.AccountDgv.CurrentRow.Cells[3].Value.ToString();

            CheckBtn.Visible = true;
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            if (BioID.Text == "" || CA.Text == "" || Pay.Text == "")
            {
                MessageBox.Show("Fill up all fields");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand("UPDATE Balance SET Balance = '" + CA.Text + "', Pay = '" + Pay.Text + "' WHERE BiometricID = '" + BioID.Text + "' ", con);
                cmd.ExecuteNonQuery();
                this.Refresh();
                con.Close();
            }
        }
    }
}
