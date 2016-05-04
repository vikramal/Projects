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
    public partial class tenderreject : Form
    {
        public tenderreject()
        {
            InitializeComponent();
        }

        private void tenderreject_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tenderrejDataSet2.tenderreject' table. You can move, or remove it, as needed.
            this.tenderrejectTableAdapter.Fill(this.tenderrejDataSet2.tenderreject);
            // TODO: This line of code loads data into the 'tenderappDataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter.Fill(this.tenderappDataSet2.tenderapply);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.richTextBox4.Text == "")
            {
                MessageBox.Show("Enter Reason for Rejection.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox4.Focus();
            }
            else
            {
                this.tenderrejectTableAdapter.Adapter.SelectCommand.Connection.Open();
                this.tenderrejectTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
                this.tenderrejectTableAdapter.Adapter.SelectCommand.CommandText = "insert into tenderreject values('" + this.comboBox1.Text + "' , '" + this.textBox1.Text + "' , '" + this.textBox2.Text + "' , '" + this.textBox3.Text + "' , '" + this.textBox4.Text + "' , '" + this.textBox5.Text + "' , '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.richTextBox1.Text + "' , '" + this.richTextBox2.Text + "' , '" + this.richTextBox3.Text + "' , '" + this.richTextBox4.Text + "')";
                this.tenderrejectTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
                this.tenderrejectTableAdapter.Adapter.SelectCommand.Connection.Close();

                MessageBox.Show("Record Saved.", "Sucess....", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.textBox1.Text = "";
                this.textBox2.Text = "";
                this.textBox3.Text = "";
                this.textBox4.Text = "";
                this.textBox5.Text = "";
                this.textBox6.Text = "";
                this.textBox7.Text = "";
                this.richTextBox1.Text = "";
                this.richTextBox2.Text = "";
                this.richTextBox3.Text = "";
                this.richTextBox4.Text = "";

                this.button1.Enabled = true;
                this.button2.Enabled = false;
                this.comboBox1.Enabled = false;
                this.richTextBox4.ReadOnly = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.Enabled = true;
            this.comboBox1.DroppedDown = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.richTextBox4.ReadOnly = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
