using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
/// symodels 的摘要说明
/// </summary>
public class symodels
{
	public symodels()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}

    //注册字段
    private string username;

    public string Username
    {
        get { return username; }
        set { username = value; }
    }
    private string password;

    public string Password
    {
        get { return password; }
        set { password = value; }
    }
    private string koulin;

    public string Koulin
    {
        get { return koulin; }
        set { koulin = value; }
    }
    private string sex;

    public string Sex
    {
        get { return sex; }
        set { sex = value; }
    }
    private string phone;

    public string Phone
    {
        get { return phone; }
        set { phone = value; }
    }
    private string qq;

    public string Qq
    {
        get { return qq; }
        set { qq = value; }
    }
    private string email;

    public string Email
    {
        get { return email; }
        set { email = value; }
    }
    private string depart;

    public string Depart
    {
        get { return depart; }
        set { depart = value; }
    }
}