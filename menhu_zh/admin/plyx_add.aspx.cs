﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_plyx_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatapl();
        }
    }

    private void binddatapl()   //此项注意更改
    {
        string sql = "select gameid from sy_game";
        sydb.bind_D(ddlid, sql);
    }
    protected void btnfb_Click(object sender, EventArgs e)
    {
        string id = ddlid.SelectedItem.Value.ToString();
        int gyid = Convert.ToInt32(id);
        string name = "管理员";
        string con = txtcon.Text.Trim();
        if (sybll.Insert_yxpl(gyid, name, con) > 0)
        {
            sybll.Update_addyxpl(gyid);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('评论发布成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('评论发布失败!');", true);
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txtcon.Text = "";
    }
}