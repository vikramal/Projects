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
    public partial class nic : Form
    {
        public nic()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.textBox2.Focus();
            this.richTextBox1.ReadOnly = false;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Number of Employees.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }

            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Incharge Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Timings.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }

            else if (this.richTextBox1.Text == "")
            {
                MessageBox.Show("Enter Functions.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox1.Focus();
            }

            else
            {

                this.nicTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.nicTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.nicTableAdapter.Adapter.SelectCommand.CommandText = "insert into nic values('" + this.textBox1.Text + "','" + this.textBox2.Text + "' , '" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.richTextBox1.Text + "')";
                this.nicTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.nicTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.richTextBox1.ReadOnly = true;
            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox4.ReadOnly = true;
            this.button1.Enabled = true;
            this.button2.Enabled = false;
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.richTextBox1.Text = "";
        }

        private void nic_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nicDataSet2.nic' table. You can move, or remove it, as needed.
            this.nicTableAdapter.Fill(this.nicDataSet2.nic);

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
    }
}
