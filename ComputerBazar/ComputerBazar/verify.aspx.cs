using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace ComputerBazar
{
    public partial class verify : System.Web.UI.Page
    {
        string s = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string email = Request.QueryString["email"].ToString();
            
            SqlConnection con = new SqlConnection(s);
            SqlCommand cmd1 = new SqlCommand("update customer set status='yes' where email='"+ email +"'", con);
            cmd1.Connection = con;
            con.Open();
            cmd1.ExecuteNonQuery();
            con.Close();
        }
    }
}