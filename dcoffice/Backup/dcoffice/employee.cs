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
    public partial class employee : Form
    {
        public employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'empupautoDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empupautoDataSet2.employee);
            // TODO: This line of code loads data into the 'employee1DataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.employee1DataSet2.employee);
            // TODO: This line of code loads data into the 'employeeDataSet2.employee' table. You can move, or remove it, as needed.
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.employeeTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.employeeTableAdapter.Adapter.SelectCommand.CommandText = "select * from employee order by empid desc";
            this.employeeTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.employeeTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.employeeTableAdapter.Fill(this.empupautoDataSet2.employee);

            if(this.textBox7.Text == "")
            {
                this.textBox1.Text = "2001";
            }
            else
            {
                int x = int.Parse(this.textBox7.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }
            this.comboBox1.Enabled = true;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.dateTimePicker1.Enabled = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = this.textBox5.Text;
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter Employee ID","Error....",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Employee Name", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Department", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Designation", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Address", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }
            
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Contact Number", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (d.Length < 10)
            {
                MessageBox.Show("Contact Number must consist of 10 digits", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Select Date of Joining", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else
            {
                this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.employeeTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.employeeTableAdapter1.Adapter.SelectCommand.CommandText = "insert into employee values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.comboBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "')";
                this.employeeTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("RECORD SAVED", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.comboBox1.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }

       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox6.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            empupdate em = new empupdate();
            em.ShowDialog();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
