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
    public partial class retailerlogin : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from retailer where name='" + this.name_txt.Text + "' and password='" + this.pass_txt.Text + "' and status='yes'", con);
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@name", this.name_txt.Text);
            cmd.Parameters.AddWithValue("@password", this.pass_txt.Text);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                this.error.Text = "Invalid Username and Password or please contact-us in ComputrerBazar office for futher deatils with all required documents for Registration";
            }
            else
            {
                Response.Write("SUCCESS");
                Session["un"] = this.name_txt.Text;
                Response.Redirect("retailerhome.aspx");
            }
            dr.Close();
            con.Close();
        }
    }
}