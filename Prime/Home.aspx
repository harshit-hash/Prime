<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<%@ register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<head runat="server">
    <title></title>
    <link href="css/Home.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <ul>
        <li><a class="active" href="#home">Home</a></li>
        <li><a href="Login.aspx" style="margin-left:1477px;">Log-Out</a></li>
    </ul>
    <div class="card">
        <div class="container" align="center">
            <h1>
                For Calculating Prime No. Please Enter Any 3 Number</h1>
            <h3>
                Enter No. 1</h3>
            <asp:TextBox ID="TxtNo1" runat="server" placeholder="Enter Any"></asp:TextBox>
            <asp:FilteredTextBoxExtender ID="Fb1" runat="server" TargetControlID="TxtNo1" ValidChars="0123456789">
            </asp:FilteredTextBoxExtender>
            <h3>
                Enter No. 2</h3>
            <asp:TextBox ID="TxtNo2" runat="server" placeholder="Enter Any"></asp:TextBox>
            <asp:FilteredTextBoxExtender ID="Fb2" runat="server" TargetControlID="TxtNo2" ValidChars="0123456789">
            </asp:FilteredTextBoxExtender>
            <h3>
                Enter No. 3</h3>
            <asp:TextBox ID="TxtNo3" runat="server" placeholder="Enter Any"></asp:TextBox>
            <asp:FilteredTextBoxExtender ID="Fb3" runat="server" TargetControlID="TxtNo3" ValidChars="0123456789">
            </asp:FilteredTextBoxExtender>
            <div align="center">
                <asp:Button ID="BtnReg" class="btn" runat="server" Text="Find Prime" OnClick="BtnReg_Click" /></div>
        </div>
        <h1>
            <asp:Label ID="LblAns" runat="server" Text=""></asp:Label></h1>
    </div>
    </form>
</body>
</html>
