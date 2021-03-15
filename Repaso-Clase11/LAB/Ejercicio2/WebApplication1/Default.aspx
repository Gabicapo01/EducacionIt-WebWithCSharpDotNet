<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Administracion de Errores</h1>
            <h2>Ejecutar sin debug (CTRL+F5)</h2>
            <asp:Button runat="server" Text="Error a nivel de pagina sin capturar con Try/Catch" ID="errorNivelPaginaSinTryCatch" OnClick="errorNivelPaginaSinTryCatch_Click"/> <br /> <br />
            <asp:Button runat="server" Text="Error a nivel de pagina capturado con Try/Catch" ID="errorNivelPaginaConTryCatch" OnClick="errorNivelPaginaConTryCatch_Click"/> <br /> <br />
            
            <asp:Button runat="server" Text="Error de IIS (pagina no encontrada)" ID="errorIIS" OnClick="errorIIS_Click"/>
            <br />
            <br />
            <asp:Label runat="server" ID="lblTryCatch1"></asp:Label><br /> <br />
            <asp:Label runat="server" ID="lblTryCatch2"></asp:Label> <br />
            <br />
            <asp:Label runat="server" ID="lblFinally"></asp:Label>
        </div>
    </form>
</body>
</html>
