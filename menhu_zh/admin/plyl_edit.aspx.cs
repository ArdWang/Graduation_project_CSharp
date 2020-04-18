using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_plyl_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddataplgy();
        }
    }

    private void binddataplgy() //娱乐
    {
        string sql = "select * from pl_yl order by plylId desc";
        int inCurrent = Convert.ToInt32(lblCurrent.Text);
        PagedDataSource pgs = new PagedDataSource();
        pgs.DataSource = sybll.select_news(sql).DefaultView;
        pgs.AllowPaging = true;
        pgs.PageSize = 5;
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
        grdylpl.DataSource = pgs;
        grdylpl.DataBind();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddataplgy();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddataplgy();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddataplgy();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddataplgy();
    }
    protected void grdylpl_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdylpl.EditIndex = e.NewEditIndex;
        binddataplgy();
    }
    protected void grdylpl_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdylpl.EditIndex = -1;
        binddataplgy();
    }
    protected void grdylpl_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string plId = grdylpl.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(plId);
        string plname = ((TextBox)(grdylpl.Rows[e.RowIndex].Cells[2].Controls[0].FindControl("txtplman"))).Text.ToString();
        string plcon = ((TextBox)(grdylpl.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtplcon"))).Text.ToString();
        if (sybll.Update_plyl(id, plname, plcon) > 0)
        {

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grdylpl.EditIndex = -1;
        binddataplgy();
    }
    protected void grdylpl_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sql = "select * from pl_yl order by plylId desc";
        string plId = grdylpl.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(plId);
        DataTable dt = sybll.select_news(sql);
        int id2 = Convert.ToInt32(dt.Rows[0]["xyID"].ToString());
        if (sybll.Delete_plyl(id) > 0)
        {
            sybll.Update_downylpl(id2);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grdylpl.EditIndex = -1;
        binddataplgy();
    }
}