using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class zhmm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public static SqlConnection conn()//连接数据库
    {
        //string str = ConfigurationManager.ConnectionStrings["sy_LJ"].ToString();
        string str = @"Data Source=.\sqlexpress;Initial Catalog=Sy_DBOW;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        return con;
    }
    protected void btnok_Click(object sender, EventArgs e)
    {
        string name = txtname.Text;
        string kl = txtkl.Text;
        if (sybll.selectuserKoulin(name, kl))
        {
            Panel1.Visible = false;
            Panel2.Visible = true;
            lbpwd.Text = sybll.selectuserKoulin1(name, kl);
            lbname.Text = name;
        }
        else
        {
            ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('对不起账户名或口令错误!');", true);
        }
        
    }
    protected void btnfh_Click(object sender, EventArgs e)
    {
        Response.Redirect("sy_shouye.aspx");
    }
    protected void btnqx_Click(object sender, EventArgs e)
    {
        Response.Redirect("sy_shouye.aspx");
    }
}