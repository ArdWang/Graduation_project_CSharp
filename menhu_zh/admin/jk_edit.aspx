<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="jk_edit.aspx.cs" Inherits="admin_jk_edit" ValidateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/admin_gy.css" rel="stylesheet" type="text/css" />

    <script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div class="left">
        <div class="l_top">健康管理</div>
        <div class="l_con">
           <ul>
              <li><a href="admin_jk.aspx">健康新闻</a></li>
              <li><a href="jk_add.aspx">健康发布</a></li>
              <li><a href="jk_edit.aspx">健康编辑</a></li>
              <li><a href="#">说明</a></li>
           </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
  <div class="right">
       <div class="r_top">内容编辑</div>
       <div class="r_con">
          <asp:GridView ID="grdjk" runat="server" AutoGenerateColumns="False" 
               onrowediting="grdjk_RowEditing" 
               onrowcancelingedit="grdkj_RowCancelingEdit" 
               onrowupdating="grdjk_RowUpdating" DataKeyNames="jkId" 
               onrowdeleting="grdjk_RowDeleting">
           <Columns>
               <asp:TemplateField HeaderText="标题">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtjkbt" runat="server" Text='<%# Bind("jkTitle") %>' 
                           TextMode="MultiLine" Width="80px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("jkTitle") %>' CssClass="zt1"></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t2" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="内容">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtjkcon" runat="server" Text='<%# Bind("jkCon") %>' 
                           TextMode="MultiLine" Width="240px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label3" runat="server" Text='<%# Bind("jkCon") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t31" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="图片">
                   <EditItemTemplate>
                      <asp:FileUpload ID="fuimg" runat="server" Width="80px" Height="30px" /><br/>
                       <asp:TextBox ID="txtimg" runat="server" Text='<%# Bind("jkImg") %>' Width="100px" Height="150px"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label4" runat="server" Text='<%# Bind("jkImg") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t4" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布人">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtjkman" runat="server" Text='<%# Bind("jkFbman") %>' 
                           Width="60px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label5" runat="server" Text='<%# Bind("jkFbman") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t5" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布时间">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtjktime" runat="server" onClick="WdatePicker()" Text='<%# Bind("jkTime") %>' 
                           Width="80px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label6" runat="server" Text='<%# Bind("jkTime") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t6" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="评论">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtjkpl" runat="server" Text='<%# Bind("jkpl") %>' 
                           Width="50px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label7" runat="server" Text='<%# Bind("jkpl") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t7" />
               </asp:TemplateField>
               <asp:CommandField ShowEditButton="True" HeaderText="编辑">
               <ItemStyle CssClass="t8" />
               </asp:CommandField>
               <asp:TemplateField HeaderText="删除" ShowHeader="False">
                   <ItemTemplate>
                       <asp:LinkButton ID="lbtndel" runat="server" CausesValidation="False" 
                           CommandName="Delete" Text="删除" CommandArgument='<%# Eval("jkId") %>' 
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
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</asp:Content>

