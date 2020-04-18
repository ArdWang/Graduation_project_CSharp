using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class content_content1 : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["name"] != "")
        {
            Session.Timeout = 30;
            lbname.Text = Session["name"].ToString();
        }
    }
    protected void lbtnexit_Click(object sender, EventArgs e)
    {
        Response.Redirect("../sy_shouye.aspx");
        Session.Remove("name");
    }
}
