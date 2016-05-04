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
    public partial class updateproduct : System.Web.UI.Page
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
            
            if (!IsPostBack)
            {
                SqlConnection con = new SqlConnection(s);
                SqlCommand cmd = new SqlCommand("select * from product where rname='" + x + "'", con);
                cmd.Connection = con;
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                pid_list.DataSource = ds;
                pid_list.DataTextField = "pid";
                pid_list.DataValueField = "pid";
                pid_list.DataBind();
                con.Close();
            }
        }

        protected void pid_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("select * from product where pid='" + this.pid_list.Text + "'", con1);
            cmd1.Parameters.AddWithValue("@pid", this.pid_list.Text);
            cmd1.Connection = con1;
            con1.Open();
            SqlDataReader dr1 = cmd1.ExecuteReader();
            while (dr1.Read())
            {
                this.pname_txt.Text = dr1["pname"].ToString();
                this.pcat_txt.Text = dr1["pcategory"].ToString();
                this.cmpname_txt.Text = dr1["cname"].ToString();
                this.pdis_txt.Text = dr1["pdescription"].ToString();
                this.price_txt.Text = dr1["pprice"].ToString();
                this.pimage_img.ImageUrl = dr1["pimage"].ToString();
            }
            con1.Close();
        }


        protected void update_but_Click(object sender, EventArgs e)
        {
            SqlConnection con2 = new SqlConnection(s);
            SqlCommand cmd2 = new SqlCommand("update product set pdescription='" + this.pdis_txt.Text + "',pprice='"+this.price_txt.Text+"' where pid='" + this.pid_list.Text + "'", con2);
            cmd2.Connection = con2;
            con2.Open();
            cmd2.ExecuteNonQuery();
            con2.Close();
            this.message_lbl.Text = "Product Updated Successfully";
        }
    }
}