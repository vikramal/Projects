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
    public partial class bill1 : System.Web.UI.Page
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

            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("select * from customer where email='" + x + "'", con1);
            cmd1.Connection = con1;
            con1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                this.custname_lbl.Text = dr1["name"].ToString();
                this.address_lbl.Text = dr1["address"].ToString();
                this.cno_lbl.Text = dr1["phno"].ToString();
                this.email_lbl.Text = dr1["email"].ToString();
            }
            con1.Close();


            SqlConnection con2 = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("select * from purchase where uname='" + x + "'", con2);
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