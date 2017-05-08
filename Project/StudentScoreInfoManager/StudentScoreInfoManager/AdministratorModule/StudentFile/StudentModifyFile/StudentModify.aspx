<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentModify.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.StudentFile.StudentModifyFile.StudentModify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btn1" runat="server" Text="修改" OnClick="btn1_Click" />
        <%=Session["AdminiId"]="hh" %>
    </div>
    </form>
</body>
</html>
