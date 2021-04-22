<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="AcumuladorSesion.aspx.cs" Inherits="Blog.SitioWeb.Paginas.AcumuladorSesion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h1>Acumulador en Sesion</h1>
    <asp:Label runat="server" ID="lblContador"> </asp:Label> <br />
    <asp:Button runat="server" id="btnContador" Text="Incrementar" CssClass="btn btn-primary" onclick="btnContador_Click"/><br />
    <br />
    <asp:Label runat="server" ID="WebConfig"> </asp:Label> <br />
</asp:Content>
