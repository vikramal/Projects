using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace ComputerBazar
{
    public partial class customerorder : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        string x = "";
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

            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from purchase where uname='"+ x +"'",con);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
        }
    }
}