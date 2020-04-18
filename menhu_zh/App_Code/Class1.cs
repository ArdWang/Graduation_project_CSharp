using System;
using System.Collections.Generic;
using System.Web;

/// <summary>
///Class1 的摘要说明
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		//TODO: 在此处添加构造函数逻辑
		//
	}
    public static string Jqziduan(string name)
    {
        if (name.Length > 21)
        {
            name = name.Substring(0, 21);
        }
        return name;
    }
}