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
    public partial class retailerreg : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "";
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from retailer order by id", con);
            cmd.Connection = con;
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows == false)
            {
                a = "1000";
            }
            else
            {
                while (dr.Read())
                {
                    a = dr["id"].ToString();
                    int b = Convert.ToInt32(a);
                    b++;
                    a = b.ToString();
                }
            }
            dr.Close();
            con.Close();
            this.id_txt.Text = a;
        }

        protected void save_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("insert into retailer values('" + this.id_txt.Text + "','" + this.name_txt.Text + "','" + this.pass_txt.Text + "','" + this.email_txt.Text + "','" + this.add_txt.Text + "','" + this.ph_txt.Text + "','" + this.tin_txt.Text + "','" + this.pan_txt.Text + "',' no ')", con);
            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("RECORD SAVED");
            this.id_txt.Text = "";
            this.name_txt.Text = "";
            this.pass_txt.Text = "";
            this.repass_txt.Text = "";
            this.email_txt.Text = "";
            this.add_txt.Text = "";
            this.ph_txt.Text = "";
            this.tin_txt.Text = "";
            this.pan_txt.Text = "";
            Response.Redirect("index.aspx");
        }
    }
}