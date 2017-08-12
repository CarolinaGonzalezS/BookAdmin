<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Principal.Master" AutoEventWireup="true" CodeBehind="ResultSearch.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.ResultSearch" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
   
    <center style="font-size: 20px"> 
       <br />
       <asp:GridView ID="grvResult" HorizontalAlign="Center" 
           BorderWidth="5px" BackColor="Black" runat="server" Width="100%" Font-Names="Angsana New" 
           ForeColor="White" Font-Bold="False" Font-Size="30pt">
           <FooterStyle VerticalAlign="Middle" />
           <HeaderStyle  VerticalAlign="Middle" BackColor="White" ForeColor="Black" BorderColor="Black" />
       </asp:GridView>
       <br />
       
    </center>
    
</asp:Content>
