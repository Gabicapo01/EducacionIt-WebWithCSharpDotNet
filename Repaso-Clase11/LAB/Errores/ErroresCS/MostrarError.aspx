<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MostrarError.aspx.cs" Inherits="ErroresCS.MostrarError"  %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Se ha producido un error</h1>
        <asp:Label ID="lblMensaje" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" />
    </div>
    </form>
</body>
</html>
