<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/BusquedaLibro.master" AutoEventWireup="true" CodeBehind="AuthorOfBook.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.AuthorOfBook" %>
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
                &nbsp;</td>
            <td>
                <asp:RadioButtonList ID="rblAuthor" RepeatDirection="Horizontal" runat="server" 
                    onselectedindexchanged="rblAuthor_SelectedIndexChanged" Width="263px">
                    <asp:ListItem Class="btn-primary" Text="Nuevo" Value="1"></asp:ListItem>
                    <asp:ListItem Class="btn-primary" Text="Ya existe" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </td>
            <td>
                
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
            <td colspan="3">
            <center>
                <asp:DropDownList ID="ddlAuthor" runat="server" class="dropdown-header" 
                    BackColor="#0275d8" ForeColor="White" Font-Size="20px" Font-Names="Arial"
                    onselectedindexchanged="ddlAuthor_SelectedIndexChanged">
                </asp:DropDownList>
                </center>
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
            <td >
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
                <asp:Button ID="btnUpdateAuthor" runat="server" onclick="btnUpdateAuthor_Click" 
                    Text="ACTUALIZAR" Visible="False" />
            </td>
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
            <td style="height: 62px">
                </td>
            <td style="height: 62px">
                </td>
            <td style="height: 62px">
                <asp:Label ID="Label2" runat="server" Text="Apellido:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td style="height: 62px">
                <asp:TextBox ID="textLastName" runat="server" CssClass="form-control" 
                    Width="150px" Enabled="False" Font-Names="Arial"></asp:TextBox>
            </td>
            <td style="height: 62px">
                </td>
            <td style="height: 62px">
                <asp:Button ID="btnDeleteAuthor" runat="server" onclick="btnDeleteAuthor_Click" 
                    Text="ELIMINAR" Visible="False" />
            </td>
            <td style="height: 62px">
                </td>
            <td style="height: 62px">
                </td>
            <td style="height: 62px">
                </td>
            <td style="height: 62px">
                </td>
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
            <td Width="100">
                &nbsp;</td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Nacionalidad:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="textNationality" runat="server" CssClass="form-control" 
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
                <asp:Button ID="btnNextEditorial" runat="server" 
                    Text="SIGUIENTE &gt;&gt;" Font-Bold="True" onclick="btnNextEditorial_Click" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt" />
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
                <asp:Button ID="btnUpdateCont" runat="server" onclick="btnUpdateCont_Click" 
                    Text="SIGUIENTE &gt;&gt;" Font-Bold="True" Visible="False" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt"/>
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
    </table>
</asp:Content>
