using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Kelompok1
{
    public partial class ReportKartuCekup : Form
    {
        private int id;
        public ReportKartuCekup(int id)
        {
            InitializeComponent();
            this.id = id;

            ReportCekup1.Refresh();
            ReportCekup1.SetParameterValue("id_pasien", id);
            crystalReportViewer1.ReportSource = ReportCekup1;
        }
    }
}
