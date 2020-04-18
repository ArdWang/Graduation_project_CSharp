using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_admin_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddataadmin();
        }
    }
    private void binddataadmin() //admin
    {
        string sql = "select * from admin_tb order by adminId desc";
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
        grdadmin.DataSource = pgs;
        grdadmin.DataBind();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddataadmin();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddataadmin();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddataadmin();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddataadmin();
    }
    protected void grdadmin_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grdadmin.EditIndex = e.NewEditIndex;
        binddataadmin();
    }
   
    protected void grdadmin_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string adId = grdadmin.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(adId);
        if (sybll.Delete_admin(id) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grdadmin.EditIndex = -1;
        binddataadmin();
    }
    protected void grdadmin_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grdadmin.EditIndex = -1;
        binddataadmin();
    }
    protected void grdadmin_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string adId = grdadmin.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(adId);
        string adminname = ((TextBox)(grdadmin.Rows[e.RowIndex].Cells[1].Controls[0].FindControl("txtadminuser"))).Text.ToString();
        string adminpwd = ((TextBox)(grdadmin.Rows[e.RowIndex].Cells[2].Controls[0].FindControl("txtadminpwd"))).Text.ToString();
        string adminsm = ((TextBox)(grdadmin.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtsm"))).Text.ToString();
        if (sybll.Update_admin(id, adminname, adminpwd, adminsm) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grdadmin.EditIndex = -1;
        binddataadmin();
    }
}