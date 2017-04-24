<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BrowseAndModify.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.AdministratorFile.AdminiBMFile.BrowseAndModify" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="t1" runat="server" Enabled="false"/>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click" Text="修改" />
    </div>
    </form>
</body>
</html>
