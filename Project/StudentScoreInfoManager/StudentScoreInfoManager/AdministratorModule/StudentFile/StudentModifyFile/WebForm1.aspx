<%@ Page Title="" Language="C#" MasterPageFile="~/MasterForm/Management.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.StudentFile.StudentModifyFile.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="title" runat="server">
    学生信息修改
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <link href="../../../Css/AdminiInfoModify.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="modify_content">
        <form id="form1" runat="server">
        <%var student = Session["Student"] as StudentScoreInfoManager.LinqClass.Student; %>
        姓名:
        <input type="text" name="nameInput" class="input_class" value="<%=student.Name %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Name %>';}"/>
        <label class="warn_content" id="name">*</label>
        密码:
        <input type="password" name="passwordInput" class="input_class" value="<%=student.Password %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Password %>';}"/>
        <label class="warn_content" id="password">*</label>
        <br />
        性别:
        <input type="text" name="sexInput" class="input_class" value="<%=student.Sex %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Sex %>';}"/>
            <label class="warn_content" id="sex">*</label>
        <br />
        年龄:
        <input type="text" name="ageInput" class="input_class" value="<%=student.Age %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Age %>';}"/>
            <label class="warn_content" id="age"></label>
        专业:
        <!--待改下拉列表-->
        <input type="text" name="professionInput" class="input_class" value="<%=student.Profession %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Profession %>';}"/>
            <label class="warn_content" id="profession">*</label>
            <br />
        民族:
            <!--待改下拉列表-->
            <input type="text" name="nationInput" class="input_class" value="<%=student.Nation %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Nation %>';}"/>
            <label class="warn_content" id="nation">*</label>
        政治面貌:
            <!--待改下拉列表-->
            <input type="text" name="politicalInput" class="input_class" value="<%=student.PoliticalOutlook %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.PoliticalOutlook %>';}"/>
            <label class="warn_content" id="political" >*</label>
            <br />
        曾用名:
            <input type="text" name="usednameInput" class="input_class" value="<%=student.UsedName %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.UsedName %>';}"/>
            <label class="warn_content" id="username"></label>
        身份证号:
            <input type="text" name="identityInput" class="input_class" value="<%=student.IdentityCardNum %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.IdentityCardNum %>';}"/>
            <label class="warn_content" id="identity">*</label>
            <br />
        生日:
            <!--格式提醒-->
            <input type="text" name="birthdayInput" class="input_class" value="<%=student.Birthday %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Birthday %>';}"/>
            <label class="warn_content" id="birthday">格式:201x-x-x</label>
        出生地:
            <input type="text" name="originplaceInput" class="input_class" value="<%=student.OriginPlace %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.OriginPlace %>';}"/>
            <label class="warn_content" id="originplace"></label>
            <br />
        健康状况:
            <input type="text" name="healthInput" class="input_class" value="<%=student.Health %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Health %>';}"/>
            <label class="warn_content" id="health"></label> 
        入学年份:
            <input type="text" name="enrollmenInput" class="input_class" value="<%=student.EnrollmenYear %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.EnrollmenYear %>';}"/>
            <label class="warn_content" id="enrollmen">*格式:201x-x-x</label>  
            <br />
        家庭住址:
            <input type="text" name="homeInput" class="input_class" value="<%=student.HomeAddress %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.HomeAddress %>';}"/>
            <label class="warn_content" id="home"></label>
        手机号码:
            <input type="text" name="phoneInput" class="input_class" value="<%=student.PhoneNumber %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.PhoneNumber %>';}"/>
            <label class="warn_content" id="phone"></label>
            <br />
        邮件:
            <input type="text" name="mailInput" class="input_class" value="<%=student.Mail %>" onfocus="this.value = '';" onblur="if (this.value == '') {this.value = '<%=student.Mail %>';}"/>
            <label class="warn_content" id="mail"></label>
            <br />
        照片:
        <input id="file" runat="server" type="file" name="imageInput" class="input_class" />
        <asp:Button ID="updateBtn" Text="更新" runat="server" OnClick="updateBtn_Click" CssClass="updateBtn"/>
        </form>
    </div>
    <script src="/Script/jquery.min.js" type="text/javascript"></script>
    <script type="text/javascript">
        //姓名
        $('.input_class').eq(0).blur(function () {
            if ($(this).val() == "") {
                $(this).next('input').html("*不能为空");
            }
            else if ($(this).val().length <= 1 || $(this).val().length > 40) {
                $(this).next('input').html("*姓名长度必须在2-40个字符内");
            }
            else {
                $(this).next('input').html("*");
            }
        });
        //密码
        $('.input_class').eq(1).blur(function () {
            if ($(this).val() == "") {
                $(this).next('input').html("*不能为空");
            }
            else if ($(this).val().length < 3 || $(this).val().length > 8) {
                $(this).next('input').html("*密码长度必须在3-8个字符内");
            }
            else {
                $(this).next('input').html("*");
            }
        });
        //性别
        $('.input_class').eq(3).blur(function () {
            if ($(this).val() == "") {
                $(this).next('input').html("*不能为空");
            }
            else {
                $(this).next('input').html("*");
            }
        });
        //年龄
        $('.input_class').eq(4).blur(function () {
            if ($(this).val() != "") {
                if (Number($(this).val()) <= 0 || Number($(this).val()) > 65) {
                    $(this).next('input').html("*年龄必须在0-65之间");
                }
                else {
                    $(this).next('input').html("");
                }
            }
        });
        //手机号码
        $('.input_class').eq(15).blur(function () {
            if ($(this).val() != "") {
                if (!$(this).val().match(/^1\d{10}$/)) {
                    $(this).next('input').html("*请输入正确格式的手机号码");
                }
                else {
                    $(this).next('input').html("");
                }
            }
        });
        //出生地
        $('.input_class').eq(11).blur(function () {
            if ($(this).val() != "") {
                if ($(this).val().length <= 0 || $(this).val().length > 40) {
                    $(this).next('input').html("*字数必须在40字以内");
                } else {
                    $(this).next('input').html("");
                }
            }
        });
        //专业
        //民族
        //政治面貌
        //曾用名
        $('.input_class').eq(8).blur(function () {
            if ($(this).val() != "") {
                if ($(this).val().length <= 1 || $(this).val().length > 40)
                    $(this).next('input').html("*姓名长度必须在2-40个字符内");
            }
        });
        //身份证号
        $('.input_class').eq(9).blur(function () {
            if ($(this).val() != "") {
                //正则表达式验证
                if (1) { }
            } else {
                $(this).next('input').html("*不能为空");
            }
        });
        //生日
        $('.input_class').eq(10).blur(function () {
            if ($(this).val() != "") {
                //正则表达式验证
                if (1) {
                    $(this).next('input').html("*请输入正确的生日格式");
                }
            }
        });
        //健康状况
        $('.input_class').eq(12).blur(function () {
            if ($(this).val() != "") {
                if ($(this).val().length > 10) {
                    $(this).next('input').html("*必须在10个字符以内");
                }
            }
        });
        //入学年份
        $('.input_class').eq(13).blur(function () {
            if ($(this).val() != "") {
                //正则表达式验证
                if (1) {
                    $(this).next('input').html("*请输入正确的日期格式");
                }
            } else {
                $(this).next('input').html("*不能为空");
            }
        });
        //家庭住址
        //健康状况
        $('.input_class').eq(14).blur(function () {
            if ($(this).val() != "") {
                if ($(this).val().length > 50) {
                    $(this).next('input').html("*必须在50个字符以内");
                }
            }
        });
        //邮件
        $('.input_class').eq(16).blur(function () {
            if ($(this).val() != "") {
                //正则表达式格式验证
                if (1) {
                    $(this).next('input').html("*请填写正确的邮箱格式");
                }
            }
        });
    </script>
</asp:Content>
