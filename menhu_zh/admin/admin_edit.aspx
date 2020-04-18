<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="admin_edit.aspx.cs" Inherits="admin_admin_edit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/admin_zy.css" rel="stylesheet" type="text/css" />
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
        <asp:GridView ID="grdadmin" runat="server" AutoGenerateColumns="False" 
            onrowcancelingedit="grdadmin_RowCancelingEdit" 
            onrowdeleting="grdadmin_RowDeleting" onrowediting="grdadmin_RowEditing" 
            DataKeyNames="adminId" onrowupdating="grdadmin_RowUpdating">
            <Columns>
                <asp:TemplateField HeaderText="管理员用户名">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtadminuser" runat="server" Text='<%# Bind("adminname") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("adminname") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="管理员密码">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtadminpwd" runat="server" Text='<%# Bind("adminpwd") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("adminpwd") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="说明">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtsm" runat="server" Text='<%# Bind("adminsm") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("adminsm") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" HeaderText="編輯" />
                <asp:TemplateField HeaderText="删除" ShowHeader="False">
                   <ItemTemplate>
                       <asp:LinkButton ID="lbtndel" runat="server" CausesValidation="False" 
                           CommandName="Delete" Text="删除" CommandArgument='<%# Eval("adminId") %>' 
                                        onclientclick='return confirm("真的刪除吗?");'></asp:LinkButton>
                   </ItemTemplate>
                  
               </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <div class="db">
                       <asp:LinkButton ID="lbtFirst" runat="server" OnClick="lbtFirst_Click">首页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtUp" runat="server" OnClick="lbtUp_Click">上一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtDown" runat="server" OnClick="lbtDown_Click">下一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtLast" runat="server" OnClick="lbtLast_Click">尾页</asp:LinkButton>&nbsp;共<asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>页&nbsp;&nbsp;共<asp:Label ID="Label2" runat="server" Text=""></asp:Label>条记录&nbsp;&nbsp;当前<asp:Label ID="lblCurrent" runat="server" Text="1"></asp:Label>页</div>
    </div>
 </div>
</asp:Content>

