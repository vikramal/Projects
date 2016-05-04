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
    public partial class updemppass : Form
    {
        public updemppass()
        {
            InitializeComponent();
        }

        private void updemppass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login4DataSet2.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.login4DataSet2.login);
            // TODO: This line of code loads data into the 'login3DataSet2.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.login3DataSet2.login);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox2.Enabled = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.textBox2.ReadOnly = false;
            this.textBox3.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.comboBox2.Text == "")
            {
                MessageBox.Show("Select Employee Name.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.comboBox2.DroppedDown = true;
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter new password.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter Confirm password.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }

            else if (this.textBox2.Text != this.textBox3.Text)
            {
                MessageBox.Show("New password and Confirm password does not match.", "Erroor...!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
                this.textBox2.Text = "";
                this.textBox3.Text = "";
            }
            else
            {
                this.loginTableAdapter1.Adapter.SelectCommand.Connection.Open();
                this.loginTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.loginTableAdapter1.Adapter.SelectCommand.CommandText = "update login set password = '" + this.textBox2.Text + "' where username = '" + this.comboBox2.Text + "'";
                this.loginTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
                this.loginTableAdapter1.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Password Changed Successfully.", "Success...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                this.loginTableAdapter.Fill(this.login3DataSet2.login);

                this.comboBox2.Enabled = false;
                this.button1.Enabled = true;
                this.button2.Enabled = false;
                this.textBox2.ReadOnly = true;
                this.textBox3.ReadOnly = true;
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
            }

        }
    }
}
