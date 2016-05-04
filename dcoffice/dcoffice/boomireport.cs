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
    public partial class boomireport : Form
    {
        public boomireport()
        {
            InitializeComponent();
        }

        private void boomireport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'landallocationDataSet2.landallocation' table. You can move, or remove it, as needed.
            this.landallocationTableAdapter.Fill(this.landallocationDataSet2.landallocation);
            // TODO: This line of code loads data into the 'denotiDataSet2.denotification' table. You can move, or remove it, as needed.
            this.denotificationTableAdapter.Fill(this.denotiDataSet2.denotification);
            // TODO: This line of code loads data into the 'landdenotifDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter.Fill(this.landdenotifDataSet2.landnotification);
            // TODO: This line of code loads data into the 'conversionDataSet2.landconversion' table. You can move, or remove it, as needed.
            this.landconversionTableAdapter.Fill(this.conversionDataSet2.landconversion);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }

        private void reportViewer3_Load(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
