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
    public partial class landconversion : Form
    {
        public landconversion()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void landconversion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'conversionDataSet2.landconversion' table. You can move, or remove it, as needed.
            this.landconversionTableAdapter.Fill(this.conversionDataSet2.landconversion);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.landconversionTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.landconversionTableAdapter.Adapter.SelectCommand.CommandText = "select * from landconversion order by applicationnum desc";
            this.landconversionTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.landconversionTableAdapter.Fill(this.conversionDataSet2.landconversion);

            if (this.textBox12.Text == "")
            {
                this.textBox1.Text = "2001";
            }
            else
            {
                int x = int.Parse(this.textBox12.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }
            this.textBox2.ReadOnly = false;
            this.textBox2.Focus();
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.textBox8.ReadOnly = false;
            this.textBox9.ReadOnly = false;
            this.textBox10.ReadOnly = false;
            this.textBox11.ReadOnly = false;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            this.button2.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.comboBox1.Text = "";
            this.comboBox2.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = this.textBox4.Text;
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Application Number.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Address.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Contact Number.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }
            else if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Land Type.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }
            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Taluk Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Panchayat Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Location.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Market Value.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox7.Focus();
            }
            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Government Value.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }
            else if (this.textBox9.Text == "")
            {
                MessageBox.Show("Enter Land Area.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox9.Focus();
            }
            else if (this.textBox10.Text == "")
            {
                MessageBox.Show("Enter Convertion Fees.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox10.Focus();
            }
            else if (this.textBox11.Text == "")
            {
                MessageBox.Show("Enter Converting Authority.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox11.Focus();
            }
            else if (d.Length < 10)
            {
                MessageBox.Show("Contact Number must consist of 10 Digits.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox4.Focus();
            }
            else
            {
                this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.landconversionTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.landconversionTableAdapter.Adapter.SelectCommand.CommandText = "insert into landconversion values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "','" + this.textBox10.Text + "','" + this.textBox11.Text + "')";
                this.landconversionTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.landconversionTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("RECORD SAVED", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.comboBox1.Text = "";
                this.comboBox2.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.textBox10.Text = "";
                this.textBox11.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
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
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
