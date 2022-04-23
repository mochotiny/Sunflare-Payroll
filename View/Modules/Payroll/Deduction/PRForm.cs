using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WFA_APP.View.Modules.Payroll.Deduction.Sheet;

namespace WFA_APP.View.Modules.Payroll.Deduction
{
    public partial class PRForm : Form
    {
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
        public PRForm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void SheetBtn_Click(object sender, EventArgs e)
        {
            PanelBoard.Location = new Point(12, 50);
            this.PanelPR.Controls.Clear();
            SheetForm sheet = new SheetForm() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            sheet.FormBorderStyle = FormBorderStyle.None;
            this.PanelPR.Controls.Add(sheet);
            sheet.Show();
        }

        private void DeductionBtn_Click(object sender, EventArgs e)
        {
            PanelBoard.Location = new Point(128, 50);
            
            this.PanelPR.Controls.Clear();
            Deductions deduct = new Deductions() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            deduct.FormBorderStyle = FormBorderStyle.None;
            this.PanelPR.Controls.Add(deduct);
            deduct.Show();
        }
    }
}
