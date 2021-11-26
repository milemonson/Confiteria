<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="PasteleriaProyect.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>
<html>
<head>
<link rel="shortcut icon" href="./img/logo.png" type="image/png" />
<title>Login Manolita</title>
 <link href="./Styles/Login.css" rel="stylesheet" />

 </head>
  <body>
     <div class="bg"></div>
     <div class="bg bg2"></div>
     <div class="bg bg3"></div>
    <div class="form-box" runat="server">
       <div class="header">
		<img src="./img/logo.png" width="150" height="150" />
		</div>
        <asp:Label ID="Label1" CssClass="Label1" runat="server" Text="Usuario:"></asp:Label>
        <asp:TextBox ID="inputuser" CssClass="inputuser" runat="server" ></asp:TextBox>
       
        <asp:Label ID="Label2" CssClass="Label2" runat="server" Text="Contraseña:"></asp:Label>
        <asp:TextBox ID="inputpass" CssClass="inputpass" runat="server" TextMode="Password"></asp:TextBox>
         <label ID="Label3"><input type="checkbox" runat="server" onchange="document.getElementById('inputpass').type = this.checked ? 'text' : 'password'"/>Mostrar/Ocultar</label>
        
        <asp:Button ID="btnLogin" CssClass="btnLogin" runat="server" Text="Entrar" OnClick="btnLogin_Click" />
       </div>
       <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
       <script src="./Scripts/SweetAlerts.js"></script>
       <script src="./Scripts/validate.js"></script>
      </body>
</html>
        </asp:Content>

