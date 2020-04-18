<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="kj_edit.aspx.cs" Inherits="admin_kj_edit" ValidateRequest="false"%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
<link href="css/admin_gy.css" rel="stylesheet" type="text/css" />

    <script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>
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
       <div class="r_top">科技内容编辑</div>
       <div class="r_con">
          <asp:GridView ID="grdkj" runat="server" AutoGenerateColumns="False" 
               onrowediting="grdkj_RowEditing" 
               onrowcancelingedit="grdkj_RowCancelingEdit" 
               onrowupdating="grdkj_RowUpdating" DataKeyNames="kjId" 
               onrowdeleting="grdkj_RowDeleting">
           <Columns>
               <asp:TemplateField HeaderText="科技标题">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtkjbt" runat="server" Text='<%# Bind("kjTitle") %>' 
                           TextMode="MultiLine" Width="80px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("kjTitle") %>' CssClass="zt1"></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t2" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="科技内容">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtkjcon" runat="server" Text='<%# Bind("kjCon") %>' 
                           TextMode="MultiLine" Width="240px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label3" runat="server" Text='<%# Bind("kjCon") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t31" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="图片">
                   <EditItemTemplate>
                      <asp:FileUpload ID="fuimg" runat="server" Width="80px" Height="30px" /><br/>
                       <asp:TextBox ID="txtimg" runat="server" Text='<%# Bind("kjImg") %>' Width="100px" Height="150px"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label4" runat="server" Text='<%# Bind("kjImg") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t4" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布人">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtkjman" runat="server" Text='<%# Bind("kjFbman") %>' 
                           Width="60px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label5" runat="server" Text='<%# Bind("kjFbman") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t5" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布时间">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtkjtime" runat="server" onClick="WdatePicker()" Text='<%# Bind("kjTime") %>' 
                           Width="80px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label6" runat="server" Text='<%# Bind("kjTime") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t6" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="评论">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtkjpl" runat="server" Text='<%# Bind("kjpl") %>' 
                           Width="50px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label7" runat="server" Text='<%# Bind("kjpl") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t7" />
               </asp:TemplateField>
               <asp:CommandField ShowEditButton="True" HeaderText="编辑">
               <ItemStyle CssClass="t8" />
               </asp:CommandField>
               <asp:TemplateField HeaderText="删除" ShowHeader="False">
                   <ItemTemplate>
                       <asp:LinkButton ID="lbtndel" runat="server" CausesValidation="False" 
                           CommandName="Delete" Text="删除" CommandArgument='<%# Eval("kjId") %>' 
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

