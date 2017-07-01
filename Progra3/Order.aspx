<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="Order.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 125px;
        }
        .auto-style10 {
            width: 23%;
        }
    </style>
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
                <br />
                </table>
                <br />
                <br />
                <table bgcolor="af3a11" align="right" class="auto-style1" style="width: 23%">
                 <tr>
                    <td style="color:#ffffff" align="center"><asp:Label  ID="Label1" runat="server" Text="Metodo de pago" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Large"></asp:Label></td>

                </tr>
                <tr>
                    <td style="color:#ffffff" align="center"><asp:RadioButton ID="efecPay" runat="server"  /><asp:Label ID="Label2" runat="server" Text="Efectivo"></asp:Label>
                        
                </tr>
               


            </table>
            <br />
            <br />
            <br />
            <br />
            
            <table bgcolor="af3a11" align="center" class="auto-style10" style="width: 23%; background-color: #ED7B08;">
                <tr>
                    <td style="color:#ffffff; background-color: #ED7B08;" align="center" class="auto-style9">
                        <asp:Button ID="atrasBTN" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Atras" ForeColor="White" OnClick="ButtonAtras_Click" Width="122px" />
                    </td>
                    <td style="color:#ffffff; background-color: #ED7B08;" align="center">
                        <asp:Button ID="ButtonEnded" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Finalizar pago" ForeColor="White" OnClick="ButtonEnded_Click" />
                    </td>
                    <td style="color:#ffffff; background-color: #ED7B08;" align="center">
                        <asp:Button ID="compraConfirmadaBTN" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Compra Confirmada" ForeColor="White" OnClick="compraConfirmada" />
                    </td>
                    <td style="color:#ffffff; background-color: #ED7B08;" align="center">
                        <asp:Button ID="CompraRechazada" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Compra Rechazada" ForeColor="White" OnClick="compraRechazada" />
                    </td>

                </tr>
            </table>
        
        </div>
    </div>
</asp:Content>

