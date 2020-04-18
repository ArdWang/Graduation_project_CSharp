using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class content_content : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Session["name"] ==null)
            {
                lbname.Text = "游客";
            }
            if (Session["name"] != null)
            {
                Session.Timeout = 30;
                lbname.Text = Session["name"].ToString();
            }
        }
    }


    protected void lbtnexit_Click(object sender, EventArgs e)
    {
        Session.Remove("name");
        Response.Redirect("../sy_shouye.aspx");
    }
    
}
