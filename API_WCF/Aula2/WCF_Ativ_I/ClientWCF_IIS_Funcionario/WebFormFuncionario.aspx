<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormFuncionario.aspx.cs" Inherits="ClientWCF_Funcionario.WebFormFuncionario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="btnCarregar" runat="server" Text="Carregar" OnClick="btnCarregar_Click" />
        <br />
        <asp:GridView ID="GridViewfuncionario" runat="server"></asp:GridView>
        <br />
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnSelecionar" runat="server" Text="Selecionar" OnClick="btnSelecionar_Click" />
<br />
    </div>
    </form>
</body>
</html>
