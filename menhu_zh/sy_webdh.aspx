<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sy_webdh.aspx.cs" Inherits="sy_webdh" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/Telescopic.css" rel="stylesheet" />
    <link href="css/sy_shouye.css" rel="stylesheet" />
    <script type="text/javascript" src="js/JQuery_1.82.js"></script>
    <script type="text/javascript" src="js/sy_shouye.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>网站导航</title>
</head>
<body>
    <form id="form1" runat="server">
       <div id="box">
       <div class="head">
           <div class="h_left1">
              
           </div>
           <div class="h_right"><a onclick="this.style.behavior='url(#default#homepage)';this.setHomePage('http://localhost/sy_shouye.aspx');" href="#">设为首页</a>&nbsp;<span class="wz1">|</span>&nbsp;<a href="#">收藏本站</a>&nbsp;<span class="wz1">|</span>&nbsp;<a href="sy_webdh.aspx">网站导航</a>&nbsp;&nbsp;</div>
       </div>
       <div class="nav1">
           <div class="n_left"><span class="wz2">W蓝科技-</span><span class="wz3">服务邵阳</span><br/><span class="wz4">WBlue Technology</span></div>
           <div class="n_middle"><a href="http://jiameng.dqccc.com/"><img src="images/gg/gg1.png" alt="自己广告" /></a></div>
           <div class="n_right"><a href="http://jiameng.dqccc.com/quan/"><img src="images/gg/gg3.png" alt="其它广告" /></a></div>
       </div>
       <div class="redian">
           <ul>
               <li class="l4">资讯</li>
               <li class="l2">
                   <a href="content/sy_news.aspx" target="_blank">新闻</a>
                   <a href="content/sy_xiaoy.aspx" target="_blank">校园</a>
                   <a href="content/sy_yule.aspx" target="_blank">娱乐</a>
                   <a href="content/sy_tiyu.aspx" target="_blank">体育</a>
                   <a href="content/sy_game.aspx" target="_blank">游戏</a>
                   <a href="content/sy_qiche.aspx" target="_blank">汽车</a>
               </li>
               <li class="l1">生活</li>
               <li class="l2">
                   <a href="content/sy_keji.aspx" target="_blank">科技</a>
                   <a href="content/sy_jiank.aspx" target="_blank">健康</a>
                   <a href="content/sy_lyou.aspx" target="_blank">旅游</a>
                   <a href="https://www.taobao.com/" target="_blank">商城</a>
                   <a href="content/sy_shix.aspx" target="_blank">时尚</a>
                   <a href="#" target="_blank">美食</a>
               </li>
               
               <li class="l1">电影</li>
               <li class="l2">
                   <a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">大地</a>
                   <a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">大从</a>
                   <a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">青年</a>
                   <a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">1.75</a>
                   <a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">广电</a>
                   <a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">咨询</a>
               </li>
               <li class="l1">互动</li>
               <li class="l3">
                   <a href="content/sy_luntan.aspx" target="_blank">论坛</a>
                   <a href="content/sy_weibo.aspx" target="_blank">微博</a>
                   <a href="content/sy_study.aspx" target="_blank">学习</a>  
               </li>
               <li class="l1">广告</li>
               <li class="l5">
                   <a href="http://www.shaoyangw.com/portal.php?mod=view&aid=2"><img src="images/gg/gg4.png" alt="深圳市易达科技有限公司" /></a>
               </li>
               <li class="l6">
                   <a href="http://www.0739i.com.cn/"><img src="images/gg/gg6.png" alt="邵阳资讯网" /></a>
               </li>
           </ul>
       </div>
       <div class="main">
           <div class="dhang">
               <div class="dh_top">网站导航</div>
               <div class="dh_con">
                   <ul>
                       <li><a href="sy_shouye.aspx">首页</a></li>
                       <li><a href="sy_zhuce.aspx">注册</a></li>
                       <li><a href="zhmm.aspx">找回密码</a></li>
                       <li><a href="content/sy_yule.aspx" target="_blank">娱乐</a></li>
                   <li><a href="content/sy_tiyu.aspx" target="_blank">体育</a></li>
                   <li><a href="content/sy_game.aspx" target="_blank">游戏</a></li>
                   <li><a href="content/sy_qiche.aspx" target="_blank">汽车</a></li>
                       <li><a href="content/sy_keji.aspx" target="_blank">科技</a></li>
                   <li><a href="content/sy_jiank.aspx" target="_blank">健康</a></li>
                   <li><a href="content/sy_lyou.aspx" target="_blank">旅游</a></li>
                   <li><a href="https://www.taobao.com/" target="_blank">商城</a></li>
                   <li><a href="content/sy_shix.aspx" target="_blank">时尚</a></li>
                   <li><a href="content/sy_meishi.aspx" target="_blank">美食</a></li>
                       <li><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">大地</a></li>
                   <li><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">大从</a></li>
                   <li><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">青年</a></li>
                   <li><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">1.75</a></li>
                   <li><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">广电</a></li>
                   <li><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/" target="_blank">咨询</a></li>
                        <li><a href="content/sy_luntan.aspx" target="_blank">论坛</a></li>
                    <li><a href="content/sy_weibo.aspx" target="_blank">微博</a></li>
                    <li><a href="content/sy_study.aspx" target="_blank">学习</a></li>
                       <li><a href="content/sy_aboutme.htm">关于我们</a></li>
                       <li><a href="content/sy_callme.htm">联系我们</a></li>  
                   </ul>
               </div>
           </div>
       </div>
       <div class="bottom">
              <div class="b_top"><a href="content/sy_aboutme.htm">关于我们</a>|<a href="content/sy_callme.htm">联系我们</a>|<a href="http://www.syzyedu.com/">友情链接</a>|<a href="https://mail.qq.com/cgi-bin/loginpage">QQ邮箱</a>|客服热线：0739-111111|客服QQ：862881341<br/>Copyright© 2015　dqccc.com. All Rights Reserved<br/>版权所有  W蓝科技  湘ICP证04322号  湘ICP备43222211号</div>
              <div class="b_con">
                  <a href="http://net.china.com.cn/" target="_blank"><img src="images/db/db_bl.png" /></a>
                  <a href="http://www.cyberpolice.cn/wfjb/" target="_blank"><img src="images/db/db_wj.png" /></a>
                  <a href="http://www.wenming.cn/wmpl_pd/yczl/201506/t20150629_2701547.shtml" target="_blank"><img src="images/db/db_cb.png" /></a>
              </div>
          </div>
       </div>
    
    </form>
</body>
</html>
