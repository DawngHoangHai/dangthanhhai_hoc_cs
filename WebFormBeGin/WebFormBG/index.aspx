<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebFormBG.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Bài Tập Lần 1</title>
</head>
<body>
    
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btn1" runat="server" Text="1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2" runat="server" Text="2" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn3" runat="server" Text="3" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnCong" runat="server" Text="+" />

        <br />
        <br />
                <asp:Button ID="btn4" runat="server" Text="4" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn5" runat="server" Text="5" />
&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn6" runat="server" Text="6" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnTRu" runat="server" Text="-" />
        <br />
        <br />
        <asp:Button ID="tbn7" runat="server" Text="7" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn8" runat="server" Text="8" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn9" runat="server" Text="9" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnNhan" runat="server" Text="*" />
        <br />
        <br />
        <asp:Button ID="btnPhay" runat="server" Text="." />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnBang" runat="server" Text="=" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn0" runat="server" Text="0" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnChia" runat="server" Text="/" />
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnReset" runat="server" Text="Reset" />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnThoat" runat="server" Text="Thoát" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </form>
    
</body>
</html>
