﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NetManageView.aspx.cs" Inherits="StudentScoreInfoManager.AdministratorModule.NetManageFile.NetManageView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:FileUpload runat="server" ID="file1"/>
        <asp:Button ID="btn1" runat="server" OnClick="btn1_Click"/>
    </div>
    </form>
</body>
</html>
