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
    public partial class loading : Form
    {
        public loading()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Value = this.progressBar1.Value + 1;
            if (this.progressBar1.Value == 100)
            {
                this.timer1.Stop();
                this.Hide();
                homepage h = new homepage();
                h.ShowDialog();
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void loading_Load(object sender, EventArgs e)
        {
        }
    }
}
