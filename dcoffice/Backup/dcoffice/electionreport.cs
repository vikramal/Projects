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
    public partial class electionreport : Form
    {
        public electionreport()
        {
            InitializeComponent();
        }

        private void electionreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rejectionDataSet2.rejection' table. You can move, or remove it, as needed.
            this.rejectionTableAdapter.Fill(this.rejectionDataSet2.rejection);
            // TODO: This line of code loads data into the 'nominationautogenDataSet2.nomination' table. You can move, or remove it, as needed.
            this.nominationTableAdapter.Fill(this.nominationautogenDataSet2.nomination);
            // TODO: This line of code loads data into the 'electiondetailssaveDataSet2.electiondetails' table. You can move, or remove it, as needed.
            this.electiondetailsTableAdapter.Fill(this.electiondetailssaveDataSet2.electiondetails);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
        }
    }
}
