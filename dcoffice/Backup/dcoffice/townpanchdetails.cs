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
    public partial class townpanchdetails : Form
    {
        public townpanchdetails()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.townTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.townTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.townTableAdapter1.Adapter.SelectCommand.CommandText = "select * from town order by panchayatid desc";
            this.townTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.townTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.townTableAdapter1.Fill(this.towntalukDataSet2.town);

            if (this.textBox3.Text == "")
            {
                this.textBox1.Text = "1001";
            }
            else
            {
                int x = int.Parse(this.textBox3.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;
            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;

            this.textBox2.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.richTextBox1.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.textBox9.ReadOnly = false;
            this.textBox10.ReadOnly = false;
            this.textBox11.ReadOnly = false;
            this.richTextBox2.ReadOnly = false;
            this.textBox13.ReadOnly = false;

            this.label16.Visible = true;
            this.comboBox1.Visible = true;
            this.label10.Visible = false;
            this.textBox9.Visible = false;
        }

        private void townpanchdetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'towntalukDataSet2.town' table. You can move, or remove it, as needed.
            this.townTableAdapter1.Fill(this.towntalukDataSet2.town);
            // TODO: This line of code loads data into the 'townaddnewDataSet1.town' table. You can move, or remove it, as needed.
            this.townTableAdapter.Fill(this.townaddnewDataSet1.town);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = this.textBox13.Text;

            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Panchayat Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox2.Focus();
            }

            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Enter Taluk Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Number of Villages", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox4.Focus();
            }

            else if (this.richTextBox1.Text == "")
            {
                MessageBox.Show("Enter Village Details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.richTextBox1.Focus();
            }

            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Male Population", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox6.Focus();
            }



            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Female Population", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox7.Focus();
            }

            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Total Population", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox8.Focus();
            }

            else if (this.comboBox1.Text == "" && this.textBox9.Text == "")
            {
                MessageBox.Show("Enter Ruling Party", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox9.Focus();
            }

            else if (this.textBox10.Text == "")
            {
                MessageBox.Show("Enter President Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox10.Focus();
            }

            else if (this.textBox11.Text == "")
            {
                MessageBox.Show("Enter Vice President Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox11.Focus();
            }

            else if (this.richTextBox2.Text == "")
            {
                MessageBox.Show("Enter Panchayat Address", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.richTextBox2.Focus();
            }

            else if (this.textBox13.Text == "")
            {
                MessageBox.Show("Enter Contact Number", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox13.Focus();
            }
            else if (d.Length < 10)
            {
                MessageBox.Show("Contact Number must consist of 10 Digits.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox13.Focus();
            }

            else
            {
                if (this.comboBox1.Text == "Others")
                {
                    this.townTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.townTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.townTableAdapter.Adapter.SelectCommand.CommandText = "insert into town values('" + this.textBox1.Text + "' ,'" + this.textBox2.Text + "' , '" + this.comboBox2.Text + "' ,'" + this.textBox4.Text + "' , '" + this.richTextBox1.Text + "', '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.textBox8.Text + "' , '" + this.textBox9.Text + "' , '" + this.textBox10.Text + "' , '" + this.textBox11.Text + "' , '" + this.richTextBox2.Text + "' , '" + this.textBox13.Text + "')";
                    this.townTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.townTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox4.Text = "";
                    this.richTextBox1.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.textBox8.Text = "";
                    this.textBox9.Text = "";
                    this.textBox10.Text = "";
                    this.textBox11.Text = "";
                    this.richTextBox2.Text = "";
                    this.textBox13.Text = "";

                    this.textBox2.ReadOnly = true;
                    this.textBox4.ReadOnly = false;
                    this.richTextBox1.ReadOnly = false;
                    this.textBox6.ReadOnly = false;
                    this.textBox7.ReadOnly = false;
                    this.textBox9.ReadOnly = false;
                    this.textBox10.ReadOnly = false;
                    this.textBox11.ReadOnly = false;
                    this.richTextBox2.ReadOnly = false;
                    this.textBox13.ReadOnly = false;

                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                }

                else
                {
                    this.townTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.townTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.townTableAdapter.Adapter.SelectCommand.CommandText = "insert into town values('" + this.textBox1.Text + "' ,'" + this.textBox2.Text + "' , '" + this.comboBox2.Text + "' ,'" + this.textBox4.Text + "' , '" + this.richTextBox1.Text + "', '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.textBox8.Text + "' , '" + this.comboBox1.Text + "' , '" + this.textBox10.Text + "' , '" + this.textBox11.Text + "' , '" + this.richTextBox2.Text + "' , '" + this.textBox13.Text + "')";
                    this.townTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.townTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox4.Text = "";
                    this.richTextBox1.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.textBox8.Text = "";
                    this.textBox9.Text = "";
                    this.textBox10.Text = "";
                    this.textBox11.Text = "";
                    this.richTextBox2.Text = "";
                    this.textBox13.Text = "";

                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Male population.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }

            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Female population.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox7.Focus();
            }

            else
            {
                int a = int.Parse(this.textBox6.Text);
                int b = int.Parse(this.textBox7.Text);
                int c = a + b;
                this.textBox8.Text = c.ToString();
                this.textBox9.Focus();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            this.textBox2.Text = "";
            this.textBox4.Text = "";
            this.richTextBox1.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.richTextBox2.Text = "";
            this.textBox13.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            townupdate tu = new townupdate();
            tu.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox4.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox4.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox4.Focus();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox6.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox6.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox6.Focus();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox7.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox7.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox7.Focus();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox8.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox8.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox8.Focus();
                }
            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (this.textBox13.Text != "")
            {
                try
                {
                    var a = (double.Parse(this.textBox13.Text));
                }
                catch
                {
                    MessageBox.Show("Enter oly Numbers", "Error....", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox13.Focus();
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "Others")
            {
                this.label16.Visible = false;
                this.comboBox1.Visible = false;
                this.label10.Visible = true;
                this.textBox9.Visible = true;
                this.textBox9.Focus();
                this.button7.Visible = true;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Visible = false;
            this.label16.Visible = true;
            this.comboBox1.Visible = true;
            this.label10.Visible = false;
            this.textBox9.Visible = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
