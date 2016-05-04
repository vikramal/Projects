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
    public partial class agriculture : Form
    {
        public agriculture()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.agricultureTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.agricultureTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.agricultureTableAdapter.Adapter.SelectCommand.CommandText = "select * from agriculture order by referenceid desc";
            this.agricultureTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.agricultureTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.agricultureTableAdapter.Fill(this.agri1DataSet2.agriculture);

            if (this.textBox7.Text == "")
            {
                this.textBox1.Text = "5000";
            }
            else
            {
                int x = int.Parse(this.textBox7.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

            this.comboBox1.Enabled = true;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.textBox4.ReadOnly = false;
            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void agriculture_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'agriDataSet2.agriculture' table. You can move, or remove it, as needed.
            this.agricultureTableAdapter1.Fill(this.agriDataSet2.agriculture);
            // TODO: This line of code loads data into the 'agri1DataSet2.agriculture' table. You can move, or remove it, as needed.
            this.agricultureTableAdapter.Fill(this.agri1DataSet2.agriculture);

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.comboBox1.Text= "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
            this.textBox4.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox1.Text == "")
            {
                MessageBox.Show("Select Taluk Name.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.DroppedDown=true;
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Panchayat.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter total Irrigation Coverage.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }
            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter Water Source.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Enter Main Crop.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Enter Other Crop Details.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else
            {
                this.agricultureTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.agricultureTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.agricultureTableAdapter1.Adapter.SelectCommand.CommandText = "insert into agriculture values('"+this.textBox1.Text+"','"+this.comboBox1.Text+"','"+this.textBox2.Text+"','"+this.textBox3.Text+"','"+this.textBox4.Text+"','"+this.textBox5.Text+"','"+this.textBox6.Text+"')";
                this.agricultureTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.agricultureTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved.","Success...",MessageBoxButtons.OK,MessageBoxIcon.Information);

                this.textBox1.Text = "";
                this.comboBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
