<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="menuComidas.aspx.cs" Inherits="menuComidas" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            height: 289px;
            width: 395px;
            margin-left: 240px;
        }

        .auto-style15 {
            width: 395px;
            height: 176px;
        }

        .auto-style16 {
            height: 289px;
            width: 412px;
        }

        .auto-style17 {
            width: 412px;
            height: 176px;
        }

        .auto-style18 {
            width: 23%;
            height: 9px;
        }

        .auto-style19 {
            width: 979px;
            height: 641px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style18">
        <tr>
            <td>&nbsp;</td>
        </tr>
    </table>

        <table ;class="auto-style9" class="auto-style19">
            
            <tr>

                <td class="auto-style14" style="background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-attachment: scroll; background-color: #ED7B08;">
                    <asp:Label  ID="lblOption" runat="server" Text="Opcion  #1" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image runat="server" Height="138px" ImageAlign="Top" ImageUrl="~/Images/hamburguesa-francesa-preparaci-n-9641.jpg" Width="221px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                    <br />
                    <br />
                </td>
                <td class="auto-style16" style="background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-color: #ED7B08;" title="test">
                    <br />
                    <br />
                    <asp:Label  ID="lblOption0" runat="server" Text="Opcion  #2" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="144px" ImageUrl="~/Images/papas-fritas.jpg" Width="221px" />
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td class="auto-style15" style="background-color: #ED7B08; background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-attachment: inherit;">&nbsp;&nbsp;
                    <br />
                    <asp:Label  ID="lblOption1" runat="server" Text="Opcion  #3" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="Image2" runat="server" Height="155px" ImageUrl="~/Images/Make-It-Your-Way-Hot_636151539128369821.jpg" Width="169px" />
                    <br />
&nbsp; </td>
                <td class="auto-style17" style="background-color: #ED7B08; background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y;">
                    <asp:Label  ID="lblOption2" runat="server" Text="Opcion  #4" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="Image3" runat="server" Height="140px" ImageUrl="~/Images/yavoy_corcelnegro_combohamb.jpg" Width="202px" />
                </td>
            </tr>
    </table>
    </asp:Content>

