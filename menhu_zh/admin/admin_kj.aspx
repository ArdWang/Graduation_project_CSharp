<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="admin_kj.aspx.cs" Inherits="admin_admin_kj" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/admin_gy.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left">
        <div class="l_top">科技管理</div>
        <div class="l_con">
           <ul>
              <li><a href="admin_kj.aspx">科技新闻</a></li>
              <li><a href="kj_add.aspx">科技发布</a></li>
              <li><a href="kj_edit.aspx">科技编辑</a></li>
              <li><a href="#">说明</a></li>
           </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
   <div class="right">
   <div class="r_top">科技内容</div>
   <div class="r_con">
       <asp:GridView ID="grdkj" runat="server" AutoGenerateColumns="False">
           <Columns>
               <asp:TemplateField HeaderText="科技ID">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("kjId") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label1" runat="server" Text='<%# Bind("kjId") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t1" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="科技标题">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox2" runat="server" Text='<%# Bind("kjTitle") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("kjTitle") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t2" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="科技内容">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox3" runat="server" Text='<%# Bind("kjCon") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label3" runat="server" Text='<%# Bind("kjCon") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t3" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="图片">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox4" runat="server" Text='<%# Bind("kjImg") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label4" runat="server" Text='<%# Bind("kjImg") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t4" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布人">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox5" runat="server" Text='<%# Bind("kjFbman") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label5" runat="server" Text='<%# Bind("kjFbman") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t5" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布时间">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox6" runat="server" Text='<%# Bind("kjTime") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label6" runat="server" Text='<%# Bind("kjTime") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t6" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="评论">
                   <EditItemTemplate>
                       <asp:TextBox ID="TextBox7" runat="server" Text='<%# Bind("kjpl") %>'></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label7" runat="server" Text='<%# Bind("kjpl") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t7" />
               </asp:TemplateField>
           </Columns>
       </asp:GridView>
       <div class="db">
                       <asp:LinkButton ID="lbtFirst" runat="server" OnClick="lbtFirst_Click">首页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtUp" runat="server" OnClick="lbtUp_Click">上一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtDown" runat="server" OnClick="lbtDown_Click">下一页</asp:LinkButton>&nbsp;<asp:LinkButton ID="lbtLast" runat="server" OnClick="lbtLast_Click">尾页</asp:LinkButton>&nbsp;共<asp:Label ID="lblTotal" runat="server" Text=""></asp:Label>页&nbsp;&nbsp;共<asp:Label ID="Label2" runat="server" Text=""></asp:Label>条记录&nbsp;&nbsp;当前<asp:Label ID="lblCurrent" runat="server" Text="1"></asp:Label>页</div>
   </div>
</div>
</asp:Content>

