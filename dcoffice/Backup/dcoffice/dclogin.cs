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
    public partial class dclogin : Form
    {
        public dclogin()
        {
            InitializeComponent();
        }

        private void dclogin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dcloginDataSet1.dclogin' table. You can move, or remove it, as needed.
            this.dcloginTableAdapter.Fill(this.dcloginDataSet1.dclogin);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter User Name", "Wait ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Password", "Wait ...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }
            else
            {
                this.dcloginTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.dcloginTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.dcloginTableAdapter.Adapter.SelectCommand.CommandText = "select * from dclogin where username='" + this.textBox1.Text + "' and password='" + this.textBox2.Text + "'";
                this.dcloginTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.dcloginTableAdapter.Adapter.SelectCommand.Connection.Close();

                this.dcloginTableAdapter.Fill(this.dcloginDataSet1.dclogin);

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
                    loading2 f = new loading2();
                    f.ShowDialog();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainlogin m = new mainlogin();
            m.ShowDialog();
        }
    }
}