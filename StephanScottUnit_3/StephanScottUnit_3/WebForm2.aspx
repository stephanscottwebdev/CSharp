<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="StephanScottUnit_3.WebForm2" %>
<%@ PreviousPageType VirtualPath="~/WebForm1.aspx" %>
<!DOCTYPE html>

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

    <form id="form1" action="WebForm2.aspx" runat="server">

        <h1 class="bootstrap-override">Quotation Confirmation</h1>

        <div class="form-group">
            
            <p><asp:Label ID="lblSaleP" runat="server" Text="Sale Price: "></asp:Label></p>
            <p><asp:Label ID="lblDisc" runat="server" Text="Discount Amount: "></asp:Label></p>
            <p><asp:Label ID="lblTotal" runat="server" Text="Total Price: "></asp:Label></p>

        </div>

        <p><asp:Button ID="Button3" class="btn btn-success" runat="server" type="submit" Text="Return" PostBackUrl="~/WebForm1.aspx"/>
    
    </form>
    
</body>
</html>