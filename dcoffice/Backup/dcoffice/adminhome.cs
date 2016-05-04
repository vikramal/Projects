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
    public partial class adminhome : Form
    {
        public adminhome()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            boomireport bm = new boomireport();
            bm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            budgetreport br = new budgetreport();
            br.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panchayatreport pr = new panchayatreport();
            pr.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            electionreport er = new electionreport();
            er.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tenderreport tr = new tenderreport();
            tr.ShowDialog();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            boomiviews bv = new boomiviews();
            bv.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            employeereport er = new employeereport();
            er.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            this.label1.Text = dt.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            addemp a = new addemp();
            a.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mainlogin m = new mainlogin();
            this.Hide();
            m.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            updemppass u = new updemppass();
            u.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            empdel d = new empdel();
            d.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            endowmentreports er = new endowmentreports();
            er.ShowDialog();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            mail m = new mail();
            m.ShowDialog();
        }

        private void adminhome_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            budgetview br = new budgetview();
            br.ShowDialog();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panchayatview pv = new panchayatview();
            pv.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            endowmentview ev = new endowmentview();
            ev.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            employeeview ev = new employeeview();
            ev.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tenderview tv = new tenderview();
            tv.ShowDialog();
        }
    }
}
