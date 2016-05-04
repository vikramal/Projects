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
    public partial class tenderview : Form
    {
        public tenderview()
        {
            InitializeComponent();
        }

        private void tenderview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tenderapprovalviewDataSet2.tenderapproval' table. You can move, or remove it, as needed.
            this.tenderapprovalTableAdapter1.Fill(this.tenderapprovalviewDataSet2.tenderapproval);
            // TODO: This line of code loads data into the 'tenderapprovalautoDataSet2.tenderapproval' table. You can move, or remove it, as needed.
            this.tenderapprovalTableAdapter.Fill(this.tenderapprovalautoDataSet2.tenderapproval);
            // TODO: This line of code loads data into the 'tenderrejectviewDataSet2.tenderreject' table. You can move, or remove it, as needed.
            this.tenderrejectTableAdapter1.Fill(this.tenderrejectviewDataSet2.tenderreject);
            // TODO: This line of code loads data into the 'tenderrejDataSet2.tenderreject' table. You can move, or remove it, as needed.
            this.tenderrejectTableAdapter.Fill(this.tenderrejDataSet2.tenderreject);
            // TODO: This line of code loads data into the 'tenderappDataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter1.Fill(this.tenderappDataSet2.tenderapply);
            // TODO: This line of code loads data into the 'tenapplyautoDataSet2.tenderapply' table. You can move, or remove it, as needed.
            this.tenderapplyTableAdapter.Fill(this.tenapplyautoDataSet2.tenderapply);
            // TODO: This line of code loads data into the 'tenderpublish2DataSet2.tenderpublish' table. You can move, or remove it, as needed.
            this.tenderpublishTableAdapter1.Fill(this.tenderpublish2DataSet2.tenderpublish);
            // TODO: This line of code loads data into the 'tenderpublish1DataSet2.tenderpublish' table. You can move, or remove it, as needed.
            this.tenderpublishTableAdapter.Fill(this.tenderpublish1DataSet2.tenderpublish);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderpublish where tenderdocnum='" + this.comboBox1.Text + "'";
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderpublishTableAdapter1.Fill(this.tenderpublish2DataSet2.tenderpublish);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderpublish";
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderpublishTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderpublishTableAdapter1.Fill(this.tenderpublish2DataSet2.tenderpublish);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderapply where applicationnum='"+this.comboBox2.Text+"'";
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderapplyTableAdapter1.Fill(this.tenderappDataSet2.tenderapply);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderapply";
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapplyTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderapplyTableAdapter1.Fill(this.tenderappDataSet2.tenderapply);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderreject where applicationnum='" + this.comboBox3.Text + "'";
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderrejectTableAdapter1.Fill(this.tenderrejectviewDataSet2.tenderreject);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.CommandText = "select * from tenderreject";
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderrejectTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.tenderrejectTableAdapter1.Fill(this.tenderrejectviewDataSet2.tenderreject);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.CommandText = "select * from tenderapproval where applicationnum='" + this.comboBox4.Text + "'";
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.tenderapprovalTableAdapter.Fill(this.tenderapprovalautoDataSet2.tenderapproval);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.Connection.Open();
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.CommandText = "select * from tenderapproval";
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.ExecuteNonQuery();
            this.tenderapprovalTableAdapter.Adapter.SelectCommand.Connection.Close();

            this.tenderapprovalTableAdapter.Fill(this.tenderapprovalautoDataSet2.tenderapproval);
        }
    }
}
