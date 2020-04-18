<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="user_add.aspx.cs" Inherits="admin_user_add" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/admin_zy.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left">
        <div class="l_top">用户管理</div>
        <div class="l_con">
           <ul>
              <li><a href="admin_add.aspx">管理增加</a></li>
              <li><a href="admin_edit.aspx">管理编辑</a></li>
              <li><a href="user_add.aspx">注册用户增加</a></li>
              <li><a href="user_edit.aspx">注册用户修改</a></li>
           </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="right">
        <div class="r_con">
      <table>
        <tr><td style=" width:100px; text-align:right;">用户添加：</td><td style=" width:300px; text-align:left; height:30px;">
            <asp:TextBox ID="txtname" runat="server"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator
                ID="RequiredFieldValidator1" runat="server" ErrorMessage="用戶名不能唯空" 
                ControlToValidate="txtname" Display="Dynamic"></asp:RequiredFieldValidator>&nbsp;<asp:CustomValidator ID="CustomValidator1" runat="server" ControlToValidate="txtname" Display="Dynamic" ErrorMessage="用户名已被注册" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator></td></tr>
                <tr><td style=" width:100px; text-align:right;">密码：</td><td style=" width:300px; text-align:left; height:30px;">
            <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator
                ID="RequiredFieldValidator2" runat="server" ErrorMessage="密码不能唯空" 
                ControlToValidate="txtpwd" Display="Dynamic"></asp:RequiredFieldValidator></td></tr>
                <tr><td style=" width:100px; text-align:right;">确认密码：</td><td style=" width:300px; text-align:left; height:30px;">
                    
            <asp:TextBox ID="txtpwd1" runat="server" TextMode="Password"></asp:TextBox>&nbsp;<asp:CompareValidator 
                        ID="CompareValidator1" runat="server" ErrorMessage="两次密码不一样" 
                        ControlToCompare="txtpwd" ControlToValidate="txtpwd1" Display="Dynamic"></asp:CompareValidator></td></tr>
                <tr><td style=" width:100px; text-align:right;">口令：</td><td style=" width:300px; text-align:left; height:30px;">
            <asp:TextBox ID="txtsm" runat="server"></asp:TextBox>&nbsp;</td></tr>
            <tr><td colspan="2" style=" text-align:center; height:50px;">
                <asp:Button ID="btnok" runat="server" Text="提交" Width="80px" Height="30px" 
                    onclick="btnok_Click"/>&nbsp;&nbsp;<asp:Button ID="btncancel"
                    runat="server" Text="取消" Width="80px" Height="30px" 
                    onclick="btncancel_Click"/></td></tr>
      </table>
   </div>
    </div>
</asp:Content>

