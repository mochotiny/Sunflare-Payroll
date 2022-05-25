    using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WFA_APP.DB;

namespace WFA_APP.View.App
{
    public partial class LogForm : Form
    {
        //Connection mycon = new Connection();
        SqlConnection con = new SqlConnection(DbConnection.ConnectionString);

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
        public LogForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLog_Click(object sender, EventArgs e)
        {
            //if (User_TB.Text == "" && Pass_TB.Text == "")
            //{
            //    //new App().Show();
            //    //this.Hide();
            //}
            //else
            //{
            //    MessageBox.Show("The Username or password you entered is incorrect, try again");
            //    User_TB.Clear();
            //    Pass_TB.Clear();
            //    User_TB.Focus();
            //}          
            try
            {
                using (con)
                {
                    SqlCommand cmd = new SqlCommand("proc_Login", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    cmd.Parameters.AddWithValue("@Uname", User_TB.Text);
                    cmd.Parameters.AddWithValue("@Upass", Pass_TB.Text);

                    SqlDataReader rd = cmd.ExecuteReader();
                    if (rd.HasRows)
                    {
                        rd.Read();
                        if (rd[3].ToString() == "Admin")
                        {
                            Connection.type = "A";
                        }
                        else if (rd[3].ToString() == "Manager")
                        {
                            Connection.type = "M";
                        }
                        
                        MessageBox.Show("Welcome " + User_TB.Text);

                        App app = new App();
                        app.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("ERROR");
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
