<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserCreateAccount.aspx.vb" Inherits="Manga.UserCreate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
   <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
   <title>Tela de Registro</title>
   <link rel="stylesheet" href="../Resources/style.css"/>
</head>
<body>
    <div class="wrapper">
    <h2>Criar nova conta</h2>
        <form id="formCreateAccount" runat="server">
      <div class="input-box">
          <asp:textbox runat="server" id="tbFirstName" placeholder="Nome" required></asp:textbox>
      </div>
      <div class="input-box">
          <asp:textbox runat="server" id="tbLastName" placeholder="Sobrenome" required></asp:textbox>
      </div>
      <div class="input-box">
        <asp:textbox runat="server" id="tbEmail" placeholder="Email" required></asp:textbox>
      </div>
      <div class="input-box">
        <asp:textbox runat="server" id="tbPassword" placeholder="Senha" required></asp:textbox>
      </div>
      <div class="input-box">
        <asp:textbox runat="server" id="tbPasswordConfirm" placeholder="Confirme a senha" required></asp:textbox>
      </div>
   
      <div class="input-box button">
            <asp:Button ID="btnCreateAccount" runat="server" Text="Criar Conta" PostBackUrl="~/Views/UserLogin.aspx" /> 
         
      </div>
      <div class="text">
          
        <h3>Já possui uma conta? <a href="UserLogin.aspx">Logar Agora</a></h3>
      </div>
        </form>
  </div>
</body>
</html>
