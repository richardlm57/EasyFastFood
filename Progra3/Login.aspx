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
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelUsernameLogin" runat="server" Text="Nombre de usuario" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" style="color: #FFFFFF;"><asp:Label  ID="LabelPassword" runat="server" Text="Contraseña" Font-Names="Kristen ITC" text-align="center" Font-Size="Small"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                </td>
            </tr>
        </table>
        <table align="center" class="auto-style1" style="width: 50%">
                <tr>
                    <td style="color:#ffffff" align="center">
                        <asp:Button ID="ButtonLogin" runat="server" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" Text="Login" ForeColor="White" OnClick="ButtonLogin_Click" />
                    </td>
                </tr>
                <tr>
                    <td style="color:#ffffff">
                        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="Small" BackColor="#af3a11" ForeColor="White">Nueva cuenta</asp:LinkButton>
                    </td>
                </tr>
            </table>
            
            <br />
            
            <asp:Label ID="lblerror" runat="server" Text=""></asp:Label>
        </div>
        </div>
</asp:Content>

