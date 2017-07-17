<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head >    
	<title>LOGIN ADMINISTRADOR</title>

	<!-- Google Fonts -->
	<link href='https://fonts.googleapis.com/css?family=Roboto+Slab:400,100,300,700|Lato:400,100,300,700,900' rel='stylesheet' type='text/css'>

	<!-- Custom Stylesheet -->
	<link rel="stylesheet" href="css/style.css">
    <link rel="stylesheet" href="css/animate.css">

</head>
<body>
    <form id="form1" runat="server">
<div  class="bounceInRight">
		<div class="top">
			<h1 id="title" class="hidden">BookAdmin</h1>
		</div>
		<div class="login-box animated fadeInUp">
			<div class="box-header">
				<h2>Log In</h2>
			</div>
			<label for="username">Username</label>
			<br/>
			&nbsp;<asp:TextBox ID="textNameUser" runat="server" 
                placeholder="Ingrese Usuario"></asp:TextBox>
			<br/>
			<label for="password">Password</label>
			<br/>
			&nbsp;<asp:TextBox ID="textPassword" runat="server" TextMode="Password"  
                            placeholder="Ingrese Contraseña"  
                            ></asp:TextBox>
			<br/>
                    <asp:Button ID="btnEnter" runat="server" Text="INGRESAR" 
                        onclick="btnEnter_Click" />
			<br/>
			<a href="#"></a>
		</div>
	</div>
    </form>

     <div class=footer>
         <footer>
          <p>Desarrollado por: SmarTech</p>
          <p>Informacion Contacto: <a href="#">
          smartech@gmail.com</a>.</p>
          </footer>
      </div>
      
   

</body>
</html>
