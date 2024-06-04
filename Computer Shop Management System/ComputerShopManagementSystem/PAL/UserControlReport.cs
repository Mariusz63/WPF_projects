﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerShopManagementSystem.PAL
{
    public partial class UserControlReport : UserControl
    {
        public UserControlReport()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            FormReport formReport = new FormReport();
            formReport.startDate = dtpStartDate.Value.Date;
            formReport.endDate = dtpEndDate.Value.Date;
            formReport.ShowDialog();
        }
    }
}
