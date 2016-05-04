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
    public partial class endowmentreports : Form
    {
        public endowmentreports()
        {
            InitializeComponent();
        }

        private void endowmentreports_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gDataSet2.grants1' table. You can move, or remove it, as needed.
            this.grants1TableAdapter.Fill(this.gDataSet2.grants1);
            // TODO: This line of code loads data into the 'aenDataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter.Fill(this.aenDataSet2.endowment);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
