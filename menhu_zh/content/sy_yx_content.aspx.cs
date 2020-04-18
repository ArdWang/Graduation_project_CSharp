using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class content_sy_yx_content : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatagy1();
            binddatagy2();
            binddatapl();
            binddatagy();
            binddatagys();
            binddatagyx();
        }
    }
    private void binddatagy()
    {
        string gyid = Request["yx_id"].ToString();
        int id = Convert.ToInt32(gyid);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_yxId(id).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 1;
        rptyx.DataSource = pds;
        rptyx.DataBind();
    }
    private void binddatagy1() //游戏表
    {
        string sql = "select top 5 gameid,gametitle from sy_game order by gametime desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 5;
        rptyx1.DataSource = pds;
        rptyx1.DataBind();
    }
    private void binddatagy2() //游戏表
    {
        string sql = "select top 5 gameid,gametitle from sy_game order by gamepl desc";
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_news(sql).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 5;
        rptyx2.DataSource = pds;
        rptyx2.DataBind();
    }
    private void binddatapl()
    {
        string id = Request["yx_id"].ToString();
        int gyid = Convert.ToInt32(id);
        rptpl.DataSource = sybll.select_yxPl(gyid);
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
            string id = Request["yx_id"].ToString();
            int id1 = Convert.ToInt32(id);
            string con = txtpl.Text.Trim();
            if (sybll.Insert_yxpl(id1, name, SqlInsertEncode(con)) > 0)
            {
                sybll.Update_addyxpl(id1);
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('评论发布成功!');", true);
                btnfb.Enabled = false;
                btnqx.Enabled = false;
                txtpl.Enabled = false;
            }
            binddatapl();
            binddatagy();
        }
    }
    protected void btnqx_Click(object sender, EventArgs e)
    {
        txtpl.Text = "";
    }

    /// <summary>
    /// 对输入框的特殊字串进行过滤，防止SQL注入
    /// </summary>
    /// <param name="strFromText">要被过滤的字符串</param>
    /// <returns>过滤后的字符串</returns>
    public static string SqlInsertEncode(string strFromText)
    {
        if (!System.String.IsNullOrEmpty(strFromText) && strFromText != "")
        {
            strFromText = strFromText.Replace(";", "&#59;");
            strFromText = strFromText.Replace("!", "&#33;");
            strFromText = strFromText.Replace("@", "&#64;");
            strFromText = strFromText.Replace("$", "&#36;");
            strFromText = strFromText.Replace("*", "&#42;");
            strFromText = strFromText.Replace("(", "&#40;");
            strFromText = strFromText.Replace(")", "&#41;");
            strFromText = strFromText.Replace("-", "&#45;");
            strFromText = strFromText.Replace("+", "&#43;");
            strFromText = strFromText.Replace("=", "&#61;");
            strFromText = strFromText.Replace("|", "&#124;");
            strFromText = strFromText.Replace("\\", "&#92;");
            strFromText = strFromText.Replace("/", "&#47;");
            strFromText = strFromText.Replace(":", "&#58;");
            strFromText = strFromText.Replace("\"", "&#34;");
            strFromText = strFromText.Replace("'", "&#39;");
            strFromText = strFromText.Replace("<", "&#60;");
            strFromText = strFromText.Replace(" ", "&#32;");
            strFromText = strFromText.Replace(">", "&#62;");
            strFromText = strFromText.Replace(" ", "&#32;");
        }
        return strFromText;
    }

    //显示上一篇标题代码
    private void binddatagys() //上一篇
    {
        string id = Request["yx_id"].ToString();
        int gyid = Convert.ToInt32(id);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_yxxsId(gyid).DefaultView;
        pds.AllowPaging = true;
        pds.PageSize = 1;
        rptgs.DataSource = pds;
        rptgs.DataBind();
    }
    private void binddatagyx() //下一篇
    {
        string id = Request["yx_id"].ToString();
        int gyid = Convert.ToInt32(id);
        PagedDataSource pds = new PagedDataSource();
        pds.DataSource = sybll.select_yxxxId(gyid).DefaultView;
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
            string sql = "select top 1 * from sy_game where gametitle like '%'+@serach+'%' or gamecon like '%'+@serach+'%'";
            DataTable dt = sybll.select_AllSerach(sql, txtserach.Text.Trim());
            if (dt.Rows.Count == 0)
            {
                btnfb.Enabled = false;
                btnqx.Enabled = false;
                txtpl.Enabled = false;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('对不起没有找到你需要的内容!');", true);
                lbserach.Text = "对不起！没有找到你需要内容，请重新搜索吧。";
            }
            rptyx.DataSource = dt;
            rptyx.DataBind();
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
    protected void rptyx_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        try
        {
            foreach (RepeaterItem item in rptyx.Items)
            {
                if (item.ItemType == ListItemType.Item || item.ItemType == ListItemType.AlternatingItem)
                {

                    Image img = (Image)(rptyx.Items[0].FindControl("imgxy"));
                    Label limg = (Label)(rptyx.Items[0].FindControl("lbimg"));
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
            throw ex;
        }
    }
}