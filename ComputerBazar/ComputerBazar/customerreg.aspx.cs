using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Net.Mail;
using SmsClient;


namespace ComputerBazar
{
    public partial class customerreg : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        SerialPort sp = new SerialPort();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void save_but_Click(object sender, EventArgs e)
        {
            //SendSms sms = new SendSms();

            //string message = "HI " + this.email_txt.Text + " thank you for registering with ComputerBazaar. your Username is " + this.email_txt.Text + "and password is " + this.pass_txt.Text + ". thank you. visit again" + char.ConvertFromUtf32(26) + char.ConvertFromUtf32(13);
            //sms.send("8123500958", "vikram1038", this.ph_txt.Text, message);

            sp.PortName = "COM12";
            sp.Open();
            string phno;
            phno = char.ConvertFromUtf32(34) + this.ph_txt.Text + char.ConvertFromUtf32(34);
            sp.Write("AT+CMGF=1" + char.ConvertFromUtf32(13));
            sp.Write("AT+CMGS=" + phno + char.ConvertFromUtf32(13));
            sp.Write("HI " + this.email_txt.Text + " thank you for registering with ComputerBazaar. your Username is " + this.email_txt.Text + "and password is " + this.pass_txt.Text + ". thank you. visit again" + char.ConvertFromUtf32(26) + char.ConvertFromUtf32(13));
            sp.Close();

            MailMessage m = new MailMessage();
            SmtpClient sc = new SmtpClient();

            try
            {
                string link = "";

                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("insert into customer values('" + this.email_txt.Text + "','" + this.pass_txt.Text + "','" + 0 + "','" + this.ph_txt.Text + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "','" + 0 + "',' no ')", con);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                link = this.email_txt.ToString();
                m.From = new MailAddress("computerbazar.vmv@gmail.com");
                m.To.Add(new MailAddress(this.email_txt.Text));
                m.Subject = " Welcome to computer Bazaar";
                m.IsBodyHtml = true;
                m.Body = "HI " + this.email_txt.Text + " thank you for registering with ComputerBazaar. your Username is " + this.email_txt.Text + "and password is " + this.pass_txt.Text + ". To login click here http://localhost:10282/verify.aspx?email=" + email_txt.Text;
                sc.Host = "smtp.gmail.com";
                sc.Port = 587;
                sc.Credentials = new System.Net.NetworkCredential("computerbazar.vmv@gmail.com", "vmvshopping");
                sc.EnableSsl = true;
                sc.Send(m);
                this.message_lbl.Text="We Have sent a confirmation to your email address please confirm it and then login to ComputerBazar.com";
                ClientScript.RegisterStartupScript(typeof(Page), "closePage", "window.close();", true);

            }
            catch (Exception ex)
            {
                this.message_lbl.Text=ex.Message;
            }
        }

        protected void ph_txt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}