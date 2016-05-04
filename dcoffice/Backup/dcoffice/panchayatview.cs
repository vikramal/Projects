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
    public partial class panchayatview : Form
    {
        public panchayatview()
        {
            InitializeComponent();
        }

        private void panchayatview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agriDataSet2.agriculture' table. You can move, or remove it, as needed.
            this.agricultureTableAdapter1.Fill(this.agriDataSet2.agriculture);
            // TODO: This line of code loads data into the 'agri1DataSet2.agriculture' table. You can move, or remove it, as needed.
            this.agricultureTableAdapter.Fill(this.agri1DataSet2.agriculture);
            // TODO: This line of code loads data into the 'hospautoDataSet2.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter1.Fill(this.hospautoDataSet2.hospital);
            // TODO: This line of code loads data into the 'hospitalDataSet2.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.hospitalDataSet2.hospital);
            // TODO: This line of code loads data into the 'roadDataSet2.road' table. You can move, or remove it, as needed.
            this.roadTableAdapter1.Fill(this.roadDataSet2.road);
            // TODO: This line of code loads data into the 'road1DataSet2.road' table. You can move, or remove it, as needed.
            this.roadTableAdapter.Fill(this.road1DataSet2.road);
            // TODO: This line of code loads data into the 'disDataSet2.district' table. You can move, or remove it, as needed.
            this.districtTableAdapter1.Fill(this.disDataSet2.district);
            // TODO: This line of code loads data into the 'districtaddDataSet1.district' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.districtaddDataSet1.district);
            // TODO: This line of code loads data into the 'towntalukDataSet2.town' table. You can move, or remove it, as needed.
            this.townTableAdapter1.Fill(this.towntalukDataSet2.town);
            // TODO: This line of code loads data into the 'towncomboDataSet1.town' table. You can move, or remove it, as needed.
            this.townTableAdapter.Fill(this.towncomboDataSet1.town);
            // TODO: This line of code loads data into the 'villagepanchadcofficeDataSet1.panchayatdetails' table. You can move, or remove it, as needed.
            this.panchayatdetailsTableAdapter1.Fill(this.villagepanchadcofficeDataSet1.panchayatdetails);
            // TODO: This line of code loads data into the 'villagepanchayatDataSet.panchayatdetails' table. You can move, or remove it, as needed.
            this.panchayatdetailsTableAdapter.Fill(this.villagepanchayatDataSet.panchayatdetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandText = "select * from panchayatdetails where panchayatid='" + this.comboBox1.Text + "'";
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.panchayatdetailsTableAdapter1.Fill(this.villagepanchadcofficeDataSet1.panchayatdetails);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandText = "select * from panchayatdetails";
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.panchayatdetailsTableAdapter1.Fill(this.villagepanchadcofficeDataSet1.panchayatdetails);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.townTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.townTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.townTableAdapter1.Adapter.SelectCommand.CommandText = "select * from panchayatdetails where panchayatid='" + this.comboBox3.Text + "'";
            this.townTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.townTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.townTableAdapter1.Fill(this.towntalukDataSet2.town);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.townTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.townTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.townTableAdapter1.Adapter.SelectCommand.CommandText = "select * from panchayatdetails";
            this.townTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.townTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.townTableAdapter1.Fill(this.towntalukDataSet2.town);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.districtTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.districtTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.districtTableAdapter.Adapter.SelectCommand.CommandText = "select * from district where panchayatid='" + this.comboBox3.Text + "'";
            this.districtTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.districtTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.districtTableAdapter.Fill(this.districtaddDataSet1.district);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.districtTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.districtTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.districtTableAdapter.Adapter.SelectCommand.CommandText = "select * from district";
            this.districtTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.districtTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.districtTableAdapter.Fill(this.districtaddDataSet1.district);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.roadTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.roadTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.roadTableAdapter1.Adapter.SelectCommand.CommandText = "select * from road where referenceid='" + this.comboBox4.Text + "'";
            this.roadTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.roadTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.roadTableAdapter1.Fill(this.roadDataSet2.road);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.roadTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.roadTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.roadTableAdapter1.Adapter.SelectCommand.CommandText = "select * from road";
            this.roadTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.roadTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.roadTableAdapter1.Fill(this.roadDataSet2.road);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.hospitalTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.hospitalTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.hospitalTableAdapter1.Adapter.SelectCommand.CommandText = "select * from hospital where referenceid='" + this.comboBox5.Text + "'";
            this.hospitalTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.hospitalTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.hospitalTableAdapter1.Fill(this.hospautoDataSet2.hospital);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.hospitalTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.hospitalTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.hospitalTableAdapter1.Adapter.SelectCommand.CommandText = "select * from hospital";
            this.hospitalTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.hospitalTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.hospitalTableAdapter1.Fill(this.hospautoDataSet2.hospital);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.agricultureTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.agricultureTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.agricultureTableAdapter1.Adapter.SelectCommand.CommandText = "select * from agriculture where referenceid='" + this.comboBox5.Text + "'";
            this.agricultureTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.agricultureTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.agricultureTableAdapter1.Fill(this.agriDataSet2.agriculture);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.agricultureTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.agricultureTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.agricultureTableAdapter1.Adapter.SelectCommand.CommandText = "select * from agriculture";
            this.agricultureTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.agricultureTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.agricultureTableAdapter1.Fill(this.agriDataSet2.agriculture);
        }
    }
}
