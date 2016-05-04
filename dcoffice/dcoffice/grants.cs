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
    public partial class grants : Form
    {
        public grants()
        {
            InitializeComponent();
        }


        //endonment new button
        private void button3_Click(object sender, EventArgs e)
        {
            this.textBox4.Focus();
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.textBox8.ReadOnly = false;
            this.comboBox6.Enabled = true;

            this.button3.Enabled = false;
            this.button5.Enabled = true;
        }


        // endonment save button.
        private void button5_Click(object sender, EventArgs e)
        {
            if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Temple/Mosque/church Namre.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }

            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Trust Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }

            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Trustee Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }

            else if (this.comboBox6.Text == "")
            {
                MessageBox.Show("Select Taluk Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox6.DroppedDown = true;
            }

            else if (this.comboBox7.Text == "")
            {
                MessageBox.Show("Select Panchayat Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox7.DroppedDown = true;
            }

            else if (this.comboBox8.Text == "")
            {
                MessageBox.Show("Select village Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox8.DroppedDown = true;
            }

            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Enter Number of Members.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox7.Focus();
            }

            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Address.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }
            else
            {
                this.endowmentTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.endowmentTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.endowmentTableAdapter.Adapter.SelectCommand.CommandText = "insert into endowment values('" + this.textBox4.Text + "' , '" + this.textBox5.Text + "' , '" + this.textBox6.Text + "' , '" + this.comboBox6.Text + "' , '" + this.comboBox7.Text + "' , '" + this.comboBox8.Text + "' , '" + this.textBox7.Text + "' , '" + this.textBox8.Text + "')";
                this.endowmentTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.endowmentTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved.", "Sucess...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";

                this.textBox4.ReadOnly = true;
                this.textBox5.ReadOnly = true;
                this.textBox6.ReadOnly = true;
                this.textBox7.ReadOnly = true;
                this.textBox8.ReadOnly = true;
                this.comboBox6.Enabled = false;
                this.comboBox7.Enabled = false;
                this.comboBox8.Enabled = false;

                this.button3.Enabled = true;
                this.button5.Enabled = false;

                this.comboBox6.Text = null;
                this.comboBox7.Text = null;
                this.comboBox8.Text = null;
            }
        }

        private void grants_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aenDataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter3.Fill(this.aenDataSet2.endowment);
            // TODO: This line of code loads data into the 'egrant1DataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter2.Fill(this.egrant1DataSet2.endowment);
            // TODO: This line of code loads data into the 'avill2DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter3.Fill(this.avill2DataSet2.addvillage);
            // TODO: This line of code loads data into the 'avill1DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter2.Fill(this.avill1DataSet2.addvillage);
            // TODO: This line of code loads data into the 'egrantDataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter1.Fill(this.egrantDataSet2.endowment);
            // TODO: This line of code loads data into the 'gDataSet2.grants1' table. You can move, or remove it, as needed.
            this.grants1TableAdapter1.Fill(this.gDataSet2.grants1);
            // TODO: This line of code loads data into the 'grants1DataSet2.grants1' table. You can move, or remove it, as needed.
            this.grants1TableAdapter.Fill(this.grants1DataSet2.grants1);
            // TODO: This line of code loads data into the 'aa2DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter1.Fill(this.aa2DataSet2.addvillage);
            // TODO: This line of code loads data into the 'aa1DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter.Fill(this.aa1DataSet2.addvillage);
            // TODO: This line of code loads data into the 'endonmentDataSet2.endowment' table. You can move, or remove it, as needed.
            this.endowmentTableAdapter.Fill(this.endonmentDataSet2.endowment);
            
            
            this.comboBox1.Text = null;
            this.comboBox6.Text = null;
            this.comboBox7.Text = null;
            this.comboBox8.Text = null;

            this.button1.Enabled = true;
        }


        //grants clear button
        private void button6_Click(object sender, EventArgs e)
        {
        }


        //grants home button
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //endonment clear button
        private void button8_Click(object sender, EventArgs e)
        {
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.comboBox6.Text = null;
            this.comboBox7.Text = null;
            this.comboBox8.Text = null;
        }

        //endonment home button
        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        // grants new button
        private void button1_Click(object sender, EventArgs e)
        {
            this.grants1TableAdapter.Adapter.SelectCommand.Connection.Open();
            this.grants1TableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.grants1TableAdapter.Adapter.SelectCommand.CommandText = "select * from grants1 order by grantdocnum desc";
            this.grants1TableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.grants1TableAdapter.Adapter.SelectCommand.Connection.Close();

            this.grants1TableAdapter.Fill(this.grants1DataSet2.grants1);

            if (this.textBox9.Text == "")
            {
                this.textBox1.Text = "1001";
            }
            else
            {
                int x = int.Parse(this.textBox9.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

           
            this.textBox3.ReadOnly = false;
            this.comboBox1.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;


        }


        //grants save button
        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Temple/Mosque/church Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }

            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Grant date.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }

            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Grant amount.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else
            {
                this.grants1TableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.grants1TableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.grants1TableAdapter1.Adapter.SelectCommand.CommandText = "insert into grants1 values('" + this.textBox1.Text + "' ,'" + this.comboBox1.Text + "' , '" + this.textBox10.Text + "' ,'" + this.textBox11.Text + "' , '" + this.textBox12.Text + "', '" + this.textBox13.Text + "' , '" + this.textBox2.Text + "' , '" + this.textBox3.Text + "')";
                this.grants1TableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.grants1TableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved.", "Sucess...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.textBox3.ReadOnly = true;
                this.comboBox1.Enabled = false;
                this.dateTimePicker1.Enabled = true;
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox2.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox7.Enabled = true;
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "select distinct(villagepanchayat) from addvillage where taluk = '" + this.comboBox6.Text + "'";
            this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter.Fill(this.aa1DataSet2.addvillage);
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox8.Enabled = true;
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandText = "select distinct(villages) from addvillage where taluk = '" + this.comboBox6.Text + "' and villagepanchayat = '" + this.comboBox7.Text + "'";
            this.addvillageTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter1.Fill(this.aa2DataSet2.addvillage);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            this.endowmentTableAdapter3.Adapter.SelectCommand.Connection.Open();
            this.endowmentTableAdapter3.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.endowmentTableAdapter3.Adapter.SelectCommand.CommandText = "select * from endowment";           
            this.endowmentTableAdapter3.Adapter.SelectCommand.ExecuteNonQuery();
            this.endowmentTableAdapter3.Adapter.SelectCommand.Connection.Close();

            this.endowmentTableAdapter3.Fill(this.aenDataSet2.endowment);

            //this.endowmentTableAdapter2.Adapter.SelectCommand.Connection.Open();
            //this.endowmentTableAdapter2.Adapter.SelectCommand.CommandType = CommandType.Text;
            //this.endowmentTableAdapter2.Adapter.SelectCommand.CommandText = "select distinct(trustname) from endowment where temple = '" + this.comboBox1.Text + "'";
            //this.endowmentTableAdapter2.Adapter.SelectCommand.ExecuteNonQuery();
            //this.endowmentTableAdapter2.Adapter.SelectCommand.Connection.Close();

            //this.endowmentTableAdapter2.Fill(this.egrant1DataSet2.endowment);
        }
    }
}