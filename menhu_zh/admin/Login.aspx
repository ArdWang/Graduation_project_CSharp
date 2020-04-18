<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admin_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>网站后台登录</title>
    <link href="css/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
       <div id="box">
           <div id="top">
               <span class="zt1">W蓝科技-网站后台管理系统</span><br/><span class="zt3"> management system of information media</span>
           </div>
           <div id="middle">
               <div id="left">
                   <div class="top1">小提示-Tips</div>
                   <div class="main">
                       1.点击登录即可登录。<br/>
                       2.管理员账户密码是不能注册的<br/>
                       3.管理员唯一性
                   </div>
               </div>
               <div id="login">
                   <div class="top2"><span class="zt4">登录-Login</span></div>
                   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                   <div class="con1">
                       <table>
                           <tr>
                               <td style="text-align:right; width:120px;"><span class="zt5">用户名：</span></td><td style="text-align:left; width:170px;">
                                   <asp:TextBox ID="txtuser" runat="server" Width="120px"></asp:TextBox></td>
                           </tr>
                            <tr>
                               <td style="text-align:right; width:120px;"><span class="zt5">密码：</span></td><td style="text-align:left;">
                                   <asp:TextBox ID="txtpwd" runat="server" Width="120px" TextMode="Password"></asp:TextBox></td>
                           </tr>
                           <tr>
                               <td  style="text-align:right; " class="auto-style1">
                                   <asp:Button ID="Login" runat="server" Text="登录" ForeColor="Black" Width="50px" 
                                       OnClick="Login_Click" Height="25px" /></td><td style="text-align:center" class="auto-style2">
                                   <asp:Button ID="Reg" runat="server" Text="取消" ForeColor="Black" Width="50px" 
                                       OnClick="Reg_Click" Height="25px" /></td>
                           </tr>
                           
                       </table>
                  </div>
               </div>
           </div>
           <div id="bottom"><span class=zt2>W蓝科技工作室&nbsp;|&nbsp;后台管理&nbsp;|&nbsp;技术支持<br/>Copyright© 2015　dqccc.com. All Rights Reserved</span></div>
        
       </div>
    </form>
</body>
</html>
