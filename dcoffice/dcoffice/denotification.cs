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
    public partial class denotification : Form
    {
        public denotification()
        {
            InitializeComponent();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            this.textBox15.Text = this.dateTimePicker3.Value.ToLongDateString();
        }

       
       private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void denotification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'landdenotifDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter1.Fill(this.landdenotifDataSet2.landnotification);
            // TODO: This line of code loads data into the 'denotiDataSet2.denotification' table. You can move, or remove it, as needed.
            this.denotificationTableAdapter.Fill(this.denotiDataSet2.denotification);
            // TODO: This line of code loads data into the 'landnotifcautoDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter.Fill(this.landnotifcautoDataSet2.landnotification);
            // TODO: This line of code loads data into the 'landlaDataSet2.landnotification' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.dateTimePicker3.Enabled = true;
            this.textBox16.ReadOnly = false;
            this.textBox17.ReadOnly = false;
            this.textBox18.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (this.textBox15.Text == "")
            {
                MessageBox.Show("Select Denotifiction Date", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox15.Focus();
            }

            else if (this.textBox16.Text == "")
            {
                MessageBox.Show("Enter Denotifiction By", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox16.Focus();
            }
            else if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter Denotification Document Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox17.Focus();
            }

            else if (this.textBox18.Text == "")
            {
                MessageBox.Show("Enter Denotification Reason", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox18.Focus();
            }
            else
            {
                this.denotificationTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.denotificationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.denotificationTableAdapter.Adapter.SelectCommand.CommandText = "insert into denotification values('" + this.comboBox2.Text + "' ,'" + this.textBox2.Text + "' , '" + this.textBox3.Text + "' ,'" + this.textBox4.Text + "' , '" + this.textBox5.Text + "', '" + this.textBox6.Text + "' , '" + this.textBox1.Text + "' , '" + this.textBox8.Text + "' , '" + this.textBox9.Text + "' , '" + this.textBox10.Text + "' , '" + this.textBox11.Text + "' , '" + this.textBox12.Text + "' , '" + this.textBox13.Text + "','" + this.textBox14.Text +"' , '" + this.textBox15.Text + "' , '" + this.textBox16.Text + "' , '" + this.textBox17.Text + "' , '" + this.textBox18.Text + "')";
                this.denotificationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.denotificationTableAdapter.Adapter.SelectCommand.Connection.Close();

                this.landnotificationTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.landnotificationTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.landnotificationTableAdapter1.Adapter.SelectCommand.CommandText = "delete from landnotification where notificationdocnum = '" + this.comboBox2.Text + "'";
                this.landnotificationTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.landnotificationTableAdapter1.Adapter.SelectCommand.Connection.Close();

                this.landnotificationTableAdapter.Fill(this.landnotifcautoDataSet2.landnotification);

                MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


                this.textBox15.Text = "";
                this.textBox16.Text = "";
                this.textBox17.Text = "";
                this.textBox18.Text = "";
                this.dateTimePicker3.Enabled = false;
                this.textBox16.ReadOnly = true;
                this.textBox17.ReadOnly = true;
                this.textBox18.ReadOnly = true;

                

            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void off_Tick(object sender, EventArgs e)
        {

            this.on.Start();
            double a = this.on.Interval;

            if (a % 10 == 0)
            {
                this.label1.Visible = false;
                this.on.Stop();
                this.off.Start();
            }
        }

        private void on_Tick(object sender, EventArgs e)
        {

            double a = this.on.Interval;

            if (a % 10 == 0)
            {
                this.label1.Visible = true;
                this.off.Stop();
                this.on.Start();
            }
        }

    }
}
