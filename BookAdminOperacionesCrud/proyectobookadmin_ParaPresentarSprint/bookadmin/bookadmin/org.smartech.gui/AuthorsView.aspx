<%@ Page Title="" Language="C#" Theme="Tema1" MasterPageFile="~/org.SmarTech.GUI/BusquedaLibro.master" AutoEventWireup="true" CodeBehind="AuthorsView.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.AuthorsView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">
        <tr>
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
            <td colspan="3">
            <center>
                <asp:DropDownList ID="ddlAuthor" runat="server" class="dropdown-header" 
                    BackColor="#0275d8" ForeColor="White" Font-Size="20px" Font-Names="Arial" onselectedindexchanged="ddlAuthor_SelectedIndexChanged" 
                    >
                </asp:DropDownList>
                </center>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
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
                <asp:Label ID="Label1" runat="server" Text="Nombre:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnUpdateAuthor" runat="server" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt" Font-Bold="True" 
                    Text="Actualizar" onclick="btnUpdateAuthor_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
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
                <asp:Label ID="Label2" runat="server" Text="Apellido:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textLastName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnDeleteAuthor" runat="server"
                    CssClass="btn-danger" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="12pt" 
                    Text="Eliminar" onclick="btnDeleteAuthor_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
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
                <asp:Label ID="Label3" runat="server" Text="Nacionalidad:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textNationality" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="textNationality" Display="Dynamic" ErrorMessage="Nacionalidad no valida" 
                    ValidationExpression="[A-Za-z]*"></asp:RegularExpressionValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
