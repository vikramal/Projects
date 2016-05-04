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
    public partial class customerlogin : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from customer where email='" + this.name_txt.Text + "' and password='" + this.pass_txt.Text + "' and status='yes'", con);
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@name", this.name_txt.Text);
            cmd.Parameters.AddWithValue("@password", this.pass_txt.Text);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                this.error.Text = "Invalid Username and Password or Please Confirm the mail sent by ComputerBazar.com team";
            }
            else
            {
                Response.Write("SUCCESS");
                Session["un"] = this.name_txt.Text;
                Session["total"] = 0;
                Response.Redirect("customerhome.aspx");
            }
            dr.Close();
            con.Close();
        }
    }
}