<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="AdminBlogPostFormulario.aspx.cs" Inherits="Blog.SitioWeb.Administracion.BlogPost.AdminBlogPostFormulario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">

 <h1>Posts</h1>
    <asp:Panel runat="server" ID="pnlError" Visible="false">
        <div class="alert alert-danger" role="alert">
            Ha ocurrido un error al realizar la operacion!
        </div>
    </asp:Panel>

    <div class="form-group">
        <div class="panel-heading">
            <strong><label>Id: </label></strong>
            <asp:Label runat="server" ID="lblId"></asp:Label>
            <br />
            
            <h5>Categoria:</h5> <asp:Label runat="server" ID="lblCategoria"></asp:Label>
            <asp:DropDownList ID="DropDownList" runat="server" DataSourceID="ObjectDataSourceCategorias" AppendDataBoundItems="true" DataTextField="Nombre" DataValueField="Id" AutoPostBack="True" CssClass="form-control" ></asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSourceCategorias" runat="server" SelectMethod="TodasLasCategorias" TypeName="Blog.Negocio.CategoriasNegocio"></asp:ObjectDataSource>
            
        </div>
        
        <br />
        <hr />
        <h5><label>Titulo</label></h5>
        <asp:TextBox runat="server" ID="txtTitulo" CssClass="form-control"></asp:TextBox>
        <h5><label>Resumen</label></h5>
        <asp:TextBox runat="server" ID="txtResumen" CssClass="form-control"></asp:TextBox>
        <h5><label>Cuerpo</label></h5>
        <asp:TextBox runat="server" ID="txtCuerpo" CssClass="form-control" TextMode="multiline" style="resize:both" height="450" wrap="true"></asp:TextBox>
        
        
    </div>
    
    <div class="form-group">
        <asp:Button runat="server" ID="btnGrabarPost" CssClass="btn btn-success" Text="Guardar" OnClick="btnGrabarPost_Click"/>

        <asp:Button runat="server" ID="btnBorrarPost" CssClass="btn btn-success" Text="Borrar" OnClick="btnBorrarPost_Click"/>
        <asp:Button runat="server" ID="VolverButton" CssClass="btn btn-success" Text="Volver" OnClick="VolverButton_Click"/>
        

    </div>


</asp:Content>
