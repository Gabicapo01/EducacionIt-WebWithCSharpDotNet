<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="AdminBlogPostDefault.aspx.cs" Inherits="Blog.SitioWeb.Administracion.BlogPost.AdminBlogPostDefault" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
     <h1>Administracion de BlogPosts</h1>
    <br />
    <a href="AdminBlogPostFormulario.aspx" class="btn btn-primary">Nuevo</a>
    <br />
    <br />
    <asp:ListView runat="server" ID="lstBlogPost">
        <LayoutTemplate>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">Categoria</th>
                        <th scope="col">Titulo</th>
                        <th scope="col">Resumen</th>
                        <th scope="col">Opciones</th>
                    </tr>
                </thead>
                <tbody>
                    <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>
                </tbody>
            </table>
        </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <th scope="row"><%#Eval("Id")%></th>
                <td><%#Eval("Categoria.Nombre")%></td>
                <td><%#Eval("Titulo")%></td>
                <td><%#Eval("Resumen")%></td>
                <td>
                    <a href="AdminBlogPostFormulario.aspx?ID=<%#Eval("Id")%>" class="btn btn-info" style="margin-right:5px">Editar</a> 
                    <a href="AdminBlogPostFormulario.aspx?ID=<%#Eval("Id")%>" class="btn btn-info">Borrar</a>
                </td>
            </tr>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
