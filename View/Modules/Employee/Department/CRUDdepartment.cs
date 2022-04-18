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
    }
}
