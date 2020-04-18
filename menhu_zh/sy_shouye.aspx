<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sy_shouye.aspx.cs" Inherits="sy_shouye" Debug="true" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="css/Telescopic.css" rel="stylesheet" />
    <link href="css/sy_shouye.css" rel="stylesheet" />
    <script type="text/javascript" src="js/JQuery_1.82.js"></script>
    <script type="text/javascript" src="js/sy_shouye.js"></script>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>邵阳资讯网</title>
</head>
<body>
    <form id="form1" runat="server">
    <div id="box">
       <div class="head">
           <div class="h_left">
               <ul>
                   <li>用户名：<asp:TextBox ID="txtname" runat="server" Width="100px" Height="20px"></asp:TextBox></li>
                   <li>密码：<asp:TextBox ID="txtpwd" runat="server" Width="100px" TextMode="Password" Height="20px"></asp:TextBox></li>
                   <li class="llll1">
                       <asp:Button ID="btndl" runat="server" Text="登录" Width="50px" Height="22px" OnClick="btndl_Click" />&nbsp;&nbsp;<asp:Button ID="btnres" runat="server" Text="注册" Width="50px" Height="22px" OnClick="btnres_Click" /></li>
                   <li class="lll1"><a href="zhmm.aspx">找回密码</a></li>
               </ul>
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
                   <a href="content/sy_meishi.aspx" target="_blank">美食</a>
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
           <div class="zixun">
               <div class="z_top">
                 <div class="t_t1">新闻</div>
               <a href="content/sy_news.aspx">更多》</a></div>
               <div class="z_con">
                   <asp:Repeater ID="rptnews" runat="server">
                       <HeaderTemplate><ul></HeaderTemplate>
                       <ItemTemplate>
                          
                               <li>
                                   <asp:HyperLink ID="HyperLink1" runat="server" Text='<%# ziduanjq.Jq_nesbt(Eval("newsTitle").ToString()) %>' NavigateUrl='<%# Eval("newsId","content/sy_news_content.aspx?xw_id={0}") %>'></asp:HyperLink></li>
                          
                       </ItemTemplate>
                       <FooterTemplate></ul></FooterTemplate>
                   </asp:Repeater>
               </div>
           </div>
           <div class="zixun1">
               <div class="z_top">
                 <div class="t_t1">校园</div>
              <a href="content/sy_xiaoy.aspx">更多》</a></div>
              <div class="xy_con">
                  <div class="x_con1">
                      <asp:Repeater ID="rptxy1" runat="server">
                          <HeaderTemplate><ul></HeaderTemplate>
                          <ItemTemplate>
                              <li class="xyl1">
                                  <asp:Image ID="imgxy" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("xyImg").ToString()) %>' /></li>
                              <li class="xyl2"><span class="xyzt1">
                                  <asp:HyperLink ID="hylxy1" runat="server" Text='<%#ziduanjq.Jq_xybt(Eval("xyTitle").ToString()) %>' NavigateUrl='<%# Eval("xyId","content/sy_xy_content.aspx?xy_id={0}") %>'></asp:HyperLink></span>
                                  <br/><span class="xyzt2">
                                      <asp:Literal ID="ltxy1" runat="server" Text='<%#ziduanjq.Jq_xyCon(Eval("xyCon").ToString()) %>'></asp:Literal></span>
                              </li>
                          </ItemTemplate>
                          <FooterTemplate></ul></FooterTemplate>
                      </asp:Repeater>
                  </div>
                  <div class="x_con2">
                      <asp:Repeater ID="rptxy2" runat="server">
                          <HeaderTemplate><ul></HeaderTemplate>
                          <ItemTemplate>
                              <li class="xyl3"><span class="xyzt3">
                                  <asp:HyperLink ID="hylxy2" runat="server" Text='<%#ziduanjq.Jq_xybt1(Eval("xyTitle").ToString()) %>' NavigateUrl='<%# Eval("xyId","content/sy_xy_content.aspx?xy_id={0}") %>'></asp:HyperLink></span>
                                  <br/><span class="xyzt4">
                                      <asp:Literal ID="ltxy2" runat="server" Text='<%#ziduanjq.Jq_xyCon1(Eval("xyCon").ToString()) %>'></asp:Literal></span>
                              </li>
                          </ItemTemplate>
                          <FooterTemplate></ul></FooterTemplate>
                      </asp:Repeater>
                  </div>
              </div>
           </div>
          </div>
          <div class="yule">
              <div class="y_top">娱乐快讯</div>
              <div class="y_top1"><a href="content/sy_yule.aspx">更多》</a></div>
              <div class="y_con">
                <div id="taobao">
                 <asp:Repeater ID="Repeater1" runat="server">
                   <HeaderTemplate><ul></HeaderTemplate>
                   <ItemTemplate>
                       <li>
                           <asp:Image ID="Imgyl" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("yuleImg").ToString()) %>' />
                       </li>         
                   </ItemTemplate>
                   <FooterTemplate></ul></FooterTemplate>
                 </asp:Repeater>
                </div>
              </div>
              <div class="y_con1">
                  <asp:Repeater ID="rptyule1" runat="server">
                      <HeaderTemplate><ul></HeaderTemplate>
                      <ItemTemplate>
                          <li>
                              <asp:HyperLink ID="hylyl1" runat="server" Text='<%#Class1.Jqziduan(Eval("yuleTitle").ToString()) %>' NavigateUrl='<%# Eval("yuleId","content/sy_yl_content.aspx?yl_id={0}") %>'></asp:HyperLink></li>
                      </ItemTemplate>
                      <FooterTemplate></ul></FooterTemplate>
                  </asp:Repeater>
              </div>
              <div class="y_con2">
                  <div class="c_top1">游戏资讯</div>
                  <div class="c_top2"><a href="content/sy_game.aspx">更多》</a></div>
                  <div class="c_con1">
                      <asp:Repeater ID="rptgame" runat="server">
                          <HeaderTemplate><ul></HeaderTemplate>
                          <ItemTemplate>
                                  <li class="li1"><asp:Image ID="Image2" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("gameImg").ToString()) %>' /></li>
                                  <li class="li2">
                                     <asp:HyperLink ID="hlkyx1" runat="server" Text='<%# ziduanjq.Jq_yxbt(Eval("gameTitle").ToString
                                     ()) %>' NavigateUrl='<%# Eval("gameId","content/sy_yx_content.aspx?yx_id={0}") %>'></asp:HyperLink></li>
                           </ItemTemplate>
                          <FooterTemplate></ul></FooterTemplate>
                      </asp:Repeater>
                  </div>
              </div>
              <div class="y_con3">
                  <div class="c_top1">体育资讯</div>
                  <div class="c_top2"><a href="content/sy_tiyu.aspx">更多》</a></div>
                  <div class="ty_con">
                      <asp:Repeater ID="rptty1" runat="server">
                          <HeaderTemplate><ul></HeaderTemplate>
                          <ItemTemplate>
                              <li class="tyl1">
                                  <asp:Image ID="imgty" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("tyImg").ToString()) %>'/></li>
                              <li class="tyl2"><span class="tyzt1">
                                  <asp:HyperLink ID="hylty" runat="server" Text='<%# ziduanjq.Jq_tybt(Eval("tyTitle").ToString()) %>' NavigateUrl='<%# Eval("tyId","content/sy_ty_content.aspx?ty_id={0}") %>'></asp:HyperLink></span><br/><span class="tyzt2"><asp:Literal ID="ltty" runat="server" Text='<%# ziduanjq.Jq_tyCon(Eval("tyCon").ToString()) %>'></asp:Literal></span></li>
                          </ItemTemplate>
                          <FooterTemplate></ul></FooterTemplate>
                      </asp:Repeater>
                  </div>
              </div>
          </div>
          <div class="middle">
              <div class="m_left">
                <div class="ml_top">科技
                <div class="ml_top1"><a href="content/sy_keji.aspx">更多》</a></div>
                </div>
                <div class="kj_con">
                    <asp:Repeater ID="rptkj" runat="server">
                        <HeaderTemplate><ul></HeaderTemplate>
                        <ItemTemplate>
                            <li class="kjl1">
                                <asp:Image ID="Image3" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("kjImg").ToString()) %>' /></li>
                            <li class="kjl2"><span class="kjzt1">
                                <asp:HyperLink ID="hylkj" runat="server" Text='<%# ziduanjq.Jq_kjbt(Eval("kjTitle").ToString()) %>' NavigateUrl='<%# Eval("kjId","content/sy_kj_content.aspx?kj_id={0}") %>'></asp:HyperLink></span><br/>
                                <span class="kjzt2"><asp:Literal ID="Literal1" runat="server" Text='<%# ziduanjq.Jq_kjcon(Eval("kjCon").ToString()) %>'></asp:Literal></span></li>
                        </ItemTemplate>
                        <FooterTemplate></ul></FooterTemplate>
                    </asp:Repeater>
                </div>
                <div class="kj_con1">
                    <asp:Repeater ID="rptkj1" runat="server">
                        <HeaderTemplate><ul></HeaderTemplate>
                        <ItemTemplate><li>
                            <asp:HyperLink ID="hylkj1" runat="server" Text='<%# ziduanjq.Jq_kjbt1(Eval("kjTitle").ToString())
 %>' NavigateUrl='<%# Eval("kjId","content/sy_kj_content.aspx?kj_id={0}") %>'></asp:HyperLink></li></ItemTemplate>
                        <FooterTemplate></ul></FooterTemplate>
                    </asp:Repeater>
                </div>
                
              </div>
              <div class="m_middle">
                <div class="qc_top">汽车
                  <div class="qc_top1"><a href="content/sy_qiche.aspx">更多》</a></div>
                </div>
                <div class="qc_con">
                   <div id="focus_change">
                       <div id="focus_change_list" style="top:0; left:0;">
                            <asp:Repeater ID="rptqc1" runat="server">
                                <HeaderTemplate><ul></HeaderTemplate>
                                <ItemTemplate>
                                    <li>
                                        <asp:Image ID="Imgqc1" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("qcImg").ToString()) %>' /></li>
                                </ItemTemplate>
                                <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                    </div>
                    <div id="focus_change_btn">
                        <asp:Repeater ID="rptqc2" runat="server">
                            <HeaderTemplate><ul></HeaderTemplate>
                            <ItemTemplate>
                                <li>
                                    <asp:Image ID="Imgqc2" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("qcImg").ToString()) %>' /></li>
                            </ItemTemplate>
                            <FooterTemplate></ul></FooterTemplate>
                        </asp:Repeater>
                    </div>
                  </div>
                 </div>
                 <div class="qc_con1">
                     <asp:Repeater ID="rptqc3" runat="server">
                         <HeaderTemplate><ul></HeaderTemplate>
                         <ItemTemplate>
                             <li class="qcl1">
                                 <asp:Image ID="Imgqc3" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("qcImg").ToString()) %>'/></li>
                             <li class="qcl2"><span class="qczt1"><asp:HyperLink ID="hplqc1" runat="server" Text='<%# ziduanjq.Jq_qcbt(Eval("qcTitle").ToString()) %>' NavigateUrl='<%# Eval("qcId","content/sy_qc_content.aspx?qc_id={0}") %>'></asp:HyperLink></span><br/><span class="qczt2">
                                 <asp:Label ID="lbqccon" runat="server" Text='<%# ziduanjq.Jq_qccon(Eval("qcCon").ToString()) %>'></asp:Label></span><br/><span class="qczt2">汽车价格：<asp:Label ID="lbqcprice" runat="server" Text='<%# Eval("qcPrice") %>'></asp:Label></span><br/>
                                 <span class="qczt2">上市时间：<asp:Label ID="lbqctime" runat="server" Text='<%# Eval("qcTime") %>'></asp:Label></span>
                             </li>
                         </ItemTemplate>
                         <FooterTemplate></ul></FooterTemplate>
                     </asp:Repeater>
                 </div>
              </div>
              <div class="m_right">
                  <div class="sc_top">商城
                    <div class="sc_top1"><a href="https://www.taobao.com/">更多》</a></div>
                  </div>
                  <div class="sc_con">
                    <div id="shangpin">
                        <asp:Repeater ID="rptspfl" runat="server">
                         <HeaderTemplate><ul id="wz"></HeaderTemplate>
                         <ItemTemplate><li>
                             <asp:Label ID="lbspfl" runat="server" Text='<%# Eval("spFlname") %>'></asp:Label></li></ItemTemplate>
                         <FooterTemplate></ul></FooterTemplate>
                        </asp:Repeater>
                        <div id="a1" class="zsq">
                            <asp:Repeater ID="rptsp" runat="server">
                              <HeaderTemplate><ul></HeaderTemplate>
                              <ItemTemplate>
                                 <li>
                                     <asp:Image ID="Imgsp" runat="server" ImageUrl='<%# Eval("spImg") %>'/><br/>
                                     <asp:HyperLink ID="hypspa1" runat="server" Text='<%# ziduanjq.Jq_spbt(Eval("spTitle").ToString()) %>' NavigateUrl="https://www.taobao.com/market/nvzhuang/index.php?spm=a21bo.7724922.8374-1.1.k4GB9E"></asp:HyperLink><br/>
                                     价格：<asp:Label ID="lbsp11" runat="server" Text='<%# Eval("spPrice") %>'></asp:Label>
                                     </li>
                              </ItemTemplate>
                              <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                        <div id="a2" class="zsq">
                            <asp:Repeater ID="rptsp1" runat="server">
                              <HeaderTemplate><ul></HeaderTemplate>
                              <ItemTemplate>
                                 <li>
                                     <asp:Image ID="Imgsp1" runat="server" ImageUrl='<%# Eval("spImg") %>'/><br/>
                                     <asp:HyperLink ID="hypspa2" runat="server" Text='<%# ziduanjq.Jq_spbt(Eval("spTitle").ToString()) %>' NavigateUrl="https://www.taobao.com/market/nanzhuang/index.php?spm=a21bo.7724922.8374-1.2.k4GB9E"></asp:HyperLink><br/>
                                     价格：<asp:Label ID="lbsp12" runat="server" Text='<%# Eval("spPrice") %>'></asp:Label>
                                     </li>
                              </ItemTemplate>
                              <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                        <div id="a3" class="zsq">
                            <asp:Repeater ID="rptsp2" runat="server">
                              <HeaderTemplate><ul></HeaderTemplate>
                              <ItemTemplate>
                                 <li>
                                     <asp:Image ID="Imgsp2" runat="server" ImageUrl='<%# Eval("spImg") %>'/><br/>
                                     <asp:HyperLink ID="hypspa3" runat="server" Text='<%# ziduanjq.Jq_spbt(Eval("spTitle").ToString()) %>' NavigateUrl="https://life.taobao.com/?spm=a21bo.7724922.8374-1.17.k4GB9E"></asp:HyperLink><br/>
                                     价格：<asp:Label ID="lbsp13" runat="server" Text='<%# Eval("spPrice") %>'></asp:Label>
                                     </li>
                              </ItemTemplate>
                              <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                        <div id="a4" class="zsq">
                            <asp:Repeater ID="rptsp3" runat="server">
                              <HeaderTemplate><ul></HeaderTemplate>
                              <ItemTemplate>
                                 <li>
                                     <asp:Image ID="Imgsp3" runat="server" ImageUrl='<%# Eval("spImg") %>'/><br/>
                                     <asp:HyperLink ID="hypspa4" runat="server" Text='<%# ziduanjq.Jq_spbt(Eval("spTitle").ToString()) %>' NavigateUrl="https://www.taobao.com/market/jiadian/home.php?spm=a21bo.7724922.8374-1.15.T1P0ge"></asp:HyperLink><br/>
                                     价格：<asp:Label ID="lbsp14" runat="server" Text='<%# Eval("spPrice") %>'></asp:Label>
                                     </li>
                              </ItemTemplate>
                              <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                  </div>
              </div>
          </div>
          <div class="xiaofei">
              <div class="meishi">
                  <div class="ms_top">美食
                      <div class="ms_top1"><a href="content/sy_meishi.aspx">更多》</a></div>
                  </div>
                  <div class="ms_con">
                      <div id="ms_max">
                          <asp:Repeater ID="rptms1" runat="server">
                         <HeaderTemplate><ul id="ms_min"></HeaderTemplate>
                         <ItemTemplate><li>
                             <asp:HyperLink ID="hylms" runat="server" Text='<%# Eval("msTitle").ToString().Substring(0,4) %>' NavigateUrl='<%# Eval("msId","content/sy_ms_content.aspx?ms_id={0}") %>'></asp:HyperLink></li></ItemTemplate>
                         <FooterTemplate></ul></FooterTemplate>
                        </asp:Repeater>
                        <div id="b1" class="ms_zs">
                            <asp:Repeater ID="rptms2" runat="server">
                                <HeaderTemplate><ul></HeaderTemplate>
                                <ItemTemplate><li>
                                    <asp:Image ID="Imgms1" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("msImg").ToString()) %>'/></li></ItemTemplate>
                                <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                        <div id="b2" class="ms_zs">
                            <asp:Repeater ID="rptms3" runat="server">
                                <HeaderTemplate><ul></HeaderTemplate>
                                <ItemTemplate><li>
                                    <asp:Image ID="Imgms2" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("msImg").ToString()) %>'/></li></ItemTemplate>
                                <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                         <div id="b3" class="ms_zs">
                            <asp:Repeater ID="rptms4" runat="server">
                                <HeaderTemplate><ul></HeaderTemplate>
                                <ItemTemplate><li>
                                    <asp:Image ID="Imgms3" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("msImg").ToString()) %>'/></li></ItemTemplate>
                                <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                        <div id="b4" class="ms_zs">
                            <asp:Repeater ID="rptms5" runat="server">
                                <HeaderTemplate><ul></HeaderTemplate>
                                <ItemTemplate><li>
                                    <asp:Image ID="Imgms4" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("msImg").ToString()) %>'/></li></ItemTemplate>
                                <FooterTemplate></ul></FooterTemplate>
                            </asp:Repeater>
                        </div>
                      </div>
                 </div>
                 <div class="ms_con1">
                     <asp:Repeater ID="rptmsxx" runat="server">
                         <HeaderTemplate><table></HeaderTemplate>
                         <ItemTemplate>
                             <tr><td class="ms_td1"><asp:HyperLink ID="hylms1" runat="server" Text='<%# ziduanjq.Jq_msbt(Eval("msTitle").ToString()) %>' NavigateUrl='<%# Eval("msId","content/sy_ms_content.aspx?ms_id={0}") %>'></asp:HyperLink></li></td><td class="ms_td2">
                                 <asp:Literal ID="ltms1" runat="server" Text='<%# ziduanjq.Jq_mscon(Eval("msCon").ToString()) %>'></asp:Literal></td></tr>
                         </ItemTemplate>
                         <FooterTemplate></table></FooterTemplate>
                     </asp:Repeater>
                 </div>
              </div>
              <div class="lyou">
                  <div class="ly_top">旅游
                      <div class="ly_top1"><a href="content/sy_lyou.aspx">更多》</a></div>
                  </div>
                  <div class="ly_con">
                      <div class="indexFocus">
                          <div id="movePic1" class="focusBox">
                              <div class="bigPic" id="oPic">
                                  <asp:Repeater ID="rptly1" runat="server">
                                      <HeaderTemplate><ul></HeaderTemplate>
                                      <ItemTemplate><li>
                                          <asp:Image ID="Imgly" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("lyImg").ToString()) %>' /></li></ItemTemplate>
                                      <FooterTemplate></ul></FooterTemplate>
                                  </asp:Repeater>
                              </div>
                              <div class="btn" id="oBtn">
                                  <ul>
                                      <li>1</li>
                                      <li>2</li>
                                      <li>3</li>
                                      <li>4</li>
                                  </ul>
                              </div>
                              <div class="picText" id="oText">
                                  <asp:Repeater ID="rptly2" runat="server">
                                      <HeaderTemplate><ul></HeaderTemplate>
                                      <ItemTemplate><li>
                                          <asp:HyperLink ID="hylly" runat="server" Text='<%# ziduanjq.Jq_lybt(Eval("lyTitle").ToString()) %>' NavigateUrl='<%# Eval("lyId","content/sy_ly_content.aspx?ly_id={0}") %>'></asp:HyperLink><br/>
                                          <span class="lyzt1">&nbsp;&nbsp;&nbsp;&nbsp;<asp:Literal ID="llycon" runat="server" Text='<%# ziduanjq.Jq_lycon(Eval("lyCon").ToString()) %>'></asp:Literal></span><br/>
                                          <span class="lyzt2"><asp:Label ID="lblyprice" runat="server" Text='<%# Eval("lyPrice") %>'></asp:Label></span></li></ItemTemplate>
                                      <FooterTemplate></ul></FooterTemplate>
                                  </asp:Repeater>
                              </div>
                              <div class="picText_bg"></div>
                          </div>
                      </div>
                  </div>
              </div>
          </div>
          <div class="qita">
             <div class="shixiang">
                <div class="sx_top">时尚
                   <div class="sx_top1"><a href="content/sy_shix.aspx">更多》</a></div>
                </div>
                <div class="sx_con">
                    <asp:Repeater ID="rptsx1" runat="server">
                      <HeaderTemplate><ul></HeaderTemplate>
                      <ItemTemplate><li class="sxl1">
                          <asp:Image ID="Image1" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("sxImg").ToString()) %>'/></li>
                          <li class="sxl2">
                              <asp:HyperLink ID="hylsx" runat="server" Text='<%# ziduanjq.Jq_sxbt(Eval("sxTitle").ToString())%>' NavigateUrl='<%# Eval("sxId","content/sy_sx_content.aspx?sx_id={0}") %>'></asp:HyperLink><br/>
                              <span class="sxwz1"><asp:Literal ID="ltlsx" runat="server" Text='<%# ziduanjq.Jq_sxcon(Eval("sxCon").ToString())%>'></asp:Literal></span>
                              </li>
                          </ItemTemplate>
                      <FooterTemplate></ul></FooterTemplate>
                    </asp:Repeater>
                </div>
             </div>
             <div class="jiankang">
                 <div class="jk_top">健康
                     <div class="jk_top1"><a href="content/sy_jiank.aspx">更多》</a></div>
                 </div>
                 <div class="jk_con">
                     
                         <asp:Repeater ID="rptjk1" runat="server">
                             <HeaderTemplate><ul></HeaderTemplate>
                             <ItemTemplate><li class="jkl1"><span class="jkzt1">
                                 <asp:HyperLink ID="hypjk1" runat="server" Text='<%# ziduanjq.Jq_jkbt(Eval("jkTitle").ToString())%>' NavigateUrl='<%# Eval("jkId","content/sy_jk_content.aspx?jk_id={0}") %>'></asp:HyperLink></span></li><li class="jkl2">
                                 <span class="jkzt2">
                                     <asp:Literal ID="ltjk" runat="server" Text='<%# ziduanjq.Jq_jkCon(Eval("jkCon").ToString())%>'></asp:Literal></span></li></ItemTemplate>
                             <FooterTemplate></ul></FooterTemplate>
                         </asp:Repeater>
                    
                 </div>
             </div>
             <div class="study">
                 <div class="sd_top">学习
                     <div class="sd_top1"><a href="content/sy_study.aspx">更多》</a></div>
                 </div>
                 <div class="sd_con">
                     <asp:Repeater ID="rptsd1" runat="server">
                         <HeaderTemplate><ul></HeaderTemplate>
                         <ItemTemplate><li class="sdl1">
                             <asp:Image ID="Imgsd" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("sdImg").ToString()) %>' /></li>
                             <li class="sdl2">
                                 <span class="sdzt1"><asp:HyperLink ID="hlksd" runat="server" Text='<%# ziduanjq.Jq_sdbt(Eval("sdTitle").ToString())%>' NavigateUrl='<%# Eval("sdId","content/sy_sd_content.aspx?sd_id={0}") %>'></asp:HyperLink></span><br/>
                                 <span class="sdzt2"><asp:Literal ID="ltsd" runat="server" Text='<%# ziduanjq.Jq_sdCon(Eval("sdCon").ToString())%>' ></asp:Literal></span></li>
                         </ItemTemplate>
                         <FooterTemplate></ul></FooterTemplate>
                     </asp:Repeater>
                 </div>
                 <div class="sd_con1">
                     <asp:Repeater ID="rptsd2" runat="server">
                         <HeaderTemplate><ul></HeaderTemplate>
                         <ItemTemplate><li>
                             <asp:HyperLink ID="hytsd2" runat="server" Text='<%# ziduanjq.Jq_sdbt1(Eval("sdTitle").ToString())%>' NavigateUrl='<%# Eval("sdId","content/sy_sd_content.aspx?sd_id={0}") %>'></asp:HyperLink></li></ItemTemplate>
                         <FooterTemplate></ul></FooterTemplate>
                     </asp:Repeater>
                 </div>
             </div>
             <div class="dianying">
                <div class="dy_top">电影
                     <div class="dy_top1"><a href="http://theater.mtime.com/China_Hunan_Province_Shaoyang/">更多》</a></div>
                 </div>
                 <div class="dy_con">
                     <asp:Repeater ID="rptdy" runat="server">
                         <HeaderTemplate><ul></HeaderTemplate>
                         <ItemTemplate><li class="dyl1">
                             <asp:Image ID="Imgdy" runat="server" ImageUrl='<%# ziduanjq.Jq_img(Eval("dyImg").ToString()) %>'/></li>
                             <li class="dyl2">
                                 <span class="dyzt1"><asp:HyperLink ID="hyldy" runat="server" Text='<%# ziduanjq.Jq_dybt(Eval("dyTitle").ToString())%>' NavigateUrl="http://theater.mtime.com/China_Hunan_Province_Shaoyang/"></asp:HyperLink></span><br/><span class="dyzt2">内容介绍：<asp:Literal ID="ltdyjs" runat="server" Text='<%# ziduanjq.Jq_dyCon(Eval("dycon").ToString())%>'></asp:Literal><br/>上映时间：<asp:Label ID="lbdytime" runat="server" Text='<%# Eval("dyTime")%>'></asp:Label><br/>
                                 影院：<asp:Label ID="lbdyyy" runat="server" Text='<%# Eval("dyYy")%>'></asp:Label></span></li>
                         </ItemTemplate>
                         <FooterTemplate></ul></FooterTemplate>
                     </asp:Repeater>
                 </div>
             </div>
             
          </div>
          <div class="zuihou">
              <div class="youqing">
                  <div class="yq_top">友情链接</div>
                  <div class="yq_con">
                      <ul>
                           <li><a href="https://www.baidu.com/" target="_blank"><img src="images/yq/baidu.png" alt="百度" /></a></li>
                           <li><a href="http://www.qq.com" target="_blank"><img src="images/yq/tengxun.png" alt="QQ" /></a></li>
                           <li><a href="http://www.sina.com.cn/" target="_blank"><img src="images/yq/xinlang.png" alt="新浪" /></a></li>
                           <li><a href="http://www.sohu.com/" target="_blank"><img src="images/yq/souhu.png" alt="搜狐" /></a></li>
                           <li><a href="http://jz.faisco.com/pro8.html?_ta=178" target="_blank"><img src="images/yq/fanke.png" alt="凡科" /></a></li>
                           <li><a href="http://www.360.com/" target="_blank"><img src="images/yq/360.png" alt="360" /></a></li>
                           <li><a href="http://www.renren.com//" target="_blank"><img src="images/yq/renr.png" alt="人人网" /></a></li>
                           <li><a href="http://mail.163.com/" target="_blank"><img src="images/yq/wangyi.png" alt="网易" /></a></li>
                           <li><a href="http://www.ifeng.com/" target="_blank"><img src="images/yq/fengf.png" alt="凤凰" /></a></li>
                      </ul>
                  </div>
              </div>
              <div class="pianming">
                  <div class="pm_top">便民工具</div>
                  <div class="pm_con">
                      <ul>
                          <li><a href="http://www.weather.com.cn/weather/101250901.shtml">邵阳天气</a></li>
                          <li><a href="http://shaoyang.8684.cn/">邵阳公交车查询</a></li>
                          <li><a href="http://shouji.51240.com/">手机号码查询</a></li>
                          <li><a href="http://shenfenzheng.51240.com/">身份证号码查询</a></li>
                          <li><a href="http://map.51240.com/">电子地图</a></li>
                          <li><a href="http://chepai.51240.com/">车牌查询</a></li>
                          <li><a href="http://caipiao.51240.com/">彩票查询</a></li>
                          <li><a href="http://tv.51240.com/">电视台节目查询</a></li>
                          <li><a href="http://kuaidichaxun.51240.com/">快递查询</a></li>
                          <li><a href="http://fangjia.51240.com/">2015年节日放假查询</a></li>
                          <li><a href="http://www.boc.cn/" style="color:#fff"><img src="images/bm/zgyh.png" alt="中国银行" /></a></li>
                          <li><a href="http://www.icbc.com.cn/icbc/"  style="color:#fff"><img src="images/bm/zggh.png" alt="中国工商银行" /></a></li>
                          <li><a href="http://www.ccb.com/cn/home/index.html"  style="color:#fff"><img src="images/bm/zgjh.png" alt="中国建设银行" /></a></li>
                          <li><a href="http://www.psbc.com/portal/zh_CN/index.html"  style="color:#fff"><img src="images/bm/zgyz.png" alt="中国邮政银行" /></a></li>
                          <li><a href="http://www.abchina.com/cn/"  style="color:#fff"><img src="images/bm/zgnh.png" alt="中国农业银行" /></a></li>
                          <li><a href="http://www.hrxjbank.com.cn/"  style="color:#fff"><img src="images/bm/hrxj.png" alt="华融湘江银行" /></a></li>
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
    <div class="Telescopic">  
	<div class="rq"></div>
	<div class="nav" style="display:none">
		<a href="javascript:;">童年</a>
		<a href="javascript:;">趣事</a>
		<a href="javascript:;">回忆</a>
		<a href="javascript:;">放牛</a>
		<a href="javascript:;">捉迷藏</a>
		<a href="javascript:;">自制风筝</a>
		<a href="javascript:;">玩泥巴</a>
		<a href="javascript:;">烤红薯</a>
		<a href="javascript:;">看场</a>
		<a href="javascript:;">玩弹珠</a>
		<a href="javascript:;">爬山</a>
		<a href="javascript:;">游泳</a>
	</div>
	<div class="return_top" style="display:none"></div>
	<div class="wx"></div>
