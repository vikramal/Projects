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
    public partial class nomination : Form
    {
        string g = "";

        public nomination()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void nomination_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nominationautogenDataSet2.nomination' table. You can move, or remove it, as needed.
            this.nominationTableAdapter1.Fill(this.nominationautogenDataSet2.nomination);
            // TODO: This line of code loads data into the 'nominationDataSet2.nomination' table. You can move, or remove it, as needed.
            this.nominationTableAdapter.Fill(this.nominationDataSet2.nomination);
            // TODO: This line of code loads data into the 'nominationelectionDataSet2.electiondetails' table. You can move, or remove it, as needed.
            this.electiondetailsTableAdapter.Fill(this.nominationelectionDataSet2.electiondetails);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.nominationTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.nominationTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.nominationTableAdapter1.Adapter.SelectCommand.CommandText = "select * from nomination order by candidateno desc";
            this.nominationTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.nominationTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.nominationTableAdapter1.Fill(this.nominationautogenDataSet2.nomination);

            if (this.textBox11.Text == "")
            {
                this.textBox10.Text = "1001";
            }
            else
            {
                int x = int.Parse(this.textBox11.Text);
                x++;
                this.textBox10.Text = x.ToString();
            }
            this.comboBox1.Enabled = true;
            this.textBox1.Enabled = true;
            this.textBox2.Enabled = true;
            this.textBox3.Enabled = true;
            this.textBox4.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.textBox5.Enabled = true;
            this.comboBox2.Enabled = true;
            this.textBox7.Enabled = true;
            this.comboBox3.Enabled = true;
            this.radioButton1.Enabled = true;
            this.radioButton2.Enabled = true;
            this.textBox8.Enabled = true;
            this.comboBox4.Enabled = true;
            this.textBox9.Enabled = true;
            this.numericUpDown1.Enabled = true;
            this.richTextBox1.Enabled = true;
            this.richTextBox2.Enabled = true;

            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.comboBox2.Text = null;
            this.comboBox3.Text = null;
            this.comboBox4.Text = null;

            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.richTextBox1.Text = "";
            this.richTextBox2.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.comboBox2.Text = null;
            this.button7.Visible = false;
            this.label8.Visible = true;
            this.comboBox2.Visible = true;
            this.label9.Visible = false;
            this.textBox6.Visible = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "Others")
            {
                this.textBox6.Focus();
                this.label9.Visible = true;
                this.textBox6.Visible = true;
                this.comboBox2.Visible = false;
                this.label8.Visible = false;
                this.button7.Visible = true;
            }
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox4.Text == "Married")
            {
                this.label14.Visible = true;
                this.textBox9.Visible = true;
            }
            else
            {
                this.label14.Visible = false;
                this.textBox9.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = this.textBox7.Text;
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Election ID..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Select Nomination Date From Calender", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if(this.textBox10.Text == "")
            {
                MessageBox.Show("Select Candidate NO.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox10.Focus();
            }
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Candidate Name..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.comboBox2.Text == "" && this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Party Name..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Contact Number..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox7.Focus();
            }
            else if(this.radioButton1.Checked == false && this.radioButton2.Checked == false)
            {
                MessageBox.Show("Select Gender.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.comboBox3.Text == "")
            {
                MessageBox.Show("Select Qualification..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox3.DroppedDown = true;
            }
            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Occupation..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }
            else if (this.comboBox4.Text == "")
            {
                MessageBox.Show("Select Marital Status..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox4.DroppedDown = true;
            }
            else if (this.richTextBox1.Text == "")
            {
                MessageBox.Show("Enter Address..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox1.Focus();
            }
            else if (this.richTextBox2.Text == "")
            {
                MessageBox.Show("Enter Asset Details..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox2.Focus();
            }
            else if (d.Length < 10)
            {
                MessageBox.Show("Contact Number must consist of 10 Digits.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox9.Focus();
            }
            else if (this.comboBox2.Text == "Others")
            {
                this.nominationTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.nominationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.nominationTableAdapter.Adapter.SelectCommand.CommandText = "insert into nomination values('" + this.comboBox1.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','"+this.textBox10.Text+"','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.numericUpDown1.Value + "','" + g + "','" + this.richTextBox1.Text + "','" + this.richTextBox2.Text + "')";
                this.nominationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.nominationTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                
                this.comboBox2.Text = null;
                this.comboBox3.Text = null;
                this.comboBox4.Text = null;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.richTextBox1.Text = "";
                this.richTextBox2.Text = "";
                this.numericUpDown1.ResetText();

                this.comboBox1.Enabled = false;
                this.textBox1.Enabled = false;
                this.textBox2.Enabled = false;
                this.textBox3.Enabled = false;
                this.textBox4.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.textBox5.Enabled = false;
                this.comboBox2.Enabled = false;
                this.textBox7.Enabled = false;
                this.comboBox3.Enabled = false;
                this.radioButton1.Enabled = false;
                this.radioButton2.Enabled = false;
                this.textBox8.Enabled = false;
                this.comboBox4.Enabled = false;
                this.textBox9.Enabled = false;
                this.numericUpDown1.Enabled = false;
                this.richTextBox1.Enabled = false;
                this.richTextBox2.Enabled = false;

                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }

            else
            {
                    this.nominationTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.nominationTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.nominationTableAdapter.Adapter.SelectCommand.CommandText = "insert into nomination values('" + this.comboBox1.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox10.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.comboBox2.Text + "','" + this.textBox7.Text + "','" + this.comboBox3.Text + "','" + this.comboBox4.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.numericUpDown1.Value + "','" + g + "','" + this.richTextBox1.Text + "','" + this.richTextBox2.Text + "')";
                    this.nominationTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.nominationTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    
                    this.comboBox2.Text = null;
                    this.comboBox3.Text = null;
                    this.comboBox4.Text = null;
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.textBox8.Text = "";
                    this.textBox9.Text = "";
                    this.richTextBox1.Text = "";
                    this.richTextBox2.Text = "";
                    this.numericUpDown1.ResetText();

                    this.comboBox1.Enabled = false;
                    this.textBox1.Enabled = false;
                    this.textBox2.Enabled = false;
                    this.textBox3.Enabled = false;
                    this.textBox4.Enabled = false;
                    this.dateTimePicker1.Enabled = false;
                    this.textBox5.Enabled = false;
                    this.comboBox2.Enabled = false;
                    this.textBox7.Enabled = false;
                    this.comboBox3.Enabled = false;
                    this.radioButton1.Enabled = false;
                    this.radioButton2.Enabled = false;
                    this.textBox8.Enabled = false;
                    this.comboBox4.Enabled = false;
                    this.textBox9.Enabled = false;
                    this.numericUpDown1.Enabled = false;
                    this.richTextBox1.Enabled = false;
                    this.richTextBox2.Enabled = false;

                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
            }
        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox4.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            g = "male";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            g = "Female";
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
            {
                e.Handled = true;
            }
        }

        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
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
    }
}
