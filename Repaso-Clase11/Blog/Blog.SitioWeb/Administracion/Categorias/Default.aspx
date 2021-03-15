<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.SitioWeb.Administracion.Categorias.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <h1>Administracion de Categorias</h1>
    <br />
    <a href="Formulario.aspx" class="btn btn-primary">Nuevo</a> <br />
    <br />
    <asp:ListView runat="server" ID="lstCategorias">
        <LayoutTemplate>
            <table class="table">
                <thead>
                    <tr>
                        <th scope="col">Id</th>
                        <th scope="col">Nombre</th>
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
                <td><%#Eval("Nombre")%></td>
                <td>
                    <a href="Formulario.aspx?ID=<%#Eval("Id")%>" class="btn btn-info">Editar</a>
                    <a href="Formulario.aspx?ID=<%#Eval("Id")%>" class="btn btn-info">Borrar</a>


                </td>
            </tr>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
