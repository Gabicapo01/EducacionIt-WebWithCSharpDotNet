<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error.aspx.cs" Inherits="IntegradorASP.Error" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <br />
        <div class="panel panel-danger">
            <div class="panel-heading"> Se ha producido un error  </div>
            <div class="panel-body">
                <asp:Label runat="server" ID="lblError" Text="Error inesperado." ></asp:Label>
            </div>
            <div class="panel-footer text-right">
                <asp:Button runat="server" ID="btnAceptar" Text="Aceptar" PostBackUrl="~/Default.aspx" />

            </div>
        </div>
    </form>
</body>
</html>
