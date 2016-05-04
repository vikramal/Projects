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
    public partial class employeereport : Form
    {
        public employeereport()
        {
            InitializeComponent();
        }

        private void employeereport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salsaveDataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.salsaveDataSet2.salary);
            // TODO: This line of code loads data into the 'eDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.eDataSet2.employee);

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
