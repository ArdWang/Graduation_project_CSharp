using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class content_sy_news_content : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddataxw();
            binddataxw1();
            binddataxw2();
            binddatapl();
            binddatagys();
            binddatagyx();
        }
    }
    private void binddataxw()
    {
        string newsid = Request["xw_id"].ToString();
        int id = Convert.ToInt32(newsid);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_newsId(id).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 1;
        rptnews.DataSource = pds;
        rptnews.DataBind();
    }

    private void binddataxw1() //新聞表
    {
        string sql = "select top 5 newsid,newstitle from sy_news order by newstime desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 5;
        rptxw1.DataSource = pds;
        rptxw1.DataBind();
    }
    private void binddataxw2() //新聞表
    {
        string sql = "select top 5 newsid,newstitle from sy_news order by newspl desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 5;
        rptxw2.DataSource = pds;
        rptxw2.DataBind();
    }
    private void binddatapl()
    {
        string id = Request["xw_id"].ToString();
        int newsid = Convert.ToInt32(id);
        rptpl.DataSource = sybll.select_newsPl(newsid);
        rptpl.DataBind();
    }
    protected void btnfb_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string name = "";
            if (Session["name"] == null)
            {
                name = "游客";
            }
            if (Session["name"] != null)
            {
                name = Session["name"].ToString();
            }
            string id = Request["xw_id"].ToString();
            int newsid = Convert.ToInt32(id);
            string con = txtpl.Text.Trim();
            if (sybll.Insert_newspl(newsid, name, con) > 0)
            {
                sybll.Update_addnewspl(newsid);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('评论发布成功!');", true);
                btnfb.Enabled = false;
                btnqx.Enabled = false;
                txtpl.Enabled = false;
            }
            binddatapl();
            binddataxw();
        }
    }
    protected void btnqx_Click(object sender, EventArgs e)
    {
        txtpl.Text = "";
    }

    //显示上一篇标题代码
    private void binddatagys() //上一篇
    {
        string id = Request["xw_id"].ToString();
        int gyid = Convert.ToInt32(id);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_newsxsId(gyid).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 1;
        rptgs.DataSource = pds;
        rptgs.DataBind();
   }
    private void binddatagyx() //下一篇
    {
        string id = Request["xw_id"].ToString();
        int gyid = Convert.ToInt32(id);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_newsxxId(gyid).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 1;
        rptgx.DataSource = pds;
        rptgx.DataBind();
    }

    protected void btnserach_Click(object sender, EventArgs e)
    {
        lbserach.Text = "";
        btnfb.Enabled = true;
        btnqx.Enabled = true;
        txtpl.Enabled = true;
        if (txtserach.Text != "")
        {
            string sql = "select top 1 * from sy_news where newstitle like '%'+@serach+'%' or newscon like '%'+@serach+'%'";
            DataTable dt = sybll.select_AllSerach(sql, txtserach.Text.Trim());
            if (dt.Rows.Count == 0)
            {
                btnfb.Enabled = false;
                btnqx.Enabled = false;
                txtpl.Enabled = false;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('对不起没有找到你需要的内容!');", true);
                lbserach.Text = "对不起！没有找到你需要内容，请重新搜索吧。";
            }
            rptnews.DataSource = dt;
            rptnews.DataBind();
        }
    }
    //检测验证码
    protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
    {
        string code = yanzhenma.Text.Trim().ToUpper();//将输入的字母都转化成大写然后作比较
        string rightCode = Session["Code"].ToString();
        if (code == rightCode)
        {
            args.IsValid = true;
        }
        else
        {
            args.IsValid = false;
        }
    }
    protected void rptnews_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            foreach (RepeaterItem item in rptnews.Items)
            {
                if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                {

                    Image img = (Image)(rptnews.Items[0].FindControl("imgxy"));
                    Label limg = (Label)(rptnews.Items[0].FindControl("lbimg"));
                    if (!System.IO.Directory.Exists(Server.MapPath(img.ImageUrl)))
                    {
                        System.Drawing.Image img1 = System.Drawing.Image.FromFile(Server.MapPath(img.ImageUrl)); //Server.MapPath获得服务器的物理路径
                        int width = img1.Width;
                        int height = img1.Height;
                        if (width >= 560)
                        {
                            img.Width = 560;
                        }
                        else
                        {
                            img.Width = img1.Width;
                        }
                        /*if (height >= 400)
                        {
                            img.Height = 400;
                        }
                        else
                        {
                            img.Height = img1.Height;
                        }*/

                    }
                    if (img.ImageUrl == "")
                    {
                        limg.Text = "这个文章没有图片";
                        img.Visible = false;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            //throw ex;
        }
    }
}