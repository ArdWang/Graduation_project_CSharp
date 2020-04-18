<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="admin_zy.aspx.cs" Inherits="admin_admin_zy" %>

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
           当前管理员有：<asp:Label ID="lbadmin" runat="server" Text=""></asp:Label>个<br/>
           当前注册用户有：<asp:Label ID="lbuser" runat="server" Text=""></asp:Label>个<br/>
           当前访问用户有：<asp:Label ID="lbcurrent" runat="server" Text=""></asp:Label>个<br/>
           当前访问总用户有：<asp:Label ID="lbtotal" runat="server" Text=""></asp:Label>个<br/>
        </div>
        <div class="r_con1">
            <div class="rc_top1">用户IP</div>
            <div class="rc_con1">
                <asp:Repeater ID="rptuser" runat="server">
                    <HeaderTemplate><ul></HeaderTemplate>
                    <ItemTemplate>
                        <li>
                            <asp:Label ID="lbname" runat="server" Text='<%# Eval("ipname") %>'>&nbsp;.&nbsp;</asp:Label> 用户浏览IP：<asp:Label ID="lbip" runat="server" Text='<%# Eval("Ipdz") %>'></asp:Label>
                        </li>
                    </ItemTemplate>
                    <FooterTemplate></ul></FooterTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>

