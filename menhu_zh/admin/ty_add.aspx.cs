using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class admin_ty_add : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            if (Session["name"] != null)
            {
                Session.Timeout = 90;
                lbname.Text = Session["name"].ToString();
            }
        }
    }
    protected void btnhsy_Click(object sender, EventArgs e)
    {
        Response.Redirect("admin_zy.aspx");
    }
    protected void btnqsy_Click(object sender, EventArgs e)
    {
        Response.Redirect("../sy_shouye.aspx");
    }
    protected void lbexit_Click(object sender, EventArgs e)
    {
        Response.Redirect("Login.aspx");
        Session.Remove("name");
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            string tybt = txttybt.Text.Trim();
            string tycon = content1.Value.Trim();
            string tyImg = gettup();
            string fbman = txtfbman.Text.Trim();
            string time = txttime.Text.Trim();
            if (sybll.Insert_ty(tybt, tycon, tyImg, fbman, time) > 0)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('发布成功!');", true);
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('发布失败!');", true);
        }
    }
    protected void btncancel_Click(object sender, EventArgs e)
    {
        txttybt.Text = "";
        content1.Value = "";
        txtfbman.Text = "";
        txttime.Text = "";
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
    /*判断图片代码*/
    private string gettup()
    {
        if (fuimg.HasFile)//判断是否有文件
        {

            Literal lt = new Literal();//定义一个Literal用来显示脚本

            if (CheckFileType(fuimg.FileName))//检查上传文件的类型
            {

                string filePath = "../images/ty/" + fuimg.FileName;

                fuimg.SaveAs(Server.MapPath(filePath));//把文件上传到服务器的绝对路径上
                return filePath;
            }
            else
            {
                Response.Write("<script>alert('只能上传JPG,JEPG,PNG,GIF类型的图片文件!~')</script>");
            }

        }
        return "";
    }
}