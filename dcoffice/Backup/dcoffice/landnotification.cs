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
    public partial class landnotification : Form
    {
        public landnotification()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.comboBox1.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox13.Text = "";
            this.textBox14.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.landnotificationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landnotificationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landnotificationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landnotification order by notificationdocnum desc";
            this.landnotificationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landnotificationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landnotificationTableAdapter.Fill(this.landnotifcationautoDataSet2.landnotification);

            if (this.textBox7.Text == "")
            {
                this.textBox1.Text = "1001";
            }
            else
            {
                int x = int.Parse(this.textBox7.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

            this.textBox2.Focus();
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.comboBox1.Enabled = true;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.textBox6.ReadOnly = false;
            this.textBox8.ReadOnly = false;
            this.textBox11.ReadOnly = false;
            this.textBox12.ReadOnly = false;
            this.textBox13.ReadOnly = false;
            this.textBox14.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Survay Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Property Details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Owner Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Location", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Total Area(Sqft)", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Panchayath", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;

            }
            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Notification Circular Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }
            else if (this.textBox9.Text == "")
            {
                MessageBox.Show("Select Circular Date", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox9.Focus();
            }
            else if (this.textBox10.Text == "")
            {
                MessageBox.Show("Select Notification Date", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox10.Focus();
            }
            else if (this.textBox11.Text == "")
            {
                MessageBox.Show("Enter Notification Reason", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox11.Focus();
            }
            else if (this.textBox12.Text == "")
            {
                MessageBox.Show("Enter Notification Authority", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox12.Focus();
            }
            else if (this.textBox13.Text == "")
            {
                MessageBox.Show("Enter Market Value", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox13.Focus();
            }
            else if (this.textBox14.Text == "")
            {
                MessageBox.Show("Enter Government Value", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox14.Focus();
            }
            else
            {
                this.landnotificationTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.landnotificationTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.landnotificationTableAdapter1.Adapter.SelectCommand.CommandText = "insert into landnotification values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.comboBox1.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.textBox12.Text + "','" + this.textBox13.Text + "','" + this.textBox14.Text + "')";
                this.landnotificationTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.landnotificationTableAdapter1.Adapter.SelectCommand.Connection.Close();
                MessageBox.Show("Record Saved", "sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.comboBox1.Enabled = false;
                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;
                this.textBox5.ReadOnly = true;
                this.textBox6.ReadOnly = true;
                this.textBox8.ReadOnly = true;
                this.dateTimePicker1.Enabled = false;
                this.dateTimePicker2.Enabled = false;
                this.textBox11.ReadOnly = true;
                this.textBox12.ReadOnly = true;
                this.textBox13.ReadOnly = true;
                this.textBox14.ReadOnly = true;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
                this.textBox12.Text = "";
                this.textBox13.Text = "";
                this.textBox14.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox9.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.textBox10.Text = this.dateTimePicker2.Value.ToLongDateString();
        }

        private void landnotification_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'landnotificationsaveDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter1.Fill(this.landnotificationsaveDataSet2.landnotification);
            // TODO: This line of code loads data into the 'landnotifcationautoDataSet2.landnotification' table. You can move, or remove it, as needed.
            this.landnotificationTableAdapter.Fill(this.landnotifcationautoDataSet2.landnotification);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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
