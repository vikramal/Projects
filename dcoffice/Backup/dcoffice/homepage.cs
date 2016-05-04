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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nic n = new nic();
            n.ShowDialog();
        }

        private void villageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void healthToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homepage_Load(object sender, EventArgs e)
        {

        }

        private void roadToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            villagepanch vl = new villagepanch();
            vl.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            updatevillpanch upv = new updatevillpanch();
            upv.ShowDialog();
        }

        private void addNewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            townpanchdetails tp = new townpanchdetails();
            tp.ShowDialog();
        }

        private void updateAndDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            townupdate tp = new townupdate();
            tp.ShowDialog();
        }

        private void addNewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            districtdetails d = new districtdetails();
            d.ShowDialog();
        }

        private void updateAndDeleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            districtupdate du = new districtupdate();
            du.ShowDialog();
        }

        private void landNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            landnotification ln = new landnotification();
            ln.ShowDialog();
        }

        private void tenderPublishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenderpublish tp = new tenderpublish();
            tp.ShowDialog();
        }

        private void landDeNotificationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            denotification d = new denotification();
            d.ShowDialog();
        }

        private void agricultureToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void roadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            road r = new road();
            r.ShowDialog();
        }

        private void landAllocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            landallocation l = new landallocation();
            l.ShowDialog();
        }

        private void hospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hospital h = new hospital();
            h.ShowDialog();
        }

        private void agricultureToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            agriculture a = new agriculture();
            a.ShowDialog();
        }

        private void landConversionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            landconversion l = new landconversion();
            l.ShowDialog();
        }

        private void budgetApprovalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            budget b = new budget();
            b.ShowDialog();
        }

        private void salaryDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employee em = new employee();
            em.ShowDialog();
        }

        private void salaryDetailsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            salary s = new salary();
            s.ShowDialog();
        }

        private void addVIllagePanchayatAndVillagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addvillage a = new addvillage();
            a.ShowDialog();
        }

        private void endonmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grants g = new grants();
            g.ShowDialog();
        }

        private void tenderApplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenderapply t = new tenderapply();
            t.ShowDialog();
        }

        private void tenderRejectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenderreject r = new tenderreject();
            r.ShowDialog();
        }

        private void tenderApprovalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tenderapproval td = new tenderapproval();
            td.ShowDialog();
        }

        private void rejectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            nomination n = new nomination();
            n.ShowDialog();
        }

        private void nominationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            electiondetails ed = new electiondetails();
            ed.ShowDialog();
        }

        private void sendMailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mail m = new mail();
            m.ShowDialog();
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void boomiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void budgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void punchayatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tenderToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void employeeToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void declarationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rejection re = new rejection();
            re.ShowDialog();
        }
    }
}