</div>
    
    </form>
<!-- JQuery代码-->
<!--1.淘宝代码-->
<script type="text/javascript">
    $(function () {
        var sWidth = $("#taobao").width(); //获取焦点图的宽度（显示面积）
        var len = $("#taobao ul li").length; //获取焦点图个数
        var index = 0;
        var picTimer;

        //以下代码添加数字按钮和按钮后的半透明长条
        var btn = "<div class='btnBg'></div><div class='btn'>";
        for (var i = 0; i < len; i++) {
            btn += "<span>&bull;</span>";
        }
        btn += "</div>"
        $("#taobao").append(btn);
        $("#areaOneAdFocus .btnBg").css("opacity", 0.5);

        //为数字按钮添加鼠标滑入事件，以显示相应的内容
        $("#taobao .btn span").mouseenter(function () {
            index = $("#taobao .btn span").index(this);
            showPics(index);
        }).eq(0).trigger("mouseenter");

        //图片为左右滚动，即所有li元素都是在同一排向左浮动，所以这里需要计算出外围ul元素的宽度
        $("#taobao ul").css("width", sWidth * (len + 1));

        //鼠标滑入某li中的某div里，调整其同辈div元素的透明度，由于li的背景为黑色，所以会有变暗的效果
        $("#taobao ul li div").hover(function () {
            $(this).siblings().css("opacity", 0.7);
        }, function () {
            $("#taobao ul li div").css("opacity", 1);
        });

        //鼠标滑上焦点图时停止自动播放，滑出时开始自动播放
        $("#taobao").hover(function () {
            clearInterval(picTimer);
        }, function () {
            picTimer = setInterval(function () {
                if (index == len) { //如果索引值等于li元素个数，说明最后一张图播放完毕，接下来要显示第一张图，即调用showFirPic()，然后将索引值清零
                    showFirPic();
                    index = 0;
                } else { //如果索引值不等于li元素个数，按普通状态切换，调用showPics()
                    showPics(index);
                }
                index++;
            }, 3000); //此3000代表自动播放的间隔，单位：毫秒
        }).trigger("mouseleave");

        //显示图片函数，根据接收的index值显示相应的内容
        function showPics(index) { //普通切换
            var nowLeft = -index * sWidth; //根据index值计算ul元素的left值
            //通过animate()调整ul元素滚动到计算出的position
            $("#taobao ul").stop(true, false).animate({ "left": nowLeft }, 500);
            //为当前的按钮切换到选中的效果
            $("#taobao .btn span").removeClass("on").eq(index).addClass("on");
        }

        function showFirPic() { //最后一张图自动切换到第一张图时专用
            $("#taobao ul").append($("#taobao ul li:first").clone());
            //通过li元素个数计算ul元素的left值，也就是最后一个li元素的右边
            var nowLeft = -len * sWidth;
            $("#taobao ul").stop(true, false).animate({ "left": nowLeft }, 500, function () {
                //通过callback，在动画结束后把ul元素重新定位到起点，然后删除最后一个复制过去的元素
                $("#taobao ul").css("left", "0");
                $("#taobao ul li:last").remove();
            });
            $("#taobao .btn span").removeClass("on").eq(0).addClass("on"); //为第一个按钮添加选中的效果
        }
    });

    /*返回顶部*/
    $(document).ready(function () {
        $(".return_top").click(function () {
            $("html,body").animate({ "scrollTop": 0 }, 1000);
        });
        $(window).scroll(function () {
            var Sctop = $(window).scrollTop();
            Sctop > 1200 ? $(".nav").stop().animate({ "height": 408 }, 300) && $(".return_top").show() : $(".nav").stop().animate({ "height": 0 }, 300) && $(".return_top").hide();
        });
        function toDou(n) {
            if (n < 10) {
                return '0' + n;
            } else {
                return '' + n;
            }
        }
        function tick() {
            var oDate = new Date();
            var str = toDou(oDate.getHours()) + ":" + toDou(oDate.getMinutes()) + ":" + toDou(oDate.getSeconds());
            $(".rq").html(str);
        }
        setInterval(tick, 1000);
        tick();

    })
</script>
</body>
</html>
