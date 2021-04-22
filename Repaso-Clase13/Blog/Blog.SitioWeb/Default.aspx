<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Blog.SitioWeb.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContenidoPrincipal" runat="server">
    <asp:ListView runat="server" ID="lstPosts">
        <LayoutTemplate>
            <div class="card-deck">
                <asp:PlaceHolder runat="server" ID="itemPlaceHolder"></asp:PlaceHolder>   
            </div>
        </LayoutTemplate>
        <ItemTemplate>
            <div class="card">
                <div class="card-body">
                    <h5 class="card-title"><%#Eval("Titulo")%></h5>
                    <p class="card-text"><%#Eval("Resumen")%></p>
                    <a href="verPost.aspx?ID=<%#Eval("ID")%>" class="btn btn-primary">Ver mas</a>
                </div>
            </div>
        </ItemTemplate>

    </asp:ListView>
</asp:Content>
