<%@ Page Title="" Language="C#" Theme="Tema1" MasterPageFile="~/org.SmarTech.GUI/Principal.Master" AutoEventWireup="true" CodeBehind="ResultCategorySearch.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ResultCategorySearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contenidoMenuContextual" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <center style="font-size: 20px"> 
       <br />
    <asp:GridView ID="grvResult" HorizontalAlign="Center" 
           BorderWidth="5px" BackColor="Black" runat="server" Width="100%" Font-Names="Angsana New" 
           ForeColor="White" Font-Bold="False" Font-Size="30pt">
           <FooterStyle VerticalAlign="Middle" />
           <HeaderStyle BackColor="White" ForeColor="Black" BorderColor="Black" />
</asp:GridView>
</center>
</asp:Content>
