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
    public partial class index : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd = new SqlCommand("select * from product", con);
            cmd.Connection = con;
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            GridView1.DataSource = dt;
            GridView1.DataBind();
            con.Close();

            SqlConnection con1 = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("delete from temp_buy", con);
            cmd1.Connection = con1;
            con1.Open();
            cmd1.ExecuteNonQuery();
            con1.Close();
        }
    }
}