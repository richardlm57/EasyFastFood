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
            width: 100%;
            height: 62px;
        }

        .auto-style19 {
            width: 1350px;
            height: 685px;
        }
        .auto-style20 {
            width: 54px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="auto-style18">
        <tr>
            <td style="font-family: 'kristen ITC'; background-color: #af3a11; color: #FFFFFF; text-align: center; font-size: x-large;">Menu comidas</td>
        </tr>
    </table>

        <table ;class="auto-style9" class="auto-style19">
            
            <tr>

                <td class="auto-style14" style="background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-attachment: scroll; background-color: #ED7B08;">
                    <asp:Label  ID="lblOption1" runat="server" Text="Opcion  #1" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image runat="server" Height="138px" ImageAlign="Top" ImageUrl="~/Images/hamburguesa-francesa-preparaci-n-9641.jpg" Width="221px" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                    <br />
                    <div style="position:relative;left:300px">
                    <input id="QtyOption1" type="number" min="1" max="20" class="auto-style20"/>&nbsp;
                    <br />
                    <asp:Button ID="addBtn1" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                        </div>
                </td>
                <td class="auto-style16" style="background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-color: #ED7B08;" title="test">
                    <br />
                    <br />
                    <asp:Label  ID="lblOption2" runat="server" Text="Opcion  #2" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>

                    <br />
                    <br />
                    <asp:Image ID="Image1" runat="server" Height="144px" ImageUrl="~/Images/papas-fritas.jpg" Width="221px" />
                    <br />
                    <br />
                    <div style="position:relative;left:300px">
                    <input id="QtyOption1" type="number" min="1" max="20" class="auto-style20"/>&nbsp;
                    <br />
                    <asp:Button ID="Button1" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                        </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style15" style="background-color: #ED7B08; background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-attachment: inherit;">&nbsp;&nbsp;
                    <br />
                    <asp:Label  ID="lblOption3" runat="server" Text="Opcion  #3" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="Image2" runat="server" Height="155px" ImageUrl="~/Images/Make-It-Your-Way-Hot_636151539128369821.jpg" Width="169px" />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="addBtn3" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                    <br />
&nbsp; </td>
                <td class="auto-style17" style="background-color: #ED7B08; background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y;">
                    <asp:Label  ID="lblOption4" runat="server" Text="Opcion  #4" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <br />
                    <br />
                    <asp:Image ID="Image3" runat="server" Height="140px" ImageUrl="~/Images/yavoy_corcelnegro_combohamb.jpg" Width="202px" />
                    <br />
                    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="addBtn4" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                </td>
            </tr>
    </table>
    </asp:Content>

