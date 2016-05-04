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
    public partial class tenderpublish : Form
    {
        public tenderpublish()
        {
            InitializeComponent();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            
            this.textBox2.Text = "";
            this.comboBox1.Text = "";
            this.textBox5.Text = "";
            this.textBox6.Text = "";
            this.textBox7.Text = "";
            this.textBox8.Text = "";
            this.textBox9.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderpublish order by tenderdocnum desc";
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderpublishTableAdapter1.Fill(this.tenderpublish1DataSet2.tenderpublish);

            if (this.textBox3.Text == "")
            {
                this.textBox1.Text = "2001";
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
            this.button5.Enabled = true;
            this.comboBox1.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.dateTimePicker2.Enabled = true;
            this.dateTimePicker3.Enabled = true;
            this.textBox4.Text = DateTime.Now.ToLongDateString();
            this.textBox2.ReadOnly = false;
            this.textBox8.ReadOnly = false;
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
                    this.textBox8.Text = "";
                    this.textBox8.Focus();
                }
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox5.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            this.textBox6.Text = this.dateTimePicker2.Value.ToLongDateString();
        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            this.textBox7.Text = this.dateTimePicker3.Value.ToLongDateString();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Tender Amount.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }

            else
            {
                double a = double.Parse(this.textBox8.Text);
                double b = a * 0.10;
                this.textBox9.Text = b.ToString();
            }
        }
        private void tenderpublish_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tenderpublish1DataSet2.tenderpublish' table. You can move, or remove it, as needed.
            this.tenderpublishTableAdapter1.Fill(this.tenderpublish1DataSet2.tenderpublish);
            // TODO: This line of code loads data into the 'tenderpublishDataSet2.tenderpublish' table. You can move, or remove it, as needed.
            this.tenderpublishTableAdapter.Fill(this.tenderpublishDataSet2.tenderpublish);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Tender Name","Erroor...!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if(this.comboBox1.Text == "")
            {
                MessageBox.Show("Enter Tender Type", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox1.Focus();
            }
            else if (this.textBox5.Text == "")
            {
                MessageBox.Show("Select Date", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox5.Focus();
            }
            else if (this.textBox6.Text == "")
            {
                MessageBox.Show("Select Date", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox6.Focus();
            }
            else if (this.textBox7.Text == "")
            {
                MessageBox.Show("Select Date", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox7.Focus();
            }
            else if (this.textBox8.Text == "")
            {
                MessageBox.Show("Enter Tender Amount", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox8.Focus();
            }
            else if (this.textBox9.Text == "")
            {
                MessageBox.Show("Select Calculate E.M.D Button", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox9.Focus();
            }
            else
            {
                this.tenderpublishTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.tenderpublishTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.tenderpublishTableAdapter.Adapter.SelectCommand.CommandText = "insert into tenderpublish values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.comboBox1.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "','" + this.textBox6.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox9.Text + "')";
                this.tenderpublishTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.tenderpublishTableAdapter.Adapter.SelectCommand.Connection.Close();
                MessageBox.Show("RECORD SAVED", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.textBox2.Text = "";
                this.comboBox1.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.textBox8.Text = "";
                this.textBox9.Text = "";
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                this.button3.Enabled = false;
                this.button5.Enabled = false;
            }
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
    }
}
