﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_APP.View.Modules.Report.Monthly
{
    public partial class MonthlyForm : Form
    {
        public MonthlyForm()
        {
            InitializeComponent();
        }

        private void Monthly_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}