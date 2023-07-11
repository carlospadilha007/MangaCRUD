<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UpdateAccount.aspx.vb" Inherits="Manga.UpdateAccount" %>
<%@ PreviousPageType VirtualPath="~/Views/UserLogin.aspx" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
    <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
    <title>Tela de Atualização de cadastro</title>
    <link rel="stylesheet" href="../Resources/style.css"/>
</head>
<body>
    <div class="wrapper2">
    <h2>Atualizar conta</h2>
    <form action="#" runat="server" id="formCreateAccount">
     
        <div class="input-box">
            <asp:Label ID="lbFirstName" runat="server" Text="Nome"></asp:Label>
          <asp:textbox runat="server" id="tbUpdateFirstName"  Text=""></asp:textbox>
      </div>
      <div class="input-box">
          <asp:Label ID="lbLastName" runat="server" Text="Sobrenome"></asp:Label>
          <asp:textbox runat="server" id="tbUpdateLastName" Text="" ></asp:textbox>
      </div>
      <div class="input-box">
          <asp:Label ID="lbEmail" runat="server" Text="Email"></asp:Label>
        <asp:textbox runat="server" id="tbUpdateEmail" Text="" ></asp:textbox>
      </div>
      <div class="input-box">
          <asp:Label ID="lbPassword" runat="server" Text="Senha"></asp:Label>
        <asp:textbox runat="server" id="tbUpdatePassword" Text="" ></asp:textbox>
      </div>
      <div class="input-box">
          <asp:Label ID="lbNewPassword" runat="server" Text="Nova Senha" ></asp:Label>
        <asp:textbox runat="server" id="tbNewPassword" Text=""></asp:textbox>
      </div>
   
      <div class="input-box button2">
          <asp:Button ID="btnUpdateAccount" runat="server" Text="Atualizar dados" />
      </div>
        <div class="input-box button3">
            <asp:Label ID="lbMail" runat="server" Text="#" Visible="False"></asp:Label>
          <asp:Button ID="btnDeleteAccount" runat="server" Text="Deletar Conta" />
      </div>
    </form>
  </div>
</body>
</html>
