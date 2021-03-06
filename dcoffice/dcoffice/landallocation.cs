﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace dcoffice
{
    public partial class landallocation : Form
    {
        public landallocation()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {
            string d = this.textBox9.Text;

            if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Allocation Land Address", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox3.Focus();
            }

            else if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Enter Panchayat Type", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Land Area", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox4.Focus();
            }

            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Land Valution", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox5.Focus();
            }

            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Allocated To", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox6.Focus();
            }



            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Address", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox7.Focus();
            }

            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Occupation", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox8.Focus();
            }

            else if (this.textBox9.Text == "")
            {
                MessageBox.Show("Enter Contact Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox9.Focus();
            }
            else if (d.Length < 10)
            {
                MessageBox.Show("Contact Number must consist of 10 Digits.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox9.Focus();
            }
            else if (this.textBox10.Text == "")
            {
                MessageBox.Show("Enter Income", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox10.Focus();
            }
            else
            {
                this.landallocationTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.landallocationTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.landallocationTableAdapter1.Adapter.SelectCommand.CommandText = "insert into landallocation values('" + this.textBox1.Text + "' , '" + this.textBox2.Text + "' , '" + this.textBox3.Text + "' , '" + this.textBox4.Text + "' , '" + this.textBox5.Text + "' , '" + this.comboBox1.Text + "' , '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.textBox8.Text + "' , '" + this.textBox9.Text + "' , '" + this.textBox10.Text + "')";
                this.landallocationTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.landallocationTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;
               
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = DateTime.Now.ToLongDateString();

            this.landallocationTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landallocationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landallocationTableAdapter.Adapter.SelectCommand.CommandText = "select * from landallocation order by allocationdocnum desc";
            this.landallocationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landallocationTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landallocationTableAdapter.Fill(this.landallocationDataSet2.landallocation);

            if (this.textBox11.Text == "")
            {
                this.textBox1.Text = "1001";
            }
            else
            {
                int x = int.Parse(this.textBox11.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }
            
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.textBox8.ReadOnly = false;
            this.textBox9.ReadOnly = false;
            this.textBox10.ReadOnly = false;
            this.comboBox1.Enabled = true;
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
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            
            
        
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox5.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox5.Text));
                }
                catch
                {
                    MessageBox.Show("Enter only Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox5.Text = "";
                    this.textBox5.Focus();
                }
            }
        }

        private void landallocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'landallocaDataSet2.landallocation' table. You can move, or remove it, as needed.
            this.landallocationTableAdapter1.Fill(this.landallocaDataSet2.landallocation);
            // TODO: This line of code loads data into the 'landallocationDataSet2.landallocation' table. You can move, or remove it, as needed.
            this.landallocationTableAdapter.Fill(this.landallocationDataSet2.landallocation);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
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
