<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistroProducto.aspx.cs" Inherits="WebHome.RegistroProducto" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="LabelCodigo" runat="server" Text="Codigo"></asp:Label>
        <asp:TextBox ID="TextBoxCodigo" runat="server" Width="128px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Buttonbuscar" runat="server" Text="Buscar" Width="80px" />
        <br />
        <asp:Label ID="Labelnombre" runat="server" Text="Nombre"></asp:Label>
        <asp:TextBox ID="TextBoxnombre" runat="server" Width="127px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Labelexistencia" runat="server" Text="Existencia"></asp:Label>
        <br />
        <asp:Label ID="Labelcosto" runat="server" Text="Costo"></asp:Label>
        <asp:TextBox ID="TextBoxcosto" runat="server" Width="127px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBoxeixtencia" runat="server" Width="86px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;
        <br />
        <asp:Label ID="Labeleprecio" runat="server" Text="Precio"></asp:Label>
        <asp:TextBox ID="TextBoxprecio" runat="server" Width="141px"></asp:TextBox>
&nbsp;&nbsp;
        <asp:Label ID="Labelitb" runat="server" Text="ITB"></asp:Label>
&nbsp;&nbsp;
        <asp:DropDownList ID="DropDownListitb" runat="server" Height="16px" style="margin-left: 0px" Width="89px">
            <asp:ListItem Selected="True">0</asp:ListItem>
            <asp:ListItem Value="0.08">0.08</asp:ListItem>
            <asp:ListItem>0.16</asp:ListItem>
            <asp:ListItem>0.18</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Labelmensaje" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="Buttonnuevo" runat="server" Text="Nuevo" Width="60px" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonEliminar" runat="server" Text="Eliminar" Width="67px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="ButtonGuardar" runat="server" Text="Guardar" Width="68px" OnClick="ButtonGuardar_Click" />
        <br />
    
    </div>
    </form>
</body>
</html>
