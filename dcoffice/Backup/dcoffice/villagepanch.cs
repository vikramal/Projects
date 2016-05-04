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
    public partial class villagepanch : Form
    {
        public villagepanch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.CommandText = "select * from panchayatdetails order by panchayatid desc";
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.panchayatdetailsTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.panchayatdetailsTableAdapter1.Fill(this.dcofficeDataSet1.panchayatdetails);

            if (this.textBox14.Text == "")
            {
                this.textBox1.Text = "1001";
            }
            else
            {
                int x = int.Parse(this.textBox14.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }
            
           
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button3.Enabled = true;
            this.button4.Enabled = true;

            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            this.comboBox3.Enabled = true;
            this.comboBox4.Enabled = true;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.textBox9.ReadOnly = false;
            this.textBox10.ReadOnly = false;
            this.textBox11.ReadOnly = false;
            this.textBox12.ReadOnly = false;
            this.textBox13.ReadOnly = false;

            this.label16.Visible = true;
            this.comboBox1.Visible = true;
            this.label10.Visible = false;
            this.textBox9.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string d = this.textBox13.Text;
            

            

            if (this.comboBox3.Text == "")
            {
                MessageBox.Show("Select Panchayat Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox3.DroppedDown = true;
            }

            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Taluk Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox2.DroppedDown = true;
            }

            else if (this.comboBox4.Text == "")
            {
                MessageBox.Show("Select village name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.comboBox4.DroppedDown = true;
            }

            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Village Details", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox5.Focus();
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
                this.comboBox1.DroppedDown = true;
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

            else if (this.textBox12.Text == "")
            {
                MessageBox.Show("Enter Panchayat Address", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox12.Focus();
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
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.CommandText = "insert into panchayatdetails values('" + this.textBox1.Text + "' ,'" + this.comboBox3.Text + "' , '" + this.comboBox2.Text + "' ,'" + this.comboBox4.Text + "' , '" + this.textBox5.Text + "', '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.textBox8.Text + "' , '" + this.textBox9.Text + "' , '" + this.textBox10.Text + "' , '" + this.textBox11.Text + "' , '" + this.textBox12.Text + "' , '" + this.textBox13.Text + "')";
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.textBox1.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.textBox8.Text = "";
                    this.textBox9.Text = "";
                    this.textBox10.Text = "";
                    this.textBox11.Text = "";
                    this.textBox12.Text = "";
                    this.textBox13.Text = "";

                    this.comboBox1.Enabled = false;
                    this.comboBox2.Enabled = false;
                    this.comboBox3.Enabled = false;
                    this.comboBox4.Enabled = false;

                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                }
                else
                {
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.CommandText = "insert into panchayatdetails values('" + this.textBox1.Text + "' ,'" + this.comboBox3.Text + "' , '" + this.comboBox2.Text + "' ,'" + this.comboBox4.Text + "' , '" + this.textBox5.Text + "', '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.textBox8.Text + "' , '" + this.comboBox1.Text + "' , '" + this.textBox10.Text + "' , '" + this.textBox11.Text + "' , '" + this.textBox12.Text + "' , '" + this.textBox13.Text + "')";
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.panchayatdetailsTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Record Saved Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.textBox1.Text = "";
                    this.textBox5.Text = "";
                    this.textBox6.Text = "";
                    this.textBox7.Text = "";
                    this.textBox8.Text = "";
                    this.textBox9.Text = "";
                    this.textBox10.Text = "";
                    this.textBox11.Text = "";
                    this.textBox12.Text = "";
                    this.textBox13.Text = "";
                    this.comboBox1.Enabled = false;
                    this.comboBox2.Enabled = false;
                    this.comboBox3.Enabled = false;
                    this.comboBox4.Enabled = false;

                    this.button1.Enabled = true;
                    this.button2.Enabled = false;
                }
            }
        }


        private void villagepanch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'adDataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter1.Fill(this.adDataSet2.addvillage);
            // TODO: This line of code loads data into the 'addvDataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter.Fill(this.addvDataSet2.addvillage);
            // TODO: This line of code loads data into the 'dcofficeDataSet1.panchayatdetails' table. You can move, or remove it, as needed.
            this.panchayatdetailsTableAdapter1.Fill(this.dcofficeDataSet1.panchayatdetails);
            // TODO: This line of code loads data into the 'dcofficeDataSet.panchayatdetails' table. You can move, or remove it, as needed.
            this.panchayatdetailsTableAdapter.Fill(this.dcofficeDataSet.panchayatdetails);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            updatevillpanch vp = new updatevillpanch();
            vp.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click_1(object sender, EventArgs e)
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
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
            this.textBox10.Text = "";
            this.textBox11.Text = "";
            this.textBox12.Text = "";
            this.textBox13.Text = "";
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
            else
            {
                this.button7.Visible = false;
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "select distinct(villagepanchayat) from addvillage where taluk = '" + this.comboBox2.Text + "'";
            this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter.Fill(this.addvDataSet2.addvillage);
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandText = "select distinct(villages) from addvillage where taluk = '" + this.comboBox2.Text + "' and villagepanchayat = '" + this.comboBox3.Text + "'";
            this.addvillageTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter1.Fill(this.adDataSet2.addvillage);
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

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            addvillage a = new addvillage();
            a.ShowDialog();
        }
    }
}
