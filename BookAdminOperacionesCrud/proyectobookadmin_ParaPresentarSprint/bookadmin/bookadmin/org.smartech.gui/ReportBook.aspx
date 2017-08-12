<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Reports.master" AutoEventWireup="true" CodeBehind="ReportBook.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ResultReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvBookReport" HorizontalAlign="Center" 
           BorderWidth="5px" BackColor="Black" runat="server" Width="100%" Font-Names="Angsana New" 
           ForeColor="White" Font-Bold="False" Font-Size="30pt">
           <FooterStyle VerticalAlign="Middle" />
           <HeaderStyle BackColor="White" ForeColor="Black" BorderColor="Black" />
                </asp:GridView>
            &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="btnReturnReport" runat="server" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt" onclick="btnReturnReport_Click" 
                    style="text-align: center" Text="Regresar a Reportes" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            </td>
            <td>
                <asp:Button ID="btnReport" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt" runat="server" style="text-align: center" 
                    Text="Imprimir Reporte" />
            </td>
        </tr>
    </table>
</asp:Content>
