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
    public partial class retchangepassword : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        string x = "";
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

        }

        protected void changepassword(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            string x = Session["un"].ToString();
            SqlCommand cmd = new SqlCommand("select * from retailer where username='" + x + "' and password='" + this.retcurrentpass_txt.Text + "'", con);
            cmd.Parameters.AddWithValue("@username", x);
            cmd.Parameters.AddWithValue("@password", this.retcurrentpass_txt.Text);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                this.error_lbl.Text = "Current Password is Wrong";
                this.retcurrentpass_txt.Text = "";
                this.retpass_txt.Text = "";
                this.retrepass_txt.Text = "";
            }
            else
            {
                SqlConnection con1 = new SqlConnection(s);
                SqlCommand cmd1 = new SqlCommand("update retailer set password='" + this.retpass_txt.Text + "' where username='" + x + "'",con1);
                cmd1.Connection = con1;
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                Response.Redirect("retailerhome.aspx");
            }
            dr.Close();
            con.Close();
        }
    }
}