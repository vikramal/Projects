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
    public partial class addvillage : Form
    {
        public addvillage()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Taluk name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }

            else if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter Village Panchayat Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }

            else
            {
                this.addvillpanchTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.addvillpanchTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.addvillpanchTableAdapter.Adapter.SelectCommand.CommandText = "select * from addvillpanch where taluk = '" + this.comboBox2.Text + "' and villagepanchayat = '" + this.textBox1.Text + "'";
                this.addvillpanchTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.addvillpanchTableAdapter.Adapter.SelectCommand.Connection.Close();

                this.addvillpanchTableAdapter.Fill(this.addvillpanchDataSet2.addvillpanch);

                if (this.textBox4.Text == "" || this.textBox3.Text == "")
                {
                    this.addvillpanchTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.addvillpanchTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.addvillpanchTableAdapter.Adapter.SelectCommand.CommandText = "insert into addvillpanch values('" + this.comboBox2.Text + "','" + this.textBox1.Text + "')";
                    this.addvillpanchTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.addvillpanchTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Village panchayat saved sucessfully", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox1.Text = "";
                    this.textBox1.Focus();
                }
                else
                {
                    MessageBox.Show("Village Panchayat name already exists.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox1.Text = "";
                    this.textBox1.Focus();
                }
            }
        }

        private void addvillage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'addvillageDataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter.Fill(this.addvillageDataSet2.addvillage);
            // TODO: This line of code loads data into the 'addvillpanchDataSet2.addvillpanch' table. You can move, or remove it, as needed.
            this.addvillpanchTableAdapter.Fill(this.addvillpanchDataSet2.addvillpanch);

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.addvillpanchTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.addvillpanchTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillpanchTableAdapter.Adapter.SelectCommand.CommandText = "select * from addvillpanch where taluk = '" + this.comboBox3.Text + "'";
            this.addvillpanchTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillpanchTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.addvillpanchTableAdapter.Fill(this.addvillpanchDataSet2.addvillpanch);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox3.Text == "")
            {
                MessageBox.Show("Select Taluk name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox3.DroppedDown = true;
            }

            else if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Taluk name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown = true;
            }

            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Select Taluk name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }

            else
            {
                this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "select * from addvillage where villagepanchayat = '" + this.comboBox1.Text + "' and villages = '" + this.textBox2.Text + "'";
                this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

                this.addvillageTableAdapter.Fill(this.addvillageDataSet2.addvillage);

                if (this.textBox5.Text == "" || this.textBox6.Text == "")
                {
                    this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "insert into addvillage values('" + this.comboBox3.Text + "','" + this.comboBox1.Text + "','" + this.textBox2.Text + "')";
                    this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

                    MessageBox.Show("Village panchayat saved sucessfully", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.textBox2.Text = "";
                    this.textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("Village already exists.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox2.Text = "";
                    this.textBox2.Focus();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
