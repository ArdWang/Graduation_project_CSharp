using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_spfl_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatasp();
        }
    }

    private void binddatasp()
    {
        string sql = "select * from sy_spfl order by spflId desc";
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
        grdsp.DataSource = pgs;
        grdsp.DataBind();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddatasp();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddatasp();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddatasp();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddatasp();
    }
    protected void grdsp_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdsp.EditIndex = e.NewEditIndex;
        binddatasp();
    }
    protected void grdnews_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdsp.EditIndex = -1;
        binddatasp();
    }
    protected void grdsp_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string spId = grdsp.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(spId);

        string spflname = ((TextBox)(grdsp.Rows[e.RowIndex].Cells[1].Controls[0].FindControl("txtflname"))).Text.ToString();

       
        if (sybll.Update_spfl(id,spflname) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grdsp.EditIndex = -1;
        binddatasp();
    }
    protected void grdsp_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string spId = grdsp.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(spId);
        if (sybll.Delete_spfl(id) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grdsp.EditIndex = -1;
        binddatasp();
    }
}