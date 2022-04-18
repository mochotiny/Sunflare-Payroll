using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_APP.DB;
using WFA_APP.View.App;

namespace WFA_APP.View.Modules.Home
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            if (Connection.type == "A")
            {
                BuniLabel2.Visible = false;
            }
            else if (Connection.type == "M")
            {
                BuniLabel.Visible = false;
            }
        }
    }
}
