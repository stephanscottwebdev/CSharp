<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="StephanScottUnit5.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" type="text/css" href="css/style.css" />

    <!-- Latest compiled and minified CSS-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <title>Confirmation</title>
</head>
<body class="container-fluid">
    <img src="imgs/crown.png" style="padding-top: 10px" class="container-fluid" />
    <form id="form1" runat="server" action="WebForm2.aspx">
        <h1 class="bootstrap-override">Royal Inns and Suites</h1>
        <p><em>Where you're always treated like royalty</em></p>
        <h1 class="bootstrap-override">Request Confirmation</h1>
        <div class="alert-danger">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText=" * indicates a required field." CssClass="text-danger"
                ShowSummary="true" Visible="true" />
        </div>
        <h2>Please confirm your reservation</h2>
        <div class="container-fluid">
            <p>
                <label id="firstN">First Name: </label>
                <asp:Label ID="fName" runat="server"></asp:Label></p>
            <p>
                <label id="lastName">Last Name: </label>
                <asp:Label ID="lName" runat="server" Text="Last Name: "></asp:Label></p>
            <p>
                <label id="emailadd">Email: </label>
                <asp:Label ID="email" runat="server" Text="Email: "></asp:Label></p>
            <p>
                <label id="phone">Phone Number: </label>
                <asp:Label ID="pNumber" runat="server" Text="Phone Number: "></asp:Label></p>
            <p>
                <label id="prefMethod">Preferred Method of Contact: </label>
                <asp:Label ID="pContact" runat="server" Text="Preferred Method of Contact: "></asp:Label></p>

            <h2>Requested Information</h2>
            <p>
                <label id="arrivalD">Arrival Date: </label>
                <asp:Label ID="arrivD" runat="server" Text="Arrival Date: "></asp:Label></p>
            <p>
                <label id="departD">Departure Date: </label>
                <asp:Label ID="depD" runat="server" Text="Departure Date: "></asp:Label></p>
            <p>
                <label id="numDay">Number of Days: </label>
                <asp:Label ID="numDays" runat="server" Text="Number of days: "></asp:Label></p>
            <p>
                <label id="numbGuests">Number of Guests: </label>
                <asp:Label ID="numGuests" runat="server" Text="Number of guests: "></asp:Label></p>
            <p>
                <label id="bedSize1">Bed Size: </label>
                <asp:Label ID="bedSize" runat="server" Text="Bed Size: "></asp:Label></p>
            <p>
                <label id="specialReq">Special Requests: </label>
                <asp:Label ID="specReq" runat="server" TextArea="Special Requests: "></asp:Label></p>

            <asp:Button ID="Button1" class="btn btn-primary" runat="server" type="submit" Text="Confirm Request" />
            <asp:Button ID="Button2" class="btn btn-success" runat="server" type="sumbit" Text="Modify Request" />
        </div>
    </form>
    <p>
        <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label></p>
    <p>
        <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label></p>
</body>
</html>
<footer>
    <div class="container-fluid">
        <div style="text-align: center" />
        <p>© 2014 Royal Inns and Suites</p>
    </div>
</footer>