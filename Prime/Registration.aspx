<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

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
                Registration</h1>
        </div>
        <div class="row">
            <h3>
                Name</h3>
            <asp:TextBox ID="TxtName" class="txt" type="text" runat="server" placeholder="Name" required></asp:TextBox>
            <h3>
                Email</h3>
            <asp:TextBox ID="TxtEmail" class="txt" type="text" runat="server" placeholder="Email" required></asp:TextBox>
            <h3>
                Password</h3>
            <asp:TextBox ID="TxtPsw" class="txt" type="password" runat="server" placeholder="Password" required></asp:TextBox>
            <h3>
                Confirm Password</h3>
            <asp:TextBox ID="TxtConPsw" class="txt" type="password" runat="server" placeholder="Confirm Password"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToCompare="TxtConPsw"
                ErrorMessage="Not Matched" ForeColor="Red" ControlToValidate="TxtPsw" Style="padding-right: 15%;"></asp:CompareValidator>
            <div align="center" style="margin:20px 0 30px 0;">
                <asp:Button ID="BtnReg" class="btn" runat="server" Text="Register" OnClick="BtnReg_Click" /></div>
            <a href="Login.aspx" style="color: blue">Sing-In</a>
        </div>
    </div>
    </form>
</body>
</html>
