using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;


namespace ComputerBazar
{
    public partial class retailerhome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["un"] != null)
            {
                string x = Session["un"].ToString();
                this.welcome_lbl.Text = "WELCOME TO ComputerBazar " + x.ToUpper();
            }
            else
            {
                Response.Redirect("retailerlogin.aspx");
            }
        }
    }
}