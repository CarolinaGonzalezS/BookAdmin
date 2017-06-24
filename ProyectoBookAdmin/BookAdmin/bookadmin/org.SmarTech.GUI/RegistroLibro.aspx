<%@ Page Theme="Tema1" Title="" Language="C#" MasterPageFile="~/org.SmarTech.GUI/RegistroLibro.master" AutoEventWireup="true" CodeBehind="RegistroLibro.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.RegistroLibro" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml" />
<body>
   
    
    <div>
    
        <table class="style1">
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="3">
                    <asp:Label ID="Label1" runat="server" Text="Datos Autor"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="style4">
                    <asp:TextBox ID="textNomAut" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="textNomAut" ErrorMessage="Ingresar solo letras" 
                        ValidationExpression="^[a-z &amp; A-Z]*$">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="textNomAut" Display="Dynamic" ErrorMessage="Ingrese Nombre">*</asp:RequiredFieldValidator>
                    <br />
                </td>
                <td>
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <br />
                    <asp:Label ID="Label3" runat="server" Text="Apellido:"></asp:Label>
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textApellido" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                    <br />
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                        ControlToValidate="textApellido" ErrorMessage="Ingresar solo letras" 
                        ValidationExpression="^[a-z &amp; A-Z]*$">*</asp:RegularExpressionValidator>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="textApellido" Display="Dynamic" 
                        ErrorMessage="Ingrese Apellido">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label4" runat="server" Text="Nacionalidad:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="textNacionalidad" runat="server" Enabled="False" 
                        style="margin-bottom: 0px"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4" colspan="2">
                    <asp:Button ID="buttonVeriAutor" runat="server" Text="Verificar Autor" 
                        onclick="buttonVeriAutor_Click" BackColor="ButtonShadow" />
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
                <td class="style1">
                    </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="3">
                    <asp:Label ID="Label5" runat="server" Text="Datos de Editorial"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textNomEdit" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <br />
                    <asp:Label ID="Label7" runat="server" Text="Pais"></asp:Label>
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textPais" runat="server" Height="22px" Enabled="False"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label8" runat="server" Text="Ciudad:"></asp:Label>
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textCiudad" runat="server" Enabled="False"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <br />
                    <asp:Button ID="buttonVeriEditorial" runat="server" Text="Verificar Editorial" 
                        onclick="buttonVeriEditorial_Click" />
                </td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    <br />
                </td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="3">
                    <asp:Label ID="Label9" runat="server" Text="Datos del Libro"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label10" runat="server" Text="Titulo"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textTitulo" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label15" runat="server" Text="Categoria:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCategoria" runat="server" 
                        ontextchanged="ddlCategoria_TextChanged" Height="47px" Width="187px">
                    </asp:DropDownList>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label11" runat="server" Text="Codigo:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textCodigo" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label13" runat="server" Text="Fecha Publicacion:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textFech" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label12" runat="server" Text="ISBN:"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textIsbn" runat="server"></asp:TextBox>
                </td>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label14" runat="server" Text="Stock:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textStock" runat="server"></asp:TextBox>
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="buttonRegistrar" runat="server" Text="Registrar" 
                        onclick="buttonRegistrar_Click" Width="239px" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
    
    </div>

</body>
</html>
</asp:Content>
