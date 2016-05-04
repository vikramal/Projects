using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Globalization;

namespace ComputerBazar
{
    public partial class viewproduct1 : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        string x = "";
        double tot = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
                x = Session["un"].ToString();
                tot = Convert.ToInt64(Session["total"].ToString());
            }
            else
            {
                Response.Redirect("customerlogin.aspx");
            }

            string pid = Request.QueryString["pid"].ToString();
            string fpath = "~/";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from product where pid='"+pid+"'", con);
            cmd.Parameters.AddWithValue("@pid", pid);

            cmd.Connection = con;
            con.Open();

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                this.pname_lbl.Text = dr["pname"].ToString();
                this.pdesc_lbl.Text = dr["pdescription"].ToString();
                this.pprice_lbl.Text = dr["pprice"].ToString();
                this.pcat_lbl.Text = dr["pcategory"].ToString();
                fpath = fpath+dr["pimage"].ToString();
                this.image_lbl.ImageUrl = fpath;
            }
            dr.Close();
            con.Close();
        }

        protected void buy_btn_Click(object sender, EventArgs e)
        {
            string pid1 = "";
            string rname = "";
            string image = "";
            string pid = Request.QueryString["pid"].ToString();
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from product where pid='"+pid+"'", con);
            cmd.Parameters.AddWithValue("@pid", pid);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
  
            while (dr.Read())
            {
                pid1 = dr["pid"].ToString();
                this.pname_lbl.Text = dr["pname"].ToString();
                this.pdesc_lbl.Text = dr["pdescription"].ToString();
                this.pprice_lbl.Text = dr["pprice"].ToString();
                image = dr["pimage"].ToString();
                rname = dr["rname"].ToString();
                tot = tot + Convert.ToInt64(dr["pprice"].ToString());
                Session["total"] = tot;
            }
            
            con.Close();
            SqlCommand cmd1 = new SqlCommand("insert into temp_buy values('" + pid1 + "','" + this.pname_lbl.Text + "','" + this.pdesc_lbl.Text + "','"+ image +"','" + this.pprice_lbl.Text + "','" + rname + "','"+ x +"')", con);
            cmd1.Connection = con;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
            Response.Redirect("placeorder.aspx");
        }
   }
}