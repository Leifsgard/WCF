<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamousPassedAway2010.aspx.cs" Inherits="Client.FamousPassedAway2010" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="Label2" runat="server" Text="Please enter a date from the list below to see which famous person that passed away at that date:  "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" Height="409px" TextMode="MultiLine" Width="400px"></asp:TextBox>
    </div>
    </form>
</body>
</html>
