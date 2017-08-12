<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Reports.master" AutoEventWireup="true" CodeBehind="ReportCustomer.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ReportCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">
        <tr>
            <td>
                <asp:GridView ID="grvCustomerReport" runat="server" HorizontalAlign="Center" 
           BorderWidth="5px" BackColor="Black" Width="100%" Font-Names="Angsana New" 
           ForeColor="White" Font-Bold="False" Font-Size="30pt">
           <FooterStyle VerticalAlign="Middle" />
           <HeaderStyle BackColor="White" ForeColor="Black" BorderColor="Black" />
                </asp:GridView>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>
