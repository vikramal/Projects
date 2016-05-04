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
    public partial class endowmentview : Form
    {
        public endowmentview()
        {
            InitializeComponent();
        }

        private void endowmentview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'endowmentviewDataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter1.Fill(this.endowmentviewDataSet2.endowment);
            // TODO: This line of code loads data into the 'endonmentDataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter.Fill(this.endonmentDataSet2.endowment);
            // TODO: This line of code loads data into the 'grants1DataSet2.grants1' table. You can move, or remove it, as needed.
            this.grants1TableAdapter1.Fill(this.grants1DataSet2.grants1);
            // TODO: This line of code loads data into the 'gDataSet2.grants1' table. You can move, or remove it, as needed.
            this.grants1TableAdapter.Fill(this.gDataSet2.grants1);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.grants1TableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.grants1TableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.grants1TableAdapter1.Adapter.SelectCommand.CommandText = "select * from grants1 where grantdocnum='" + this.comboBox2.Text + "'";
            this.grants1TableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.grants1TableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.grants1TableAdapter1.Fill(this.grants1DataSet2.grants1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.grants1TableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.grants1TableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.grants1TableAdapter1.Adapter.SelectCommand.CommandText = "select * from grants1";
            this.grants1TableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.grants1TableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.grants1TableAdapter1.Fill(this.grants1DataSet2.grants1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.endowmentTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.endowmentTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.endowmentTableAdapter1.Adapter.SelectCommand.CommandText = "select * from endowment where trustname='" + this.comboBox1.Text + "'";
            this.endowmentTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.endowmentTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.endowmentTableAdapter1.Fill(this.endowmentviewDataSet2.endowment);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.endowmentTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.endowmentTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.endowmentTableAdapter1.Adapter.SelectCommand.CommandText = "select * from endowment";
            this.endowmentTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.endowmentTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.endowmentTableAdapter1.Fill(this.endowmentviewDataSet2.endowment);
        }
    }
}
