<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div width="100%" style="background-color: #ED7B08;">
        <div style="margin:auto">
            <table bgcolor="af3a11" align="center" class="auto-style1" style="width: 23%">
                <tr>
                    <td style="color:#ffffff" align="center">Orden por confirmar</td>
                </tr>
            </table>
            <br />
            <table bgcolor="af3a11" align="right" class="auto-style1" style="width: 23%">
                <tr>
                    <td style="color:#ffffff" align="center">Total = 0</td>
                </tr>
            </table>
            <br />
            <table bgcolor="af3a11" align="center" class="auto-style1" style="width: 23%">
                <tr>
                    <td style="color:#ffffff" align="center">
                        <asp:Button ID="Button1" runat="server" BackColor="#af3a11" Text="Finalizar pago" ForeColor="White" />
                    </td>
                </tr>
            </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </div>
</asp:Content>

