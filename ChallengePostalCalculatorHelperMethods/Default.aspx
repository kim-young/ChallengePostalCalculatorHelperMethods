<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostalCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        Postal Calculator<br />
        <br />
        Width:
        <asp:TextBox ID="widthTextBox" runat="server" OnTextChanged="handleChanged" AutoPostBack="True"></asp:TextBox>
        <br />
        Height:
        <asp:TextBox ID="heightTextBox" runat="server" OnTextChanged="handleChanged" AutoPostBack="True"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="lengthTextBox" runat="server" OnTextChanged="handleChanged" AutoPostBack="True"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="groundRadioButton" runat="server" GroupName="deliveryMethod" OnCheckedChanged="handleChanged" Text="Ground" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="airRadioButton" runat="server" GroupName="deliveryMethod" OnCheckedChanged="handleChanged" Text="Air" AutoPostBack="True" />
        <br />
        <asp:RadioButton ID="nextDayRadioButton" runat="server" GroupName="deliveryMethod" OnCheckedChanged="handleChanged" Text="Next Day" AutoPostBack="True" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    </form>
</body>
</html>
