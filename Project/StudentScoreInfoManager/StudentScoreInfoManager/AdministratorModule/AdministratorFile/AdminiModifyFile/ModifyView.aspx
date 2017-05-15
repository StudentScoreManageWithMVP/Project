<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/Management.Master" AutoEventWireup="true" CodeBehind="ModifyView.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiModifyFile.ModifyView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    管理员个人信息修改
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Css/AdminiInfoModify.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="modify_content">
        <form id="form1" runat="server">
            <%var admini = Session["Administrator"] as StudentScoreInfoManager.LinqClass.Administrator;
      %>
            姓名:
        <input type="text" name="nameInput" class="input_class" value="<%=admini.Name %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Name %>';}"/>
        <br />
        性别:
        <input type="text" name="sexInput" class="input_class" value="<%=admini.Sex %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Sex %>';}"/>
        <br />
        年龄:
        <input type="text" name="ageInput" class="input_class" value="<%=admini.Age %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Age %>';}"/>
        <br />
        电话号码:
        <input type="text" name="phoneInput" class="input_class" value="<%=admini.PhoneNumber %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.PhoneNumber %>';}"/>
        <br />
        出生地：
        <input type="text" name="originPlaceInput" class="input_class" value="<%=admini.OriginPlace %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.OriginPlace %>';}"/>
        <br />
        简介:
        <br />
        <textarea rows="10" cols="100" name="brifeInput" class="textarea_class"><%=admini.Brief_Introducation %></textarea>
        <asp:Button ID="updateBtn" Text="更新" runat="server" OnClick="updateBtn_Click" CssClass="updateBtn"/>
        </form>
    </div>
</asp:Content>
