<%@ Page Title="" Language="C#" MasterPageFile="~/admin/admin.master" AutoEventWireup="true" CodeFile="qc_edit.aspx.cs" Inherits="admin_qc_edit" validateRequest="false" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/admin_gy.css" rel="stylesheet" type="text/css" />

    <script src="My97DatePicker/WdatePicker.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left">
        <div class="l_top">汽车管理</div>
        <div class="l_con">
           <ul>
              <li><a href="admin_qc.aspx">汽车首页</a></li>
              <li><a href="qc_add.aspx">汽车发布</a></li>
              <li><a href="qc_edit.aspx">汽车编辑</a></li>
              <li><a href="#">说明</a></li>
           </ul>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="right">
       <div class="r_top">汽车内容编辑</div>
       <div class="r_con">
          <asp:GridView ID="grdqc" runat="server" AutoGenerateColumns="False" 
               onrowediting="grdqc_RowEditing" 
               onrowcancelingedit="grdqc_RowCancelingEdit" 
               onrowupdating="grdqc_RowUpdating" DataKeyNames="qcId" 
               onrowdeleting="grdqc_RowDeleting">
           <Columns>
               <asp:TemplateField HeaderText="汽车标题">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtqcbt" runat="server" Text='<%# Bind("qcTitle") %>' 
                           TextMode="MultiLine" Width="80px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label2" runat="server" Text='<%# Bind("qcTitle") %>' CssClass="zt1"></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t2" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="汽车内容">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtqccon" runat="server" Text='<%# Bind("qcCon") %>' 
                           TextMode="MultiLine" Width="240px" Height="190px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label3" runat="server" Text='<%# Bind("qcCon") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t31" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="价格">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtqcprice" runat="server" Width="40px" Height="190px" Text='<%# Bind("qcPrice") %>' CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label1" runat="server" Text='<%# Bind("qcPrice") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="tpice" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="汽车图片">
                   <EditItemTemplate>
                      <asp:FileUpload ID="fuimg" runat="server" Width="80px" Height="30px" /><br/>
                       <asp:TextBox ID="txtimg" runat="server" Text='<%# Bind("qcImg") %>' Width="100px" Height="150px"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label4" runat="server" Text='<%# Bind("qcImg") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t4" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布人">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtqcman" runat="server" Text='<%# Bind("qcFbman") %>' 
                           Width="60px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label5" runat="server" Text='<%# Bind("qcFbman") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t5" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="发布时间">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtqctime" runat="server" onClick="WdatePicker()" Text='<%# Bind("qcTime") %>' 
                           Width="70px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label6" runat="server" Text='<%# Bind("qcTime") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t6" />
               </asp:TemplateField>
               <asp:TemplateField HeaderText="评论">
                   <EditItemTemplate>
                       <asp:TextBox ID="txtqcpl" runat="server" Text='<%# Bind("qcpl") %>' 
                           Width="30px" CssClass="zt1"></asp:TextBox>
                   </EditItemTemplate>
                   <ItemTemplate>
                       <asp:Label ID="Label7" runat="server" Text='<%# Bind("qcpl") %>'></asp:Label>
                   </ItemTemplate>
                   <ItemStyle CssClass="t7" />
               </asp:TemplateField>
               <asp:CommandField ShowEditButton="True" HeaderText="编辑">
               <ItemStyle CssClass="t8" />
               </asp:CommandField>
               <asp:TemplateField HeaderText="删除" ShowHeader="False">
                   <ItemTemplate>
                       <asp:LinkButton ID="lbtndel" runat="server" CausesValidation="False" 
                           CommandName="Delete" Text="删除" CommandArgument='<%# Eval("qcId") %>' 
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

