using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Login_Click(object sender, EventArgs e)
    {
        string username = txtuser.Text.Trim();
        string userpwd = txtpwd.Text.Trim();
        if (sybll.selectlogin(username, userpwd))
        {
            Session["name"] = username;
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('登陆成功!');", true);
            Response.Redirect("admin_zy.aspx?loginname=" + username);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('账号或密码错误!');", true);
    }
    protected void Reg_Click(object sender, EventArgs e)
    {
        txtuser.Text = "";
        txtpwd.Text = "";
    }
}