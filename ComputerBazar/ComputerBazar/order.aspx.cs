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
    public partial class order : System.Web.UI.Page
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

            string a = "";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from purchase order by orderid", con);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                a = "1000";
            }
            else
            {
                while (dr.Read())
                {
                    a = dr["orderid"].ToString();
                    int b = Convert.ToInt32(a);
                    b++;
                    a = b.ToString();
                }
            }
            con.Close();
            this.orderid_txt.Text = a;

            string date=DateTime.Now.ToString("dd-MM-yyyy");
            this.orderdate_txt.Text = date.ToString();

            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("select * from customer where email='"+ x +"'", con);
            cmd1.Connection = con1;
            con1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                this.name_txt.Text=dr1["name"].ToString();
                this.phno_txt.Text = dr1["phno"].ToString();
                this.email_txt.Text=dr1["email"].ToString();
                this.address_txt.Text=dr1["address"].ToString();
                this.landmark_txt.Text=dr1["landmark"].ToString();
                this.city_txt.Text=dr1["city"].ToString();
                this.state_txt.Text=dr1["state"].ToString();
                this.pincode_txt.Text=dr1["pincode"].ToString();
            }
            con1.Close();

            SqlConnection con2 = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("select * from temp_buy where uname='"+ x +"'", con2);
            cmd2.Connection = con2;
            con2.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            con.Close();

            this.grandtotal_txt.Text = Session["total"].ToString();
        }

        protected void orderdate_txt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void clear_btn_Click(object sender, EventArgs e)
        {

        }

        protected void payment_btn_Click(object sender, EventArgs e)
        {
            if (this.card_radio.Checked == false && this.cash_radio.Checked == false)
            {
                this.message_lbl.Text = "Please Chosse the payment options";
            }
            else
            {
                if (this.cash_radio.Checked == true)
                {
                    Random randomNumber = new Random();
                    int generatedNo = randomNumber.Next(100, int.MaxValue);
                    string verificationcode = Convert.ToString(generatedNo);
                    sp.PortName = "COM12";
                    sp.Open();
                    string phno = "";

                    phno = char.ConvertFromUtf32(34) + this.phno_txt.Text + char.ConvertFromUtf32(34);
                    sp.Write("AT+CMGF=1" + char.ConvertFromUtf32(13));
                    sp.Write("AT+CMGS=" + phno + char.ConvertFromUtf32(13));
                    sp.Write("Hello " + this.name_txt.Text + " Your Cash on Delivery Verfication Code is " + generatedNo.ToString() + " Please enter the Code to confirm your ORDER " + char.ConvertFromUtf32(26) + char.ConvertFromUtf32(13));
                    sp.Close();

                    SqlConnection con1 = new SqlConnection(s);
                    SqlCommand cmd1 = new SqlCommand("select * from temp_buy where uname='" + x + "'", con1);
                    cmd1.Connection = con1;
                    con1.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        string pid;
                        string pname;
                        string pdesc;
                        string pimage;
                        string pprice;
                        string rname;
                        string uname;
                        StringBuilder s1 = new StringBuilder();

                        pid = dr1["pid"].ToString();
                        pname = dr1["pname"].ToString();
                        pdesc = dr1["pdescription"].ToString();
                        pimage = dr1["pimage"].ToString();
                        pprice = dr1["pprice"].ToString();
                        rname = dr1["rname"].ToString();
                        uname = dr1["uname"].ToString();

                        SqlConnection con = new SqlConnection(s);
                        SqlCommand cmd = new SqlCommand("insert into codpurchase(orderid,orderdate,name,phno,email,address,landmark,city,state,pincode,rname,uname,verificationcode,location,pid,grandtotal,status) values ('" + this.orderid_txt.Text + "','" + this.orderdate_txt.Text + "','" + this.name_txt.Text + "','" + this.phno_txt.Text + "','" + this.email_txt.Text + "','" + this.address_txt.Text + "','" + this.landmark_txt.Text + "','" + this.city_txt.Text + "','" + this.state_txt.Text + "','" + this.pincode_txt.Text + "','" + rname + "','" + uname + "','" + verificationcode + "',' delhi ','" + s1.Append(pid) + "','" + this.grandtotal_txt.Text + "','not confirmed')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        SqlConnection con3 = new SqlConnection(s);
                        SqlCommand cmd3 = new SqlCommand("insert into purchase(orderid,orderdate,pid,pname,pdescription,pimage,pprice,rname,uname,grandtotal,status) values ('" + this.orderid_txt.Text + "','" + this.orderdate_txt.Text + "','" + pid + "','" + pname + "','" + pdesc + "','" + pimage + "','" + pprice + "','" + rname + "','" + uname + "','" + this.grandtotal_txt.Text + "','not confirmed')", con3);
                        con3.Open();
                        cmd3.ExecuteNonQuery();
                        con3.Close();
                    }
                    con1.Close();

                    Response.Redirect("codpayment.aspx");
                }
                else if (this.card_radio.Checked == true)
                {
                  
                    SqlConnection con1 = new SqlConnection(s);
                    SqlCommand cmd1 = new SqlCommand("select * from temp_buy where uname='" + x + "'", con1);
                    cmd1.Connection = con1;
                    con1.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    while (dr1.Read())
                    {
                        string pid;
                        string pname;
                        string pdesc;
                        string pimage;
                        string pprice;
                        string rname;
                        string uname;
                        StringBuilder s1 = new StringBuilder();

                        pid = dr1["pid"].ToString();
                        pname = dr1["pname"].ToString();
                        pdesc = dr1["pdescription"].ToString();
                        pimage = dr1["pimage"].ToString();
                        pprice = dr1["pprice"].ToString();
                        rname = dr1["rname"].ToString();
                        uname = dr1["uname"].ToString();

                        SqlConnection con = new SqlConnection(s);
                        SqlCommand cmd = new SqlCommand("insert into cardpayment(orderid,orderdate,name,phno,email,address,landmark,city,state,pincode,rname,uname,verificationcode,location,pid,grandtotal,status,cardno,cardname,cardexpire) values ('" + this.orderid_txt.Text + "','" + this.orderdate_txt.Text + "','" + this.name_txt.Text + "','" + this.phno_txt.Text + "','" + this.email_txt.Text + "','" + this.address_txt.Text + "','" + this.landmark_txt.Text + "','" + this.city_txt.Text + "','" + this.state_txt.Text + "','" + this.pincode_txt.Text + "','" + rname + "','" + uname + "','" + 0 + "',' delhi ','" + s1.Append(pid) + "','" + this.grandtotal_txt.Text + "','not confirmed','" + 0 + "','" + 0 + "','" + 0 + "')", con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                        SqlConnection con3 = new SqlConnection(s);
                        SqlCommand cmd3 = new SqlCommand("insert into purchase(orderid,orderdate,pid,pname,pdescription,pimage,pprice,rname,uname,grandtotal,status) values ('" + this.orderid_txt.Text + "','" + this.orderdate_txt.Text + "','" + pid + "','" + pname + "','" + pdesc + "','" + pimage + "','" + pprice + "','" + rname + "','" + uname + "','" + this.grandtotal_txt.Text + "','not confirmed')", con3);
                        con3.Open();
                        cmd3.ExecuteNonQuery();
                        con3.Close();
                    }
                    con1.Close();
                    Response.Redirect("cardpayment.aspx");
                }
            }
        }
    }
}