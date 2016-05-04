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
    public partial class employeeview : Form
    {
        public employeeview()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void employeeview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salaryviewDataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter1.Fill(this.salaryviewDataSet2.salary);
            // TODO: This line of code loads data into the 'salsaveDataSet2.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.salsaveDataSet2.salary);
            // TODO: This line of code loads data into the 'employee1DataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter1.Fill(this.employee1DataSet2.employee);
            // TODO: This line of code loads data into the 'empDataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.empDataSet2.employee);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.employeeTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.employeeTableAdapter1.Adapter.SelectCommand.CommandText = "select * from employee where empid='" + this.comboBox2.Text + "'";
            this.employeeTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.employeeTableAdapter1.Fill(this.employee1DataSet2.employee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.employeeTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.employeeTableAdapter1.Adapter.SelectCommand.CommandText = "select * from employee";
            this.employeeTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.employeeTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.employeeTableAdapter1.Fill(this.employee1DataSet2.employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.salaryTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.salaryTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.salaryTableAdapter1.Adapter.SelectCommand.CommandText = "select * from salary where empid='" + this.comboBox1.Text + "'";
            this.salaryTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.salaryTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.salaryTableAdapter1.Fill(this.salaryviewDataSet2.salary);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.salaryTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.salaryTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.salaryTableAdapter1.Adapter.SelectCommand.CommandText = "select * from salary";
            this.salaryTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.salaryTableAdapter1.Adapter.SelectCommand.Connection.Close();

            this.salaryTableAdapter1.Fill(this.salaryviewDataSet2.salary);
        }
    }
}
