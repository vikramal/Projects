using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;
using SmsClient;
using System.Text;

namespace ComputerBazar
{
    public partial class cardpayment : System.Web.UI.Page
    {
        
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        string x = "";
        SerialPort sp = new SerialPort();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
               x = Session["un"].ToString();
            }
            else
            {
                Response.Redirect("customerlogin.aspx");
            }

            this.amount_lbl.Text = Session["total"].ToString();

            RangeValidator1.MinimumValue = DateTime.Now.ToString("d");
            RangeValidator1.MaximumValue = DateTime.Today.AddYears(+20).ToString("d");
        }

        protected void finish_btn_Click(object sender, EventArgs e)
        {
            string cardno = this.cardnum_txt.Text;
            string cno = this.phno_txt.Text;
            Random randomNumber = new Random();
            int generatedNo = randomNumber.Next(100, int.MaxValue);
            string verificationcode = Convert.ToString(generatedNo);
            sp.PortName = "COM12";
            sp.Open();
            string phno = "";
            string name = "";

            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("select * from customer where email='" + x + "'", con1);
            cmd1.Connection = con1;
            con1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                phno = dr1["phno"].ToString();
                name = dr1["name"].ToString();
            }
            con1.Close();

            if (this.phno_txt.Text == phno)
            {
                phno = char.ConvertFromUtf32(34) + this.phno_txt.Text + char.ConvertFromUtf32(34);
                sp.Write("AT+CMGF=1" + char.ConvertFromUtf32(13));
                sp.Write("AT+CMGS=" + phno + char.ConvertFromUtf32(13));
                sp.Write("Hello " + name + " Your Payment Verfication Code is " + generatedNo.ToString() + " Please enter the Code to confirm your ORDER " + char.ConvertFromUtf32(26) + char.ConvertFromUtf32(13));
                sp.Close();


                SqlConnection con2 = new SqlConnection(s);
                SqlCommand cmd2 = new SqlCommand("update cardpayment set verificationcode='"+ verificationcode +"',cardno='" + this.cardnum_txt.Text + "',cardname='" + this.cardname_txt.Text + "',cardexpire='" + this.cardexpire_txt.Text + "' where email='" + x + "'", con2);
                cmd2.Connection = con2;
                con2.Open();
                cmd2.ExecuteNonQuery();
                con2.Close();

                Response.Redirect("cardpayment1.aspx");

            }
            else
            {
                this.message_lbl.Text = "Enter Correct Phone number";
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            this.cardexpire_txt.Text = Calendar1.SelectedDate.ToString("d");
        }

        protected void cardexpire_txt_TextChanged(object sender, EventArgs e)
        {
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}