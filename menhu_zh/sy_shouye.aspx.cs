using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class sy_shouye : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddata1();
            binddataxy1();
            binddataxy2();
            binddata3();
            binddata4();
            binddata5();
            binddata6();
            binddata7();
            binddata8();
            binddata9();
            binddata10();
            binddata11();
            binddatasca1();
            binddatasca2();
            binddatasca3();
            binddatasca4();
            binddatams1();
            binddatams2();
            binddatams3();
            binddatams4();
            binddatams5();
            binddatamswz();
            binddataly1();
            binddataly2();
            binddatasx1();
            binddatajk();
            binddatasd1();
            binddatasd2();
            binddatady();
            binddataty();
        }
    }

    private void binddata1() //新聞表
    {
        string sql = "select * from sy_news order by newsId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 16;
        rptnews.DataSource = pds;
        rptnews.DataBind();
    }

    private void binddataxy1() //校园图片文字显示
    {
        string sql = "select top 2 * from sy_xiaoy order by xyId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 2;
        rptxy1.DataSource = pds;
        rptxy1.DataBind();
    }
    private void binddataxy2() //校园文字显示
    {
        string sql = "select top 4 * from sy_xiaoy order by xyTime desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptxy2.DataSource = pds;
        rptxy2.DataBind();
    }

    private void binddata3() //娱乐表
    {
        string sql = "select top 4 * from sy_yule order by yuleId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        Repeater1.DataSource = pds;
        Repeater1.DataBind();
    }

    private void binddata4()//娱乐文字显示
    {
        string sql = "select top 10 * from sy_yule order by yuleTime desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 10;
        rptyule1.DataSource = pds;
        rptyule1.DataBind();
    }

    private void binddata5() //游戏娱乐
    {
        string sql = "select top 2 * from sy_game order by gameId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 2;
        rptgame.DataSource = pds;
        rptgame.DataBind();
    }

    private void binddataty() //体育
    {
        string sql = "select top 2 * from sy_tiyu order by tyId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 2;
        rptty1.DataSource = pds;
        rptty1.DataBind();
    }

    private void binddata6() //科技
    {
        string sql = "select top 3 * from sy_keji order by kjId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 3;
        rptkj.DataSource = pds;
        rptkj.DataBind();
    }
    private void binddata7() //科技不带图片显示
    {
        string sql = "select top 10 kjId,kjTitle from sy_keji order by kjId desc ";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 10;
        rptkj1.DataSource = pds;
        rptkj1.DataBind();
    }
    public string GetLen(string s)
    {
        if (s.Length > 10)
            s = s.Substring(0, 15) + "...";
        return s;

    }

    private void binddata8() //汽车大图显示
    {
        string sql = "select top 4 * from sy_qiche order by qcId desc ";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptqc1.DataSource = pds;
        rptqc1.DataBind();
    }

    private void binddata9() //汽车小图显示
    {
        string sql = "select top 4 * from sy_qiche order by qcId desc ";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptqc2.DataSource = pds;
        rptqc2.DataBind();
    }

    private void binddata10() //汽车内容显示
    {
        string sql = "select top 4 * from sy_qiche order by qcId desc ";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptqc3.DataSource = pds;
        rptqc3.DataBind();
    }

    private void binddata11() //商城标题显示
    {
        string sql = "select top 4 * from sy_spfl";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptspfl.DataSource = pds;
        rptspfl.DataBind();
    }

    private void binddatasca1() //商城图片显示
    {
        string sql = "select top 12 * from sy_sptb where spFlId=1";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 12;
        rptsp.DataSource = pds;
        rptsp.DataBind();
    }

    private void binddatasca2() //商城图片显示
    {
        string sql = "select top 12 * from sy_sptb where spFlId=2";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 12;
        rptsp1.DataSource = pds;
        rptsp1.DataBind();
    }

    private void binddatasca3() //商城图片显示
    {
        string sql = "select top 12 * from sy_sptb where spFlId=3";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 12;
        rptsp2.DataSource = pds;
        rptsp2.DataBind();
    }

    private void binddatasca4() //商城图片显示
    {
        string sql = "select top 12 * from sy_sptb where spFlId=4";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 12;
        rptsp3.DataSource = pds;
        rptsp3.DataBind();
    }
    private void binddatams1() //美食标题显示
    {
        string sql = "select top 4 * from sy_meishi";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptms1.DataSource = pds;
        rptms1.DataBind();
    }
    private void binddatams2() //美食图片显示
    {
        string sql = "select top 4 msImg from sy_meishi where msId=1";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptms2.DataSource = pds;
        rptms2.DataBind();
    }
    private void binddatams3() //美食图片显示
    {
        string sql = "select top 4 msImg from sy_meishi where msId=2";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptms3.DataSource = pds;
        rptms3.DataBind();
    }
    private void binddatams4() //美食图片显示
    {
        string sql = "select top 4 msImg from sy_meishi where msId=3";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptms4.DataSource = pds;
        rptms4.DataBind();
    }
    private void binddatams5() //美食图片显示
    {
        string sql = "select top 4 msImg from sy_meishi where msId=4";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptms5.DataSource = pds;
        rptms5.DataBind();
    }

    private void binddatamswz() //美食文字显示
    {
        string sql = "select top 4 * from sy_meishi";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptmsxx.DataSource = pds;
        rptmsxx.DataBind();
    }

    private void binddataly1() //旅游图片显示
    {
        string sql = "select top 4 * from sy_lyou order by lyId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptly1.DataSource = pds;
        rptly1.DataBind();
    }
    private void binddataly2() //旅游文字显示
    {
        string sql = "select top 4 * from sy_lyou order by lyId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptly2.DataSource = pds;
        rptly2.DataBind();
    }
    private void binddatasx1() //时尚图片文字显示
    {
        string sql = "select top 2 * from sy_shix order by sxId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 2;
        rptsx1.DataSource = pds;
        rptsx1.DataBind();
    }

    private void binddatajk() //健康文字显示
    {
        string sql = "select top 2 * from sy_jiank order by jkId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 2;
        rptjk1.DataSource = pds;
        rptjk1.DataBind();
    }
    private void binddatasd1() //学习图片显示
    {
        string sql = "select top 1 * from sy_study order by sdId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 1;
        rptsd1.DataSource = pds;
        rptsd1.DataBind();
    }
    private void binddatasd2() //学习文字显示
    {
        string sql = "select top 8 * from sy_study order by sdId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 8;
        rptsd2.DataSource = pds;
        rptsd2.DataBind();
    }
    private void binddatady() //电影图片文字显示
    {
        string sql = "select top 4 * from sy_diany order by dyId desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 4;
        rptdy.DataSource = pds;
        rptdy.DataBind();
    }


    protected void btnres_Click(object sender, EventArgs e)  //跳转注册
    {
        Response.Redirect("sy_zhuce.aspx");
    }
    protected void btndl_Click(object sender, EventArgs e) //跳转登录界面
    {
        string username = txtname.Text.Trim();
        string userpwd = txtpwd.Text.Trim();
        if (sybll.selectuserlogin(username, userpwd))
        {
            Session["name"] = username;
            string ip = System.Web.HttpContext.Current.Request.UserHostAddress;
            if (sybll.Insert_Ip(username,ip) > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('你的IP为安全!');", true);
            }
            
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('登陆成功!');", true);
            Response.Redirect("sy_shouyexy.aspx?loginname=" + username);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('账号或密码错误!');", true);
    }
}