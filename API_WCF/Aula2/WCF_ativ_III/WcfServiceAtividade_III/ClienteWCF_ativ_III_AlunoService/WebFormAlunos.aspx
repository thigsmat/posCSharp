<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormAlunos.aspx.cs" Inherits="ClienteWCF_ativ_III_AlunoService.WebFormAlunos" %>

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
        <asp:GridView ID="GridViewAlunos" runat="server"></asp:GridView>
        <br />
        <asp:TextBox ID="txtBuscar" runat="server"></asp:TextBox>
        <asp:Button ID="btnSelecionar" runat="server" Text="Selecionar" OnClick="btnSelecionar_Click" />
          <br />
          <asp:Label ID="Label1" runat="server" Text="Aluno Media"></asp:Label>
          <asp:TextBox ID="txtIDMedia" runat="server"></asp:TextBox>
          <asp:Button ID="btnMedia" runat="server" Text="Media" OnClick="btnMedia_Click" />
           <asp:TextBox ID="txtMedia" runat="server"></asp:TextBox>
<br />
    </div>
    </form>
</body>
</html>
