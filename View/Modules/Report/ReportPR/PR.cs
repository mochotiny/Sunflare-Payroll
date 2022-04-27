using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Report.ReportPR
{
    public partial class PR : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-39MS9Q2;Initial Catalog=pr-app;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();
        public PR()
        {
            InitializeComponent();
        }

    }
}
