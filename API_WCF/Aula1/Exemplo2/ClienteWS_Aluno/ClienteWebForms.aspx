<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteWebForms.aspx.cs" Inherits="ClienteWS_Aluno.ClienteWebForms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
  
        <asp:Button ID="txtCarregar" runat="server" Text="Carregar Alunos" OnClick="txtCarregar_Click" />
    
        <br /><br />
        <asp:GridView ID="grvAlunos" runat="server"></asp:GridView>
        <asp:Label ID="lblerro" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
