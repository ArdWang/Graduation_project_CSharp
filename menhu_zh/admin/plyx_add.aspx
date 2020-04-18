<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="plyx_add.aspx.cs" Inherits="admin_plyx_add" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
     <link href="css/admin_gy.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left">
        <div class="l_top">游戏评论管理</div>
        <div class="l_con">
           <ul>
              <li><a href="plyx_add.aspx">评论发布</a></li>
              <li><a href="plyx_edit.aspx">评论编辑</a></li>
           </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="right">
         <div class="r_con">
             <div class="pl_top">评论发布</div>
             <div class="pl_con">
                 <div class="plc_top">ID选择</div>
                 <div class="plc_con">
                    ID选择：
                  
                     <asp:DropDownList ID="ddlid" runat="server" Width="80px" Height="20px">
                     </asp:DropDownList>
                 </div>
                 <div class="plc_top">内容</div>
                 <div class="plc_con1">
                     <asp:TextBox ID="txtcon" runat="server" TextMode="MultiLine" Width="500px" Height="150px"></asp:TextBox>
                 </div>
                 <div class="plc_con3">
                     <asp:Button ID="btnfb" runat="server" Text="发表"   Width="60px" Height="25px" OnClick="btnfb_Click"/>&nbsp;&nbsp;&nbsp;<asp:Button ID="btncancel" Width="60px" Height="25px" runat="server" Text="取消" CausesValidation="False" OnClick="btncancel_Click" />
                 </div>
             </div>
             
         </div>
    </div>
</asp:Content>

