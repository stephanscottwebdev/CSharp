
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StephanScottUnit1.WebForm1" %>

<!DOCTYPE html>
<!--
 Stephan Scott
 Windows 10

 Microsoft Visual Studio Version: Community 2017

 CIS 174

 Unit 1 Price Quote

 Program Description: To have a user input a price and have the form calculate and show a discount.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Price Quote</title>
    <style type="text/css">
        .auto-style1 {
            width: 133px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>Price Quotation</h1>

            <table style="width: 24%;">
                <tr>
                    <td class="auto-style1">Sales Price:</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="150px" BorderStyle="Inset" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Discount Percent:</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="150px" BorderStyle="Inset" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Discount Amount:</td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Font-Bold="True" Width="150px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1">Total:</td>
                    <td>
                        <asp:Label ID="Label1" runat="server" Width="149px" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
            </table>
            <!-- Makes the fields in the textbox required. -->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
            ErrorMessage="Valid price is required." ControlToValidate="TextBox1" 
            Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
            <!-- Checks to makes sure the range is within the parameters I have set. -->
            <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ErrorMessage="Sale Price must range from 10 to 1000." ControlToValidate="TextBox1" 
            Display="Dynamic" ForeColor="Red" Type="Double"
            MaximumValue="1000" MinimumValue="10"></asp:RangeValidator>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Valid discount is required." ControlToValidate="TextBox2" 
            Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

            <asp:RangeValidator ID="RangeValidator2" runat="server" 
            ErrorMessage="Discount range 10 - 50" ControlToValidate="TextBox2" Type="Integer"
            Display="Dynamic" ForeColor="Red" MaximumValue="50" MinimumValue="10"></asp:RangeValidator>

        </div>
        <p><asp:Button ID="Button1" runat="server" Text="Calculate" BorderStyle="Outset" OnClick="Button1_Click" /></p>
    </form>
</body>
</html>
