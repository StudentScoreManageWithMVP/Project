<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/Management.Master" AutoEventWireup="true" CodeBehind="BrowseView.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiBMFile.BrowseModify" %>
<asp:Content ID="ContentTitle" ContentPlaceHolderID="title" runat="server">
    管理员个人信息
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Css/AdminiInfoBrowse.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%var admini = mPresenter.GetAdministratorById(1);
      Session["Administrator"] = admini;
      %>
    <div class="admini_main_content">
        <div class="image_content">
            <img src="<%=admini.ImageUrl %>" />
        </div>
        <br />        
        <label>姓名:<%=admini.Name %></label>
        <br />
        <label>性别:<%=admini.Sex %></label>
        <br />
        <label>年龄:<%=admini.Age %></label>
        <br />
        <label>电话号码:<%=admini.PhoneNumber %></label>
        <br />
        <label>出生地:<%=admini.OriginPlace %></label>
        <br />      
        <label>简介:<%=admini.Brief_Introducation %></label>
        <br />
        <a href="../AdminiModifyFile/ModifyView.aspx">修改</a>
    </div>
    <!--<script src="/Script/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        $('.admini_main_content a').click(function () {
            $.session.set('administoridId','');
        });
    </script>-->
</asp:Content>
