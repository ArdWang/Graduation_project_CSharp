<%@ Page Language="C#" AutoEventWireup="true" CodeFile="sy_zhuce.aspx.cs" Inherits="sy_zhuce" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <link href="css/sy_zc.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
         <div id="box">
           <div id="top">
               <span class="zt1">W蓝科技-用户注册页面</span><br/><span class="zt3"> management system of information media</span>
           </div>
           <div id="middle">
               <div id="reg">
                   <div class="top3">
                       <span class="syzt1">用户注册-Regster</span>
                   </div>
                   <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
                   <div class="con1">
                       <table>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">用户名：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="username" runat="server" Width="120px"></asp:TextBox></td><td style="text-align:left;"><span class="zt6">*<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="username" Display="Dynamic" ErrorMessage="用户名不能为空"></asp:RequiredFieldValidator>
                                   <asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="username" Display="Dynamic" ErrorMessage="用户名已被注册" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>
                                   </span></td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">密码：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="password" runat="server" Width="120px" TextMode="Password"></asp:TextBox></td><td style="text-align:left;"><span class="zt6">*<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="password" Display="Dynamic" ErrorMessage="密码不能为空"></asp:RequiredFieldValidator>
                                   <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="password" ControlToValidate="password1" Display="Dynamic" ErrorMessage="两次密码不一致"></asp:CompareValidator>
                                   </span></td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">确认密码：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="password1" runat="server" Width="120px" TextMode="Password"></asp:TextBox></td><td style="text-align:left;"><span class="zt6">*<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="password1" Display="Dynamic" ErrorMessage="再次输入密码不能为空"></asp:RequiredFieldValidator>
                                   </span></td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">密码口令：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="koulin" runat="server" Width="120px"></asp:TextBox></td><td style="text-align:left;"><span class="zt6">*<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="koulin" Display="Dynamic" ErrorMessage="密码口令是找回密码的唯一方式"></asp:RequiredFieldValidator>
                                   </span></td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">性别：</span></td><td style="text-align:left; width:130px;">
                               <asp:DropDownList ID="ddsex" runat="server" DataTextField="rmID" DataValueField="rmID">
                                   <asp:ListItem>请选择</asp:ListItem>
                                   <asp:ListItem>男</asp:ListItem>
                                   <asp:ListItem>女</asp:ListItem>
                                </asp:DropDownList></td><td style="text-align:left;"></td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">手机号码：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="phone" runat="server" Width="120px"></asp:TextBox></td><td style="text-align:left;">
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="手机号码格式错误" ControlToValidate="phone" Display="Dynamic" ForeColor="Red" ValidationExpression="\d{11}"></asp:RegularExpressionValidator>
                               </td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">QQ号码：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="qqnumber" runat="server" Width="120px"></asp:TextBox></td><td style="text-align:left;">
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="qqnumber" Display="Dynamic" ErrorMessage="QQ号码格式错误" ForeColor="Red" ValidationExpression="^[0-9]{6,10}$"></asp:RegularExpressionValidator>
                               </td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">电子邮件：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="emial" runat="server" Width="120px"></asp:TextBox></td><td style="text-align:left;">
                                   <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="emial" Display="Dynamic" ErrorMessage="电子邮箱格式错误" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                               </td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">你的职位：</span></td><td style="text-align:left; width:130px;"><asp:DropDownList ID="ddxibie" runat="server" DataTextField="rmID" DataValueField="rmID">
                               <asp:ListItem>--请选择--</asp:ListItem>
                               <asp:ListItem>学生</asp:ListItem>
                               <asp:ListItem>公务员</asp:ListItem>
                               <asp:ListItem>教师</asp:ListItem>
                               <asp:ListItem>计算机IT</asp:ListItem>
                               <asp:ListItem>商务</asp:ListItem>
                               <asp:ListItem>其它</asp:ListItem>
                 </asp:DropDownList>
                              </td><td style="text-align:left;"></td></tr>
                           <tr><td style="text-align:right; width:250px;"><span class="zt2">填写验证码：</span></td><td style="text-align:left; width:130px;">
                               <asp:TextBox ID="yanzhenma" runat="server" Width="120px"></asp:TextBox></td><td style="text-align:left;">
                                   <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="yanzhenma" Display="Dynamic" ErrorMessage="验证码不能为空" ForeColor="Red"></asp:RequiredFieldValidator>
                                   <asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="yanzhenma" Display="Dynamic" ErrorMessage="验证码输入错误" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
                               </td></tr>
                           <tr><td style="text-align:right; height:30px; width:250px;"></td><td style="text-align:center; width:130px;"><img style="height:30px; width:70px;" src="Ashxchuli/yanzhenma.ashx" onclick="this.src='Ashxchuli/yanzhenma.ashx?aaa='+new Date()" alt="" />&nbsp&nbsp</td><td><span class="zt2">看不清楚请点击图片刷新</span></td></tr>
                           <tr><td colspan="2" style="text-indent:180px;">
                               <asp:Button ID="Regs" runat="server" Text="注册" Width="50" ForeColor="#0000CC" OnClick="Regs_Click" /></td><td>
                                   <asp:Button ID="Rept" runat="server" Text="重填" ForeColor="#0000CC" Width="50px" CausesValidation="False" OnClick="Rept_Click" /></td></tr>
                       </table>
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
    </form>
</body>
</html>
