using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web;

/// <summary>
/// ziduanjq 的摘要说明
/// </summary>
public class ziduanjq
{
	public ziduanjq()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static int Jqimgwidth(string name) //截取图片显示
    {
        name = name.Substring(13, name.Length - 13);
        System.Drawing.Image img = System.Drawing.Image.FromFile(name);
        //Bitmap img = (Bitmap)Image.FromFile(name, true);
        int width = img.Width;
        if (width>=560)
        {
            width=560;
        }
        
        return width;
    }
    public static int Jqimgheight(string name) //截取图片显示
    {
        //name = name.Substring(13, name.Length - 13);
        System.Drawing.Image img = System.Drawing.Image.FromFile(name);
        int height = img.Height;
        if (height >= 300)
        {
            height = 300;
        }

        return height;
    }
    public static string Jq_img(string name) //科技标题显示
    {
        if (name.Length >= 3)
        {
            name = name.Substring(3, name.Length-3);
        }
        return name;
    }
    public static string Jq_msbt(string name) //科技标题显示
    {
        if (name.Length >= 5)
        {
            name = name.Substring(0, 5);
        }
        return name;
    }
    public static string Jq_mscon(string name) //科技标题显示
    {
        if (name.Length >= 25)
        {
            name = name.Substring(0, 25) + "...";
        }
        return name;
    }
    public static string Jq_sxbt(string name) //科技标题显示
    {
        if (name.Length >= 12)
        {
            name = name.Substring(0, 12)+"...";
        }
        return name;
    }
    public static string Jq_sxcon(string name) //科技标题显示
    {
        if (name.Length >= 45)
        {
            name = name.Substring(0, 45) + "...";
        }
        return name;
    }
    public static string Jq_kjbt1(string name) //科技标题显示
    {
        if (name.Length >= 22)
        {
            name = name.Substring(0, 22);
        }
        return name;
    }
    public static string Jq_daoyu(string name) //导语内容显示
    {
        if (name.Length >= 60)
        {
            name = name.Substring(0, 60) + "...";
        }
        return name;
    }
    public static string Jq_spbt(string name) //商品标题显示
    {
        if (name.Length >= 12)
        {
            name = name.Substring(0, 12);
        }
        return name;
    }
    public static string Jq_lybt(string name) //旅游标题显示
    {
        if (name.Length >= 4)
        {
            name = name.Substring(0, 4);
        }
        return name;
    }
    public static string Jq_lycon(string name) //旅游内容显示
    {
        if (name.Length >= 60)
        {
            name = name.Substring(0, 60)+"...";
        }
        return name;
    }
    public static string Jq_kjcon(string name) //科技标题显示
    {
        if (name.Length >= 30)
        {
            name = name.Substring(0, 30) + "...";
        }
        return name;
    }
    public static string Jq_kjbt(string name) //科技标题显示
    {
        if (name.Length >= 14)
        {
            name = name.Substring(0, 14);
        }
        return name;
    }
    public static string Jq_qccon(string name) //汽车标题显示
    {
        if (name.Length >= 13)
        {
            name = name.Substring(0, 13)+"...";
        }
        return name;
    }
    public static string Jq_qcbt(string name) //汽车标题显示
    {
        if (name.Length >= 16)
        {
            name = name.Substring(0, 16);
        }
        return name;
    }
    public static string Jq_nesbt(string name) //游戏标题显示
    {
        if (name.Length >= 19)
        {
            name = name.Substring(0, 19);
        }
        return name;
    }
    public static string Jq_yxbt(string name) //游戏标题显示
    {
        if (name.Length > 15)
        {
            name = name.Substring(0, 15);
        }
        return name;
    }
    public static string Jq_jkbt(string name)
    {
        if (name.Length > 12)
        {
            name = name.Substring(0, 12)+"...";
        }
        return name;
    }
    public static string Jq_jkCon(string name)
    {
        if (name.Length >=60)
        {
            name = name.Substring(0, 60) + "...[更多]";
        }
        return name;
    }
    public static string Jq_sdbt(string name)
    {
        if (name.Length > 12)
        {
            name = name.Substring(0, 12) + "...";
        }
        return name;
    }

    public static string Jq_sdbt1(string name)
    {
        if (name.Length >= 10)
        {
            name = name.Substring(0, 10);
        }
        return name;
    }
    public static string Jq_sdCon(string name)
    {
        if (name.Length >= 45)
        {
            name = name.Substring(0, 45) + "...[更多]";
        }
        return name;
    }
    public static string Jq_dybt(string name)
    {
        if (name.Length >= 10)
        {
            name = name.Substring(0, 10);
        }
        return name;
    }
    public static string Jq_dyCon(string name)
    {
        if (name.Length >= 20)
        {
            name = name.Substring(0, 20) + "...[更多]";
        }
        return name;
    }
    /*学院区块字段*/
    public static string Jq_xybt(string name)
    {
        if (name.Length >= 9)
        {
            name = name.Substring(0, 9);
        }
        return name;
    }
    public static string Jq_xyCon(string name)
    {
        if (name.Length >= 15)
        {
            name = name.Substring(0, 15) + "...[更多]";
        }
        return name;
    }
    public static string Jq_xybt1(string name)
    {
        if (name.Length >= 7)
        {
            name = name.Substring(0, 7);
        }
        return name;
    }
    public static string Jq_xyCon1(string name)
    {
        if (name.Length >= 15)
        {
            name = name.Substring(0, 15) + "...[更多]";
        }
        return name;
    }
    /*体育区块字段*/
    public static string Jq_tybt(string name)
    {
        if (name.Length >= 10)
        {
            name = name.Substring(0, 10);
        }
        return name;
    }
    public static string Jq_tyCon(string name)
    {
        if (name.Length >= 15)
        {
            name = name.Substring(0, 15) + "...[更多]";
        }
        return name;
    }

    //新闻大标题建区字段
    public static string Jq_xwbt1(string name)
    {
        if (name.Length >= 25)
        {
            name = name.Substring(0, 25);
        }
        return name;
    }
    public static string Jq_xwbt2(string name)
    {
        if (name.Length >= 25)
        {
            name = name.Substring(0, 25);
        }
        return name;
    }
    public static string Jq_xwbtxs(string name)
    {
        if (name.Length >= 15)
        {
            name = name.Substring(0, 15);
        }
        return name;
    }
}