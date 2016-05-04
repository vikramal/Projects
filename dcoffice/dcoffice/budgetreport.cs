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
    public partial class budgetreport : Form
    {
        public budgetreport()
        {
            InitializeComponent();
        }

        private void budgetreport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budget1DataSet2.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.budget1DataSet2.budget);

            this.reportViewer1.RefreshReport();
        }
    }
}
