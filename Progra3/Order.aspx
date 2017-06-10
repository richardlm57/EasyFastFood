<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div width="100%" style="background-color: #ED7B08;">
        <div style="margin:auto">
            <table bgcolor="af3a11" align="center" class="auto-style1" style="width: 30%">
                <tr>
                    <td style="color:#ffffff" align="center"><asp:Label  ID="TitleOrder" runat="server" Text="Orden por confirmar" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label></td>
                </tr>
            </table>
            <br />
            <table bgcolor="af3a11" align="right" class="auto-style1" style="width: 23%">
                <tr>
                    <td style="color:#ffffff" align="center"><asp:Label  ID="LabelTotal" runat="server" Text="Total = 0" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Medium"></asp:Label></td>
                </tr>
            </table>
            <br />
            <br />
            <table bgcolor="af3a11" align="center" class="auto-style1" style="width: 23%">
                <tr>
                    <td style="color:#ffffff" align="center">
                        <asp:Button ID="Button1" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Finalizar pago" ForeColor="White" />
                    </td>
                </tr>
            </table>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </div>
</asp:Content>

