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
    public partial class showinvoices : System.Web.UI.Page
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
                Response.Redirect("retailerlogin.aspx");
            }
            SqlConnection con2 = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("select * from purchase where rname='" + x + "'", con2);
            cmd2.Connection = con2;
            con2.Open();
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter(cmd2);
            da2.Fill(dt2);
            GridView1.DataSource = dt2;
            GridView1.DataBind();
            con2.Close();
        }
    }
}