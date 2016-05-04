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
    public partial class districtupdate : Form
    {
        public districtupdate()
        {
            InitializeComponent();
        }

        private void districtupdate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'districtupdateDataSet1.district' table. You can move, or remove it, as needed.
            this.districtTableAdapter1.Fill(this.districtupdateDataSet1.district);
            // TODO: This line of code loads data into the 'updatedistrictcomboDataSet1.district' table. You can move, or remove it, as needed.
            this.districtTableAdapter.Fill(this.updatedistrictcomboDataSet1.district);

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string d = this.textBox13.Text;

            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Panchayat Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox2.Focus();
            }

            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Taluk Name", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox3.Focus();
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Number of Villages", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox4.Focus();
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

            else if (this.textBox9.Text == "")
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
                this.districtTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.districtTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.districtTableAdapter1.Adapter.SelectCommand.CommandText = "update district set panchayatname = '" + this.textBox2.Text + "' , talukname = '" + this.textBox3.Text + "' , numvillages = '" + this.textBox4.Text + "' ,villagedetails = '" + this.textBox5.Text + "' , malepopulation = '" + this.textBox6.Text + "' , femalepopulation = '" + this.textBox7.Text + "' , totalpopulation = '" + this.textBox8.Text + "' , rulingparty = '" + this.textBox9.Text + "' , presidentname = '" + this.textBox10.Text + "' , vicepresidentname = '" + this.textBox11.Text + "' , panchayataddress = '" + this.textBox12.Text + "' , contactnumber = '" + this.textBox13.Text + "' where panchayatid = '" + this.comboBox1.Text + "'";
                this.districtTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.districtTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record updated Successfully", "sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.districtTableAdapter.Fill(this.updatedistrictcomboDataSet1.district);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.districtTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.districtTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.districtTableAdapter1.Adapter.SelectCommand.CommandText = "delete from district where panchayatid = '" + this.comboBox1.Text + "'";
            this.districtTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.districtTableAdapter1.Adapter.SelectCommand.Connection.Close();

            MessageBox.Show("Record Deleted Successfully", "sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.districtTableAdapter.Fill(this.updatedistrictcomboDataSet1.district);
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

    }
}
