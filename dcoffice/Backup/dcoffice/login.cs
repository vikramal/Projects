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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDataSet.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.loginDataSet.login);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter User Name", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Password", "Error ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else
            {
                this.loginTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.loginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.loginTableAdapter.Adapter.SelectCommand.CommandText = "select * from login where username='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "'";
                this.loginTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.loginTableAdapter.Adapter.SelectCommand.Connection.Close();

                this.loginTableAdapter.Fill(this.loginDataSet.login);

                this.textBox3.Visible = true;

                if (this.textBox3.Text == "")
                {
                    this.textBox3.Visible = false;
                    MessageBox.Show("Access Denied", "Sorry...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox1.Focus();
                }
                else
                {
                    this.textBox3.Visible = false;
                    this.Hide();
                    loading f = new loading();
                    f.ShowDialog();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainlogin m = new mainlogin();
            m.ShowDialog();
        }
    }
}
