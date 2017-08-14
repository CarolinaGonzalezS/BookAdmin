<%@ Page Title="" Language="C#" Theme="Tema1" MasterPageFile="~/org.SmarTech.GUI/BusquedaLibro.master" AutoEventWireup="true" CodeBehind="EditorialsView.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.EditorialsView" %>
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
                <asp:DropDownList ID="ddlEditorial" runat="server" class="dropdown-header" 
                    BackColor="#0275d8" ForeColor="White" Font-Size="20px" Font-Names="Arial" onselectedindexchanged="ddlEditorial_SelectedIndexChanged" 
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
                <asp:TextBox ID="textName" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" onclick="btnUpdate_Click" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt" Font-Bold="True" 
                    Text="Actualizar" />
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
                <asp:Label ID="Label2" runat="server" Text="Pais:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCountry" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="textCountry" Display="Dynamic" ErrorMessage="Pais no valido" 
                    ValidationExpression="[a-zA-ZñÑáéíóúÁÉÍÓÚ\s]+"></asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:Button ID="btnDelete" runat="server" onclick="btnDelete_Click" 
                    CssClass="btn-danger" Font-Bold="True" Font-Names="Arial" 
                    Font-Size="12pt" 
                    Text="Eliminar" />
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
                <asp:Label ID="Label3" runat="server" Text="Ciudad:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCity" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="textCity" Display="Dynamic" ErrorMessage="Ciudad  no valida" 
                    ValidationExpression="[A-Za-z]*"></asp:RegularExpressionValidator>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
