<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Reports.master" AutoEventWireup="true" CodeBehind="ReportFine.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ReportFine" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
<center>
    <asp:GridView ID="grvFineReport" runat="server" BorderWidth="5px" BackColor="Black" Width="90%" Font-Names="Angsana New" 
           ForeColor="White" Font-Bold="False" Font-Size="20pt">
           <FooterStyle VerticalAlign="Middle" />
           <HeaderStyle BackColor="White" ForeColor="Black" BorderColor="Black" />
    </asp:GridView>
    </center>
    <table width="100%">
    <tr>
    <td></td>
    <td>
        <asp:Button ID="btnReturnReport" runat="server" Text="Regresar a Reportes" 
                Font-Size="12pt" style="text-align: center" CssClass="btn-success" 
                Font-Names="Arial" onclick="btnReturnReport_Click"/>
        </td>
    <td></td>
    </tr>
    <tr>
    <td></td>
    <td></td>
    <td></td>
    </tr>
    
    </table>
</asp:Content>
