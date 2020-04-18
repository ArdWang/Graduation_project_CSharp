using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string name = txtname.Text.Trim();
            string pwd = txtpwd.Text.Trim();

            string sm = txtsm.Text.Trim();
           
            if (sybll.Insert_admin(name,pwd,sm) > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('发布成功!');", true);
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('发布失败!');", true);
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtname.Text = "";
        txtpwd.Text = "";
        txtsm.Text = "";
    }
}
