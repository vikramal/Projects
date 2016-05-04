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
    public partial class electiondetails : Form
    {
        public electiondetails()
        {
            InitializeComponent();
        }

        private void electiondetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'electiondetailssaveDataSet2.electiondetails' table. You can move, or remove it, as needed.
            this.electiondetailsTableAdapter1.Fill(this.electiondetailssaveDataSet2.electiondetails);
            // TODO: This line of code loads data into the 'electiondetailsautoDataSet2.electiondetails' table. You can move, or remove it, as needed.
            this.electiondetailsTableAdapter.Fill(this.electiondetailsautoDataSet2.electiondetails);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.electiondetailsTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.electiondetailsTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.electiondetailsTableAdapter.Adapter.SelectCommand.CommandText = "select * from electiondetails order by electionid desc";
            this.electiondetailsTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.electiondetailsTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.electiondetailsTableAdapter.Fill(this.electiondetailsautoDataSet2.electiondetails);

            if (this.textBox5.Text == "")
            {
                this.textBox1.Text = "2001";
            }

            else
            {

                int x = int.Parse(this.textBox5.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

            this.comboBox1.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.dateTimePicker3.Enabled = true;

            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.comboBox1.Text = null;
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Election Type.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Select Date from Calender.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Select Date from Calender.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.dateTimePicker2.Value > this.dateTimePicker1.Value )
            {
                MessageBox.Show("Nomination date must be before election date.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Select Date from Calender.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.dateTimePicker3.Value > this.dateTimePicker1.Value)
            {
                MessageBox.Show("Nomination withdrawal date must be before election date and after Nomination date.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.electiondetailsTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.electiondetailsTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.electiondetailsTableAdapter1.Adapter.SelectCommand.CommandText = "insert into electiondetails values('" + this.textBox1.Text + "','" + this.comboBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "')";
                this.electiondetailsTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.electiondetailsTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox1.Text = "";
                this.comboBox1.Text = null;
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";

                this.comboBox1.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.dateTimePicker2.Enabled = false;
                this.dateTimePicker3.Enabled = false;

                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.textBox3.Text = this.dateTimePicker2.Value.ToLongDateString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            this.textBox4.Text = this.dateTimePicker3.Value.ToLongDateString();
        }
    }
}
