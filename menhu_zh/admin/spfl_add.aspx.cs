using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_spfl_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            if (Session["name"] != null)
            {
                Session.Timeout = 90;
                lbname.Text = Session["name"].ToString();
            }
        }
    }
    protected void btnhsy_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_zy.aspx");
    }
    protected void btnqsy_Click(object sender, EventArgs e)
    {
        Response.Redirect("../sy_shouye.aspx");
    }
    protected void lbexit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
        Session.Remove("name");
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string spflname = txtflname.Text.Trim();

            if (sybll.Insert_spfl(spflname) > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('发布成功!');", true);
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('发布失败!');", true);
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtflname.Text = "";
    }
}