<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamousPeopleWebForm.aspx.cs" Inherits="Client.FamousPeopleWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label2" runat="server" Text="Please enter a year from the list below to see which famous person died in a plane crash that year:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="409px" TextMode="MultiLine" Width="400px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
