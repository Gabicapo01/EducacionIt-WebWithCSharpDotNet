<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ErroresCS.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Administración de errores</h1>
        <h2>Ejecutar sin debug (CTRL+F5)</h2>
        <asp:Button ID="btnSinCapturar" runat="server" Text="Error a nivel de página sin capturar con Try/Catch" OnClick="btnSinCapturar_Click" />
        <br />
        <br />
        <asp:Button ID="btnCapturado" runat="server" Text="Error a nivel de página capturado con Try/Catch" OnClick="btnCapturado_Click" />
        <br />
        <br />
        <asp:Button ID="btnIIS" runat="server" Text="Error de IIS (página no encontrada)" OnClick="btnIIS_Click" />
    </div>
    </form>
</body>
</html>
