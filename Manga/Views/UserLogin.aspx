<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="UserLogin.aspx.vb" Inherits="Manga.UserLogin" %>
<%@ PreviousPageType VirtualPath="~/Views/UserCreateAccount.aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
   <meta http-equiv="X-UA-Compatible" content="ie=edge"/>
   <title>Tela de Login</title>
   <link rel="stylesheet" href="../Resources/style.css"/>
</head>
<body>
    <div class="wrapper">
    <h2>Entrar na conta</h2>
    <form action="#" runat="server">
      <div class="input-box">
          <asp:textbox runat="server" id="tbEmailLogin" placeholder="Email" required></asp:textbox>
      </div>
      <div class="input-box">
          <asp:textbox runat="server" id="tbPasswordLogin" placeholder="Senha" required></asp:textbox>
      </div>
   
      <div class="input-box button">
          <asp:Button ID="btnLoginAccount" runat="server" Text="Entrar" PostBackUrl="~/Views/UpdateAccount.aspx" />
      </div>
      <div class="text">
        <h3>Não possui uma conta? <a href="UserCreateAccount.aspx">Criar conta</a></h3>
      </div>
     </form>
  </div>
</body>
          
</html>
