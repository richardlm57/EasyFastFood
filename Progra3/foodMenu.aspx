<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="foodMenu.aspx.cs" Inherits="foodMenu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style14 {
            height: 180px;
            width: 393px;
            margin-left: 240px;
        }

        .auto-style15 {
            width: 393px;
            height: 152px;
        }

        .auto-style16 {
            height: 180px;
            width: 412px;
        }

        .auto-style17 {
            width: 412px;
            height: 152px;
        }

        .auto-style18 {
            width: 100%;
            height: 62px;
        }

        .auto-style19 {
            width: 1794px;
            height: 823px;
        }
        .auto-style20 {
            width: 54px;
        }
        .auto-style21 {
            height: 32px;
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

                <td  ID="tdOpc1" class="auto-style14" style="background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-attachment: scroll; background-color: #ED7B08;" id="tdOpc1">
                    <asp:Label  ID="lblOption1" runat="server" Text="Opcion  #1" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    <div  style="position:relative; left:300px;width:500px; font-family: 'kristen ITC'; background-color: #fefb64;">
                        <asp:Label ID="lblOpc1" runat="server" Text=""></asp:Label>
                        </div>
                    <asp:Image ID="imgOpc1" runat="server" Height="138px" ImageAlign="Top" ImageUrl="~/Images/hamburguesa-francesa-preparaci-n-9641.jpg" Width="221px" />
                    
                    <div style="position:relative; left:300px;width:500px; font-family: 'kristen ITC'; background-color: #fefb64;">
                        
                        <table class="auto-style1">
                            <tr>
                                <td class="auto-style21"> <asp:Label ID="lbltTiemOpc1" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblTiemTotOpc1" runat="server" Text=""></asp:Label></td>
                            </tr>
                            <tr>
                                <td   class="auto-style21"> <asp:Label ID="lblPriceOpc1" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblPriceTot1" runat="server" Text=""></asp:Label></td>
                            </tr>
                        </table>
                        
                    <div style="position:relative;left:300px">
                    <input ID="QtyOption1" type="number" min="1" max="20" class="auto-style20"/>&nbsp;
                    <br />
                    <asp:Button ID="addBtnOpc1" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                        </div>
                </td>
                <td class="auto-style16" style="background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-color: #ED7B08;" title="test">
                    
                    <asp:Label  ID="lblOption2" runat="server" Text="Opcion  #2" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>

                    <div style="position:relative; left:300px; width:500px;font-family: 'kristen ITC'; background-color: #fefb64;">
                        <asp:Label ID="lblOpc2" runat="server" Text=""></asp:Label></div>
                    <asp:Image ID="Image1" runat="server" Height="144px" ImageUrl="~/Images/papas-fritas.jpg" Width="221px" />
                    
                    <div style="position:relative; left:300px; width:500px;font-family: 'kristen ITC'; background-color: #fefb64;">
                       <table class="auto-style1">
                            <tr>
                                <td class="auto-style21"> <asp:Label ID="lblTiemOcp2" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblTiemTot2" runat="server" Text=""></asp:Label></td>
                            </tr>
                            <tr>
                                <td   class="auto-style21"> <asp:Label ID="lblPriceOpc2" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblPriceTot2" runat="server" Text=""></asp:Label></td>
                            </tr>
                        </table></div>
                    <div style="position:relative;left:300px">
                    <input id="QtyOption2" type="number" min="1" max="20" class="auto-style20"/>&nbsp;
                    <br />
                    <asp:Button ID="Button1" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                        </div>
                </td>
            </tr>
            <tr>
                <td class="auto-style15" style="background-color: #ED7B08; background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y; background-attachment: inherit;">&nbsp;&nbsp;
                    <br />
                    <asp:Label  ID="lblOption3" runat="server" Text="Opcion  #3" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    
                    
                    <div style="position:relative; left:300px; width:500px;font-family: 'kristen ITC'; background-color: #fefb64;">
                        <asp:Label ID="lblOpc3" runat="server" Text=""></asp:Label></div>
                    <asp:Image ID="Image2" runat="server" Height="155px" ImageUrl="~/Images/Make-It-Your-Way-Hot_636151539128369821.jpg" Width="169px" />
                    
                    
                    <div style="position:relative; left:300px; width:500px;font-family: 'kristen ITC'; background-color: #fefb64;">
                       <table class="auto-style1">
                            <tr>
                                <td class="auto-style21"> <asp:Label ID="lblTiemOpc3" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblTiemTot3" runat="server" Text=""></asp:Label></td>
                            </tr>
                            <tr>
                                <td   class="auto-style21"> <asp:Label ID="lblPriceOpc3" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblPriceTot3" runat="server" Text=""></asp:Label></td>
                            </tr>
                        </table></div>
                    <div style="position:relative;left:300px">
                    <input id="QtyOption3" type="number" min="1" max="20" class="auto-style20"/>&nbsp;
                    <br />
                    <asp:Button ID="Button2" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                        </div>                    
                    <br />

                </td>
                <td class="auto-style17" style="background-color: #ED7B08; background-image: url('Images/descarga - Copy.jpg'); background-repeat: repeat-y;">
                    <asp:Label  ID="lblOption4" runat="server" Text="Opcion  #4" Font-Names="Kristen ITC,X-Large" text-align="center" Font-Size="X-Large"></asp:Label>
                    
                    
                    <div style="position:relative; left:300px; width:500px;font-family: 'kristen ITC'; background-color: #fefb64;">
                        <asp:Label ID="lblOpc4" runat="server" Text=""></asp:Label></div>
                    <asp:Image ID="Image3" runat="server" Height="140px" ImageUrl="~/Images/yavoy_corcelnegro_combohamb.jpg" Width="202px" />
                   
                    <div style="position:relative; left:300px; width:500px;font-family: 'kristen ITC'; background-color: #fefb64;">
                      <table class="auto-style1">
                            <tr>
                                <td class="auto-style21"> <asp:Label ID="lblTiemOpc4" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblTiemTot4" runat="server" Text=""></asp:Label></td>
                            </tr>
                            <tr>
                                <td   class="auto-style21"> <asp:Label ID="lblPriceOpc4" runat="server" Text=""></asp:Label></td>
                                <td class="auto-style21"> <asp:Label ID="lblPriceTot4" runat="server" Text=""></asp:Label></td>
                            </tr>
                        </table></div>
                    <div style="position:relative;left:300px">
                    <input id="QtyOption4" type="number" min="1" max="20" class="auto-style20"/>&nbsp;
                    <br />
                    <asp:Button ID="Button3" runat="server" Font-Names="Kristen ITC" Text="Añadir" />
                        </div>                    </td>
            </tr>
    </table>
    <div style="position:relative; text-align:center">
    <p style="background-color: #ED7B08"><asp:Button ID="Button4" runat="server" Text="Confirmar compra" BackColor="#AF3A11" Font-Names="Kristen ITC" Font-Size="Large" ForeColor="White" OnClick="Button4_Click" /></p>
    </div>
    </asp:Content>

