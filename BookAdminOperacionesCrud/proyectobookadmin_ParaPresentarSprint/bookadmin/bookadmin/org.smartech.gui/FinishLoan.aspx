<%@ Page Title="" Language="C#" MasterPageFile="~/org.SmarTech.GUI/RegistroPrestamo.master" AutoEventWireup="true" CodeBehind="FinishLoan.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.FinishLoan" %>
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
                <asp:Label ID="Label1" runat="server" Text="ID Cliente:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textIdCustomer" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Codigo Libro:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCodeBook" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Fecha de Inicio:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textDateLoan" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Fecha Limite:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textDateLimit" runat="server"></asp:TextBox>
            </td>
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
                <asp:Button ID="btnDoLoan" runat="server" onclick="btnDoLoan_Click" 
                    Text="Prestar" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
