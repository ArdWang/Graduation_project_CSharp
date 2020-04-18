using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class xw_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddata1();
        }
    }
    private void binddata1() //读取新闻数据并分页
    {
        string sql = "select * from sy_news order by newsId desc";
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
        grdnews.DataSource = pgs;
        grdnews.DataBind();
    }

    protected void grdnews_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdnews.EditIndex = e.NewEditIndex;
        binddata1();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddata1();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddata1();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddata1();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddata1();
    }
    protected void grdnews_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdnews.EditIndex = -1;
        binddata1();
    }
    protected void grdnews_RowUpdating(object sender, GridViewUpdateEventArgs e) //新闻数据更新
    {
        string newsId = grdnews.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(newsId);
        string newsbt = ((TextBox)(grdnews.Rows[e.RowIndex].Cells[1].Controls[0].FindControl("txtnewsbt"))).Text.ToString();
        string newscon = ((TextBox)(grdnews.Rows[e.RowIndex].Cells[2].Controls[0].FindControl("txtnewscon"))).Text.ToString();
        string newsimg = ((TextBox)(grdnews.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtimg"))).Text.ToString();
        string newsman = ((TextBox)(grdnews.Rows[e.RowIndex].Cells[4].Controls[0].FindControl("txtnewsman"))).Text.ToString();
        string newstime = ((TextBox)(grdnews.Rows[e.RowIndex].Cells[5].Controls[0].FindControl("txtnewstime"))).Text.ToString();
        string newspl = ((TextBox)(grdnews.Rows[e.RowIndex].Cells[6].Controls[0].FindControl("txtnewspl"))).Text.ToString();
        int pl = Convert.ToInt32(newspl);
        FileUpload fuimg = ((FileUpload)(grdnews.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("fuimg")));
        /*判断图片代码*/
        string filePath = newsimg;
        if (fuimg.HasFile)//判断是否有文件
        {

            Literal lt = new Literal();//定义一个Literal用来显示脚本

            if (CheckFileType(fuimg.FileName))//检查上传文件的类型
            {

                filePath = "../images/xw/" + fuimg.FileName;

                fuimg.SaveAs(Server.MapPath(filePath));//把文件上传到服务器的绝对路径上

            }
            else
            {
                Response.Write("<script>alert('只能上传JPG,JEPG,PNG,GIF类型的图片文件!~')</script>");
            }

        }
        if (sybll.Update_news(id, newsbt, newscon, filePath, newsman, newstime, pl) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grdnews.EditIndex = -1;
        binddata1();
    }

    //图片添加/修改全在里面
    public bool CheckFileType(string fileName)
    {

        //获取文件的扩展名,前提要用这个方法必须引入命名空间io

        string ext = Path.GetExtension(fileName);

        switch (ext.ToLower())
        {

            case ".gif":

                return true;

            case ".png":

                return true;

            case ".jpeg":

                return true;

            case ".jpg":

                return true;

            default:

                return false;

        }

    }
    protected void grdnews_RowDeleting(object sender, GridViewDeleteEventArgs e) //删除新闻代码
    {
        string newsId = grdnews.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(newsId);
        if (sybll.Delete_news(id) > 0)
        {
            sybll.Delete_plnews_del(id);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grdnews.EditIndex = -1;
        binddata1();
    }
    
}