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
    public partial class about : Form
    {
        public about()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Hide();
            mainlogin l = new mainlogin();
            l.ShowDialog();
        }

        private void about_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Icon = new System.Drawing.Icon(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"E:\capp\images\icon\a.ico");
            notifyIcon1.Visible = true;
            notifyIcon1.Text = "District Commissioner Office";
        }
    }
}
