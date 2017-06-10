<%@ Page Title="" Language="C#" MasterPageFile="~/tplPrincipal.master" AutoEventWireup="true" CodeFile="Fibonacci.aspx.cs" Inherits="Fibonacci" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
        Fibonacci:
        <asp:TextBox ID="TextBoxFibonacci" runat="server"></asp:TextBox>
    </p>
    <p>
        Resultado:
        <asp:Label ID="LabelFibonacci" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Button ID="ButtonFibonacci" runat="server" Text="Calcular" OnClick="ButtonFibonacci_Click" />
    </p>
</asp:Content>

