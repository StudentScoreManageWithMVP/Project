<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/Management.Master" AutoEventWireup="true" CodeBehind="ModifyView.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiModifyFile.ModifyView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%var admini = Session["Administrator"] as StudentScoreInfoManager.LinqClass.Administrator;
      %>
    <style type="text/css">
        .input_class {
                border: none;
                outline: none;
                padding: 9px 12px;
                font-size: 14px;
                color: #9a9a9a;
                font-family: 'Lato', sans-serif;
                width: 250px;
                background: #efefef;
                margin:10px 0px;
        }
    </style>
    姓名:
    <input type="text" class="input_class" value="<%=admini.Name %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Name %>';}"/>
    <br />
    性别:
    <input type="text" class="input_class" value="<%=admini.Sex %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Sex %>';}"/>
    <br />
    年龄:
    <input type="text" class="input_class" value="<%=admini.Age %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Age %>';}"/>
    <br />
    电话号码:
    <input type="text" class="input_class" value="<%=admini.PhoneNumber %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.PhoneNumber %>';}"/>
    <br />
    出生地：
    <input type="text" class="input_class" value="<%=admini.OriginPlace %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.OriginPlace %>';}"/>
    <br />
    简介:
    <input type="text" class="input_class" value="<%=admini.Brief_Introducation %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=admini.Brief_Introducation %>';}"/>


</asp:Content>
