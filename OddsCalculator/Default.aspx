<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="OddsCalculator.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Odds Calculator</title>
    <link type="text/css" rel="Stylesheet" href="Styles/OddsCalculatorStyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Odds Calculator</h1>
        <p>Enter the percentage chance you think a horse has of winning and the minimum odds it should be backed at will be displayed:</p>
        <p><asp:TextBox ID="PercentValue" runat="server" style="margin-left: 1px" Width="64px"></asp:TextBox>% 
                <asp:Button ID="CalculateOdds" runat="server" Text="Go" onclick="CalculateOdds_Click" /><br />
        <asp:RangeValidator ID="RangeValidateInput" runat="server" 
                ErrorMessage="Enter a decimal value between 0 and 100." 
                ControlToValidate="PercentValue" MaximumValue="100" MinimumValue="0" 
                Type="Double" Text="Enter a decimal value between 0 and 100." Display="Dynamic" 
                ForeColor="Red"></asp:RangeValidator></p>
        <p><asp:Label ID="DisplayPrice" runat="server"></asp:Label> </p>
    </div>
    </form>
</body>
</html>
