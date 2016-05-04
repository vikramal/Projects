using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ComputerBazar
{
    public partial class customerhome : System.Web.UI.Page
    {
        string x = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
                x = Session["un"].ToString();
                this.welcome_lbl.Text = "WELCOME TO ComputerBazar " + x.ToUpper();
            }
            else
            {
                Response.Redirect("customerlogin.aspx");
            }
            string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("delete from purchase where status='not confirmed' and uname='" + x + "'", con1);
            cmd1.Connection = con1;
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();

            SqlConnection con2 = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("delete from cardpayment where status='not confirmed' and uname='" + x + "'", con2);
            cmd2.Connection = con2;
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();

            SqlConnection con3 = new SqlConnection(s);
            SqlCommand cmd3 = new SqlCommand("delete from codpurchase where status='not confirmed' and uname='" + x + "'", con2);
            cmd3.Connection = con3;
            con3.Open();
            cmd3.ExecuteNonQuery();
            con3.Close();
        }
    }
}