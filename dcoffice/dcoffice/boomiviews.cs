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
    public partial class boomiviews : Form
    {
        public boomiviews()
        {
            InitializeComponent();
        }

        private void boomiviews_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'landallocationDataSet2.landallocation' table. You can move, or remove it, as needed.
            this.landallocationTableAdapter1.Fill(this.landallocationDataSet2.landallocation);
            // TODO: This line of code loads data into the 'landallocaDataSet2.landallocation' table. You can move, or remove it, as needed.
            this.landallocationTableAdapter.Fill(this.landallocaDataSet2.landallocation);
            // TODO: This line of code loads data into the 'denotiDataSet2.denotification' table. You can move, or remove it, as needed.
            this.denotificationTableAdapter.Fill(this.denotiDataSet2.denotification);
            // TODO: This line of code loads data into the 'landdenotifDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter2.Fill(this.landdenotifDataSet2.landnotification);
            // TODO: This line of code loads data into the 'landnotificationsaveDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter1.Fill(this.landnotificationsaveDataSet2.landnotification);
            // TODO: This line of code loads data into the 'landnotDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter.Fill(this.landnotDataSet2.landnotification);
            // TODO: This line of code loads data into the 'landconvertionviewDataSet2.landconversion' table. You can move, or remove it, as needed.
            this.landconversionTableAdapter1.Fill(this.landconvertionviewDataSet2.landconversion);
            // TODO: This line of code loads data into the 'landcovertionviewDataSet2.landconversion' table. You can move, or remove it, as needed.
            this.landconversionTableAdapter.Fill(this.landcovertionviewDataSet2.landconversion);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landconversionTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landconversionTableAdapter.Adapter.SelectCommand.CommandText = "select * from landconvertion where applicationnum='"+this.comboBox1.Text+"'";
            this.landconversionTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landconversionTableAdapter.Fill(this.landcovertionviewDataSet2.landconversion);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landconversionTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landconversionTableAdapter.Adapter.SelectCommand.CommandText = "select * from landconvertion";
            this.landconversionTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landconversionTableAdapter.Fill(this.landcovertionviewDataSet2.landconversion);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.landnotificationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landnotificationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landnotificationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landnotification where notificationdocnum='"+this.comboBox2.Text+"'";
            this.landnotificationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landnotificationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landnotificationTableAdapter.Fill(this.landnotDataSet2.landnotification);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.landnotificationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landnotificationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landnotificationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landnotification";
            this.landnotificationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landnotificationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landnotificationTableAdapter.Fill(this.landnotDataSet2.landnotification);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.denotificationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.denotificationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.denotificationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landnotification";
            this.denotificationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.denotificationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.denotificationTableAdapter.Fill(this.denotiDataSet2.denotification);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.denotificationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.denotificationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.denotificationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landnotification where notificationdocnum='" + this.comboBox3.Text + "'";
            this.denotificationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.denotificationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.denotificationTableAdapter.Fill(this.denotiDataSet2.denotification);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.landallocationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landallocationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landallocationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landallocation where allocationdocnum='" + this.comboBox4.Text + "'";
            this.landallocationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landallocationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landallocationTableAdapter.Fill(this.landallocaDataSet2.landallocation);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.landallocationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landallocationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landallocationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landallocation";
            this.landallocationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landallocationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landallocationTableAdapter.Fill(this.landallocaDataSet2.landallocation);
        }
    }
}
