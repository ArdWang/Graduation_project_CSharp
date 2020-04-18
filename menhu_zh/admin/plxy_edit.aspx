<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="plxy_edit.aspx.cs" Inherits="admin_plxy_edit" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/admin_gy.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left">
        <div class="l_top">校园评论管理</div>
        <div class="l_con">
           <ul>
              <li><a href="plxy_add.aspx">评论发布</a></li>
              <li><a href="plxy_edit.aspx">评论编辑</a></li>
           </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="right">
       <div class="r_top">校园评论编辑</div>
       <div class="r_con">
          <asp:GridView ID="grdxypl" runat="server" AutoGenerateColumns="False" 
               onrowediting="grdxypl_RowEditing" 
               onrowcancelingedit="grdxypl_RowCancelingEdit" 
               onrowupdating="grdxypl_RowUpdating" DataKeyNames="plxyID" 
               onrowdeleting="grdxypl_RowDeleting">
           <Columns>
               <asp:TemplateField HeaderText="评论文章ID">
                   <EditItemTemplate>
                       <asp:Label ID="lbid1" runat="server" Text='<%# Eval("xyID") %>'></asp:Label>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="lbid" runat="server" Text='<%# Bind("xyID") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t1" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="评论人">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtplman" runat="server" Text='<%# Bind("plman") %>' 
                           TextMode="MultiLine" Width="80px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("plman") %>' CssClass="zt1"></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t2" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="评论内容">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtplcon" runat="server" Text='<%# Bind("plCon") %>' 
                           TextMode="MultiLine" Width="240px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label3" runat="server" Text='<%# Bind("plCon") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t31" />
               </asp:TemplateField>
               <asp:CommandField ShowEditButton="True" HeaderText="编辑">
               <ItemStyle CssClass="t8" />
               </asp:CommandField>
               <asp:TemplateField HeaderText="删除" ShowHeader="False">
                   <ItemTemplate>
                       <asp:LinkButton ID="lbtndel" runat="server" CausesValidation="False" 
                           CommandName="Delete" Text="删除" CommandArgument='<%# Eval("plxyId") %>' 
                                        onclientclick='return confirm("真的刪除吗?");'></asp:LinkButton>
                   </ItemTemplate>
                   <ItemStyle CssClass="t9" />
               </asp:TemplateField>
           </Columns>
       </asp:GridView>
       <div class="db">
                       <asp:LinkButton ID="lbtFirst" runat="server" OnClick="lbtFirst_Click">首页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtUp" runat="server" OnClick="lbtUp_Click">上一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtDown" runat="server" OnClick="lbtDown_Click">下一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtLast" runat="server" OnClick="lbtLast_Click">尾页</asp:LinkButton>&nbsp;共<asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>页&nbsp;&nbsp;共<asp:Label ID="Label2" runat="server" Text=""></asp:Label>条记录&nbsp;&nbsp;当前<asp:Label ID="lblCurrent" runat="server" Text="1"></asp:Label>页</div>
       </div>
   </div>
</asp:Content>

