<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kj_add.aspx.cs" Inherits="admin_kj_add" ValidateRequest="false"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>科技发布</title>
    <link href="css/admin_fb.css" rel="stylesheet" />
    <script src="My97DatePicker/WdatePicker.js"></script>
    <script src="js/admin_mb.js"></script>
    <script src="My97DatePicker/WdatePicker.js"></script>
    <link href="css/admin_add.css" rel="stylesheet" />
    <script src="kindeditor-4.1.10/kindeditor.js"></script>
    <script src="kindeditor-4.1.10/lang/zh_CN.js"></script>
    <script src="kindeditor-4.1.10/plugins/code/prettify.js"></script>
    <link href="kindeditor-4.1.10/plugins/code/prettify.css" rel="stylesheet" />
    <link href="kindeditor-4.1.10/themes/default/default.css" rel="stylesheet" />
    <script>
        KindEditor.ready(function (K) {
            var editor1 = K.create('#content1', {
                cssPath: 'kindeditor-4.1.10/plugins/code/prettify.css',
                uploadJson: 'kindeditor-4.1.10/asp.net/upload_json.ashx',
                fileManagerJson: 'kindeditor-4.1.10/asp.net/file_manager_json.ashx',
                allowFileManager: true,
                afterCreate: function () {
                    var self = this;
                    K.ctrl(document, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                    K.ctrl(self.edit.doc, 13, function () {
                        self.sync();
                        K('form[name=example]')[0].submit();
                    });
                }
            });
            prettyPrint();
        });
	</script>
</head>
<body>
    <form id="form1" runat="server">
       <div id="box">
        <div class="top">
            <div class="t_top">
                <asp:Button ID="btnhsy" runat="server" Text="后台首页" Width="70px" Height="30px" BackColor="#3366CC" ForeColor="#FFFFCC" CssClass="btn" OnClick="btnhsy_Click" CausesValidation="False" />&nbsp;&nbsp
                <asp:Button ID="btnqsy" runat="server" Text="前台首页" Width="70px" Height="30px" BackColor="#3366CC" ForeColor="#FFFFCC" CssClass="btn" OnClick="btnqsy_Click" CausesValidation="False" /></div>
        </div>
        <div class="b_nav">
            <div class="n_left">欢迎回来：<asp:Label ID="lbname" runat="server" Text=""></asp:Label>
                &nbsp;&nbsp;<asp:LinkButton
                ID="lbexit" runat="server" onclick="lbexit_Click" CausesValidation="False" ForeColor="White">退出</asp:LinkButton>
            </div>
            <div id="n_right">
                <ul>
                    <li><a href="#">后台首页</a></li>
                    <li><a href="#">资讯</a>
                        <ul>
                            <li><a href="admin_xw.aspx">新闻</a></li> 
                            <li><a href="admin_xy.aspx">校园</a></li>
                            <li><a href="admin_yl.aspx">娱乐</a></li>
                            <li><a href="admin_ty.aspx">体育</a></li>
                            <li><a href="admin_qc.aspx">汽车</a></li>
                            <li><a href="admin_yx.aspx">游戏</a></li>
                       </ul>
                    </li>
                    <li><a href="#">生活</a>
                        <ul>
                            <li><a href="admin_kj.aspx">科技</a></li> 
                            <li><a href="admin_jk.aspx">健康</a></li>
                            <li><a href="admin_ly.aspx">旅游</a></li>
                            <li><a href="admin_sp.aspx">商城</a></li>
                            <li><a href="admin_sx.aspx">时尚</a></li>
                            <li><a href="admin_ms.aspx">美食</a></li>
                       </ul>
                    </li>
                    <li><a href="#">电影</a>
                        <ul>
                            <li><a href="admin_dy.aspx">电影</a></li>
                            
                       </ul>
                    </li>
                    <li><a href="#">互动</a>
                        <ul>
                            <li><a href="admin_sd.aspx">学习</a></li>
                        </ul>
                    </li>
                </ul>
            </div>
        </div>
        <div class="main">
            <div class="m_left">
                <div class="ml_top">科技管理</div>
                <div class="ml_con">
                   <ul>
                      <li><a href="admin_kj.aspx">科技首页</a></li>
                      <li><a href="kj_add.aspx">科技发布</a></li>
                      <li><a href="kj_edit.aspx">科技编辑</a></li>
                      <li><a href="#">说明</a></li>
                   </ul>
                </div>
           </div>
            <div class="m_right">
               <div class="mr_top">科技内容添加</div>
               <div class="mr_con">
                  <div class="bt">
                      <div class="bt_top">科技标题</div>
                      <div class="bt_con">
                          <asp:TextBox ID="txtkjbt" runat="server" Width="400px" Height="40px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="标题不能为空" Display="Dynamic" ControlToValidate="txtkjbt"></asp:RequiredFieldValidator>
                      </div>
                  </div>
                  <div class="nr">
                      <div class="nr_top">科技内容(必填)&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="内容不能为空" ControlToValidate="content1" Display="Dynamic"></asp:RequiredFieldValidator></div>
                      <div class="nr_con">
                          <textarea id="content1" cols="100" rows="8" style="width:500px;height:170px;visibility:hidden;" runat="server"></textarea>
                      </div>
                  </div>
                  <div class="Img">
                      <div class="im_top">科技照片</div>
                      <div class="im_con">
                          <asp:FileUpload ID="fuimg" runat="server" /></div>
                  </div>
                  <div class="fbman">
                      <div class="fb_top">发布人</div>
                      <div class="fb_con">
                          <asp:TextBox ID="txtfbman" runat="server" Width="120px" Height="20px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="发布人不能为空" Display="Dynamic" ControlToValidate="txtfbman"></asp:RequiredFieldValidator></div>
                  </div>
                  <div class="time">
                      <div class="tm_top">发布时间</div>
                      <div class="tm_con">
                          <asp:TextBox ID="txttime" runat="server" onClick="WdatePicker()" Height="20px" Width="140px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="发布时间不能为空" Display="Dynamic" ControlToValidate="txttime"></asp:RequiredFieldValidator></div>
                  </div>
                  <div class="btn">
                      <asp:Button ID="btnok" runat="server" Text="发布" Width="100px" Height="30px" CssClass="b_css1" OnClick="btnok_Click" />&nbsp;&nbsp;&nbsp; 
                      <asp:Button ID="btncancel" runat="server" Text="清空" Width="100px" Height="30px" 
                          CssClass="b_css1" OnClick="btncancel_Click" CausesValidation="False"  />
                  </div>
           </div>
        </div>
           
        </div>
        <div class="bottom">W蓝科技工作室&nbsp;|&nbsp;后台管理&nbsp;|&nbsp;技术支持<br/>Copyright© 2015　dqccc.com. All Rights Reserved</div>
    </div>
    </form>
</body>
</html>
