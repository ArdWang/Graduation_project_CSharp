<%@ Page Title="" Language="C#" MasterPageFile="~/content/content.master" AutoEventWireup="true" CodeFile="sy_tiyu.aspx.cs" Inherits="content_sy_tiyu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/content.css" rel="stylesheet" />
    <link href="css/sy_gy.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left">
   <div class="l_top">
       <div class="t_left"><img src="../images/db/logo.png" alt="" /></div>
       <div class="t_right">当前的位置：<a href="sy_tiyu.aspx">首页</a></div>
   </div>
   <div class="l_con">
       <asp:Repeater ID="rptty" runat="server">
        <HeaderTemplate><ul></HeaderTemplate>
        <ItemTemplate>
           <li class="l1">
               <asp:HyperLink ID="hylyl" runat="server" Text='<%# ziduanjq.Jq_xwbt1(Eval("tyTitle").ToString()) %>' NavigateUrl='<%# Eval("tyId","sy_ty_content.aspx?ty_id={0}") %>'></asp:HyperLink></li>
           <li class="l2">
               <asp:Label ID="lbtime" runat="server" Text='<%# Eval("tyTime") %>'></asp:Label>
           </li>
        </ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
       </asp:Repeater>
       <div class="db">
                       <asp:LinkButton ID="lbtFirst" runat="server" OnClick="lbtFirst_Click">首页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtUp" runat="server" OnClick="lbtUp_Click">上一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtDown" runat="server" OnClick="lbtDown_Click">下一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtLast" runat="server" OnClick="lbtLast_Click">尾页</asp:LinkButton>&nbsp;共<asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>页&nbsp;&nbsp;共<asp:Label ID="Label2" runat="server" Text=""></asp:Label>条记录&nbsp;&nbsp;当前<asp:Label ID="lblCurrent" runat="server" Text="1"></asp:Label>页</div>
   </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="right">
       <div class="r_top">最新体育</div>
       <div class="r_con">
           <asp:Repeater ID="rptty1" runat="server">
             <HeaderTemplate><ul></HeaderTemplate>
             <ItemTemplate>
                 <li>
                     <asp:HyperLink ID="hyplk1" runat="server" Text='<%# ziduanjq.Jq_xwbt2(Eval("tyTitle").ToString()) %>' NavigateUrl='<%# Eval("tyId","sy_ty_content.aspx?ty_id={0}") %>'></asp:HyperLink></li>
             </ItemTemplate>
             <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
       <div class="r_top">最热体育</div>
       <div class="r_con">
           <asp:Repeater ID="rptty2" runat="server">
             <HeaderTemplate><ul></HeaderTemplate>
             <ItemTemplate>
                 <li>
                     <asp:HyperLink ID="hyplk2" runat="server" Text='<%# ziduanjq.Jq_xwbt2(Eval("tyTitle").ToString()) %>' NavigateUrl='<%# Eval("tyId","sy_ty_content.aspx?ty_id={0}") %>'></asp:HyperLink></li>
             </ItemTemplate>
             <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
    </div>
</asp:Content>

