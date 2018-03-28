<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Theme="Fall" inherits="StephanScott_Unit6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" type="text/css" href="Css/Style.css" />

    <title>Confirmation</title>
</head>
<body>
    <form id="form1" runat="server" action="WebForm2.aspx">
        <section id="Title">
        <h1>Royal Inns and Suites</h1>
            <section id="tag">
            <p><em>Where you're always treated like royalty</em></p>
            </section>
        </section>

        <section id="Content">
        <h1>Request Confirmation</h1>
        <div>
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText=" * indicates a required field."
                ShowSummary="true" Visible="true" />
        </div>
        <h2>Please confirm your reservation</h2>
        <div>
            <p>
                <label id="firstN" class="label">First Name: </label>
                <asp:Label ID="fName" runat="server" ></asp:Label>
            </p>
            <p>
                <label id="lastName" class="label">Last Name: </label>
                <asp:Label ID="lName" runat="server"></asp:Label>
            </p>
            <p>
                <label id="emailadd" class="label">Email: </label>
                <asp:Label ID="email" runat="server"></asp:Label>
            </p>
            <p>
                <label id="phone" class="label">Phone Number: </label>
                <asp:Label ID="pNumber" runat="server"></asp:Label>
            </p>
            <p>
                <label id="prefMethod" class="label">Preferred Method of Contact: </label>
                <asp:Label ID="pContact" runat="server"></asp:Label>
            </p>

            <h2>Requested Information</h2>
            <p>
                <label id="arrivalD" class="label">Arrival Date: </label>
                <asp:Label ID="arrivD" runat="server"></asp:Label>
            </p>
            <p>
                <label id="departD" class="label">Departure Date: </label>
                <asp:Label ID="depD" runat="server"></asp:Label>
            </p>
            <p>
                <label id="numDay" class="label">Number of Days: </label>
                <asp:Label ID="numDays" runat="server"></asp:Label>
            </p>
            <p>
                <label id="numbGuests" class="label">Number of Guests: </label>
                <asp:Label ID="numGuests" runat="server"></asp:Label>
            </p>
            <p>
                <label id="bedSize1" class="label">Bed Size: </label>
                <asp:Label ID="bedSize" runat="server"></asp:Label>
            </p>
            <p>
                <label id="specialReq" class="label">Special Requests: </label>
                <asp:Label ID="specReq" runat="server"></asp:Label>
            </p>

            <asp:Button ID="Button1" runat="server" type="submit" Text="Confirm Request" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" type="sumbit" Text="Modify Request" OnClick="Button2_Click" />
        </div>
            </section>
    </form>
    <p>
        <asp:Label ID="Label12" runat="server" Text="Label" Visible="false"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label13" runat="server" Text="Label" Visible="false"></asp:Label>
    </p>
</body>
</html>
<section id="Footer">
<footer>
    <div>
        <div style="text-align: center" />
        <p>© 2014 Royal Inns and Suites</p>
    </div>
</footer>
    </section>