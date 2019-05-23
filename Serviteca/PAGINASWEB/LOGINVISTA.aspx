                            <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LOGINVISTA.aspx.cs" Inherits="Serviteca.PAGINASWEB.LOGINVISTA" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            text-align: center;
        }
        .auto-style3 {
            height: 20px;
        }
        .auto-style4 {
            height: 20px;
            width: 445px;
            text-align: center;
        }
        .auto-style6 {
            width: 445px;
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2" colspan="2">&nbsp; BIENVENIDO&nbsp; AL SISTEMA &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">USUARIO
                        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td class="auto-style6">CLAVE&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:TextBox ID="txtClave" runat="server" style="text-align: right"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2" colspan="2">
                        <asp:Button ID="BtnValidar" runat="server" OnClick="BtnValidar_Click" style="text-align: right" Text="Validar" />
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
    <p>
&nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
