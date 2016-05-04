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
    public partial class cutomerdelete : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        string x = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
               string x = Session["un"].ToString();
            }
            else
            {
                Response.Redirect("customerlogin.aspx");
            }
        }

        protected void save_but_Click(object sender, EventArgs e)
        {
            if (this.email_txt.Text == Session["un"].ToString())
            {
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("delete from customer where email='" + this.email_txt.Text + "' and password='" + this.pass_txt.Text + "' and phno='" + this.ph_txt.Text + "'", con);
                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Redirect("index.aspx");
            }
            else
            {
                this.message_lbl.Text = "Please Enter Your E-mail Address";
            }
        }
    }
}