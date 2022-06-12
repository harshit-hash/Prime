<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/Registration.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div class="container" align="center">
        <div>
            <h1 style="border-bottom: 1px solid;">
                Login</h1>
        </div>
        <div class="row">
            <h3>
                Email</h3>
            <asp:TextBox ID="TxtEmail" class="txt" runat="server" placeholder="Email"></asp:TextBox>
            <h3>
                Password</h3>
            <asp:TextBox ID="TxtPsw" class="txt" type="password" runat="server" placeholder="Password"></asp:TextBox>
            <div align="center" style="margin: 30px 0 20px 0;">
                <asp:Button ID="BtnLgn" class="btn" runat="server" Text="Login" OnClick="BtnLgn_Click" /></div>
            <a href="Registration.aspx" style="color: blue">Sing-Up</a>
        </div>
    </div>
    </form>
</body>
</html>
