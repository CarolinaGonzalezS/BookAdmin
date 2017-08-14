<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Reports.master" AutoEventWireup="true" CodeBehind="ReportCustomer.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ReportCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:GridView ID="grvCustomerReport" runat="server" HorizontalAlign="Center" 
           BorderWidth="5px" BackColor="Black" Width="90%" Font-Names="Angsana New" 
           ForeColor="White" Font-Bold="False" Font-Size="20pt">
           <FooterStyle VerticalAlign="Middle" />
           <HeaderStyle BackColor="White" ForeColor="Black" BorderColor="Black" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
        <td>
            
            <asp:Button ID="btnReturnReport" runat="server" Text="Regresar a Reportes" 
                Font-Size="12pt" style="text-align: center" CssClass="btn-success" 
                Font-Names="Arial" onclick="btnReturnReport_Click1"  />
            
        </td>
        <td></td>
        <td>
            &nbsp;</td>
        <td></td>
        <td>
        </td>
        
        </tr>
    </table>
</asp:Content>
