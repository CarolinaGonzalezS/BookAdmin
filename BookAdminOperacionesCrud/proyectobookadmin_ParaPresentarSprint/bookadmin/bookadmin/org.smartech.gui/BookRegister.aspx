<%@ Page Title="" Theme="Tema1" Language="C#" MasterPageFile="~/org.SmarTech.GUI/BusquedaLibro.master" AutoEventWireup="true" CodeBehind="BookRegister.aspx.cs" Inherits="BookAdmin.org.SmarTech.GUI.BookRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="contenidoPrincipal" runat="server">
    <table>
<tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="4">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
<tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="4">
                    <asp:Label ID="Label9" runat="server" Text="Datos del Libro" Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black"></asp:Label>
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2" style="width: 27px">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label10" runat="server" Text="Titulo:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textTitle" runat="server" CssClass="form-control" 
                    Width="180px" Font-Names="Arial"></asp:TextBox>
                </td>
                <td class="style2" style="width: 27px">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label15" runat="server" Text="Categoria:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlCategory" runat="server" Height="47px" Width="187px" BackColor="#0275d8" ForeColor="White" Font-Names="Arial" Font-Size="20px" >
                    </asp:DropDownList>
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label11" runat="server" Text="Codigo:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textCode" runat="server" CssClass="form-control" 
                    Width="180px" Font-Names="Arial"></asp:TextBox>
                </td>
                <td class="style2" style="width: 27px">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label13" runat="server" Text="Publicado:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textDate" runat="server" CssClass="form-control" 
                    Width="180px" Font-Names="Arial" Enabled="False"></asp:TextBox>
                    <br />
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    <asp:Button ID="btnView" runat="server" onclick="btnView_Click" 
                        Text="Seleccionar" CssClass="btn-danger" Font-Bold="True" 
                        Font-Names="Arial" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2" style="width: 27px">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" 
                        onselectionchanged="Calendar1_SelectionChanged" Visible="False">
                    </asp:Calendar>
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="Label12" runat="server" Text="ISBN:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="style2">
                    <asp:TextBox ID="textIsbn" runat="server" CssClass="form-control" 
                    Width="180px" Font-Names="Arial"></asp:TextBox>
                </td>
                <td class="style2" style="width: 27px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="textIsbn" Display="Dynamic" ErrorMessage="ISBN no valido" 
                    ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                </td>
                <td class="style3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label14" runat="server" Text="Stock:" CssClass="btn focus" 
                    Font-Bold="True" Font-Names="Arial" Font-Size="20px" ForeColor="Black" Horizontal-aling="rigth"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="textStock" runat="server" CssClass="form-control" 
                    Width="180px" Font-Names="Arial"></asp:TextBox>
                </td>
                <td style="width: 6px">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" 
                    ControlToValidate="textStock" Display="Dynamic" ErrorMessage="stock no valido" 
                    ValidationExpression="^\d+$"></asp:RegularExpressionValidator>
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2" style="width: 27px">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="4">
                    <asp:DropDownList ID="ddlState" runat="server" Enabled="false" BackColor="#0275d8" ForeColor="White" Font-Names="Arial" Font-Size="20px" >
                    </asp:DropDownList>
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style2" style="width: 27px">
                    &nbsp;</td>
                <td class="style3">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
                <td class="style2" colspan="4">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnRegister" Font-Names="Arial" runat="server" Text="REGISTRAR" 
                        onclick="buttonRegister_Click" Width="239px" Enabled="False" 
                        CssClass="btn-success" Font-Bold="True" />
                </td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 113px">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td class="style2" colspan="3">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnUpdate" runat="server" Font-Names="Arial" onclick="btnUpdate_Click" 
                        Text="FINALIZAR ACTUALIZACION" Enabled="False" CssClass="btn-success" 
                        Font-Bold="True" />
                </td>
                <td>
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td style="width: 6px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
</table>

</asp:Content>
