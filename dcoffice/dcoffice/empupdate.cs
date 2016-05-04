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
    public partial class empupdate : Form
    {
        public empupdate()
        {
            InitializeComponent();
        }

        private void empupdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.eDataSet2.employee);
            // TODO: This line of code loads data into the 'empDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDataSet2.employee);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string d = this.textBox5.Text;

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter Employee Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }

            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Enter Department Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }


            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Designation.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Address", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }

            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Contact Number.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }

            else if (d.Length < 10)
            {
                MessageBox.Show("Contact number must consist of 10 numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Date of Joining.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }

            else
            {
                this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.employeeTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.employeeTableAdapter1.Adapter.SelectCommand.CommandText = "update employee set empname = '" + this.textBox1.Text + "' , dept = '" + this.comboBox2.Text + "' , design = '" + this.textBox3.Text + "' ,address = '" + this.textBox4.Text + "' , contactnum = '" + this.textBox5.Text + "' , dateofjoin = '" + this.textBox6.Text + "' where empid = '" + this.comboBox1.Text + "'";
                this.employeeTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record updated Successfully", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.employeeTableAdapter.Fill(this.empDataSet2.employee);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.employeeTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.employeeTableAdapter1.Adapter.SelectCommand.CommandText = "delete from employee where empid = '" + this.comboBox1.Text + "'";
            this.employeeTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Close();

            MessageBox.Show("Record Deleted", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.employeeTableAdapter.Fill(empDataSet2.employee);

            this.textBox1.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox6.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar!=32)
                e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
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
