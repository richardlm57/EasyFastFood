<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="menuComidas.aspx.cs" Inherits="menuComidas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style9 {
            width: 188px;
            height: 150px;
        }
        .auto-style12 {
            height: 150px;
        }
        .auto-style13 {
            width: 188px;
            height: 155px;
        }
        .auto-style14 {
            height: 155px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p style="font-family: 'Kristen ITC'; color: #FFFFFF; background-color: #ED7B08; text-align: center;">
        <asp:TextBox ID="TextBox1" runat="server" BackColor="#AF3A11" Font-Names="Kristen ITC" Font-Size="X-Large" ForeColor="White" OnTextChanged="TextBox1_TextChanged1">Menu de comidas</asp:TextBox>
    </p>
    <table class="auto-style1">
        <tr>
            <td class="auto-style13" style="background-color: #ED7B08">
                <asp:Image ID="Image1" runat="server" />
            </td>
            <td class="auto-style14" style="background-color: #ED7B08; background-repeat: no-repeat"></td>
        </tr>
        <tr>
            <td class="auto-style9" style="background-color: #ED7B08"></td>
            <td class="auto-style12" style="background-color: #ED7B08"></td>
        </tr>
    </table>
</asp:Content>

