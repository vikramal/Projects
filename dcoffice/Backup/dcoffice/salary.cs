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
    public partial class salary : Form
    {
        public salary()
        {
            InitializeComponent();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox16_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.textBox8.ReadOnly = false;
            this.textBox9.ReadOnly = false;
            this.textBox13.ReadOnly = false;
            this.textBox14.ReadOnly = false;
            this.comboBox2.Enabled = true;
            this.button2.Enabled = true;
            this.button1.Enabled = false;
        }

        private void salary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salsaveDataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.salsaveDataSet2.salary);
            // TODO: This line of code loads data into the 'salautoDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.salautoDataSet2.employee);

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox5.Text != "")
            {
                double a = double.Parse(this.textBox5.Text);

                double b = a * 0.71;
                double c = a * 0.28;

                this.textBox6.Text = b.ToString();
                this.textBox7.Text = c.ToString();
            }
            else if (this.textBox5.Text == "")
            {
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
                this.textBox12.Text = "";
                this.textBox13.Text = "";
                this.textBox14.Text = "";
                this.textBox15.Text = "";
                this.textBox16.Text = "";
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox8.Text != "" && this.textBox9.Text != "")
            {
                double a = double.Parse(this.textBox6.Text);
                double b = double.Parse(this.textBox7.Text);
                double c = double.Parse(this.textBox8.Text);
                double d = double.Parse(this.textBox9.Text);

                double f = a + b + c + d;
                double h = double.Parse(this.textBox5.Text);
                f = h + f;

                this.textBox10.Text = f.ToString();
            }

            else if (this.textBox9.Text == "" || this.textBox8.Text == "")
            {
                this.textBox10.Text = "";
            }

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

            if (this.textBox10.Text != "")
            {
                double a = double.Parse(this.textBox10.Text);

                double b = a * 0.12;

                if (a < 8000)
                {
                    this.textBox11.Text = "0";
                }

                else if (a > 8000 && a < 10000)
                {
                    this.textBox11.Text = "100";
                }

                else if (a > 10000 && a < 12999)
                {
                    this.textBox11.Text = "150";
                }

                else if (a > 13000 && a < 15999)
                {
                    this.textBox11.Text = "200";
                }

                else if (a > 16000 && a < 2000)
                {
                    this.textBox11.Text = "250";
                }

                else if (a > 20000)
                {
                    this.textBox11.Text = "300";
                }

                this.textBox12.Text = b.ToString();
            }
            else if (this.textBox10.Text == "")
            {
                this.textBox11.Text = "";
                this.textBox12.Text = "";
                this.textBox13.Text = "";
                this.textBox14.Text = "";
                this.textBox15.Text = "";
                this.textBox16.Text = "";
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox13.Text != "" && this.textBox14.Text != "")
            {
                double a = double.Parse(this.textBox11.Text);
                double b = double.Parse(this.textBox12.Text);
                double c = double.Parse(this.textBox13.Text);
                double d = double.Parse(this.textBox14.Text);

                double f = a + b + c + d;

                this.textBox15.Text = f.ToString();

                double g = double.Parse(this.textBox10.Text);
             

                double i = g - f;

                this.textBox16.Text = i.ToString();
            }

            else if (this.textBox13.Text == "" || this.textBox14.Text == "")
            {
                this.textBox15.Text = "";
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox8.Text == "")
            {
                this.textBox9.Text = "";
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

            if (this.textBox13.Text == "")
            {
                this.textBox14.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Employee ID.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }

            else if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter Employee Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }

            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Department.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }

            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Designation.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }

            if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Month.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter year.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }

            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Basic Salary.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }

            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter CCA.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }
            else if (this.textBox9.Text == "")
            {
                MessageBox.Show("Enter MA.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox9.Focus();
            }
            else if (this.textBox13.Text == "")
            {
                MessageBox.Show("Enter IT.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox13.Focus();
            }
            else if (this.textBox14.Text == "")
            {
                MessageBox.Show("Enter Group IMU.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox14.Focus();
            }

            else
            {
                this.salaryTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.salaryTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.salaryTableAdapter.Adapter.SelectCommand.CommandText = "select * from salary where empid = '" + this.comboBox1.Text + "' and month = '" + this.comboBox2.Text + "' and year = '" + this.textBox4.Text + "'";
                this.salaryTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.salaryTableAdapter.Adapter.SelectCommand.Connection.Close();

                this.salaryTableAdapter.Fill(this.salsaveDataSet2.salary);

                if (this.textBox17.Text == "" || this.textBox18.Text == "" || this.textBox19.Text == "")
                {

                    this.salaryTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.salaryTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.salaryTableAdapter.Adapter.SelectCommand.CommandText = "insert into salary values('" + this.comboBox1.Text + "' , '" + this.textBox1.Text + "' , '" + this.textBox2.Text + "' , '" + this.textBox3.Text + "' , '" + this.comboBox2.Text + "' , '" + this.textBox4.Text + "' , '" + this.textBox5.Text + "' , '" + this.textBox6.Text + "' ,'" + this.textBox7.Text + "' , '" + this.textBox8.Text + "' , '" + this.textBox9.Text + "' , '" + this.textBox10.Text + "' , '" + this.textBox11.Text + "' , '" + this.textBox12.Text + "' , '" + this.textBox13.Text + "' , '" + this.textBox14.Text + "' , '" + this.textBox15.Text + "' , '" + this.textBox16.Text + "')";
                    this.salaryTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.salaryTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Record saved", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.textBox4.ReadOnly = true;
                    this.textBox5.ReadOnly = true;
                    this.textBox8.ReadOnly = true;
                    this.textBox9.ReadOnly = true;
                    this.textBox13.ReadOnly = true;
                    this.textBox14.ReadOnly = true;
                    this.comboBox2.Enabled = false;
                    this.button2.Enabled = false;
                    this.button1.Enabled = true;

                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.textBox8.Text = "";
                    this.textBox9.Text = "";
                    this.textBox10.Text = "";
                    this.textBox11.Text = "";
                    this.textBox12.Text = "";
                    this.textBox13.Text = "";
                    this.textBox14.Text = "";
                    this.textBox15.Text = "";
                    this.textBox16.Text = "";
                }
                else
                {
                    MessageBox.Show("Salary details of the employee of this month exists.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox13.Text = "";
            this.textBox14.Text = "";
            this.textBox15.Text = "";
            this.textBox16.Text = "";
            this.textBox4.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }
    }
}
