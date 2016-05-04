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
    public partial class customeraccount : System.Web.UI.Page
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
            SqlCommand cmd = new SqlCommand("select * from customer where email='" + x + "'", con);
            cmd.Parameters.AddWithValue("@email", x);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.name_txt.Text = dr["name"].ToString();
                this.mobno_txt.Text = dr["phno"].ToString();
                this.landno_txt.Text = dr["landno"].ToString();
                this.gender_txt.Text = dr["gender"].ToString();
                this.address_txt.Text = dr["address"].ToString();
                this.landmark_txt.Text = dr["landmark"].ToString();
                this.city_txt.Text = dr["city"].ToString();
                this.state_txt.Text = dr["state"].ToString();
                this.pincode_txt.Text = dr["pincode"].ToString();
            }
            con.Close();
        }

        protected void back_but_Click(object sender, EventArgs e)
        {
            Response.Redirect("customerhome.aspx");
        }
    }
}