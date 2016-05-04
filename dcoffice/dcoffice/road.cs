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
    public partial class road : Form
    {
        public road()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void road_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'a3DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter2.Fill(this.a3DataSet2.addvillage);
            // TODO: This line of code loads data into the 'a1DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter1.Fill(this.a1DataSet2.addvillage);
            // TODO: This line of code loads data into the 'a2DataSet2.addvillage' table. You can move, or remove it, as needed.
            this.addvillageTableAdapter.Fill(this.a2DataSet2.addvillage);
            // TODO: This line of code loads data into the 'road1DataSet2.road' table. You can move, or remove it, as needed.
            this.roadTableAdapter1.Fill(this.road1DataSet2.road);
            // TODO: This line of code loads data into the 'roadDataSet2.road' table. You can move, or remove it, as needed.
            this.roadTableAdapter.Fill(this.roadDataSet2.road);


            this.comboBox1.Text = null;
            this.comboBox2.Text = null;
            this.comboBox3.Text = null;
            this.comboBox4.Text = null;
            this.comboBox5.Text = null;

            this.comboBox4.Enabled = false;
            this.comboBox5.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.roadTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.roadTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.roadTableAdapter1.Adapter.SelectCommand.CommandText = "select * from road order by referenceid desc";
            this.roadTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.roadTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.roadTableAdapter1.Fill(this.road1DataSet2.road);
            
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


            this.comboBox1.Text = null;
            this.comboBox2.Text = null;
            this.comboBox3.Text = null;
            this.comboBox4.Text = null;
            this.comboBox5.Text = null;

            this.comboBox1.Enabled = true;
            this.comboBox2.Enabled = true;
            this.comboBox4.Enabled = true;
            this.comboBox5.Enabled = true;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            
            this.button2.Enabled = true;
            this.button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Choose Taluk Name", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.Focus();
            }
            else if (this.comboBox3.Text == "")
            {
                MessageBox.Show("Enter Panchayat Name", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox3.DroppedDown = true;
            }
            else if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Choose Road Type", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }
            else if (this.comboBox4.Text == "")
            {
                MessageBox.Show("Enter Road From", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox4.DroppedDown = true;
            }
            else if (this.comboBox5.Text == "")
            {
                MessageBox.Show("Enter Road To", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox5.DroppedDown = true;
            } 
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Total Kilometer", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Approximate Cost", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else
            {
                this.roadTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.roadTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.roadTableAdapter.Adapter.SelectCommand.CommandText = "insert into road values('" + this.textBox1.Text + "','" + this.comboBox1.Text + "','" + this.comboBox3.Text + "','" + this.comboBox2.Text + "','" + this.comboBox4.Text + "','" + this.comboBox5.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "')";
                this.roadTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.roadTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.comboBox1.Enabled = false;
                this.comboBox2.Enabled = false;
                this.comboBox3.Enabled = false;
                this.comboBox4.Enabled = false;
                this.comboBox5.Enabled = false;
                this.textBox1.Text = "";
                this.comboBox2.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;

                this.comboBox1.Text = null;
                this.comboBox2.Text = null;
                this.comboBox3.Text = null;
                this.comboBox4.Text = null;
                this.comboBox5.Text = null;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
            this.textBox5.Text = "";
            this.textBox6.Text = "";

            this.comboBox1.Text = null;
            this.comboBox2.Text = null;
            this.comboBox3.Text = null;
            this.comboBox4.Text = null;
            this.comboBox5.Text = null;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox3.Enabled = true;
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter.Adapter.SelectCommand.CommandText = "select distinct(villagepanchayat) from addvillage where taluk = '" + this.comboBox1.Text + "'";
            this.addvillageTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter.Fill(this.a2DataSet2.addvillage);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.comboBox4.Enabled = true;
            this.comboBox5.Enabled = true;

            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter1.Adapter.SelectCommand.CommandText = "select distinct(villages) from addvillage where taluk = '" + this.comboBox1.Text + "' and villagepanchayat = '" + this.comboBox3.Text + "'";
            this.addvillageTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter1.Fill(this.a1DataSet2.addvillage);


            this.addvillageTableAdapter2.Adapter.SelectCommand.Connection.Open();
            this.addvillageTableAdapter2.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.addvillageTableAdapter2.Adapter.SelectCommand.CommandText = "select distinct(villages) from addvillage where taluk = '" + this.comboBox1.Text + "' and villagepanchayat = '" + this.comboBox3.Text + "'";
            this.addvillageTableAdapter2.Adapter.SelectCommand.ExecuteNonQuery();
            this.addvillageTableAdapter2.Adapter.SelectCommand.Connection.Close();

            this.addvillageTableAdapter2.Fill(this.a3DataSet2.addvillage);
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
