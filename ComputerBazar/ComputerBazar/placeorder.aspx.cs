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
    public partial class placeorder : System.Web.UI.Page
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
                Response.Redirect("customerlogin.aspx");
            }

            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from temp_buy where uname='"+ x +"'", con);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();
            this.amount_lbl.Text = Session["total"].ToString();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("delete temp_buy where uname='" + x + "'", con2);
            cmd2.Connection = con2;
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerhome.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("order.aspx");
        }
    }
}