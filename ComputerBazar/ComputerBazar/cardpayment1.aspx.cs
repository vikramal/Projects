using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO.Ports;


namespace ComputerBazar
{
    public partial class cardpayment1 : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        string x = "";
        string code = "";
        string phno = "";
        string name = "";
        string orderno = "";

        SerialPort sp = new SerialPort();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
                x = Session["un"].ToString();
            }
            else
            {
                Response.Redirect("retailerlogin.aspx");
            }

            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from cardpayment where uname='" + x + "'", con);
            cmd.Parameters.AddWithValue("@uname", x);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                code = dr["verificationcode"].ToString();
                name = dr["name"].ToString();
                phno = dr["phno"].ToString();
                orderno = dr["orderid"].ToString();
            }
        }

        protected void finish_btn_Click(object sender, EventArgs e)
        {
            if (this.phno_txt.Text == phno && this.code_txt.Text == code)
            {
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd1 = new SqlCommand("update cardpayment set status=' confirmed ' where phno='" + phno + "'", con);
                cmd1.Connection = con;
                con.Open();
                cmd1.ExecuteNonQuery();
                con.Close();

                SqlConnection con1 = new SqlConnection(s);
                SqlCommand cmd2 = new SqlCommand("update purchase set status=' confirmed ' where uname='" + x + "'", con1);
                cmd2.Connection = con1;
                con1.Open();
                cmd2.ExecuteNonQuery();
                con1.Close();

                sp.PortName = "COM12";
                sp.Open();
                phno = char.ConvertFromUtf32(34) + this.phno_txt.Text + char.ConvertFromUtf32(34);
                sp.Write("AT+CMGF=1" + char.ConvertFromUtf32(13));
                sp.Write("AT+CMGS=" + phno + char.ConvertFromUtf32(13));
                sp.Write("Hello " + name + " Your Payment of ORDER NO: " + orderno + " has been confirmed and Payment has been done Successful " + char.ConvertFromUtf32(26) + char.ConvertFromUtf32(13));
                sp.Close();
                Session["total"] = 0;
                Response.Redirect("index.aspx");
            }
            else
            {
                this.message_lbl.Text = "Please enter correct Phone Number and Verification Code";
            }
        }
    }
}