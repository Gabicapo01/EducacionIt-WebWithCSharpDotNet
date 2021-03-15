<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="VerPost.aspx.cs" Inherits="Blog.SitioWeb.VerPost" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h1> <asp:Label runat="server" ID="lblTituloPost"></asp:Label></h1>
    <hr />
    <br />
    <h5> <asp:Label runat="server" ID="lblResumenPost"> </asp:Label></h5>
    <br />
    <p> <asp:Label runat="server" ID="lblCuerpo"></asp:Label></p>

    <asp:Button runat="server" ID="VolverButton1" CssClass="btn btn-success" Text="Volver" OnClick="VolverButton1_Click"/>

</asp:Content>
