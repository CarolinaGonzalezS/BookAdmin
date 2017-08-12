<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/Fine.master" AutoEventWireup="true" CodeBehind="Fine.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.Fine1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table style="width: 100%">
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 344px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px" >
            <asp:Label ID="Label2" runat="server" Text="ID Prestamo:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                          
                    </td>     
            <td style="width: 344px">
                <asp:TextBox ID="txtSearchFine" runat="server" Width="55px" Enabled="False"></asp:TextBox>
            &nbsp;<asp:Button ID="btnSearchLoan" runat="server" Text="Buscar Prestamo" 
                    onclick="btnSearchLoan_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 344px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label1" runat="server" Text="Cedula:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>               
                    </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtIdentificationCard" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label3" runat="server" Text="IFecha de Inicio: " CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                                          
            </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtDateLoan" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnDays" runat="server" onclick="btnDays_Click" 
                    Text="Ver Dias" Enabled="False" />
            </td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label4" runat="server" Text="Fecha de Finalizacion:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                          
                </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtDateFine" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnFillFine" runat="server" Text="Ver Multa" Enabled="False" 
                    onclick="btnFillFine_Click" />
            </td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label5" runat="server" Text="Costo Libro:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                          
                </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtCostoLibro" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label6" runat="server" Text="Dias Transcurridos:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                          
                </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtDays" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label7" runat="server" Text="Valor a Pagar:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                           
            </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtValueFine" runat="server" Enabled="False"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
            <asp:Label ID="Label8" runat="server" Text="Descripcion:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>                          
                </td>
            <td style="width: 344px">
                <asp:TextBox ID="txtDescFine" runat="server" Height="23px" Width="287px" 
                    Enabled="False"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnFinishFine" runat="server" style="text-align: right" 
                    Text="Finalizar Multa" Enabled="False" onclick="btnFinishFine_Click" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt"/>
            </td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 344px">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 69px">
                &nbsp;</td>
            <td style="width: 344px">
                &nbsp;</td>
            <td>
                <asp:Button ID="btnGoReturnBook" runat="server" CssClass="btn-success" Font-Names="Arial" 
                    Font-Size="12pt" Font-Bold="True" onclick="btnGoReturnBook_Click" 
                    Text="Ir a Devolver Libro" />
            </td>
        </tr>
    </table>
</asp:Content>