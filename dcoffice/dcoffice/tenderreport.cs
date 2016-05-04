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
    public partial class tenderreport : Form
    {
        public tenderreport()
        {
            InitializeComponent();
        }

        private void tenderreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tenderapprovalautoDataSet2.tenderapproval' table. You can move, or remove it, as needed.
            this.tenderapprovalTableAdapter.Fill(this.tenderapprovalautoDataSet2.tenderapproval);
            // TODO: This line of code loads data into the 'tenderrejDataSet2.tenderreject' table. You can move, or remove it, as needed.
            this.tenderrejectTableAdapter.Fill(this.tenderrejDataSet2.tenderreject);
            // TODO: This line of code loads data into the 'tenapplyautoDataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter.Fill(this.tenapplyautoDataSet2.tenderapply);
            // TODO: This line of code loads data into the 'tenderpublish1DataSet2.tenderpublish' table. You can move, or remove it, as needed.
            this.tenderpublishTableAdapter.Fill(this.tenderpublish1DataSet2.tenderpublish);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }
    }
}
