﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin_yx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatayx();
        }
    }
    private void binddatayx() //游戏
    {
        string sql = "select * from sy_game order by gameId desc";
        int inCurrent = Convert.ToInt32(lblCurrent.Text);
        PagedDataSource pgs = new PagedDataSource();
        pgs.DataSource = sybll.select_news(sql).DefaultView;
        pgs.AllowPaging = true;
        pgs.PageSize = 2;
        pgs.CurrentPageIndex = inCurrent - 1;
        lblTotal.Text = pgs.PageCount.ToString();
        int zongshu = Convert.ToInt32(pgs.DataSourceCount) + 1;
        Label2.Text = pgs.DataSourceCount.ToString();   //获取数据源中的项数
        lbtFirst.Enabled = true;
        lbtDown.Enabled = true;
        lbtUp.Enabled = true;
        lbtLast.Enabled = true;
        if (inCurrent == 1)
        {
            lbtFirst.Enabled = false;
            lbtUp.Enabled = false;
        }
        else
        {
            lbtLast.Enabled = true;
            lbtDown.Enabled = true;
        }
        if (inCurrent == pgs.PageCount)
        {
            lbtDown.Enabled = false;
            lbtLast.Enabled = false;
        }
        grdyx.DataSource = pgs;
        grdyx.DataBind();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddatayx();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddatayx();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddatayx();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddatayx();
    }
}