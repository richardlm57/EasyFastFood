﻿<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="compraConfirmada.aspx.cs" Inherits="compraConfirmada" %>

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
                <asp:Label ID="Label1" runat="server" Text="SU PAGO FUE PROCESADO EXITOSAMENTE"  Font-Size="Large" Font-Names="Kristen ITC,X-Large" ForeColor="White"></asp:Label>
                <br />
                <br />
            </td>
        </tr>
    </table>
    <table bgcolor="af3a11" align="center" class="auto-style10" style="width: 23%; background-color: #ED7B08;">
        <tr>
            <td style="color:#ffffff; background-color: #ED7B08;" align="center" class="auto-style9">
                <asp:Button ID="atrasBTN" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Atras" ForeColor="White" OnClick="ButtonAtras_Click" Width="122px" />
            </td>
        </tr>
    </table>
</asp:Content>

