using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class sy_zhuce : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Regs_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            symodels stu = new symodels();
            stu.Username = username.Text.Trim();
            stu.Password = password.Text.Trim();
            stu.Koulin = koulin.Text.Trim();
            stu.Sex = ddsex.SelectedItem.Text;
            stu.Phone = phone.Text.Trim();
            stu.Qq = qqnumber.Text.Trim();
            stu.Email = emial.Text.Trim();
            stu.Depart = ddxibie.SelectedItem.Text;
            if (sybll.Insert_user(stu.Username, stu.Password, stu.Koulin, stu.Sex, stu.Phone, stu.Qq, stu.Email, stu.Depart) > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你注册成功!');", true);
                Response.Redirect("sy_shouye.aspx");
            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('对不起注册失败!');", true);
            }
        }
    }
    protected void Rept_Click(object sender, EventArgs e)
    {
        username.Text = "";
        password.Text = "";
        password1.Text = "";
        koulin.Text = "";
        ddsex.SelectedItem.Text = "请选择";
        phone.Text = "";
        qqnumber.Text = "";
        emial.Text = "";
        ddxibie.SelectedItem.Text = "--请选择--";
        yanzhenma.Text = "";
    }
    //检测是否有相同的用户名
    protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
    {
        if (sybll.selectusername(args.Value))
        {
            args.IsValid = false;
        }
        else
        {
            args.IsValid = true;
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
}