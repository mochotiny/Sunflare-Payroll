using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WFA_APP.View.Modules.Attendance.TimeSheet;

namespace WFA_APP.View.Modules.Attendance
{
    public partial class Attendance : Form
    {
        public Attendance()
        {
            InitializeComponent();
            this.PanelAtt.Controls.Clear();
            Sheet sheet = new Sheet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sheet.FormBorderStyle = FormBorderStyle.None;
            this.PanelAtt.Controls.Add(sheet);
            sheet.Show();
        }

        private void Sheet_Click(object sender, EventArgs e)
        {
            this.PanelAtt.Controls.Clear();
            Sheet sheet = new Sheet() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sheet.FormBorderStyle = FormBorderStyle.None;
            this.PanelAtt.Controls.Add(sheet);
            sheet.Show();
        }

        private void Logs_Click(object sender, EventArgs e)
        {
            this.PanelAtt.Controls.Clear();
            AttendanceForm attform = new AttendanceForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            attform.FormBorderStyle = FormBorderStyle.None;
            this.PanelAtt.Controls.Add(attform);
            attform.Show();
        }
    
    }
}
