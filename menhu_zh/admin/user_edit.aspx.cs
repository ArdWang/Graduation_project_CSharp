using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class admin_user_edit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            binddatauser();
        }
    }

    private void binddatauser() //用户
    {
        string sql = "select * from sy_user order by userId desc";
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
        grduser.DataSource = pgs;
        grduser.DataBind();
    }
    protected void lbtFirst_Click(object sender, EventArgs e)
    {
        if (lblCurrent.Text != "1")
        {
            lblCurrent.Text = "1";
            binddatauser();
        }
    }
    protected void lbtUp_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) - 1).ToString());
        binddatauser();
    }
    protected void lbtDown_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = ((Convert.ToInt32(lblCurrent.Text) + 1).ToString());
        binddatauser();
    }
    protected void lbtLast_Click(object sender, EventArgs e)
    {
        lblCurrent.Text = lblTotal.Text;
        binddatauser();
    }
    protected void grdadmin_RowEditing(object sender, GridViewEditEventArgs e)
    {
        grduser.EditIndex = e.NewEditIndex;
        binddatauser();
    }
    protected void grduser_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        grduser.EditIndex = -1;
        binddatauser();
    }
    protected void grduser_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        string userId = grduser.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(userId);
        string name = ((TextBox)(grduser.Rows[e.RowIndex].Cells[0].Controls[0].FindControl("txtusernamer"))).Text.ToString();
        string pwd = ((TextBox)(grduser.Rows[e.RowIndex].Cells[1].Controls[0].FindControl("txtuserpwd"))).Text.ToString();
        string kl = ((TextBox)(grduser.Rows[e.RowIndex].Cells[2].Controls[0].FindControl("txtkl"))).Text.ToString();
        string sex = ((TextBox)(grduser.Rows[e.RowIndex].Cells[3].Controls[0].FindControl("txtsex"))).Text.ToString();
        string phone = ((TextBox)(grduser.Rows[e.RowIndex].Cells[4].Controls[0].FindControl("txtphone"))).Text.ToString();
        string qq = ((TextBox)(grduser.Rows[e.RowIndex].Cells[5].Controls[0].FindControl("txtqq"))).Text.ToString();
        string emial = ((TextBox)(grduser.Rows[e.RowIndex].Cells[6].Controls[0].FindControl("txtemial"))).Text.ToString();
        string depart = ((TextBox)(grduser.Rows[e.RowIndex].Cells[7].Controls[0].FindControl("txtdepart"))).Text.ToString();
        if (sybll.Update_user(id, name, pwd, kl,sex,phone,qq,emial,depart) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('修改失败!');", true);
        grduser.EditIndex = -1;
        binddatauser();
    }
    protected void grduser_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        string userId = grduser.DataKeys[e.RowIndex].Value.ToString();
        int id = Convert.ToInt32(userId);
        if (sybll.Delete_user(id) > 0)
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你删除成功!');", true);
        }
        else
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('删除失败!');", true);
        grduser.EditIndex = -1;
        binddatauser();
    }
}