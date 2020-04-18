using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

public partial class xiugaizl : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Session.Timeout = 90;
            binddata();
        }
    }
    public static SqlConnection conn()//连接数据库
    {
        //string str = ConfigurationManager.ConnectionStrings["sy_LJ"].ToString();
        string str = @"Data Source=.\sqlexpress;Initial Catalog=Sy_DBOW;Integrated Security=True";
        SqlConnection con = new SqlConnection(str);
        return con;
    }
    private void binddata()
    {
        if (Session["name"] != null)
        {
            string name=Session["name"].ToString();
            string sql = "select * from sy_user where username=@username";
            using (SqlConnection con = conn())
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.Add("@username",name);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lbname.Text = dr["username"].ToString();
                    password.Text=dr["userpwd"].ToString();
                    koulin.Text=dr["koulin"].ToString();
                    ddsex.SelectedItem.Text = dr["sex"].ToString();
                    phone.Text=dr["phone"].ToString();
                    qqnumber.Text=dr["qqnum"].ToString();
                    emial.Text = dr["emial"].ToString();
                    ddxibie.Text = dr["depart"].ToString();
                }
                dr.Close();
                con.Close();
            }
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

    protected void Regs_Click(object sender, EventArgs e)
    {
        if (Page.IsValid)
        {
            try
            {
                string name = lbname.Text;
                string pwd = password.Text;
                string kl = koulin.Text;
                string sex = ddsex.SelectedItem.Text;
                string dh = phone.Text;
                string qq = qqnumber.Text;
                string eml = emial.Text;
                string zw = ddxibie.Text;
                if (sybll.Update_user1(name, pwd, kl, sex, dh, qq, eml, zw) > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('恭喜你修改成功!');", true);
                }
                else
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "", "alert('对不起修改失败!');", true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
    protected void Rept_Click(object sender, EventArgs e)
    {
        Response.Redirect("sy_shouye.aspx");
    }
}