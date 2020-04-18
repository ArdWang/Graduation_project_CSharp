<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sp_add.aspx.cs" Inherits="admin_sp_add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>商品发布</title>
    <link href="css/admin_fb.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
     <div id="box">
        <div class="top">
            <div class="t_top">
                <asp:Button ID="btnhsy" runat="server" Text="后台首页" Width="70px" Height="30px" BackColor="#3366CC" ForeColor="#FFFFCC" CssClass="btn" OnClick="btnhsy_Click" CausesValidation="False" />&nbsp;&nbsp
                <asp:Button ID="btnqsy" runat="server" Text="前台首页" Width="70px" Height="30px" BackColor="#3366CC" ForeColor="#FFFFCC" CssClass="btn" OnClick="btnqsy_Click" CausesValidation="False" /></div>
        </div>
        <div class="b_nav">
            <div class="n_left">欢迎回来：<asp:Label ID="lbname" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;<asp:LinkButton
                ID="lbexit" runat="server" onclick="lbexit_Click" CausesValidation="False" ForeColor="White">退出</asp:LinkButton>
            </div>
            <div id="n_right">
                <ul>
                    <li><a href="#">后台首页</a></li>
                    <li><a href="#">资讯</a>
                        <ul>
                            <li><a href="admin_xw.aspx">新闻</a></li> 
                            <li><a href="admin_xy.aspx">校园</a></li>
                            <li><a href="admin_yl.aspx">娱乐</a></li>
                            <li><a href="admin_ty.aspx">体育</a></li>
                            <li><a href="admin_qc.aspx">汽车</a></li>
                            <li><a href="admin_yx.aspx">游戏</a></li>
                       </ul>
                    </li>
                    <li><a href="#">生活</a>
                        <ul>
                            <li><a href="admin_kj.aspx">科技</a></li> 
                            <li><a href="admin_jk.aspx">健康</a></li>
                            <li><a href="admin_ly.aspx">旅游</a></li>
                            <li><a href="admin_sp.aspx">商城</a></li>
                            <li><a href="admin_sx.aspx">时尚</a></li>
                            <li><a href="admin_ms.aspx">美食</a></li>
                       </ul>
                    </li>
                    <li><a href="#">电影</a>
                        <ul>
                            <li><a href="admin_dy.aspx">电影</a></li> 
                            
                       </ul>
                    </li>
                    <li><a href="#">互动</a>
                        <ul>
                            <li><a href="admin_sd.aspx">学习</a></li> 
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <div class="main">
            <div class="m_left">
                <div class="ml_top">商品管理</div>
                <div class="ml_con">
                   <ul>
                       <li><a href="admin_sp.aspx">商品首页</a></li>
                      <li><a href="sp_add.aspx">商品发布</a></li>
                      <li><a href="sp_edit.aspx">商品编辑</a></li>
                      <li><a href="spfl_add.aspx">商品分类添加</a></li>
                       <li><a href="spfl_edit.aspx">商品分类修改</a></li>
                      <li><a href="#">说明</a></li>
                   </ul>
                </div>
           </div>
            <div class="m_right">
               <div class="mr_top">商品内容添加</div>
               <div class="mr_con">
                  <div class="bt">
                      <div class="bt_top">标题</div>
                      <div class="bt_con">
                          <asp:TextBox ID="txtspbt" runat="server" Width="400px" Height="40px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="标题不能为空" Display="Dynamic" ControlToValidate="txtspbt"></asp:RequiredFieldValidator>
                      </div>
                  </div>
                  <div class="fl">
                      <div class="fl_top">分类ID</div>
                      <div class="fl_con">
                          
                          <asp:DropDownList ID="ddlfl" runat="server" Width="80px" Height="20px">
                          </asp:DropDownList>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="分类ID不能为空" ControlToValidate="ddlfl" Display="Dynamic"></asp:RequiredFieldValidator>
                          
                      </div>
                  </div>
                  <div class="Img">
                      <div class="im_top">照片</div>
                      <div class="im_con">
                          <asp:FileUpload ID="fuimg" runat="server" /></div>
                  </div>
                  <div class="fbman">
                      <div class="fb_top">发布人</div>
                      <div class="fb_con">
                          <asp:TextBox ID="txtfbman" runat="server" Width="120px" Height="20px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="发布人不能为空" Display="Dynamic" ControlToValidate="txtfbman"></asp:RequiredFieldValidator></div>
                  </div>
                   <div class="price">
                      <div class="pr_top">价格</div>
                      <div class="pr_con">
                          <asp:TextBox ID="txtprice" runat="server" Width="100px" Height="20px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="价格不能为空" ControlToValidate="txtprice" Display="Dynamic"></asp:RequiredFieldValidator>
                      </div>
                  </div>
                  <div class="btn">
                      <asp:Button ID="btnok" runat="server" Text="发布" Width="100px" Height="30px" CssClass="b_css1" OnClick="btnok_Click" />&nbsp;&nbsp;&nbsp; 
                      <asp:Button ID="btncancel" runat="server" Text="清空" Width="100px" Height="30px" 
                          CssClass="b_css1" OnClick="btncancel_Click" CausesValidation="False"  />
                  </div>

           </div>
        </div>
           
        </div>
        <div class="bottom">W蓝科技工作室&nbsp;|&nbsp;后台管理&nbsp;|&nbsp;技术支持<br/>Copyright© 2015　dqccc.com. All Rights Reserved</div>
    </div>
    </form>
</body>
</html>
