using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class admin_jk_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatajk();
        }
    }

    private void binddatajk() //健康
    {
        string sql = "select * from sy_jiank order by jkId desc";
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
        grdjk.DataSource = pgs;
        grdjk.DataBind();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddatajk();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddatajk();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddatajk();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddatajk();
    }
    protected void grdjk_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdjk.EditIndex = e.NewEditIndex;
        binddatajk();
    }
    protected void grdkj_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdjk.EditIndex = -1;
        binddatajk();
    }
    protected void grdjk_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string jkId = grdjk.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(jkId);
        string jkbt = ((TextBox)(grdjk.Rows[e.RowIndex].Cells[1].Controls[0].FindControl("txtjkbt"))).Text.ToString();
        string jkcon = ((TextBox)(grdjk.Rows[e.RowIndex].Cells[2].Controls[0].FindControl("txtjkcon"))).Text.ToString();
        string jkimg = ((TextBox)(grdjk.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtimg"))).Text.ToString();
        string jkman = ((TextBox)(grdjk.Rows[e.RowIndex].Cells[4].Controls[0].FindControl("txtjkman"))).Text.ToString();
        string jktime = ((TextBox)(grdjk.Rows[e.RowIndex].Cells[5].Controls[0].FindControl("txtjktime"))).Text.ToString();
        string jkpl = ((TextBox)(grdjk.Rows[e.RowIndex].Cells[6].Controls[0].FindControl("txtjkpl"))).Text.ToString();
        int pl = Convert.ToInt32(jkpl);
        FileUpload fuimg = ((FileUpload)(grdjk.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("fuimg")));
        /*判断图片代码*/
        string filePath = jkimg;
        if (fuimg.HasFile)//判断是否有文件
        {

            Literal lt = new Literal();//定义一个Literal用来显示脚本

            if (CheckFileType(fuimg.FileName))//检查上传文件的类型
            {

                filePath = "../images/jk/" + fuimg.FileName;

                fuimg.SaveAs(Server.MapPath(filePath));//把文件上传到服务器的绝对路径上

            }
            else
            {
                Response.Write("<script>alert('只能上传JPG,JEPG,PNG,GIF类型的图片文件!~')</script>");
            }

        }
        if (sybll.Update_jk(id, jkbt, jkcon, filePath, jkman, jktime, pl) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grdjk.EditIndex = -1;
        binddatajk();
    }
    protected void grdjk_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string jkId = grdjk.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(jkId);
        if (sybll.Delete_jk(id) > 0)
        {
            sybll.Delete_pljk_del(id);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grdjk.EditIndex = -1;
        binddatajk();
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
}