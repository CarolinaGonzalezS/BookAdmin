<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Reports.master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.Reports1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">

    <table style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 4px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 7px">
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
            <td colspan="7" align="center" 
                style="font-family: Arial; font-size: large; font-weight: bold; font-style: normal">
                Seleccione el Icono del 
                <br />
                Reporte que desea Visualizar</td>
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
            <td style="width: 4px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 7px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="height: 80px">
                </td>
            <td style="height: 80px">
                </td>
            <td style="height: 80px">
                </td>
            <td style="width: 4px; height: 80px">
                <asp:ImageButton ID="imgbtnBook" runat="server" Height="110px" Width="110px" 
                    onclick="imgbtnBook_Click" ImageUrl="~/org.SmarTech.GUI/images/libro.png" />
            </td>
            <td style="height: 80px">
                </td>
            <td style="width: 7px; height: 80px">
                <asp:ImageButton ID="imgbtnCustomer" runat="server" Height="110px" 
                    Width="110px" onclick="imgbtnCustomer_Click" ImageUrl="~/org.SmarTech.GUI/images/user.png"  />
            </td>
            <td style="height: 80px">
                </td>
            <td style="height: 80px">
                </td>
            <td style="height: 80px">
                </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 4px; font-size: large; " align="center">
                Libros</td>
            <td>
                &nbsp;</td>
            <td style="width: 7px; font-size: large; text-align: center;" align="center">
                Clientes</td>
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
            <td style="width: 4px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 7px">
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
            <td style="width: 4px">
                <asp:ImageButton ID="imgbtnLoan" runat="server" Height="110px" Width="110px" 
                    onclick="imgbtnLoan_Click" 
                    ImageUrl="~/org.SmarTech.GUI/images/prestamo.png" />
            </td>
            <td>
                &nbsp;</td>
            <td style="width: 7px">
                <asp:ImageButton ID="imgbtnFine" runat="server" Height="110px" Width="110px" 
                    onclick="imgbtnFine_Click" ImageUrl="~/org.SmarTech.GUI/images/dinero.png" />
            </td>
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
            <td style="width: 4px; font-size: large; text-align: center;" align="center">
                Prestamos</td>
            <td style="font-size: large">
                &nbsp;</td>
            <td style="width: 7px; font-size: large" align="center">
                Multas</td>
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
            <td style="width: 4px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 7px">
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
            <td style="width: 4px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td style="width: 7px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>

</asp:Content>
