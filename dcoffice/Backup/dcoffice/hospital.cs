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
    public partial class hospital : Form
    {
        public hospital()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.hospitalTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.hospitalTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.hospitalTableAdapter.Adapter.SelectCommand.CommandText = "select * from hospital order by referenceid desc";
            this.hospitalTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.hospitalTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.hospitalTableAdapter.Fill(this.hospautoDataSet2.hospital);

            if (this.textBox5.Text == "")
            {
                this.textBox1.Text = "500";
            }
            else
            {
                int x = int.Parse(this.textBox5.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }
            this.comboBox1.Enabled = true;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;

            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = null;
            this.comboBox2.Text = null;
            this.comboBox3.Text = null;
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }

        private void hospital_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addvillagehos2DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter1.Fill(this.addvillagehos2DataSet2.addvillage);
            // TODO: This line of code loads data into the 'addvillagehos1DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter.Fill(this.addvillagehos1DataSet2.addvillage);
            // TODO: This line of code loads data into the 'hospitalDataSet2.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter1.Fill(this.hospitalDataSet2.hospital);
            // TODO: This line of code loads data into the 'hospautoDataSet2.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.hospautoDataSet2.hospital);
            // TODO: This line of code loads data into the 'hospautoDataSet2.hospital' table. You can move, or remove it, as needed.
            this.hospitalTableAdapter.Fill(this.hospautoDataSet2.hospital);
            this.comboBox1.Text = null;
            this.comboBox2.Text = null;
            this.comboBox3.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Taluk Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox1.DroppedDown=true;
            }
            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Panchayat Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox2.DroppedDown = true;
            }
            else if (this.comboBox3.Text == "")
            {
                MessageBox.Show("Select Village", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox3.DroppedDown = true;
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Number Doctors", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Incharge", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Number Of Beds", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox4.Focus();
            }
            else
            {
                this.hospitalTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.hospitalTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.hospitalTableAdapter1.Adapter.SelectCommand.CommandText = "insert into hospital values('" + this.textBox1.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.comboBox3.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "')";
                this.hospitalTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.hospitalTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.textBox1.Text = "";
                this.comboBox1.Text = null;
                this.comboBox2.Text = null;
                this.comboBox3.Text = null;
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";

                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;

                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox2.Enabled = true;

            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "select distinct(villagepanchayat) from addvillage where taluk = '" + this.comboBox1.Text + "'";
            this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter.Fill(this.addvillagehos1DataSet2.addvillage);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox3.Enabled = true;

            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandText = "select distinct(villages) from addvillage where taluk = '" + this.comboBox1.Text + "' and villagepanchayat = '" + this.comboBox2.Text + "'";
            this.addvillageTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter1.Fill(this.addvillagehos2DataSet2.addvillage);
        }

        private void on_Tick(object sender, EventArgs e)
        {
            this.on.Start();
            double a = this.on.Interval;

            if (a % 10 == 0)
            {
                this.label2.Visible = false;
                this.on.Stop();
                this.off.Start();
            }
        }

        private void off_Tick(object sender, EventArgs e)
        {

            double a = this.on.Interval;

            if (a % 10 == 0)
            {
                this.label2.Visible = true;
                this.off.Stop();
                this.on.Start();
            }
        }
    }
}
