<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TareaProgra.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="CargarArchivo" runat="server" Height="30px" OnClick="CargarArchivo_Click" Text="Cargar Archivos" Width="124px" />
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="16px" Width="251px"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Buscar ID" Width="156px" />
        </p>
        <asp:TextBox ID="TextBox2" runat="server" Height="23px" Width="335px"></asp:TextBox>
    </form>
</body>
</html>
