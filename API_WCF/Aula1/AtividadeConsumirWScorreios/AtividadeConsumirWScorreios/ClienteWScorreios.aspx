<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteWScorreios.aspx.cs" Inherits="AtividadeConsumirWScorreios.ClienteWScorreios" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <br /><br />
        <asp:GridView ID="grv" runat="server"></asp:GridView>
        <asp:Label ID="lblerro" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
