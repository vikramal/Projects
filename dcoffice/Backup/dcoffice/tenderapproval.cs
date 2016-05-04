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
    public partial class tenderapproval : Form
    {
        public tenderapproval()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            this.textBox10.Text = this.dateTimePicker1.Value.ToLongDateString();
        }

        private void tenderapproval_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tenderapprovapplyDataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter.Fill(this.tenderapprovapplyDataSet2.tenderapply);
            // TODO: This line of code loads data into the 'tenderapprovalautoDataSet2.tenderapproval' table. You can move, or remove it, as needed.
            this.tenderapprovalTableAdapter.Fill(this.tenderapprovalautoDataSet2.tenderapproval);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.DroppedDown = true;
            this.comboBox1.Enabled = true;

            this.tenderapprovalTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.CommandText = "select * from tenderapproval order by workordernum desc";
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.tenderapprovalTableAdapter.Fill(this.tenderapprovalautoDataSet2.tenderapproval);

            if (this.textBox11.Text == "")
            {
                this.textBox8.Text = "2321";
            }

            else
            {
                int x = int.Parse(this.textBox11.Text);
                x++;
                this.textBox8.Text = x.ToString();
            }
        }
    }
}
