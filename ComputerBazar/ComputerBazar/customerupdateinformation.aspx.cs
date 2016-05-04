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
    public partial class customerupdateinformation : System.Web.UI.Page
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
                this.mobno_txt.Text = dr["phno"].ToString();
            }
            con.Close();
        }

        protected void save_but_Click(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("update customer set name='" + this.name_txt.Text + "',phno='" + this.mobno_txt.Text + "',landno='" + this.landno_txt.Text + "',gender='" + this.gender_list.SelectedValue.ToString() + "',address='" + this.address_txt.Text + "',landmark='" + this.landmark_txt.Text + "',city='" + this.city_txt.Text + "',state='" + this.state_txt.Text + "',country='" + this.country_txt.Text + "',pincode='" + this.pincode_txt.Text + "' where email='" + x + "'", con1);
            cmd1.Connection = con1;
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();
            this.message_lbl.Text = "Information Updated Successfully";
        }

        protected void pincode_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}