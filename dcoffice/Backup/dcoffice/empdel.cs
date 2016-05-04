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
    public partial class empdel : Form
    {
        public empdel()
        {
            InitializeComponent();
        }

        private void empdel_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'login6DataSet2.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter1.Fill(this.login6DataSet2.login);
            // TODO: This line of code loads data into the 'login5DataSet2.login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.login5DataSet2.login);

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.loginTableAdapter1.Adapter.SelectCommand.Connection.Open();
            this.loginTableAdapter1.Adapter.SelectCommand.CommandType = CommandType.Text;
            this.loginTableAdapter1.Adapter.SelectCommand.CommandText = "delete from login where username = '" + this.comboBox2.Text + "'";
            this.loginTableAdapter1.Adapter.SelectCommand.ExecuteNonQuery();
            this.loginTableAdapter1.Adapter.SelectCommand.Connection.Close();

            MessageBox.Show("Employee record Deleted Successfully", "sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            this.loginTableAdapter.Fill(this.login5DataSet2.login);
        }
    }
}
