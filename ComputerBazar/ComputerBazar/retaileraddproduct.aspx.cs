using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ComputerBazar
{
    public partial class addproduct : System.Web.UI.Page
    {
        string s1 = System.Configuration.ConfigurationManager.ConnectionStrings["cbConnectionString"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string a = "";
            SqlConnection con = new SqlConnection(s1);
            SqlCommand cmd = new SqlCommand("select * from product order by pid", con);
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
                    a = dr["pid"].ToString();
                    int b = Convert.ToInt32(a);
                    b++;
                    a = b.ToString();
                }
            }
            dr.Close();
            con.Close();
            this.pid_txt.Text = a;
            string x = Session["un"].ToString();
        }

        protected void product(object sender, EventArgs e)
        {
            
            string x = Session["un"].ToString();
            string path1;
            SqlConnection con = new SqlConnection(s1);
            if (this.pcat_drop.Text == "laptop")
            {
                path1 = Server.MapPath("~/upload/laptop/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/laptop/"+img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }
                }
            }
            else if (this.pcat_drop.Text == "motherboard")
            {
                path1 = Server.MapPath("~/upload/motherboard/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/motherboard/"+img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "desktop")
            {
                path1 = Server.MapPath("~/upload/desktop/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/desktop/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "hdd")
            {
                path1 = Server.MapPath("~/upload/hdd/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/hdd/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "headphone")
            {
                path1 = Server.MapPath("~/upload/headphone/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/headphone/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "keyboard")
            {
                path1 = Server.MapPath("~/upload/keyboard/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/keyboard/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "monitor")
            {
                path1 = Server.MapPath("~/upload/monitor/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/monitor/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "mouse")
            {
                path1 = Server.MapPath("~/upload/mouse/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/mouse/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "pendrive")
            {
                path1 = Server.MapPath("~/upload/pendrive/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/pendrive/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "printer")
            {
                path1 = Server.MapPath("~/upload/printer/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/printer/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "processor")
            {
                path1 = Server.MapPath("~/upload/processor/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/processor/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "ram")
            {
                path1 = Server.MapPath("~/upload/ram/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/ram/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
            else if (this.pcat_drop.Text == "speaker")
            {
                path1 = Server.MapPath("~/upload/speaker/");
                if (img_upload.HasFile)
                {
                    string ext = Path.GetExtension(img_upload.FileName);
                    if (ext == ".jpg" || ext == ".png")
                    {
                        img_upload.SaveAs(path1 + img_upload.FileName);
                        string iname = "upload/speaker/" + img_upload.FileName;
                        string s = "insert into product values('" + this.pid_txt.Text + "','" + this.pname_txt.Text + "','" + this.pcat_drop.Text + "','" + this.cname_txt.Text + "','" + this.pdesc_txt.Text + "','" + this.price_txt.Text + "','" + iname + "','" + x + "')";

                        SqlCommand cmd = new SqlCommand(s, con);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        this.Label9.Text = "Your Product Has Been Added";

                        this.pid_txt.Text = "";
                        this.pname_txt.Text = "";
                        this.pcat_drop.Text = "";
                        this.pdesc_txt.Text = "";
                        this.cname_txt.Text = "";
                        this.price_txt.Text = "";

                        string a = "";
                        SqlConnection con1 = new SqlConnection(s1);
                        SqlCommand cmd1 = new SqlCommand("select * from product order by pid", con);
                        cmd1.Connection = con1;
                        con1.Open();
                        SqlDataReader dr = cmd1.ExecuteReader();
                        if (dr.HasRows == false)
                        {
                            a = "1000";
                        }
                        else
                        {
                            while (dr.Read())
                            {
                                a = dr["pid"].ToString();
                                int b = Convert.ToInt32(a);
                                b++;
                                a = b.ToString();
                            }
                        }
                        dr.Close();
                        con1.Close();
                        this.pid_txt.Text = a;
                    }

                    else
                    {
                        this.Label9.Text = "You Can Upload Only .jpg and .png Images";
                    }
                }
            }
        }

        protected void price_txt_TextChanged(object sender, EventArgs e)
        {
            //DataTable dtchk = gen.GetDataTable("SPChkChalan");
            //if (dtchk.Rows.Count > 0)
            //{
            //    lblMsg.Text = "Chalan Number Already there";
            //}
            //else
            //{
            //    lblMsg.Text = "Chalan Number Available";
            //}
        }
    }
}

