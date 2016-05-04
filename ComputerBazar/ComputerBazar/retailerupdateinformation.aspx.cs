using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;


namespace ComputerBazar
{
    public partial class retailerupdateinformation : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string x = "";
            if (Session["un"] != null)
            {
                x = Session["un"].ToString();
            }
            else
            {
                Response.Redirect("retailerlogin.aspx");
            }

            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from retailer where name='" + x + "'", con);
            cmd.Parameters.AddWithValue("@pid", this.id_txt.Text);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                this.id_txt.Text = dr["id"].ToString();
                this.name_txt.Text = dr["name"].ToString();
                this.email_txt.Text = dr["email"].ToString();
                this.add_txt.Text = dr["address"].ToString();
                this.ph_txt.Text = dr["phno"].ToString();
                this.tin_txt.Text = dr["tinno"].ToString();
                this.pan_txt.Text = dr["panno"].ToString();
            }
            con.Close();
        }

        protected void update_but_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("update retailer set name='" + this.name_txt.Text + "',email='" + this.email_txt.Text + "',address='"+this.add_txt.Text+"',phno='"+this.ph_txt.Text+"',tinno='"+this.tin_txt.Text+"',panno='"+this.pan_txt.Text+"' where id='" + this.id_txt.Text + "'", con1);
            cmd1.Connection = con1;
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();
            this.message_lbl.Text = "Information Updated Successfully";
        }
    }
}