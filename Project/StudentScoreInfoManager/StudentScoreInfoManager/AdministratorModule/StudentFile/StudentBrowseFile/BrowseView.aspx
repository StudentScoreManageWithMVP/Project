<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/Management.Master" AutoEventWireup="true" CodeBehind="BrowseView.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.StudentFile.StudentBrowseFile.BrowseView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    学生信息浏览
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Css/StudentBrowse.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%var student = mPresenter.GetStudentInfoById(1);
      Session["Student"] = student;
      %>
    <div class="student_main_content">
        <div class="image_content">
            <img src="<%=student.ImageUrl %>" />
        </div>
        <br />
        <label>学号:<%=student.StudentId %></label>
        <br />
        <label>姓名:<%=student.Name %></label>
        <br />
        <label>性别:<%=student.Sex %></label>
        <br />
        <label>年龄:<%=student.Age %></label>
        <br />
        <label>专业:<%=student.Sex %></label>
        <br />
        <label>民族:<%=student.Nation %></label>
        <br />
        <label>政治面貌:<%=student.PoliticalOutlook %></label>
        <br />
        <label>曾用名:<%=student.UsedName %></label>
        <br />
        <label>身份证号:<%=student.IdentityCardNum %></label>
        <br />
        <label>生日:<%=student.Birthday %></label>
        <br />
        <label>出生地:<%=student.OriginPlace %></label>
        <br />
        <label>家庭住址:<%=student.HomeAddress %></label>
        <br />
        <label>健康状况:<%=student.Health %></label>
        <br />
        <label>入学年份:<%=student.EnrollmenYear %></label>
        <br />
        <label>电话号码:<%=student.PhoneNumber %></label>
        <br />
        <label>邮箱地址:<%=student.Mail %></label>
        <br />
        <a href="../StudentModifyFile/WebForm1.aspx">修改</a>
    </div>
</asp:Content>
