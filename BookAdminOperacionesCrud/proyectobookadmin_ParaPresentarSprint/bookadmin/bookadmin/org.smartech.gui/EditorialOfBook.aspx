<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/BusquedaLibro.master" AutoEventWireup="true" CodeBehind="EditorialOfBook.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.EditorialOfBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">        
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
                <asp:RadioButtonList RepeatDirection="Horizontal" ID="rblEditorial" runat="server" 
                     Width="203px" onselectedindexchanged="rblEditorial_SelectedIndexChanged" 
                    Font-Bold="True" Font-Names="Arial">
                    <asp:ListItem Class="btn-primary" Text="Nuevo" Value="1"></asp:ListItem>
                    <asp:ListItem Class="btn-primary" Text="Ya existe" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
            <td colspan="3">
                <asp:DropDownList ID="ddlEditorial" runat="server" class="dropdown-header" BackColor="#0275d8" ForeColor="White" Font-Names="Arial" Font-Size="20px" 
                    onselectedindexchanged="ddlEditorial_SelectedIndexChanged" 
                    >
                </asp:DropDownList>
            </td>
            <td>
                &nbsp;</td>
            <td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
                <asp:Label ID="Label1" runat="server" Text="Nombre:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textName" runat="server" CssClass="form-control" 
                    Width="150px" Enabled="False" Font-Names="Arial"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
                <asp:Label ID="Label2" runat="server" Text="Pais:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCountry" runat="server" CssClass="form-control" 
                    Width="150px" Enabled="False" Font-Names="Arial"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
                <asp:Label ID="Label3" runat="server" Text="Ciudad:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textCity" runat="server" CssClass="form-control" 
                    Width="150px" Enabled="False" Font-Names="Arial"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
                <asp:Button ID="btnBack" runat="server" onclick="btnBack_Click" Width="150px" Enabled="False" 
                        CssClass="btn-success" Font-Bold="True" 
                    Text="&lt;&lt; ATRAS" />
            </td>
            <td>
                &nbsp;</td>
            <td>
                
                <asp:Button ID="btnNextBook" runat="server" onclick="btnNextBook_Click" 
                CssClass="btn-success" Font-Bold="True"
                    Text="SIGUIENTE &gt;&gt;" />
                
            </td>
            <td>
                <asp:Button ID="btnUpdateCont" runat="server" onclick="btnUpdateCont_Click" 
                    Text="SIGUIENTE &gt;&gt;" Visible="False" Width="200px" Enabled="False" 
                        CssClass="btn-success" Font-Bold="True"/>
            </td>
            <td>
                &nbsp;</td>
            <td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>
            <td>
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
