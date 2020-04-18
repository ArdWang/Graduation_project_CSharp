<%@ Page Title="" Language="C#" MasterPageFile="~/content/content.master" AutoEventWireup="true" CodeFile="sy_jk_content.aspx.cs" Inherits="content_sy_jk_content" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="css/content.css" rel="stylesheet" />
    <link href="css/sy_gy.css" rel="stylesheet" type="text/css" />
    <script src="js/txtbanduan.js"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="left1">
   <div class="l_top">
       <div class="t_left"><img src="images/db/logo.png" alt="" /></div>
       <div class="t_right">当前的位置：<a href="sy_jiank.aspx">首页</a>&nbsp;>&nbsp;健康内容</div>
   </div>
   <div class="l_con1">
       <asp:Repeater ID="rptgy" runat="server" OnItemDataBound="rptgy_ItemDataBound">
        <HeaderTemplate><ul></HeaderTemplate>
        <ItemTemplate>
           <li class="ltop">
               <asp:Label ID="lbtitle" runat="server" Text='<%# Eval("jkTitle") %>'></asp:Label><li>
           <li class="ledit">
               编辑：<asp:Label ID="lbedit" runat="server" Text='<%# Eval("jkfbman") %>'></asp:Label></li>
           <li class="ltime">
               编辑时间：<asp:Label ID="lbtime" runat="server" Text='<%# Eval("jkTime") %>'></asp:Label></li>
           <li class="limg">
               <asp:Image ID="imgxy" runat="server" ImageUrl='<%# Eval("jkImg") %>' />
               <span class="imgzt"><asp:Label
                   ID="lbimg" runat="server" Text=""></asp:Label></span></li>
           <li class="lcon">
               <asp:Literal ID="ltcon" runat="server" Text='<%# Eval("jkCon") %>'></asp:Literal></li>
           <li class="lpl">评论（<asp:Label ID="lbplnum" runat="server" Text='<%# Eval("jkpl") %>'></asp:Label>）</li>
        </ItemTemplate>
        <FooterTemplate></ul></FooterTemplate>
       </asp:Repeater>
       <asp:Label ID="lbserach" runat="server" CssClass="lbszt1"></asp:Label>
   </div>
   <div class="wz">
       <div class="wzxs">
           <asp:Repeater ID="rptgs" runat="server">
               <HeaderTemplate><ul></HeaderTemplate>
               <ItemTemplate>
                   <li><span class="zitixs">上一篇</span>：<asp:HyperLink ID="hylss" runat="server" Text='<%# ziduanjq.Jq_xwbtxs(Eval("jkTitle").ToString()) %>' NavigateUrl='<%# Eval("jkId","sy_jk_content.aspx?jk_id={0}") %>'>
                       </asp:HyperLink><br/></li>
               </ItemTemplate>
               <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
       <div class="wzxx">
           <asp:Repeater ID="rptgx" runat="server">
               <HeaderTemplate><ul></HeaderTemplate>
               <ItemTemplate>
                   <li><span class="zitixs">下一篇</span>：<asp:HyperLink ID="hylss1" runat="server" Text='<%# ziduanjq.Jq_xwbtxs(Eval("jkTitle").ToString()) %>' NavigateUrl='<%# Eval("jkId","sy_jk_content.aspx?jk_id={0}") %>'>
                       </asp:HyperLink><br/></li>
               </ItemTemplate>
               <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
   </div>
   <div class="pl">
       <div class="pl_top"><span class="plzt2">网友评论</span></div>
       <div class="pl_con">
           <asp:Repeater ID="rptpl" runat="server">
               <HeaderTemplate><ul></HeaderTemplate>
               <ItemTemplate>
                   <li>
                       <asp:Label ID="lbname" runat="server" Text='<%# Eval("plman") %>'></asp:Label>&nbsp;说：<asp:Literal ID="ltplcon" runat="server" Text='<%# Eval("plcon") %>'></asp:Literal></li>
               </ItemTemplate>
               <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
   </div>
   <div class="l_pl">
       <div class="p_top"><span class="plzt2">娱乐评论</span><span class="plzt1">(文明发言,为自己争光！)</span></div>
       <div class="p_con">
           <asp:TextBox ID="txtpl" runat="server" TextMode="MultiLine" Width="500px" Height="100px" onkeyup="regx(this)"></asp:TextBox>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtpl" Display="Dynamic" ErrorMessage="*"></asp:RequiredFieldValidator>
           <br/>
           &nbsp;<span class="plzt3">验证码：</span><img style="height:30px; width:70px;" src="Ashxchuli/yanzhenma.ashx" onclick="this.src='Ashxchuli/yanzhenma.ashx?aaa='+new Date()" alt="" />&nbsp;&nbsp;<asp:TextBox ID="yanzhenma" runat="server" Width="80px" Height="20px"></asp:TextBox>&nbsp;<span class="plzt3"><asp:CustomValidator ID="CustomValidator2" runat="server" ControlToValidate="yanzhenma" Display="Dynamic" ErrorMessage="验证码输入错误" ForeColor="Red" OnServerValidate="CustomValidator2_ServerValidate"></asp:CustomValidator>
           <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="yanzhenma" Display="Dynamic" ErrorMessage="验证码不能为空"></asp:RequiredFieldValidator>
           </span>
       </div>
       <div class="p_bottom">
           <asp:Button ID="btnfb" runat="server" Text="发表"  Width="70px" Height="25px" OnClick="btnfb_Click"/>&nbsp;&nbsp;<asp:Button ID="btnqx" runat="server" Text="取消"  Width="70px" Height="25px" CausesValidation="False" OnClick="btnqx_Click"/></div>
   </div>
</div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <div class="right">
       <div class="r_top1">
                  <ul>
                     <li style=" text-align:right; font-size:12px;">站内搜索：</li><li>
                         <asp:TextBox ID="txtserach" runat="server" Width="100px" Height="20px"></asp:TextBox></li>
                     <li style=" text-align:center;">
                         <asp:Button ID="btnserach" runat="server" Text="搜索" Width="60px" Height="25px" 
                             onclick="btnserach_Click" CausesValidation="False" /></li>
                  </ul>
               </div>
       <div class="r_top">最新发布</div>
       <div class="r_con">
           <asp:Repeater ID="rptgy1" runat="server">
             <HeaderTemplate><ul></HeaderTemplate>
             <ItemTemplate>
                 <li>
                     <asp:HyperLink ID="hyplk1" runat="server" Text='<%# ziduanjq.Jq_xwbt2(Eval("jkTitle").ToString()) %>' NavigateUrl='<%# Eval("jkId","sy_jk_content.aspx?jk_id={0}") %>'></asp:HyperLink></li>
             </ItemTemplate>
             <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
       <div class="r_top">最热资讯</div>
       <div class="r_con">
           <asp:Repeater ID="rptgy2" runat="server">
             <HeaderTemplate><ul></HeaderTemplate>
             <ItemTemplate>
                 <li>
                     <asp:HyperLink ID="hyplk2" runat="server" Text='<%# ziduanjq.Jq_xwbt2(Eval("jkTitle").ToString()) %>' NavigateUrl='<%# Eval("jkId","sy_jk_content.aspx?jk_id={0}") %>'></asp:HyperLink></li>
             </ItemTemplate>
             <FooterTemplate></ul></FooterTemplate>
           </asp:Repeater>
       </div>
    </div>
</asp:Content>

