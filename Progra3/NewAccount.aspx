<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="NewAccount.aspx.cs" Inherits="NewAccount" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div width="100%" style="background-color: #ED7B08;">
        <div style="margin:auto">
            <table bgcolor="af3a11" align="center" class="auto-style1" style="width: 30%">
                <tr>
                    <td style="color:#ffffff" align="center"><asp:Label  ID="TitleOrder" runat="server" Text="Nuevo usuario" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label></td>
                </tr>
            </table>
            <br />
            <br />
        <div >
        <div style="margin:auto" >
        <table class="auto-style10">
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelName" runat="server" Text="Nombre" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="newName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelSurname" runat="server" Text="Apellido" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="newSurname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelAddress" runat="server" Text="Direccion" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="newAddress" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelNewUsername" runat="server" Text="Nombre de usuario" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="newUsername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelNewPassword" runat="server" Text="Contraseña" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="newPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelConfirmPassword" runat="server" Text="Confirmar contraseña" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="confirmPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelPassword" runat="server" Text="Contraseña" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
            </div>
            </div>
            <table  align="center" class="auto-style1" style="width: 23%">
                <tr>
                    <td style="color:#ffffff" align="center">
                        <asp:Button ID="ButtonCrearUsuario" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Crear usuario" ForeColor="White" OnClick="ButtonCrearUsuario_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </div>
</asp:Content>

