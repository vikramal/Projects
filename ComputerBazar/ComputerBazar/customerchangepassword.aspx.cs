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
    public partial class custchangepassword : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changepassword(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            string x = Session["un"].ToString();
            SqlCommand cmd = new SqlCommand("select * from customer where email='" + x + "' and password='" + this.retcurrentpass_txt.Text + "'", con);
            cmd.Parameters.AddWithValue("@email", x);
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
                SqlCommand cmd1 = new SqlCommand("update customer set password='" + this.retpass_txt.Text + "' where email='" + x + "'", con1);
                cmd1.Connection = con1;
                con1.Open();
                cmd1.ExecuteNonQuery();
                con1.Close();
                Response.Redirect("customerhome.aspx");
            }
            dr.Close();
            con.Close();
        }
    }
}