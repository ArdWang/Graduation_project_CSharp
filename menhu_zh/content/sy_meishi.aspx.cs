using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class content_sy_meishi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatagy();
            binddatagy1();
            binddatagy2();
        }
    }

    private void binddatagy1() //娱乐表
    {
        string sql = "select top 5 msid,mstitle from sy_meishi order by mstime desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 5;
        rptgy1.DataSource = pds;
        rptgy1.DataBind();
    }
    private void binddatagy2() //娱乐表
    {
        string sql = "select top 5 msid,mstitle from sy_meishi order by mspl desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 5;
        rptgy2.DataSource = pds;
        rptgy2.DataBind();
    }
    private void binddatagy() //读取数据并分页
    {
        string sql = "select * from sy_meishi order by msId desc";
        int inCurrent = Convert.ToInt32(lblCurrent.Text);
        PagedDataSource pgs = new PagedDataSource();
        pgs.DataSource = sybll.select_news(sql).DefaultView;
        pgs.AllowPaging = true;
        pgs.PageSize = 23;
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
        rptgy.DataSource = pgs;
        rptgy.DataBind();
    }


    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddatagy();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddatagy();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddatagy();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddatagy();
    }
}