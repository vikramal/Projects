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
    public partial class budget : Form
    {
        public budget()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox5.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.budgetTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.budgetTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.budgetTableAdapter.Adapter.SelectCommand.CommandText = "select * from budget order by budgetdocnum desc";
            this.budgetTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.budgetTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.budgetTableAdapter.Fill(this.budgetDataSet2.budget);

            if (this.textBox7.Text == "")
            {
                this.textBox1.Text = "2001";
            }
            else
            {
                int x = int.Parse(this.textBox7.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.comboBox2.Enabled = true;
        }

        private void budget_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budget1DataSet2.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter1.Fill(this.budget1DataSet2.budget);
            // TODO: This line of code loads data into the 'budgetDataSet2.budget' table. You can move, or remove it, as needed.
            this.budgetTableAdapter.Fill(this.budgetDataSet2.budget);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Taluk Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Panchayat Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter total Budget.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Budget Year.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Select Approve Date.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Approved By.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else
            {
                this.budgetTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.budgetTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.budgetTableAdapter1.Adapter.SelectCommand.CommandText = "insert into budget values('" + this.textBox1.Text + "','" + this.comboBox2.Text + "','" + this.textBox2.Text + "' , '" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "')";
                this.budgetTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.budgetTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox4.ReadOnly = true;
                this.textBox6.ReadOnly = true;
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                this.dateTimePicker1.Enabled = false;
                this.comboBox2.Enabled = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
