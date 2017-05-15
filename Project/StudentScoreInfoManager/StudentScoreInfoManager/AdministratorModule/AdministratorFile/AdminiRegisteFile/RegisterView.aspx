<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/Management.Master" AutoEventWireup="true" CodeBehind="RegisterView.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiRegisteFile.RegisterView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    管理员注册
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Css/AdminiInfoModify.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%var admini = Session["Administrator"] as StudentScoreInfoManager.LinqClass.Administrator;
      if (admini.Id != 1) { 
        %>
        <center>
            <h3>抱歉您没有权限</h3>
        </center>
    <% 
      }
      else { 
        %>
        <div class="modify_content">
        <form id="form1" runat="server">           
        姓名:
        <input type="text" name="nameInput" class="input_class" value=""/>
        <label class="warn_content" id="name">*</label>
        <br />
        密码:
        <input type="password" name="passwordInput" class="input_class" value=""/>
        <label class="warn_content" id="password">*</label>
        <br />
        确认密码:
        <input type="password" name="confrimpasswordInput" class="input_class" value=""/>
            <label class="warn_content" id="confrimpassword">*</label>
        <br />
        性别:
        <input type="text" name="sexInput" class="input_class" value=""/>
            <label class="warn_content" id="sex">*</label>
        <br />
        年龄:
        <input type="text" name="ageInput" class="input_class" value=""/>
            <label class="warn_content" id="age"></label>
        <br />
        电话号码:
        <input type="text" name="phoneInput" class="input_class" value=""/>
            <label class="warn_content" id="phonenumber"></label>
        <br />
        出生地：
        <input type="text" name="originPlaceInput" class="input_class" value=""/>
            <label class="warn_content" id="originplace"></label>
        <br />
        简介:
        <br />
        <textarea rows="10" cols="100" name="brifeInput" class="textarea_class"></textarea>
            <label class="warn_content" id="birfeintroduce"></label>
            <br />
        照片:
        <input id="file" runat="server" type="file" name="imageInput" class="input_class" />
        <asp:Button ID="registerBtn" Text="注册" runat="server" OnClick="registerBtn_Click" CssClass="updateBtn"/>
        </form>
    </div>
    <script src="/Script/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript" src="/Script/AdminiRegister.js"></script>
    <%}
       %>
</asp:Content>
