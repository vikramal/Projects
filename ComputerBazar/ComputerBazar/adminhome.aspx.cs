using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ComputerBazar
{
    public partial class adminhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
                string x = Session["un"].ToString();
            }
            else
            {
                Response.Redirect("adminlogin.aspx");
            }
        }
    }
}