<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="user_edit.aspx.cs" Inherits="admin_user_edit" Debug="true" %>

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
        <asp:GridView ID="grduser" runat="server" AutoGenerateColumns="False" 
            onrowcancelingedit="grduser_RowCancelingEdit" 
            onrowdeleting="grduser_RowDeleting" onrowediting="grdadmin_RowEditing" 
            DataKeyNames="userId" onrowupdating="grduser_RowUpdating" EnableModelValidation="True">
            <Columns>
                <asp:TemplateField HeaderText="注册用户名">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtusernamer" Width="50px" Height="50px" runat="server" Text='<%# Bind("username") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Bind("username") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="t11" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="密码">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtuserpwd" runat="server" Width="50px" Height="50px" Text='<%# Bind("userpwd") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text='<%# Bind("userpwd") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="t11" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="口令">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtkl" runat="server" Width="50px" Height="50px" Text='<%# Bind("koulin") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label3" runat="server" Text='<%# Bind("koulin") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="t11" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="性别">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtsex" runat="server" Width="40px" Height="20px" Text='<%# Bind("sex") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label4" runat="server" Text='<%# Bind("sex") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="t12" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="电话">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtphone" runat="server" Width="100px" Height="50px" Text='<%# Bind("phone") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label5" runat="server" Text='<%# Bind("phone") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="t1" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="QQ">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtqq" runat="server" Width="100px" Height="50px" Text='<%# Bind("qqnum") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:Label ID="Label6" runat="server" Text='<%# Bind("qqnum") %>'></asp:Label>
                    </ItemTemplate>
                    <ItemStyle CssClass="t1" />
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Emial">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtemial" runat="server" Width="100px" Height="50px" Text='<%# Bind("emial") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemStyle CssClass="t1" />
                    <ItemTemplate>
                        <asp:Label ID="Label7" runat="server" Text='<%# Bind("emial") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="工作">
                    <EditItemTemplate>
                        <asp:TextBox ID="txtdepart" runat="server" Width="40px" Height="20px" Text='<%# Bind("depart") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemStyle CssClass="t11" />
                    <ItemTemplate>
                        <asp:Label ID="Label8" runat="server" Text='<%# Bind("depart") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:CommandField ShowEditButton="True" HeaderText="編輯" />
                <asp:TemplateField HeaderText="删除" ShowHeader="False">
                   <ItemTemplate>
                       <asp:LinkButton ID="lbtndel" runat="server" CausesValidation="False" 
                           CommandName="Delete" Text="删除" CommandArgument='<%# Eval("userId") %>' 
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

