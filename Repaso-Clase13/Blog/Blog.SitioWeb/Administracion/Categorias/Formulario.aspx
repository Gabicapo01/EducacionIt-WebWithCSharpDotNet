<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Formulario.aspx.cs" Inherits="Blog.SitioWeb.Administracion.Categorias.Formulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h1>Categoria</h1>
    <asp:Panel runat="server" ID="pnlError" Visible="false">
        <div class="alert alert-danger" role="alert">
            <asp:Label runat="server" ID="lblMensajeError">Ha ocurrido un error al realizar la operacion</asp:Label>
        </div>
    </asp:Panel>

    <div class="form-group">
        <label>Nombre</label>
        <asp:TextBox runat="server" ID="txtNombre" CssClass="form-control"></asp:TextBox>
    </div>
    
    <div class="form-group">
        <asp:Button runat="server" ID="btnGrabar" CssClass="btn btn-success" Text="Guardar" OnClick="btnGrabar_Click"/>

        <asp:Button runat="server" ID="btnBorrar" CssClass="btn btn-success" Text="Borrar" OnClick="btnBorrar_Click"/>

    </div>

    
</asp:Content>
