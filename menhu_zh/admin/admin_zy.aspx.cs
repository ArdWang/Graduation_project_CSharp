using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin_zy : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddata();
            lbadmin.Text = sybll.adminTotal().ToString();
            lbuser.Text = sybll.userTotal().ToString();
            lbcurrent.Text = Application["Current"].ToString();
            lbtotal.Text = Application["Total"].ToString();
        }

    }
    private void binddata() //学习文字显示
    {
        string sql = "select  * from Ip_tb order by Ipid asc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        rptuser.DataSource = pds;
        rptuser.DataBind();
    }

}