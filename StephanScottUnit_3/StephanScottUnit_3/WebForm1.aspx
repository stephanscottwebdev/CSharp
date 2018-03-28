<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StephanScottUnit_3.WebForm1" %>

<!DOCTYPE html>
<!--
 Stephan Scott
 Windows 10

 Microsoft Visual Studio Version: Community 2017

 CIS 174

 Unit 3 Price Quote

 Program Description: Multi-page Price Quote that shows confirmation of prices and allows a user to return to the previous page. 

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" type="text/css" href="css\main.css"/>

    <!-- Latest compiled and minified CSS--> 
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous"/>

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    

    <title>Unit 3</title>

</head>
<body class="container-fluid">

    <form id="form1" action="WebForm1.aspx" runat="server">

        <h1 class="bootstrap-override">Price Quotation</h1>

        <div class="form-group">
            <label for="SalePrice">Sale Price</label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Enter a sales price between $10 - $100."></asp:TextBox>  
        </div>

        <div class="form-group">
            <label>Discount Percent</label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" placeholder="Enter a discount between 10% - 50%."></asp:TextBox>
            
            <p><asp:Label ID="Label1" runat="server" Text="Discount Amount: "></asp:Label></p>
            <p><asp:Label ID="Label2" runat="server" Text="Total Price: "></asp:Label></p>
            <p><asp:Label ID="Label3" runat="server" Text="Sale Price: " Visible="false"></asp:Label></p>
            <p><asp:Label ID="Label4" runat="server" ForeColor="Red" EnableViewState="false" CssClass="text-info col-sm-12"></asp:Label></p>
        </div>


            <!-- Makes the fields in the textbox required.-->
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
            ErrorMessage="Valid price is required. " CssClass="validator" ControlToValidate="TextBox1" Type="Double"
            Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>

            <!-- Checks to makes sure the range is within the parameters I have set.-->
            <asp:RangeValidator ID="RangeValidator1" runat="server"
            ErrorMessage=" Sale Price must range from 10 to 1000. " CssClass="validator" ControlToValidate="TextBox1"
            Display="Dynamic" ForeColor="Red" Type="Double"
            MaximumValue="1000" MinimumValue="10"></asp:RangeValidator>

            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
            ErrorMessage=" Valid discount is required. " CssClass="validator" ControlToValidate="TextBox2"
            Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
		
            <asp:RangeValidator ID="RangeValidator2" runat="server"
            ErrorMessage=" Discount range 10 - 50 " CssClass="validator" ControlToValidate="TextBox2" Type="Double"
            Display="Dynamic" ForeColor="Red" MaximumValue="50" MinimumValue="10"></asp:RangeValidator>

        <p><asp:Button ID="Button1" class="btn btn-primary" runat="server" type="submit" Text="Calculate" OnClick="Button1_Click"/>
           <asp:Button ID="Button2" class="btn btn-success" runat="server" type="sumbit" Text="Confirm" PostBackUrl="~/WebForm2.aspx" OnClick="Button2_Click"/></p>
    
    </form>
    
</body>
</html>

