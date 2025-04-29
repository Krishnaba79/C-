<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblName" runat ="server" Text="Enter First Number"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <asp:Label ID="lblName1" runat="server" Text="Enter Second Number"></asp:Label>
            <asp:TextBox ID="txtName1" runat="server"></asp:TextBox>

            <asp:DropDownList ID="ddl" runat="server">
                <asp:ListItem Value="1">Addition</asp:ListItem>
                <asp:ListItem Value="2">Submition</asp:ListItem>
                <asp:ListItem Value="3">Multiplication</asp:ListItem>
                <asp:ListItem Value="4">Divison</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
