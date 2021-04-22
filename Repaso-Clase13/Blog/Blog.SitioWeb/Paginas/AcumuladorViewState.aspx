<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="AcumuladorViewState.aspx.cs" Inherits="Blog.SitioWeb.Paginas.AcumuladorViewState" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h1>Acumulador en ViewState</h1>
    <asp:Label runat="server" ID="lblContador"> </asp:Label> <br />
    <asp:Button runat="server" id="btnContador" Text="Incrementar" CssClass="btn btn-primary" OnClick="btnContador_Click"/>
</asp:Content>
