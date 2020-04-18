using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
using System.Configuration;

/// <summary>
/// sydb 的摘要说明
/// </summary>
public class sydb
{
	public sydb()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    //\sqlexpress
    private static SqlConnection conn()  //连接数据库字符串方法
    {
        //string str = ConfigurationManager.ConnectionStrings["sy_LJ"].ToString();
        string str = @"Data Source=.\sqlexpress;Initial Catalog=Sy_DBOW;Integrated Security=True"; //定义一个字符串变量并把连接字段赋值给str
        SqlConnection con = new SqlConnection(str);  //重新new一个SqlConnection
        return con;  //返回con
    }

    public static DataTable select_All(string sql)  //查询所有表数据
    {
        DataTable dt = null;
        using (SqlConnection con = conn())
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(sda.SelectCommand);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    public static DataTable select_AllParameter(string sql,params SqlParameter[] pars)  //查询传递参数表数据
    {
        DataTable dt = null;
        using (SqlConnection con = conn())
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            sda.SelectCommand.CommandType = CommandType.Text;
            sda.SelectCommand.Parameters.AddRange(pars);
            SqlDataAdapter da = new SqlDataAdapter(sda.SelectCommand);
            dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
    //统计所有注册的数据
    public static int Total(string sql)
    {
        int total = -1;
        using (SqlConnection con = conn())
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            total =Convert.ToInt32(cmd.ExecuteScalar());
            con.Close();
        }
        return total;
    }

    public static int ExeaddCUD(string sql) //数据增加删除更新
    {
        int iRs = -1;
        using (SqlConnection con = conn())
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            con.Open();
            iRs = cmd.ExecuteNonQuery();
            con.Close();
        }
        return iRs;
    }
    public static int ExeCUD(string sql, params SqlParameter[] pars) //数据增加删除更新
    {
        int iRs = -1;
        using (SqlConnection con = conn())
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(pars);
            con.Open();
            iRs = cmd.ExecuteNonQuery();
            con.Close();
        }
        return iRs;
    }
    public static void bind_D(DropDownList d, string sql) //dropdownlist选项
    {
        SqlDataAdapter sda = new SqlDataAdapter(sql, conn());
        DataSet ds = new DataSet();
        sda.Fill(ds, "Roles");
        d.DataSource = ds.Tables["Roles"].DefaultView;
        d.DataTextField = ds.Tables["Roles"].Columns[0].ColumnName;
        d.DataValueField = ds.Tables["Roles"].Columns[0].ColumnName;
        d.DataBind();
        ds.Dispose();
    }

    /*登录检测是否相同验证*/
    public static bool selectlogin(string sql, params SqlParameter[] pars)
    {
        using (SqlConnection con = conn())
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(pars);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public static string  selectPKl(string sql, params SqlParameter[] pars)
    {
        using (SqlConnection con = conn())
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddRange(pars);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                 reader.Dispose();
                 string name = cmd.ExecuteScalar().ToString();
                 return name;
            }
            else
            {
                return "";
            }
        }
    }
   
}