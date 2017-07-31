<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Reports.master" AutoEventWireup="true" CodeBehind="ReportBook.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ResultReports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">
        <tr>
            <td colspan="2">
                <asp:GridView ID="grvBookReport" runat="server" style="text-align: center" 
                    Font-Size="15px">
                </asp:GridView>
            &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnReturnReport" runat="server" onclick="btnReturnReport_Click" 
                    style="text-align: center" Text="Regresar a Reportes" />
            </td>
            <td>
                <asp:Button ID="btnReport" runat="server" style="text-align: center" 
                    Text="Imprimir Reporte" />
            </td>
        </tr>
    </table>
</asp:Content>
