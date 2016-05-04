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
    public partial class admin : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from admin where username='" + this.name_txt.Text + "' and password='" + this.pass_txt.Text + "'", con);
            cmd.Connection = con;

            cmd.Parameters.AddWithValue("@username", this.name_txt.Text);
            cmd.Parameters.AddWithValue("@password", this.pass_txt.Text);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                this.error.Text = "Invalid Username and Password";
            }
            else
            {
                Session["un"] = this.name_txt.Text;
                Response.Redirect("adminhome.aspx");
            }
            dr.Close();
            con.Close();
        }
    }
}