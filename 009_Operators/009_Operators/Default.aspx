<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_009_Operators.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox>
    
    </div>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Go Negro" />
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>
