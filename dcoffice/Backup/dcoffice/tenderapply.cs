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
    public partial class tenderapply : Form
    {
        public tenderapply()
        {
            InitializeComponent();
        }

        private void off_Tick(object sender, EventArgs e)
        {
            double a = this.on.Interval;

            if (a % 10 == 0)
            {
                this.label1.Visible = true;
                this.off.Stop();
                this.on.Start();
            }
        }

        private void on_Tick(object sender, EventArgs e)
        {
            this.on.Start();
            double a = this.on.Interval;

            if (a % 10 == 0)
            {
                this.label1.Visible = false;
                this.on.Stop();
                this.off.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderapply order by applicationnum desc";
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderapplyTableAdapter1.Fill(this.tenderapply2DataSet2.tenderapply);

            if (this.textBox8.Text == "")
            {
                this.textBox1.Text = "1230";
            }
            else
            {
                int x = int.Parse(this.textBox8.Text);
                x++;
                this.textBox1.Text = x.ToString();
            }

            this.textBox5.ReadOnly = false;
            this.textBox6.ReadOnly = false;
            this.textBox7.ReadOnly = false;
            this.richTextBox1.ReadOnly = false;
            this.richTextBox2.ReadOnly = false;
            this.richTextBox3.ReadOnly = false;
            this.comboBox1.Enabled = true;
            this.dateTimePicker1.Enabled = true;
            this.button1.Enabled = false;
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tenderapplyTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.tenderapplyTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapplyTableAdapter.Adapter.SelectCommand.CommandText = "insert into tenderapply values('" + this.textBox1 + "' , '" + this.comboBox1.Text + "' , '" + this.textBox2.Text + "' , '" + this.textBox3.Text + "' , '" + this.textBox4.Text + "' , '" + this.textBox5.Text + "' , '" + this.textBox6.Text + "' , '" + this.textBox7.Text + "' , '" + this.richTextBox1.Text + "' , '" + this.richTextBox2.Text + "' , '" + this.richTextBox3.Text + "')";
            this.tenderapplyTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapplyTableAdapter.Adapter.SelectCommand.Connection.Close();

            MessageBox.Show("Record saved", "Sucess....", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.textBox2.ReadOnly = true;
            this.textBox3.ReadOnly = true;
            this.textBox5.ReadOnly = true;
            this.textBox6.ReadOnly = true;
            this.textBox7.ReadOnly = true;
            this.richTextBox1.ReadOnly = true;
            this.richTextBox2.ReadOnly = true;
            this.richTextBox3.ReadOnly = true;

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
            this.comboBox1.Text = null;
            this.comboBox1.Enabled = false;
            this.dateTimePicker1.Enabled = false;
        }

        private void tenderapply_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tenderpublish2DataSet2.tenderpublish' table. You can move, or remove it, as needed.
            this.tenderpublishTableAdapter.Fill(this.tenderpublish2DataSet2.tenderpublish);
            // TODO: This line of code loads data into the 'tenderapply2DataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter1.Fill(this.tenderapply2DataSet2.tenderapply);
            // TODO: This line of code loads data into the 'tenderapply1DataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter.Fill(this.tenderapply1DataSet2.tenderapply);

            this.comboBox1.Text = null;
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox4.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;

        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 32)
                e.Handled = true;

        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}
