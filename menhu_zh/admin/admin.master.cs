using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["name"] != null)
            {
                Session.Timeout = 60;
                lbname.Text = Session["name"].ToString();
            }
        }
    }
    protected void btnqsy_Click(object sender, EventArgs e)
    {
        Response.Redirect("../sy_shouye.aspx");
    }
    protected void btnhsy_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_zy.aspx");
    }
    protected void lbexit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
        Session.Remove("name");
    }
}
