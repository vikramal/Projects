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
    public partial class deleteretailer : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("select * from retailer", con);
                cmd.Connection = con;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                this.id_drp.DataSource = ds;
                this.id_drp.DataTextField = "id";
                this.id_drp.DataValueField = "id";
                this.id_drp.DataBind();
                con.Close();
            }
        }

        protected void id_drp_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("select * from retailer where id='" + this.id_drp.Text + "'", con1);
            cmd1.Parameters.AddWithValue("@pid", this.id_drp.Text);
            cmd1.Connection = con1;
            con1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                this.id_drp.Text = dr1["id"].ToString();
                this.name_txt.Text = dr1["name"].ToString();
                this.email_txt.Text = dr1["email"].ToString();
                this.address_txt.Text = dr1["address"].ToString();
                this.phno_txt.Text = dr1["phno"].ToString();
                this.panno_txt.Text = dr1["panno"].ToString();
                this.tinno_txt.Text = dr1["tinno"].ToString();
            }
            con1.Close();

        }

        protected void product(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("delete from retailer where id='" + this.id_drp.Text + "'", con);
            cmd1.Connection = con;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
        }

        protected void panno_txt_TextChanged(object sender, EventArgs e)
        {

        }

        protected void pname_txt1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tinno_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}