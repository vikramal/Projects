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
    public partial class rejection : Form
    {
        public rejection()
        {
            InitializeComponent();
        }

        private void rejection_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rejectionDataSet2.rejection' table. You can move, or remove it, as needed.
            this.rejectionTableAdapter.Fill(this.rejectionDataSet2.rejection);
            // TODO: This line of code loads data into the 'nominationcomboDataSet2.nomination' table. You can move, or remove it, as needed.
            this.nominationTableAdapter.Fill(this.nominationcomboDataSet2.nomination);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.textBox12.Focus();
            this.textBox12.ReadOnly = false;
            this.richTextBox3.ReadOnly = false;
            this.richTextBox3.Enabled = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox12.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox12.Text == "")
            {
                MessageBox.Show("Select Rejection Date..", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox12.Focus();
            }
            else if (this.richTextBox3.Text == "")
            {
                MessageBox.Show("Enter Reason For Rejection", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox3.Focus();
            }
            else
            {
                this.rejectionTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.rejectionTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.rejectionTableAdapter.Adapter.SelectCommand.CommandText = "insert into rejection values('" + this.comboBox1.Text + "','" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "','" + this.richTextBox1.Text + "','" + this.richTextBox2.Text + "','" + this.textBox12.Text + "','" + this.richTextBox3.Text + "')";
                this.rejectionTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.rejectionTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.comboBox1.Text = null;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
                this.richTextBox1.Text = "";
                this.richTextBox2.Text = "";
                this.textBox12.Text = "";
                this.richTextBox3.Text = "";

                this.comboBox1.Enabled = false;
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }
    }
}
