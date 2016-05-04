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
    public partial class updatevillpanch : Form
    {
        public updatevillpanch()
        {
            InitializeComponent();
        }

        private void updatevillpanch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addv1DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter1.Fill(this.addv1DataSet2.addvillage);
            // TODO: This line of code loads data into the 'addvDataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter.Fill(this.addvDataSet2.addvillage);
            // TODO: This line of code loads data into the 'villupdcofficeDataSet1.panchayatdetails' table. You can move, or remove it, as needed.
            this.panchayatdetailsTableAdapter1.Fill(this.villupdcofficeDataSet1.panchayatdetails);
            // TODO: This line of code loads data into the 'villpanchdcofficeDataSet1.panchayatdetails' table. You can move, or remove it, as needed.
            this.panchayatdetailsTableAdapter.Fill(this.villpanchdcofficeDataSet1.panchayatdetails);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = this.textBox13.Text;

             if (this.comboBox2.Text == "")
            {
                MessageBox.Show("select Taluk Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox2.DroppedDown=true;
            }

            else if (this.comboBox3.Text == "")
            {
                MessageBox.Show("Select Panchayat Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox3.DroppedDown = true;
            }

            else if (this.comboBox4.Text == "")
            {
                MessageBox.Show("Select Villages", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox4.DroppedDown = true;
            }

            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Village Details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox5.Focus();
            }

            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Male Population", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox6.Focus();
            }

            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Female Population", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox7.Focus();
            }

            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Total Population", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox8.Focus();
            }

            else if (this.textBox9.Text == "")
            {
                MessageBox.Show("Enter Ruling Party", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox9.Focus();
            }

            else if (this.textBox10.Text == "")
            {
                MessageBox.Show("Enter President Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox10.Focus();
            }

            else if (this.textBox11.Text == "")
            {
                MessageBox.Show("Enter Vice President Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox11.Focus();
            }

            else if (this.textBox12.Text == "")
            {
                MessageBox.Show("Enter Panchayat Address", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox12.Focus();
            }

             else if (this.textBox13.Text == "")
             {
                 MessageBox.Show("Enter Contact Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 this.textBox13.Focus();
             }

             else if (d.Length < 10)
             {
                 MessageBox.Show("Contact Number must consist of 10 Digits.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 this.textBox13.Focus();
             }

             else
             {
                 this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Open();
                 this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                 this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandText = "update panchayatdetails set panchayatname = '" + this.comboBox2.Text + "' , talukname = '" + this.comboBox3.Text + "' , numvillages = '" + this.comboBox4.Text + "' ,villagedetails = '" + this.textBox5.Text + "' , malepopulation = '" + this.textBox6.Text + "' , femalepopulation = '" + this.textBox7.Text + "' , totalpopulation = '" + this.textBox8.Text + "' , rulingparty = '" + this.textBox9.Text + "' , presidentname = '" + this.textBox10.Text + "' , vicepresidentname = '" + this.textBox11.Text + "' , panchayataddress = '" + this.textBox12.Text + "' , contactnumber = '" + this.textBox13.Text + "' where panchayatid = '" + this.comboBox1.Text + "'";
                 this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                 this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Close();

                 MessageBox.Show("Record updated Successfully", "sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                 this.panchayatdetailsTableAdapter.Fill(this.villpanchdcofficeDataSet1.panchayatdetails);
             }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandText = "delete from panchayatdetails where panchayatid = '" + this.comboBox1.Text + "'";
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Close();

            MessageBox.Show("Record Deleted Successfully", "sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.panchayatdetailsTableAdapter.Fill(this.villpanchdcofficeDataSet1.panchayatdetails);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Male population.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }

            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Female population.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox7.Focus();
            }

            else
            {
                int a = int.Parse(this.textBox6.Text);
                int b = int.Parse(this.textBox7.Text);
                int c = a + b;
                this.textBox8.Text = c.ToString();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox6.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox6.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox6.Focus();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox7.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox7.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox7.Focus();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox8.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox8.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox8.Focus();
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox13.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox13.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox13.Focus();
                }
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandText = "select distinct(villages) from addvillage where taluk = '" + this.comboBox2.Text + "' and villagepanchayat = '" + this.comboBox3.Text + "'";
            this.addvillageTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter1.Fill(this.addv1DataSet2.addvillage);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "select distinct(villagepanchayat) from addvillage where taluk = '" + this.comboBox2.Text + "'";
            this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter.Fill(this.addvDataSet2.addvillage);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
