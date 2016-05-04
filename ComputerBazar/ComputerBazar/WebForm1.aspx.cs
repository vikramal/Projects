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
    public partial class WebForm1 : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["CBconnectionstring"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("select distinct(rname) from purchase", con);
                cmd.Connection = con;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                retailername_list.DataSource = ds;
                retailername_list.DataTextField = "rname";
                retailername_list.DataValueField = "rname";
                retailername_list.DataBind();
                con.Close();
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            this.TextBox1.Text = Calendar1.SelectedDate.ToString("d");
        }

        protected void retailername_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            //SqlConnection con1 = new SqlConnection(s);
            //SqlCommand cmd1 = new SqlCommand("select * from purchse where rname='" + this.retailername_list.Text + "'", con1);
            //cmd1.Parameters.AddWithValue("@pid", this.retailername_list.Text);
            //cmd1.Connection = con1;
            //con1.Open();
            //SqlDataReader dr1 = cmd1.ExecuteReader();
            //while (dr1.Read())
            //{
            //    this.pname_txt.Text = dr1["pname"].ToString();
            //    this.pcat_txt.Text = dr1["pcategory"].ToString();
            //    this.cmpname_txt.Text = dr1["cname"].ToString();
            //    this.pdis_txt.Text = dr1["pdescription"].ToString();
            //    this.price_txt.Text = dr1["pprice"].ToString();
            //    this.pimage_img.ImageUrl = dr1["pimage"].ToString();
            //}
            //con1.Close();
        }

        protected void details_but_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from purchase where rname='" + this.retailername_list.Text + "' and orderdate='" + this.TextBox1.Text + "'", con);
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