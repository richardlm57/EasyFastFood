<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style10 {
            width: 27%;
        }
        .auto-style11 {
            width: 182px;
        }
        .auto-style14 {
            width: 22%;
            height: 165px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="background-color: #840808">
        <div style="margin:auto;background-color: #840808" class="auto-style14">
        <table class="auto-style10">
            <tr>
                <td class="auto-style11" style="font-family: Consolas; color: #FFFFFF;">Nombre usuario</td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="font-family: Consolas; color: #FFFFFF;">Contraseña</td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <div style="margin:auto">
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
            
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Nueva cuenta</asp:LinkButton>
            <br />
            
            <asp:Label ID="lblerror" runat="server"></asp:Label>
        </div>
        </div>
        </div>
</asp:Content>

