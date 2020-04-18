using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web;

/// <summary>
/// sybll 的摘要说明
/// </summary>
public class sybll
{
	public sybll()
	{
		//
		// TODO: 在此处添加构造函数逻辑
		//
	}
    public static DataTable select_news(string sql) //主页数据显示
    {
        return sydb.select_All(sql);
    }

    //搜索代码大全

    //---------------------------------------
    public static DataTable select_AllSerach(string sql, string serach)
    {
        SqlParameter[] pars = { new SqlParameter("@serach", serach) };
        return sydb.select_AllParameter(sql, pars);
    }

    //---------------------------------------
   
    //传递ID参数代码
    //查询传递参数表数据

    //---------------------------------------------------------------------
    /*新闻大区块*/
    public static DataTable select_newsxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_news where newsId<@newsId order by newsid desc";
        SqlParameter[] pars = { new SqlParameter("@newsId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_newsxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_news where newsId>@newsId order by newsid ";
        SqlParameter[] pars = { new SqlParameter("@newsId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_newsId(int id)  //新闻表
    {
        string sql = "select * from sy_news where newsId=@newsId";
        SqlParameter[] pars = { new SqlParameter("@newsId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_newsPl(int id)  //新闻表
    {
        string sql = "select * from pl_news where newsId=@newsId";
        SqlParameter[] pars = { new SqlParameter("@newsId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    //获得用户浏览的IP
    public static int Insert_Ip(string name,string IP)
    {
        string sql = "Insert into Ip_tb(ipname,ipdz)values(@ipname,@ipdz)";
        SqlParameter[] pars = { new SqlParameter("@ipname", name), new SqlParameter("@ipdz", IP) };
        return sydb.ExeCUD(sql, pars);
    }

    //插入数据到新闻评论表
    public static int Insert_newspl(int Id, string name, string con)
    {
        string sql = "insert into pl_news(newsId,plman,plcon)values(@newsId,@plman,@plcon)";
        SqlParameter[] pars={new SqlParameter("@newsId",Id),new SqlParameter("@plman",name),new SqlParameter("@plcon",con)};
        return sydb.ExeCUD(sql, pars);
    }
    //联动新闻表的评论
    public static int Update_addnewspl(int id)
    {
        string sql = "update sy_news set newspl=newspl+1 where newsid=@newsid";
        SqlParameter[] pars = { new SqlParameter("@newsid", id) };
        return sydb.ExeCUD(sql,pars);
    }
    //--------------------------------------------------------------

    /*校园大区块*/

    public static DataTable select_xyxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_xiaoy where xyId<@xyId order by xyid desc";
        SqlParameter[] pars = { new SqlParameter("@xyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_xyxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_xiaoy where xyId>@xyId order by xyid ";
        SqlParameter[] pars = { new SqlParameter("@xyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_xyId(int id)  //校园表
    {
        string sql = "select * from sy_xiaoy where xyId=@xyId";
        SqlParameter[] pars = { new SqlParameter("@xyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_xyPl(int id)  //校园表
    {
        string sql = "select * from pl_xy where xyId=@xyId";
        SqlParameter[] pars = { new SqlParameter("@xyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
  

    //插入数据到校园评论表
    public static int Insert_xypl(int Id, string name, string con)
    {
        string sql = "insert into pl_xy(xyId,plman,plcon)values(@xyId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@xyId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动校园表的评论
    public static int Update_addxypl(int id)
    {
        string sql = "update sy_xiaoy set xypl=xypl+1 where xyid=@xyid";
        SqlParameter[] pars = { new SqlParameter("@xyid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------
    /*娱乐大区块*/
    public static DataTable select_ylxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_yule where yuleId<@yuleId order by yuleid desc";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_ylxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_yule where yuleId>@yuleId order by yuleid ";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_ylId(int id)  //娱乐表
    {
        string sql = "select * from sy_yule where yuleId=@yuleId";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_ylPl(int id)  //娱乐表
    {
        string sql = "select * from pl_yl where yuleId=@yuleId";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id) };
        return sydb.select_AllParameter(sql, pars);
    }


    //插入数据到娱乐评论表
    public static int Insert_ylpl(int Id, string name, string con)
    {
        string sql = "insert into pl_yl(yuleId,plman,plcon)values(@yuleId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@yuleId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动娱乐表的评论
    public static int Update_addylpl(int id)
    {
        string sql = "update sy_yule set yulepl=yulepl+1 where yuleid=@yuleid";
        SqlParameter[] pars = { new SqlParameter("@yuleid", id) };
        return sydb.ExeCUD(sql, pars);
    }



    //--------------------------------------------------------------

    //--------------------------------------------------------------
    /*游戏大区块*/
    public static DataTable select_yxxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_game where gameId<@gameId order by gameid desc";
        SqlParameter[] pars = { new SqlParameter("@gameId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_yxxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_game where gameId>@gameId order by gameid ";
        SqlParameter[] pars = { new SqlParameter("@gameId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_yxId(int id)  //游戏表
    {
        string sql = "select * from sy_game where gameId=@gameId";
        SqlParameter[] pars = { new SqlParameter("@gameId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_yxPl(int id)  //游戏表
    {
        string sql = "select * from pl_yx where gameId=@gameId";
        SqlParameter[] pars = { new SqlParameter("@gameId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到游戏评论表
    public static int Insert_yxpl(int Id, string name, string con)
    {
        string sql = "insert into pl_yx(gameId,plman,plcon)values(@gameId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@gameId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动游戏表的评论
    public static int Update_addyxpl(int id)
    {
        string sql = "update sy_game set gamepl=gamepl+1 where gameid=@gameid";
        SqlParameter[] pars = { new SqlParameter("@gameid", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //--------------------------------------------------------------
    /*体育大区块*/
    public static DataTable select_tyxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_tiyu where tyId<@tyId order by tyid desc";
        SqlParameter[] pars = { new SqlParameter("@tyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_tyxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_tiyu where tyId>@tyId order by tyid ";
        SqlParameter[] pars = { new SqlParameter("@tyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_tyId(int id)  //体育表
    {
        string sql = "select * from sy_tiyu where tyId=@tyId";
        SqlParameter[] pars = { new SqlParameter("@tyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_tyPl(int id)  //体育表
    {
        string sql = "select * from pl_ty where tyId=@tyId";
        SqlParameter[] pars = { new SqlParameter("@tyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到体育评论表
    public static int Insert_typl(int Id, string name, string con)
    {
        string sql = "insert into pl_ty(tyId,plman,plcon)values(@tyId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@tyId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动体育表的评论
    public static int Update_addtypl(int id)
    {
        string sql = "update sy_tiyu set typl=typl+1 where tyid=@tyid";
        SqlParameter[] pars = { new SqlParameter("@tyid", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //--------------------------------------------------------------
    /*汽车大区块*/
    public static DataTable select_qcxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_qiche where qcId<@qcId order by qcid desc";
        SqlParameter[] pars = { new SqlParameter("@qcId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_qcxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_qiche where qcId>@qcId order by qcid ";
        SqlParameter[] pars = { new SqlParameter("@qcId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_qcId(int id)  //汽车表
    {
        string sql = "select * from sy_qiche where qcId=@qcId";
        SqlParameter[] pars = { new SqlParameter("@qcId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_qcPl(int id)  //汽车表
    {
        string sql = "select * from pl_qc where qcId=@qcId";
        SqlParameter[] pars = { new SqlParameter("@qcId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到汽车评论表
    public static int Insert_qcpl(int Id, string name, string con)
    {
        string sql = "insert into pl_qc(qcId,plman,plcon)values(@qcId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@qcId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动汽车表的评论
    public static int Update_addqcpl(int id)
    {
        string sql = "update sy_qiche set qcpl=qcpl+1 where qcid=@qcid";
        SqlParameter[] pars = { new SqlParameter("@qcid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------

    //--------------------------------------------------------------
    /*科技大区块*/
    public static DataTable select_kjxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_keji where kjId<@kjId order by kjid desc";
        SqlParameter[] pars = { new SqlParameter("@kjId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_kjxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_keji where kjId>@kjId order by kjid ";
        SqlParameter[] pars = { new SqlParameter("@kjId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_kjId(int id)  //科技表
    {
        string sql = "select * from sy_keji where kjId=@kjId";
        SqlParameter[] pars = { new SqlParameter("@kjId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_kjPl(int id)  //科技表
    {
        string sql = "select * from pl_kj where kjId=@kjId";
        SqlParameter[] pars = { new SqlParameter("@kjId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    //插入数据到科技评论表
    public static int Insert_kjpl(int Id, string name, string con)
    {
        string sql = "insert into pl_kj(kjId,plman,plcon)values(@kjId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@kjId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动科技表的评论
    public static int Update_addkjpl(int id)
    {
        string sql = "update sy_keji set kjpl=kjpl+1 where kjid=@kjid";
        SqlParameter[] pars = { new SqlParameter("@kjid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------
    //--------------------------------------------------------------
    /*旅游大区块*/
    public static DataTable select_lyxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_lyou where lyId<@lyId order by lyid desc";
        SqlParameter[] pars = { new SqlParameter("@lyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_lyxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_lyou where lyId>@lyId order by lyid ";
        SqlParameter[] pars = { new SqlParameter("@lyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_lyId(int id)  //旅游表
    {
        string sql = "select * from sy_lyou where lyId=@lyId";
        SqlParameter[] pars = { new SqlParameter("@lyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_lyPl(int id)  //旅游表
    {
        string sql = "select * from pl_ly where lyId=@lyId";
        SqlParameter[] pars = { new SqlParameter("@lyId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到旅游评论表
    public static int Insert_lypl(int Id, string name, string con)
    {
        string sql = "insert into pl_ly(lyId,plman,plcon)values(@lyId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@lyId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动旅游表的评论
    public static int Update_addlypl(int id)
    {
        string sql = "update sy_lyou set lypl=lypl+1 where lyid=@lyid";
        SqlParameter[] pars = { new SqlParameter("@lyid", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //-----------------------------------------------------------

    //--------------------------------------------------------------
    /*健康大区块*/
    public static DataTable select_jkxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_jiank where jkId<@jkId order by jkid desc";
        SqlParameter[] pars = { new SqlParameter("@jkId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_jkxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_jiank where jkId>@jkId order by jkid ";
        SqlParameter[] pars = { new SqlParameter("@jkId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_jkId(int id)  //健康表
    {
        string sql = "select * from sy_jiank where jkId=@jkId";
        SqlParameter[] pars = { new SqlParameter("@jkId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_jkPl(int id)  //健康表
    {
        string sql = "select * from pl_jk where jkId=@jkId";
        SqlParameter[] pars = { new SqlParameter("@jkId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到健康评论表
    public static int Insert_jkpl(int Id, string name, string con)
    {
        string sql = "insert into pl_jk(jkId,plman,plcon)values(@jkId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@jkId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动健康表的评论
    public static int Update_addjkpl(int id)
    {
        string sql = "update sy_jiank set jkpl=jkpl+1 where jkid=@jkid";
        SqlParameter[] pars = { new SqlParameter("@jkid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------

    //--------------------------------------------------------------
    /*时尚大区块*/
    public static DataTable select_sxxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_shix where sxId<@sxId order by sxid desc";
        SqlParameter[] pars = { new SqlParameter("@sxId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_sxxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_shix where sxId>@sxId order by sxid ";
        SqlParameter[] pars = { new SqlParameter("@sxId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_sxId(int id)  //时尚表
    {
        string sql = "select * from sy_shix where sxId=@sxId";
        SqlParameter[] pars = { new SqlParameter("@sxId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_sxPl(int id)  //时尚表
    {
        string sql = "select * from pl_sx where sxId=@sxId";
        SqlParameter[] pars = { new SqlParameter("@sxId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到时尚评论表
    public static int Insert_sxpl(int Id, string name, string con)
    {
        string sql = "insert into pl_sx(sxId,plman,plcon)values(@sxId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@sxId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动时尚表的评论
    public static int Update_addsxpl(int id)
    {
        string sql = "update sy_shix set sxpl=sxpl+1 where sxid=@sxid";
        SqlParameter[] pars = { new SqlParameter("@sxid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------

    //--------------------------------------------------------------
    /*美食大区块*/
    public static DataTable select_msxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_meishi where msId<@msId order by msid desc";
        SqlParameter[] pars = { new SqlParameter("@msId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_msxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_meishi where msId>@msId order by msid ";
        SqlParameter[] pars = { new SqlParameter("@msId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_msId(int id)  //美食表
    {
        string sql = "select * from sy_meishi where msId=@msId";
        SqlParameter[] pars = { new SqlParameter("@msId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_msPl(int id)  //美食表
    {
        string sql = "select * from pl_ms where msId=@msId";
        SqlParameter[] pars = { new SqlParameter("@msId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到美食评论表
    public static int Insert_mspl(int Id, string name, string con)
    {
        string sql = "insert into pl_ms(msId,plman,plcon)values(@msId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@msId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动美食表的评论
    public static int Update_addmspl(int id)
    {
        string sql = "update sy_meishi set mspl=mspl+1 where msid=@msid";
        SqlParameter[] pars = { new SqlParameter("@msid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------

    //--------------------------------------------------------------
    /*学习大区块*/
    public static DataTable select_sdxsId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_study where sdId<@sdId order by sdid desc";
        SqlParameter[] pars = { new SqlParameter("@sdId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_sdxxId(int id)  //绑定上下篇
    {
        string sql = "select * from sy_study where sdId>@sdId order by sdid ";
        SqlParameter[] pars = { new SqlParameter("@sdId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_sdId(int id)  //学习表
    {
        string sql = "select * from sy_study where sdId=@sdId";
        SqlParameter[] pars = { new SqlParameter("@sdId", id) };
        return sydb.select_AllParameter(sql, pars);
    }
    public static DataTable select_sdPl(int id)  //学习表
    {
        string sql = "select * from pl_sd where sdId=@sdId";
        SqlParameter[] pars = { new SqlParameter("@sdId", id) };
        return sydb.select_AllParameter(sql, pars);
    }

    //插入数据到学习评论表
    public static int Insert_sdpl(int Id, string name, string con)
    {
        string sql = "insert into pl_sd(sdId,plman,plcon)values(@sdId,@plman,@plcon)";
        SqlParameter[] pars = { new SqlParameter("@sdId", Id), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    //联动学习表的评论
    public static int Update_addsdpl(int id)
    {
        string sql = "update sy_study set sdpl=sdpl+1 where sdid=@sdid";
        SqlParameter[] pars = { new SqlParameter("@sdid", id) };
        return sydb.ExeCUD(sql, pars);
    }


    //--------------------------------------------------------------

    //注册数据到用户表
    public static int Insert_user( string username, string userpwd, string koulin, string sex, string phone, string qq, string email, string depart)
    {
        string sql = "insert into sy_user(username,userpwd,koulin,sex,phone,qqnum,emial,depart)values(@username,@userpwd,@koulin,@sex,@phone,@qqnum,@emial,@depart)";
        SqlParameter[] pars = { new SqlParameter("@username", username), new SqlParameter("@userpwd", userpwd), new SqlParameter("@koulin", koulin), new SqlParameter("@sex", sex), new SqlParameter("@phone", phone), new SqlParameter("@qqnum", qq), new SqlParameter("@emial", email), new SqlParameter("@depart", depart) };
        return sydb.ExeCUD(sql, pars);
    }
    //检测是否有相同的用户名
    public static bool selectusername(string username)
    {
        string sql = "select username from sy_user where username=@username";
        SqlParameter[] pars = { new SqlParameter("@username", username) };
        return sydb.selectlogin(sql, pars);
    }
    //统计所有注册用户的数据
    public static int userTotal()
    {
        string sql = "select count(username) from sy_user";
        return sydb.Total(sql);
    }
    //用户 
    public static int Update_user(int id, string name, string pwd, string kl,string sex,string phone,string qq,string emial,string depart)
    {
        string sql = "update sy_user set username=@username,userpwd=@userpwd,koulin=@koulin,sex=@sex,phone=@phone,qqnum=@qqnum,emial=@emial,depart=@depart where userId=@userId";
        SqlParameter[] pars = { new SqlParameter("@userId", id), new SqlParameter("@username", name), new SqlParameter("@userpwd", pwd), new SqlParameter("@koulin", kl),new SqlParameter("@sex",sex),new SqlParameter("@phone",phone),new SqlParameter("@qqnum",qq),new SqlParameter("@emial",emial),new SqlParameter("@depart",depart) };
        return sydb.ExeCUD(sql, pars);
    }
    //修改用户1
    public static int Update_user1(string name, string pwd, string kl, string sex, string phone, string qq, string emial, string depart)
    {
        string sql = "update sy_user set userpwd=@userpwd,koulin=@koulin,sex=@sex,phone=@phone,qqnum=@qqnum,emial=@emial,depart=@depart where username=@username";
        SqlParameter[] pars = { new SqlParameter("@username", name), new SqlParameter("@userpwd", pwd), new SqlParameter("@koulin", kl), new SqlParameter("@sex", sex), new SqlParameter("@phone", phone), new SqlParameter("@qqnum", qq), new SqlParameter("@emial", emial), new SqlParameter("@depart", depart) };
        return sydb.ExeCUD(sql, pars);
    }

    //用户资料修改_查询
    public static DataTable username(string name)
    {
        string sql = "select * from sy_user where username=@username";
        SqlParameter[] pars = { new SqlParameter("@username", name) };
        return sydb.select_AllParameter(sql, pars);
    }

    public static int Delete_user(int id) //删除sy_user表数据
    {
        string sql = "Delete sy_user where userId=@userId";
        SqlParameter[] pars = { new SqlParameter("@userId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_user(string name, string pwd, string sm)
    {
        string sql = "insert into sy_user(username,userpwd,koulin)values(@username,@userpwd,@koulin)";
        SqlParameter[] pars = { new SqlParameter("@username", name), new SqlParameter("@userpwd", pwd), new SqlParameter("@koulin", sm) };
        return sydb.ExeCUD(sql, pars);
    }

    //验证用户登录账号密码
    public static bool selectuserlogin(string username, string password)
    {
        string sql = "select username,userpwd from sy_user where username=@username and userpwd=@userpwd";
        SqlParameter[] pars = { new SqlParameter("@username", username), new SqlParameter("@userpwd", password) };
        return sydb.selectlogin(sql, pars);
    }
    //验证用户查找账号和密码口令
    public static string selectuserKoulin1(string username, string kl)
    {
        string sql = "select userpwd from sy_user where username=@username and koulin=@koulin";
        SqlParameter[] pars = { new SqlParameter("@username", username), new SqlParameter("@koulin", kl) };
        return sydb.selectPKl(sql, pars);
    }
    public static bool selectuserKoulin(string username, string kl)
    {
        string sql = "select userpwd from sy_user where username=@username and koulin=@koulin";
        SqlParameter[] pars = { new SqlParameter("@username", username), new SqlParameter("@koulin", kl) };
        return sydb.selectlogin(sql, pars);
    }


    /*此块区域用于后台*/

    //-------------------------------------------------------
    //评论新闻表数据
    public static int Update_plnews(int plid, string name, string con)
    {
        string sql = "update pl_news set plman=@plman,plcon=@plcon where plnewsID=@plnewsID";
        SqlParameter[] pars = { new SqlParameter("@plnewsID", plid),  new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plnews(int id) //删除admin_tb表数据
    {
        string sql = "Delete pl_news where plnewsID=@plnewsID";
        SqlParameter[] pars = { new SqlParameter("@plnewsID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downnewspl(int id) //随着评论数据删除新闻表的数据也随着减少
    {
        string sql = "update sy_news set newspl=newspl-1 where newsid=@newsid";
        SqlParameter[] pars = { new SqlParameter("@newsid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    //-----------------------------------------------------------

    //评论娱乐表数据

    public static int Update_plyl(int plid, string name, string con)
    {
        string sql = "update pl_yl set plman=@plman,plcon=@plcon where plylID=@plylID";
        SqlParameter[] pars = { new SqlParameter("@plylID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plyl(int id) //删除娱乐评论表数据
    {
        string sql = "Delete pl_yl where plylID=@plylID";
        SqlParameter[] pars = { new SqlParameter("@plylID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downylpl(int id) //随着评论数据删除娱乐表的数据也随着减少
    {
        string sql = "update sy_yule set yulepl=yulepl-1 where yuleid=@yuleid";
        SqlParameter[] pars = { new SqlParameter("@yuleid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plyl_del(int id) //删除sy_yule表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_yl where yuleId=@yuleId";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //-----------------------------------------------------------

    //评论校园表数据

    public static int Update_plxy(int plid, string name, string con)
    {
        string sql = "update pl_xy set plman=@plman,plcon=@plcon where plxyID=@plxyID";
        SqlParameter[] pars = { new SqlParameter("@plxyID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plxy(int id) //删除admin_tb表数据
    {
        string sql = "Delete pl_xy where plxyID=@plxyID";
        SqlParameter[] pars = { new SqlParameter("@plxyID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downxypl(int id) //随着评论数据删除新闻表的数据也随着减少
    {
        string sql = "update sy_xiaoy set xypl=xypl-1 where xyid=@xyid";
        SqlParameter[] pars = { new SqlParameter("@xyid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plxy_del(int id) //删除sy_xiaoy表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_xy where xyId=@xyId";
        SqlParameter[] pars = { new SqlParameter("@xyId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //-----------------------------------------------------------

    //评论游戏表数据

    public static int Update_plyx(int plid, string name, string con)
    {
        string sql = "update pl_yx set plman=@plman,plcon=@plcon where plyxID=@plyxID";
        SqlParameter[] pars = { new SqlParameter("@plyxID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plyx(int id) //删除游戏评论表数据
    {
        string sql = "Delete pl_yx where plyxID=@plyxID";
        SqlParameter[] pars = { new SqlParameter("@plyxID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downyxpl(int id) //随着评论数据删除游戏表的数据也随着减少
    {
        string sql = "update sy_game set gamepl=gamepl-1 where gameid=@gameid";
        SqlParameter[] pars = { new SqlParameter("@gameid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plyx_del(int id) //删除sy_game表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_yx where gameId=@gameId";
        SqlParameter[] pars = { new SqlParameter("@gameId", id) };
        return sydb.ExeCUD(sql, pars);
    }

//---------------------------------------------------------------

    //评论体育表数据

    public static int Update_plty(int plid, string name, string con)
    {
        string sql = "update pl_ty set plman=@plman,plcon=@plcon where pltyID=@pltyID";
        SqlParameter[] pars = { new SqlParameter("@pltyID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plty(int id) //删除体育评论表数据
    {
        string sql = "Delete pl_ty where pltyID=@pltyID";
        SqlParameter[] pars = { new SqlParameter("@pltyID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downtypl(int id) //随着评论数据删除游戏表的数据也随着减少
    {
        string sql = "update sy_tiyu set typl=typl-1 where tyid=@tyid";
        SqlParameter[] pars = { new SqlParameter("@tyid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plty_del(int id) //删除sy_tiyu表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_ty where tyId=@tyId";
        SqlParameter[] pars = { new SqlParameter("@tyId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //评论汽车表数据

    public static int Update_plqc(int plid, string name, string con)
    {
        string sql = "update pl_qc set plman=@plman,plcon=@plcon where plqcID=@plqcID";
        SqlParameter[] pars = { new SqlParameter("@plqcID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plqc(int id) //删除体育评论表数据
    {
        string sql = "Delete pl_qc where plqcID=@plqcID";
        SqlParameter[] pars = { new SqlParameter("@plqcID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downqcpl(int id) //随着评论数据删除游戏表的数据也随着减少
    {
        string sql = "update sy_qiche set qcpl=qcpl-1 where qcid=@qcid";
        SqlParameter[] pars = { new SqlParameter("@qcid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plqc_del(int id) //删除sy_tiyu表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_qc where qcId=@qcId";
        SqlParameter[] pars = { new SqlParameter("@qcId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //评论科技表数据

    public static int Update_plkj(int plid, string name, string con)
    {
        string sql = "update pl_kj set plman=@plman,plcon=@plcon where plkjID=@plkjID";
        SqlParameter[] pars = { new SqlParameter("@plkjID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plkj(int id) //删除科技评论表数据
    {
        string sql = "Delete pl_kj where plkjID=@plkjID";
        SqlParameter[] pars = { new SqlParameter("@plkjID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downkjpl(int id) //随着评论数据删除科技表的数据也随着减少
    {
        string sql = "update sy_keji set kjpl=kjpl-1 where kjid=@kjid";
        SqlParameter[] pars = { new SqlParameter("@kjid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plkj_del(int id) //删除sy_keji表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_kj where kjId=@kjId";
        SqlParameter[] pars = { new SqlParameter("@kjId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //评论健康表数据

    public static int Update_pljk(int plid, string name, string con)
    {
        string sql = "update pl_jk set plman=@plman,plcon=@plcon where pljkID=@pljkID";
        SqlParameter[] pars = { new SqlParameter("@pljkID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_pljk(int id) //删除科技评论表数据
    {
        string sql = "Delete pl_jk where pljkID=@pljkID";
        SqlParameter[] pars = { new SqlParameter("@pljkID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downjkpl(int id) //随着评论数据删除科技表的数据也随着减少
    {
        string sql = "update sy_jiank set jkpl=jkpl-1 where jkid=@jkid";
        SqlParameter[] pars = { new SqlParameter("@jkid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_pljk_del(int id) //删除sy_keji表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_jk where jkId=@jkId";
        SqlParameter[] pars = { new SqlParameter("@jkId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //评论旅游表数据

    public static int Update_plly(int plid, string name, string con)
    {
        string sql = "update pl_ly set plman=@plman,plcon=@plcon where pllyID=@pllyID";
        SqlParameter[] pars = { new SqlParameter("@pllyID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plly(int id) //删除科技评论表数据
    {
        string sql = "Delete pl_ly where pllyID=@pllyID";
        SqlParameter[] pars = { new SqlParameter("@pllyID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downlypl(int id) //随着评论数据删除科技表的数据也随着减少
    {
        string sql = "update sy_lyou set lypl=lypl-1 where lyid=@lyid";
        SqlParameter[] pars = { new SqlParameter("@lyid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plly_del(int id) //删除sy_keji表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_ly where lyId=@lyId";
        SqlParameter[] pars = { new SqlParameter("@lyId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------


    //评论时尚表数据

    public static int Update_plsx(int plid, string name, string con)
    {
        string sql = "update pl_sx set plman=@plman,plcon=@plcon where plsxID=@plsxID";
        SqlParameter[] pars = { new SqlParameter("@plsxID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plsx(int id) //删除科技评论表数据
    {
        string sql = "Delete pl_sx where plsxID=@plsxID";
        SqlParameter[] pars = { new SqlParameter("@plsxID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downsxpl(int id) //随着评论数据删除科技表的数据也随着减少
    {
        string sql = "update sy_shix set sxpl=sxpl-1 where sxid=@sxid";
        SqlParameter[] pars = { new SqlParameter("@sxid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plsx_del(int id) //删除sy_keji表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_sx where sxId=@sxId";
        SqlParameter[] pars = { new SqlParameter("@sxId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //---------------------------------------------------------------


    //评论美食表数据

    public static int Update_plms(int plid, string name, string con)
    {
        string sql = "update pl_ms set plman=@plman,plcon=@plcon where plmsID=@plmsID";
        SqlParameter[] pars = { new SqlParameter("@plmsID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plms(int id) //删除美食评论表数据
    {
        string sql = "Delete pl_ms where plmsID=@plmsID";
        SqlParameter[] pars = { new SqlParameter("@plmsID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downmspl(int id) //随着评论数据删除美食表的数据也随着减少
    {
        string sql = "update sy_meishi set mspl=mspl-1 where msid=@msid";
        SqlParameter[] pars = { new SqlParameter("@msid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plms_del(int id) //删除sy_meishi表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_ms where msId=@msId";
        SqlParameter[] pars = { new SqlParameter("@msId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //---------------------------------------------------------------


    //评论学习表数据

    public static int Update_plsd(int plid, string name, string con)
    {
        string sql = "update pl_sd set plman=@plman,plcon=@plcon where plsdID=@plsdID";
        SqlParameter[] pars = { new SqlParameter("@plsdID", plid), new SqlParameter("@plman", name), new SqlParameter("@plcon", con) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plsd(int id) //删除学习评论表数据
    {
        string sql = "Delete pl_sd where plsdID=@plsdID";
        SqlParameter[] pars = { new SqlParameter("@plsdID", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Update_downsdpl(int id) //随着评论数据删除学习表的数据也随着减少
    {
        string sql = "update sy_study set sdpl=sdpl-1 where sdid=@sdid";
        SqlParameter[] pars = { new SqlParameter("@sdid", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plsd_del(int id) //删除sy_study表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_sd where sdId=@sdId";
        SqlParameter[] pars = { new SqlParameter("@sdId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    //---------------------------------------------------------------

    //统计所有管理员的数据
    public static int adminTotal()
    {
        string sql = "select count(adminname) from admin_tb";
        return sydb.Total(sql);
    }
    //验证管理员账号密码
    public static bool selectlogin(string username, string password)
    {
        string sql = "select * from admin_tb where adminname=@adminname and adminpwd=@adminpwd";
        SqlParameter[] pars = { new SqlParameter("@adminname", username), new SqlParameter("@adminpwd", password) };
        return sydb.selectlogin(sql, pars);
    }

    //管理 
    public static int Update_admin(int id, string name, string pwd, string sm)
    {
        string sql = "update admin_tb set adminname=@adminname,adminpwd=@adminpwd,adminsm=@adminsm where adminId=@adminId";
        SqlParameter[] pars={new SqlParameter("@adminId",id),new SqlParameter("@adminname",name),new SqlParameter("@adminpwd",pwd),new SqlParameter("@adminsm",sm)};
        return sydb.ExeCUD(sql, pars);
    }

    public static int Delete_admin(int id) //删除admin_tb表数据
    {
        string sql = "Delete admin_tb where adminId=@adminId";
        SqlParameter[] pars = { new SqlParameter("@adminId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_admin(string name, string pwd, string sm)
    {
        string sql = "insert into admin_tb(adminname,adminpwd,adminsm)values(@adminname,@adminpwd,@adminsm)";
        SqlParameter[] pars = { new SqlParameter("@adminname", name), new SqlParameter("@adminpwd", pwd), new SqlParameter("@adminsm", sm) };
        return sydb.ExeCUD(sql, pars);
    }

    //新闻表
    public static int Update_news(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_news表数据
    {
        string sql = "update sy_news set newsTitle=@newsTitle,newsCon=@newsCon,newsImg=@newsImg,newsfbren=@newsfbren,newsTime=@newsTime,newspl=@newspl where newsId=@newsId";
        SqlParameter[] pars = { new SqlParameter("@newsId", id), new SqlParameter("@newsTitle", title), new SqlParameter("@newsCon", con), new SqlParameter("@newsImg", img), new SqlParameter("@newsfbren", fbman), new SqlParameter("@newsTime", time), new SqlParameter("@newspl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_news(int id) //删除sy_nes表数据
    {
        string sql = "Delete sy_news where newsId=@newsId";
        SqlParameter[] pars = { new SqlParameter("@newsId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_plnews_del(int id) //删除sy_nes表数据的同时评论表的数据也删除
    {
        string sql = "Delete pl_news where newsId=@newsId";
        SqlParameter[] pars = { new SqlParameter("@newsId", id) };
        return sydb.ExeCUD(sql, pars);
    }

    public static int Insert_news(string title, string con, string img, string fbman, string time) //插入sy_news表数据
    {
        string sql = "insert into sy_news(newsTitle,newsCon,newsImg,newsfbren,newsTime)values(@newsTitle,@newsCon,@newsImg,@newsfbren,@newsTime)";
        SqlParameter[] pars = { new SqlParameter("@newsTitle", title), new SqlParameter("@newsCon", con), new SqlParameter("@newsImg", img), new SqlParameter("@newsfbren", fbman), new SqlParameter("@newsTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //校园表
    public static int Update_xy(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_xiaoy表数据
    {
        string sql = "update sy_xiaoy set xyTitle=@xyTitle,xyCon=@xyCon,xyImg=@xyImg,xyFbman=@xyFbman,xyTime=@xyTime,xypl=@xypl where xyId=@xyId";
        SqlParameter[] pars = { new SqlParameter("@xyId", id), new SqlParameter("@xyTitle", title), new SqlParameter("@xyCon", con), new SqlParameter("@xyImg", img), new SqlParameter("@xyFbman", fbman), new SqlParameter("@xyTime", time), new SqlParameter("@xypl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_xy(int id) //删除sy_xiaoy表数据
    {
        string sql = "Delete sy_xiaoy where xyId=@xyId";
        SqlParameter[] pars = { new SqlParameter("@xyId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_xy(string title, string con, string img, string fbman, string time) //插入sy_xiaoy表数据
    {
        string sql = "insert into sy_xiaoy(xyTitle,xyCon,xyImg,xyfbman,xyTime)values(@xyTitle,@xyCon,@xyImg,@xyfbman,@xyTime)";
        SqlParameter[] pars = { new SqlParameter("@xyTitle", title), new SqlParameter("@xyCon", con), new SqlParameter("@xyImg", img), new SqlParameter("@xyfbman", fbman), new SqlParameter("@xyTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //娱乐表
    public static int Update_yl(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_yule表数据
    {
        string sql = "update sy_yule set yuleTitle=@yuleTitle,yuleCon=@yuleCon,yuleImg=@yuleImg,yuleFbman=@yuleFbman,yuleTime=@yuleTime,yulePl=@yulePl where yuleId=@yuleId";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id), new SqlParameter("@yuleTitle", title), new SqlParameter("@yuleCon", con), new SqlParameter("@yuleImg", img), new SqlParameter("@yuleFbman", fbman), new SqlParameter("@yuleTime", time), new SqlParameter("@yulepl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_yl(int id) //删除sy_yule表数据
    {
        string sql = "Delete sy_yule where yuleId=@yuleId";
        SqlParameter[] pars = { new SqlParameter("@yuleId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_yl(string title, string con, string img, string fbman, string time) //插入sy_yule表数据
    {
        string sql = "insert into sy_yule(yuleTitle,yuleCon,yuleImg,yulefbman,yuleTime)values(@yuleTitle,@yuleCon,@yuleImg,@yulefbman,@yuleTime)";
        SqlParameter[] pars = { new SqlParameter("@yuleTitle", title), new SqlParameter("@yuleCon", con), new SqlParameter("@yuleImg", img), new SqlParameter("@yulefbman", fbman), new SqlParameter("@yuleTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //体育表
    public static int Update_ty(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_tiyu表数据
    {
        string sql = "update sy_tiyu set tyTitle=@tyTitle,tyCon=@tyCon,tyImg=@tyImg,tyFbman=@tyFbman,tyTime=@tyTime,tyPl=@tyPl where tyId=@tyId";
        SqlParameter[] pars = { new SqlParameter("@tyId", id), new SqlParameter("@tyTitle", title), new SqlParameter("@tyCon", con), new SqlParameter("@tyImg", img), new SqlParameter("@tyFbman", fbman), new SqlParameter("@tyTime", time), new SqlParameter("@typl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_ty(int id) //删除sy_tiyu表数据
    {
        string sql = "Delete sy_tiyu where tyId=@tyId";
        SqlParameter[] pars = { new SqlParameter("@tyId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_ty(string title, string con, string img, string fbman, string time) //插入sy_tiyu表数据
    {
        string sql = "insert into sy_tiyu(tyTitle,tyCon,tyImg,tyfbman,tyTime)values(@tyTitle,@tyCon,@tyImg,@tyfbman,@tyTime)";
        SqlParameter[] pars = { new SqlParameter("@tyTitle", title), new SqlParameter("@tyCon", con), new SqlParameter("@tyImg", img), new SqlParameter("@tyfbman", fbman), new SqlParameter("@tyTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //游戏表
    public static int Update_yx(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_game表数据
    {
        string sql = "update sy_game set gameTitle=@gameTitle,gameCon=@gameCon,gameImg=@gameImg,gameFbman=@gameFbman,gameTime=@gameTime,gamePl=@gamePl where gameId=@gameId";
        SqlParameter[] pars = { new SqlParameter("@gameId", id), new SqlParameter("@gameTitle", title), new SqlParameter("@gameCon", con), new SqlParameter("@gameImg", img), new SqlParameter("@gameFbman", fbman), new SqlParameter("@gameTime", time), new SqlParameter("@gamepl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_yx(int id) //删除sy_game表数据
    {
        string sql = "Delete sy_game where gameId=@gameId";
        SqlParameter[] pars = { new SqlParameter("@gameId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_yx(string title, string con, string img, string fbman, string time) //插入sy_game表数据
    {
        string sql = "insert into sy_game(gameTitle,gameCon,gameImg,gamefbman,gameTime)values(@gameTitle,@gameCon,@gameImg,@gamefbman,@gameTime)";
        SqlParameter[] pars = { new SqlParameter("@gameTitle", title), new SqlParameter("@gameCon", con), new SqlParameter("@gameImg", img), new SqlParameter("@gamefbman", fbman), new SqlParameter("@gameTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //汽车表
    public static int Update_qc(int id, string title, string con, string price, string img, string fbman, string time, int pl) //更新sy_qiche表数据
    {
        string sql = "update sy_qiche set qcTitle=@qcTitle,qcCon=@qcCon,qcPrice=@qcPrice,qcImg=@qcImg,qcFbman=@qcFbman,qcTime=@qcTime,qcPl=@qcPl where qcId=@qcId";
        SqlParameter[] pars = { new SqlParameter("@qcId", id), new SqlParameter("@qcTitle", title), new SqlParameter("@qcCon", con), new SqlParameter("@qcPrice", price), new SqlParameter("@qcImg", img), new SqlParameter("qcFbman", fbman), new SqlParameter("@qcTime", time), new SqlParameter("@qcpl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_qc(int id) //删除sy_qiche表数据
    {
        string sql = "Delete sy_game where qcId=@qcId";
        SqlParameter[] pars = { new SqlParameter("@qcId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_qc(string title, string con,string price, string img, string fbman, string time) //插入sy_qiche表数据
    {
        string sql = "insert into sy_qiche(qcTitle,qcCon,qcPrice,qcImg,qcfbman,qcTime)values(@qcTitle,@qcCon,@qcPrice,@qcImg,@qcfbman,@qcTime)";
        SqlParameter[] pars = { new SqlParameter("@qcTitle", title), new SqlParameter("@qcCon", con), new SqlParameter("@qcPrice", price), new SqlParameter("@qcImg", img), new SqlParameter("@qcfbman", fbman), new SqlParameter("@qcTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //科技表
    public static int Update_kj(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_keji表数据
    {
        string sql = "update sy_keji set kjTitle=@kjTitle,kjCon=@kjCon,kjImg=@kjImg,kjFbman=@kjFbman,kjTime=@kjTime,kjPl=@kjPl where kjId=@kjId";
        SqlParameter[] pars = { new SqlParameter("@kjId", id), new SqlParameter("@kjTitle", title), new SqlParameter("@kjCon", con), new SqlParameter("@kjImg", img), new SqlParameter("@kjFbman", fbman), new SqlParameter("@kjTime", time), new SqlParameter("@kjpl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_kj(int id) //删除sy_keji表数据
    {
        string sql = "Delete sy_keji where kjId=@kjId";
        SqlParameter[] pars = { new SqlParameter("@kjId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_kj(string title, string con, string img, string fbman, string time) //插入sy_keji表数据
    {
        string sql = "insert into sy_keji(kjTitle,kjCon,kjImg,kjfbman,kjTime)values(@kjTitle,@kjCon,@kjImg,@kjfbman,@kjTime)";
        SqlParameter[] pars = { new SqlParameter("@kjTitle", title), new SqlParameter("@kjCon", con), new SqlParameter("@kjImg", img), new SqlParameter("@kjfbman", fbman), new SqlParameter("@kjTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //健康表
    public static int Update_jk(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_jiank表数据
    {
        string sql = "update sy_jiank set jkTitle=@jkTitle,jkCon=@jkCon,jkImg=@jkImg,jkFbman=@jkFbman,jkTime=@jkTime,jkPl=@jkPl where jkId=@jkId";
        SqlParameter[] pars = { new SqlParameter("@jkId", id), new SqlParameter("@jkTitle", title), new SqlParameter("@jkCon", con), new SqlParameter("@jkImg", img), new SqlParameter("@jkFbman", fbman), new SqlParameter("@jkTime", time), new SqlParameter("@jkpl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_jk(int id) //删除sy_jiank表数据
    {
        string sql = "Delete sy_jiank where jkId=@jkId";
        SqlParameter[] pars = { new SqlParameter("@jkId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_jk(string title, string con, string img, string fbman, string time) //插入sy_jiank表数据
    {
        string sql = "insert into sy_jiank(jkTitle,jkCon,jkImg,jkfbman,jkTime)values(@jkTitle,@jkCon,@jkImg,@jkfbman,@jkTime)";
        SqlParameter[] pars = { new SqlParameter("@jkTitle", title), new SqlParameter("@jkCon", con), new SqlParameter("@jkImg", img), new SqlParameter("@jkfbman", fbman), new SqlParameter("@jkTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //旅游表
    public static int Update_ly(int id, string title, string con, string price, string img, string fbman, string time, int pl) //更新sy_qiche表数据
    {
        string sql = "update sy_lyou set lyTitle=@lyTitle,lyCon=@lyCon,lyPrice=@lyPrice,lyImg=@lyImg,lyFbman=@lyFbman,lyTime=@lyTime,lyPl=@lyPl where lyId=@lyId";
        SqlParameter[] pars = { new SqlParameter("@lyId", id), new SqlParameter("@lyTitle", title), new SqlParameter("@lyCon", con), new SqlParameter("@lyPrice", price), new SqlParameter("@lyImg", img), new SqlParameter("lyFbman", fbman), new SqlParameter("@lyTime", time), new SqlParameter("@lypl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_ly(int id) //删除sy_qiche表数据
    {
        string sql = "Delete sy_lyou where lyId=@lyId";
        SqlParameter[] pars = { new SqlParameter("@lyId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_ly(string title, string con, string price, string img, string fbman, string time) //插入sy_qiche表数据
    {
        string sql = "insert into sy_lyou(lyTitle,lyCon,lyPrice,lyImg,lyfbman,lyTime)values(@lyTitle,@lyCon,@lyPrice,@lyImg,@lyfbman,@lyTime)";
        SqlParameter[] pars = { new SqlParameter("@lyTitle", title), new SqlParameter("@lyCon", con), new SqlParameter("@lyPrice", price), new SqlParameter("@lyImg", img), new SqlParameter("@lyfbman", fbman), new SqlParameter("@lyTime", time) };
        return sydb.ExeCUD(sql, pars);
    }


    //时尚表
    public static int Update_sx(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_shix表数据
    {
        string sql = "update sy_shix set sxTitle=@sxTitle,sxCon=@sxCon,sxImg=@sxImg,sxFbman=@sxFbman,sxTime=@sxTime,sxPl=@sxPl where sxId=@sxId";
        SqlParameter[] pars = { new SqlParameter("@sxId", id), new SqlParameter("@sxTitle", title), new SqlParameter("@sxCon", con), new SqlParameter("@sxImg", img), new SqlParameter("@sxFbman", fbman), new SqlParameter("@sxTime", time), new SqlParameter("@sxpl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_sx(int id) //删除sy_shix表数据
    {
        string sql = "Delete sy_shix where sxId=@sxId";
        SqlParameter[] pars = { new SqlParameter("@sxId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_sx(string title, string con, string img, string fbman, string time) //插入sy_shix表数据
    {
        string sql = "insert into sy_shix(sxTitle,sxCon,sxImg,sxfbman,sxTime)values(@sxTitle,@sxCon,@sxImg,@sxfbman,@sxTime)";
        SqlParameter[] pars = { new SqlParameter("@sxTitle", title), new SqlParameter("@sxCon", con), new SqlParameter("@sxImg", img), new SqlParameter("@sxfbman", fbman), new SqlParameter("@sxTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //美食表
    public static int Update_ms(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_meishi表数据
    {
        string sql = "update sy_meishi set msTitle=@msTitle,msCon=@msCon,msImg=@msImg,msFbman=@msFbman,msTime=@msTime,msPl=@msPl where msId=@msId";
        SqlParameter[] pars = { new SqlParameter("@msId", id), new SqlParameter("@msTitle", title), new SqlParameter("@msCon", con), new SqlParameter("@msImg", img), new SqlParameter("@msFbman", fbman), new SqlParameter("@msTime", time), new SqlParameter("@mspl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_ms(int id) //删除sy_meishi表数据
    {
        string sql = "Delete sy_meishi where msId=@msId";
        SqlParameter[] pars = { new SqlParameter("@msId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_ms(string title, string con, string img, string fbman, string time) //插入sy_meishi表数据
    {
        string sql = "insert into sy_meishi(msTitle,msCon,msImg,msfbman,msTime)values(@msTitle,@msCon,@msImg,@msfbman,@msTime)";
        SqlParameter[] pars = { new SqlParameter("@msTitle", title), new SqlParameter("@msCon", con), new SqlParameter("@msImg", img), new SqlParameter("@msfbman", fbman), new SqlParameter("@msTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //学习表
    public static int Update_sd(int id, string title, string con, string img, string fbman, string time, int pl) //更新sy_study表数据
    {
        string sql = "update sy_study set sdTitle=@sdTitle,sdCon=@sdCon,sdImg=@sdImg,sdFbman=@sdFbman,sdTime=@sdTime,sdPl=@sdPl where sdId=@sdId";
        SqlParameter[] pars = { new SqlParameter("@sdId", id), new SqlParameter("@sdTitle", title), new SqlParameter("@sdCon", con), new SqlParameter("@sdImg", img), new SqlParameter("@sdFbman", fbman), new SqlParameter("@sdTime", time), new SqlParameter("@sdpl", pl) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_sd(int id) //删除sy_study表数据
    {
        string sql = "Delete sy_study where sdId=@sdId";
        SqlParameter[] pars = { new SqlParameter("@sdId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_sd(string title, string con, string img, string fbman, string time) //插入sy_study表数据
    {
        string sql = "insert into sy_study(sdTitle,sdCon,sdImg,sdfbman,sdTime)values(@sdTitle,@sdCon,@sdImg,@sdfbman,@sdTime)";
        SqlParameter[] pars = { new SqlParameter("@sdTitle", title), new SqlParameter("@sdCon", con), new SqlParameter("@sdImg", img), new SqlParameter("@sdfbman", fbman), new SqlParameter("@sdTime", time) };
        return sydb.ExeCUD(sql, pars);
    }

    //商品表
    public static int Update_sp(int id, int flid, string title, string img, string fbman) //更新sy_sptb表数据
    {
        string sql = "update sy_sptb set spTitle=@spTitle,spflid=@spflid,spImg=@spImg,spFbman=@spFbman where spId=@spId";
        SqlParameter[] pars = { new SqlParameter("@spId", id), new SqlParameter("@spflid",flid), new SqlParameter("@spTitle", title), new SqlParameter("@spImg", img), new SqlParameter("@spFbman", fbman) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_sp(int id) //删除sy_sptb表数据
    {
        string sql = "Delete sy_sptb where spId=@spId";
        SqlParameter[] pars = { new SqlParameter("@spId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_sp(int flid,string title,string price, string img, string fbman) //插入sy_sptb表数据
    {
        string sql = "insert into sy_sptb(spflid,spTitle,spPrice,spImg,spfbman)values(@spflid,@spTitle,@spPrice,@spImg,@spfbman)";
        SqlParameter[] pars = {  new SqlParameter("@spflid",flid),new SqlParameter("@spTitle", title),new SqlParameter("@spPrice",price), new SqlParameter("@spImg", img), new SqlParameter("@spfbman", fbman)};
        return sydb.ExeCUD(sql, pars);
    }
    //商品分类表
    public static int Update_spfl(int id, string flname) //更新sy_sptb表数据
    {
        string sql = "update sy_spfl set spflname=@spflname where spflId=@spflId";
        SqlParameter[] pars = { new SqlParameter("@spflId", id), new SqlParameter("@spflname", flname) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_spfl(int id) //删除sy_sptb表数据
    {
        string sql = "Delete sy_spfl where spflid=@spflId";
        SqlParameter[] pars = { new SqlParameter("@spflId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_spfl(string flname) //插入sy_sptb表数据
    {
        string sql = "insert into sy_spfl(spflname)values(@spflname)";
        SqlParameter[] pars = { new SqlParameter("@spflname", flname) };
        return sydb.ExeCUD(sql, pars);
    }

    //电影表
    public static int Update_dy(int id,  string title,string Con, string img, string Yy,string time) //更新sy_diany表数据
    {
        string sql = "update sy_diany set dyTitle=@dyTitle,dyCon=@dyCon,dyImg=@dyImg,dyYy=@dyYy,dyTime=@dyTime where dyId=@dyId";
        SqlParameter[] pars = { new SqlParameter("@dyId", id), new SqlParameter("@dyTitle", title), new SqlParameter("@dyCon", Con), new SqlParameter("@dyImg", img), new SqlParameter("@dyYy", Yy),new SqlParameter("@dyTime",time) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Delete_dy(int id) //删除sy_diany表数据
    {
        string sql = "Delete sy_diany where dyId=@dyId";
        SqlParameter[] pars = { new SqlParameter("@dyId", id) };
        return sydb.ExeCUD(sql, pars);
    }
    public static int Insert_dy( string title,string con, string img, string yy,string time) //插入sy_diany表数据
    {
        string sql = "insert into sy_diany(dyTitle,dycon,dyImg,dyYy,dyTime)values(@dyTitle,@dycon,@dyImg,@dyYy,@dyTime)";
        SqlParameter[] pars = {  new SqlParameter("@dyTitle", title), new SqlParameter("@dyCon", con), new SqlParameter("@dyImg", img), new SqlParameter("@dyYy", yy), new SqlParameter("@dyTime", time) };
        return sydb.ExeCUD(sql, pars);
    }
}