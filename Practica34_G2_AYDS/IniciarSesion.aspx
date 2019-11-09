<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IniciarSesion.aspx.cs" Inherits="Practica34_G2_AYDS.IniciarSesion" %>

<!DOCTYPE html>
<html lang="en">
   <head>
      <title>IniciarSesion </title>
      <!-- Meta tags -->
      <meta name="viewport" content="width=device-width, initial-scale=1" />
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <meta name="keywords" content="Gaze Sign up & login Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
         />
      <script>
         addEventListener("load", function () { setTimeout(hideURLbar, 0); }, false); function hideURLbar() { window.scrollTo(0, 1); }
      </script>
      <!-- Meta tags -->
      <!--stylesheets-->
      <link href="Styles/style.css" rel='stylesheet' type='text/css' media="all">
      <!--//style sheet end here-->
      <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600,700" rel="stylesheet">
   </head>
   <body>
      <div class="mid-class">
         <div class="art-right-w3ls">
            <h2>Inicia Sesion y o Registrate</h2>
             <form id="form1" runat="server">
               <div class="main">
                  <div class="form-left-to-w3l">
                      <asp:TextBox ID="TextBox1" runat="server" placeholder="Usuario" MaxLength="30"></asp:TextBox>
                  </div>
                  <div class="form-left-to-w3l ">
                      <asp:TextBox ID="TextBox2" runat="server" placeholder="Contraseña" TextMode="Password" MaxLength="15"></asp:TextBox>
                     <div class="clear"></div>
                  </div>
               </div>
               
               <div class="clear"></div>
               <div class="btnn">
                   <asp:Button ID="Button1" runat="server" Text="Iniciar Sesion" Height="36px" OnClick="Button1_Click" Width="168px" BackColor="#3399FF" BorderStyle="Solid" ForeColor="Black" />
               </div>
             
            <div class="w3layouts_more-buttn">
               <h3>No tienes cuenta..?
                  <a href="#content1">Registrate!
                  </a>
               </h3>
            </div>
            <!-- popup-->
            <div id="content1" class="popup-effect">
               <div class="popup">
                  <!--login form-->
                  <div class="letter-w3ls">
                     
                        <div class="form-left-to-w3l">
                           <asp:TextBox ID="TextBox3" runat="server" placeholder="DPI"></asp:TextBox>
                        </div>
                        <div class="form-left-to-w3l">
                           <asp:TextBox ID="TextBox4" runat="server" placeholder="Nombres"></asp:TextBox>
                        </div>
                        <div class="form-left-to-w3l">
                           <asp:TextBox ID="TextBox5" runat="server" placeholder="Apellidos"></asp:TextBox>
                        </div>
                        <div class="form-left-to-w3l">
                           <asp:TextBox ID="TextBox6" runat="server" placeholder="Correo" TextMode="Email"></asp:TextBox>
                        </div>
                        <div class="form-left-to-w3l margin-zero">
                           <asp:TextBox ID="TextBox7" runat="server" placeholder="Contraseña" TextMode="Password"></asp:TextBox>
                        </div>
                        <div class="btnn">
                           <asp:Button ID="Button2" runat="server" Text="Aceptar Modificacion" Height="36px" OnClick="Registrarse" Width="168px" BackColor="#3399FF" BorderStyle="Solid" ForeColor="Black" />
                           <br>
                        </div>
                   
                     <div class="clear"></div>
                  </div>
                  <!--//login form-->
                  <a class="close" href="#">&times;</a>
               </div>
            </div>
            <!-- //popup -->
          </form>
         </div>
         <div class="art-left-w3ls">
            <h1 class="header-w3ls">
               Vive tu mejor experiencia compartiendo en nuestro sitio!
            </h1>
         </div>
      </div>
      <footer class="bottem-wthree-footer">
         <p>
            © 2019 | USAC | Analisis y Diseño 1
         </p>
      </footer>
       
   </body>
</html>