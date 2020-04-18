using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class admin_plqc_edit : System.Web.UI.Page
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
        string sql = "select * from pl_qc order by plqcId desc";
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
        grdgypl.DataSource = pgs;
        grdgypl.DataBind();
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
    protected void grdgypl_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdgypl.EditIndex = e.NewEditIndex;
        binddataplgy();
    }
    protected void grdgypl_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdgypl.EditIndex = -1;
        binddataplgy();
    }
    protected void grdgypl_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string plId = grdgypl.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(plId);
        string plname = ((TextBox)(grdgypl.Rows[e.RowIndex].Cells[2].Controls[0].FindControl("txtplman"))).Text.ToString();
        string plcon = ((TextBox)(grdgypl.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtplcon"))).Text.ToString();
        if (sybll.Update_plqc(id, plname, plcon) > 0)
        {

            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grdgypl.EditIndex = -1;
        binddataplgy();
    }
    protected void grdgypl_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string sql = "select * from pl_qc order by plqcId desc";
        string plId = grdgypl.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(plId);
        DataTable dt = sybll.select_news(sql);
        int id2 = Convert.ToInt32(dt.Rows[0]["qcID"].ToString());
        if (sybll.Delete_plqc(id) > 0)
        {
            sybll.Update_downqcpl(id2);
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grdgypl.EditIndex = -1;
        binddataplgy();
    }
}