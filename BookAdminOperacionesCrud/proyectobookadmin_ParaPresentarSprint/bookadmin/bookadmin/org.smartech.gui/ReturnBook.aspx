<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/ReturnBook.master" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ReturnBook1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<table>

    <tr>
        <td style="width: 693px">
            <br />
            <center>
            <asp:Label ID="Label1" runat="server" Text="Ticket:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textticket" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnSearch" runat="server" Text="Buscar" 
                onclick="btnSearch_Click" />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
</center>
            <asp:Label ID="Label2" runat="server" Text="Datos Personales:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Cedula:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textIdentificationCard" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nombre:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="textName" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="Apellido:"></asp:Label>
            &nbsp;&nbsp;
            <asp:TextBox ID="textLastname" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Datos Libro:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Nombre:"></asp:Label>
&nbsp;<asp:TextBox ID="textNameBook" runat="server" Enabled="False"></asp:TextBox>
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            Codigo:&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="textCode" runat="server" Enabled="False"></asp:TextBox>
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnReturnBook" runat="server" onclick="btnReturnBook_Click" 
                Text="Devolver Libro" Enabled="False" />
        </td>
    </tr>

</table>
</asp:Content>
