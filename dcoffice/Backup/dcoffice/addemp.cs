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
    public partial class addemp : Form
    {
        public addemp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void addemp_Load(object sender, EventArgs e)
        {
// TODO: This line of code loads data into the 'login2DataSet2.login' table. You can move, or remove it, as needed.
this.loginTableAdapter1.Fill(this.login2DataSet2.login);
            // TODO: This line of code loads data into the 'loginDataSet2.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginDataSet2.login);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.textBox1.ReadOnly = false;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                if (this.textBox1.Text == "")
                {
                    MessageBox.Show("Enter Employee Name", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox1.Focus();
                }
                else if (this.textBox2.Text == "")
                {
                    MessageBox.Show("Enter Password", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox2.Focus();
                }
                else if (this.textBox3.Text == "")
                {
                    MessageBox.Show("Enter Confirm Password", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox3.Focus();
                }
                else if (this.textBox2.Text != this.textBox3.Text)
                {
                    MessageBox.Show("Set password and Confirm password mismatch.", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox2.Focus();
                }

                else
                {
                    this.loginTableAdapter.Adapter.SelectCommand.Connection.Open();
                    this.loginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                    this.loginTableAdapter.Adapter.SelectCommand.CommandText = "select * from login where username='" + this.textBox1.Text + "'";
                    this.loginTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                    this.loginTableAdapter.Adapter.SelectCommand.Connection.Close();

                    this.loginTableAdapter.Fill(this.loginDataSet2.login);

                    if (this.textBox4.Text == "")
                    {

                        this.loginTableAdapter.Adapter.SelectCommand.Connection.Open();
                        this.loginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                        this.loginTableAdapter.Adapter.SelectCommand.CommandText = "insert into login values('" + this.textBox1.Text + "' , '" + this.textBox2.Text + "')";
                        this.loginTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                        this.loginTableAdapter.Adapter.SelectCommand.Connection.Close();

                        MessageBox.Show("Record saved", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        this.textBox1.ReadOnly = true;
                        this.textBox2.ReadOnly = true;
                        this.textBox3.ReadOnly = true;
                        this.button1.Enabled = true;
                        this.button2.Enabled = false;
                        this.textBox1.Text = "";
                        this.textBox2.Text = "";
                        this.textBox3.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Username already exists.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox1.Text = "";
                        this.textBox2.Text = "";
                        this.textBox3.Text = "";
                    }
                }
            }
        }
    }
