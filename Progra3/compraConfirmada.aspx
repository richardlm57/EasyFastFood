<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="compraConfirmada.aspx.cs" Inherits="compraConfirmada" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style5 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style5">
        <tr>
            <td style="background-color: #af3a11; text-align: center;" >
                <asp:Label ID="Label1" runat="server" Text="SU ORDEN SE REALIZO EXITOSAMENTE"  Font-Size="Large" Font-Names="Kristen ITC,X-Large" ForeColor="White"></asp:Label>
                <br />
                <br />
                <asp:Button ID="atrasBTN" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#ED7B08" Text="Atras" ForeColor="White" OnClick="ButtonAtras_Click" Width="122px" />                

            </td>
        </tr>
    </table>
</asp:Content>

