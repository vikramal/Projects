using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dcoffice
{
    public partial class panchayatreport : Form
    {
        public panchayatreport()
        {
            InitializeComponent();
        }

        private void panchayatreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agri1DataSet2.agriculture' table. You can move, or remove it, as needed.
            this.agricultureTableAdapter.Fill(this.agri1DataSet2.agriculture);
            // TODO: This line of code loads data into the 'hospautoDataSet2.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.hospautoDataSet2.hospital);
            // TODO: This line of code loads data into the 'road1DataSet2.road' table. You can move, or remove it, as needed.
            this.roadTableAdapter.Fill(this.road1DataSet2.road);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
