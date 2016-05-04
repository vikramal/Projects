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
    public partial class budgetview : Form
    {
        public budgetview()
        {
            InitializeComponent();
        }

        private void budgetview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budget1DataSet2.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter1.Fill(this.budget1DataSet2.budget);
            // TODO: This line of code loads data into the 'budgetDataSet2.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.budgetDataSet2.budget);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.budgetTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.budgetTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.budgetTableAdapter1.Adapter.SelectCommand.CommandText = "select * from budget where budgetdocnum='" + this.comboBox4.Text + "'";
            this.budgetTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.budgetTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.budgetTableAdapter1.Fill(this.budget1DataSet2.budget);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.budgetTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.budgetTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.budgetTableAdapter1.Adapter.SelectCommand.CommandText = "select * from budget";
            this.budgetTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.budgetTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.budgetTableAdapter1.Fill(this.budget1DataSet2.budget);
        }
    }
}
