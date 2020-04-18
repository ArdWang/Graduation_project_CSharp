<%@ Page Language="C#" AutoEventWireup="true" CodeFile="zhmm.aspx.cs" Inherits="zhmm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>找回密码</title>
    <link href="css/sy_zc.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
      <div id="box">
           <div id="top">
               <span class="zt1">W蓝科技-找回密码</span><br/><span class="zt3"> management system of information media</span>
           </div>
           <div id="middle">
               <div id="reg">
                   <div class="top3">
                       <span class="syzt1">找回密码-Retrieve Password</span>
                   </div>
                   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                   <div class="con3">
                      <div class="zmm">
                          <asp:Panel ID="Panel1" runat="server" Height="195px">
                              <table>
                                  <tr>
                                      <td style="text-align:right;">你的用户名：</td><td>
                                          <asp:TextBox ID="txtname" runat="server" Width="120px" Height="16px"></asp:TextBox></td><td>
                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtname"></asp:RequiredFieldValidator></td>
                                  </tr>
                                  <tr>
                                      <td style="text-align:right;">你的答案口令：</td><td>
                                          <asp:TextBox ID="txtkl" runat="server" Width="120px" Height="16px"></asp:TextBox></td><td>
                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtkl"></asp:RequiredFieldValidator></td>
                                  </tr>
                                  <tr>
                                      <td colspan="3" style="text-align:center;">
                                          <asp:Button ID="btnok" runat="server" Text="确定" Width="70px" Height="30px" ForeColor="Blue" OnClick="btnok_Click" />&nbsp;&nbsp;<asp:Button ID="btnqx" runat="server" Text="返回" Width="70px" Height="30px" ForeColor="Blue" OnClick="btnqx_Click" CausesValidation="False" /></td>
                                  </tr>
                              </table>
                          </asp:Panel>
                          <asp:Panel ID="Panel2" runat="server" Height="195px">
                              <table>
                                  <tr>
                                      <td style="text-align:right;">你的用户名：</td><td>
                                          <asp:Label ID="lbname" runat="server" Text=""></asp:Label></td><td>
                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtname"></asp:RequiredFieldValidator></td>
                                  </tr>
                                  <tr>
                                      <td style="text-align:right;">你的密码为：</td><td>
                                          <asp:Label ID="lbpwd" runat="server" Text=""></asp:Label> </td><td>
                                              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="*" Display="Dynamic" ControlToValidate="txtkl"></asp:RequiredFieldValidator></td>
                                  </tr>
                                  <tr>
                                      <td colspan="3" style="text-align:center;">
                                          <asp:Button ID="btnfh" runat="server" Text="返回" Width="70px" Height="30px" ForeColor="Blue" OnClick="btnfh_Click" /></td>
                                  </tr>
                              </table>
                          </asp:Panel>
                      </div>
                   </div>
               </div>
           </div>
           
          <div id="bottom">
              <div class="b_top"><a href="#">关于我们</a>|<a href="#">联系我们</a>|<a href="#">友情链接</a>|<a href="#">客服邮箱</a>|客服热线：0739-111111|客服QQ：***<br/>Copyright© 2015　dqccc.com. All Rights Reserved<br/>版权所有  W蓝科技  湘ICP证04322号  湘ICP备43222211号</div>
              <div class="b_con">
                  <a href="http://net.china.com.cn/" target="_blank"><img src="images/db/db_bl.png" /></a>
                  <a href="http://www.cyberpolice.cn/wfjb/" target="_blank"><img src="images/db/db_wj.png" /></a>
                  <a href="http://www.wenming.cn/wmpl_pd/yczl/201506/t20150629_2701547.shtml" target="_blank"><img src="images/db/db_cb.png" /></a>
              </div>
          </div>
       </div> 
       </div> 
      
    </form>
</body>
</html>
