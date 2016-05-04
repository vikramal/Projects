using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Text.RegularExpressions;

namespace dcoffice
   
{
    public partial class mail : Form
    {
        public mail()
        {
            InitializeComponent();
        }
        static bool IsEmailid(string s)

            {
               // return Regex.IsMatch(s, @"^([0-9a-zA-Z]([-./w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-/w]*[0-9a-zA-Z]/.)+[a-zA-Z]{2,9})$");
                //return Regex.IsMatch(s, @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+){3,5}$");
                return Regex.IsMatch(s,@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            }

        private void button1_Click(object sender, EventArgs e)
        {  

            if (this.textBox1.Text == "")
            {
                MessageBox.Show("Enter Receipitants.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox1.Focus();
            }
            
            else if (this.textBox2.Text == "")
            {
                MessageBox.Show("Enter Subject.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox2.Focus();
            }

            else if (this.richTextBox1.Text == "")
            {
                MessageBox.Show("Enter Body of the Mail.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.richTextBox1.Focus();
            }

            else if (this.textBox3.Text == "")
            {
                MessageBox.Show("Enter your username.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox3.Focus();
            }

            else if (this.textBox4.Text == "")
            {
                MessageBox.Show("Enter your Password.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.textBox4.Focus();
            }
            else
            {
                try
                {
                    if (this.textBox3.Text.Contains("@gmail.com"))
                    {
                        this.button1.Enabled = false;
                        MailMessage message = new MailMessage();
                        message.From = new MailAddress(this.textBox3.Text);
                        message.Subject = this.textBox2.Text;
                        message.Body = this.richTextBox1.Text;

                        System.Net.Mail.Attachment at;
                        at = new System.Net.Mail.Attachment(this.textBox5.Text);
                        message.Attachments.Add(at);

                        foreach (string m in textBox1.Text.Split(';'))
                            message.To.Add(m);

                        SmtpClient client = new SmtpClient();
                        client.Credentials = new NetworkCredential(this.textBox3.Text, this.textBox4.Text);
                        client.Host = "smtp.gmail.com";
                        client.Port = 587;
                        client.EnableSsl = true;
                        client.Send(message);

                        MessageBox.Show("Mail sent Sucessfully.", "Sucess...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    else
                    {

                        MessageBox.Show("Gmail Account Required.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox3.Focus();
                        return;
                    }
                }
                catch { MessageBox.Show("Make sure your Username and password is correct.", "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                finally { this.button1.Enabled = true; }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBox5.Text = openFileDialog1.FileName;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
