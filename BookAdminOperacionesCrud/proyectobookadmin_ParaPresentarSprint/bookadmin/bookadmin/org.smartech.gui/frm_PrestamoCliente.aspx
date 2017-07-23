<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/RegistroPrestamo.master" AutoEventWireup="true" CodeBehind="frm_PrestamoCliente.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.frm_PrestamoCliente" %>
<%@ Register assembly="CrystalDecisions.Web, Version=13.0.2000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <asp:Panel ID="Panel1" runat="server">
    <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" 
        AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="1202px" 
            ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" 
            ToolPanelWidth="200px" Width="1104px" />
        <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
            <Report FileName="C:\Users\Pacha\Documents\BookAdmin\BookAdminOperacionesCrud\proyectobookadmin_ParaPresentarSprint\bookadmin\bookadmin\org.smartech.gui\rptPrestamoCliente.rpt">
            </Report>
        </CR:CrystalReportSource>
</asp:Panel>
</asp:Content>
