<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StephanScottUnit5.WebForm1" %>

<!DOCTYPE html>
<!--
 Stephan Scott
 Windows 10

 Microsoft Visual Studio Version: Community 2017

 CIS 174

 Unit 5 Royal Inns and Suites Reservation Form States

 Program Description: Validation and state usage.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" type="text/css" href="css/style.css" />

    <!-- Latest compiled and minified CSS-->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous" />

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous" />

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>

    <title>Reservations</title>
</head>
<body class="container-fluid">
    <img src="imgs/crown.png" style="padding-top: 10px" class="container-fluid" />
    <form id="form1" runat="server" action="WebForm1.aspx">
        <h1 class="bootstrap-override">Royal Inns and Suites</h1>
        <p><em>Where you're always treated like royalty</em></p>
        <h1 class="bootstrap-override">Reservation Request</h1>
        <div class="alert-danger">
            <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText=" * indicates a required field." CssClass="text-danger"
                ShowSummary="true" Visible="true" />
        </div>
        <h2>Request Data</h2>

        <div class="form-group">
            <label for="arrivalDate">Arrival Date</label>
            <asp:CompareValidator ID="cvDate1" runat="server" Operator="LessThan" Type="Date" ControlToValidate="TextBox1"
                ControlToCompare="TextBox2" CssClass="text-danger" ErrorMessage="Invalid date selected.">
            </asp:CompareValidator>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" type="date"></asp:TextBox>

            <label for="departureDate">Departure Date</label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" CssClass="validator" required="required"
                ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red" ErrorMessage=" Must be after Arrival Date.">
            </asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cvDate2" runat="server" Operator="GreaterThan" Type="Date" ControlToValidate="TextBox2"
                ControlToCompare="TextBox1" CssClass="text-danger" ErrorMessage=" Invalid date selected.">
            </asp:CompareValidator>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" type="date"></asp:TextBox>
        </div>

        <label for="numberOfPeople">Number of Guests</label>
        <div class="form-control">
            <asp:DropDownList ID="numberOfPeople" runat="server" CssClass="dropdown" AutoPostBack="True">
                <asp:ListItem Value="1"> 1 </asp:ListItem>
                <asp:ListItem Value="2"> 2 </asp:ListItem>
                <asp:ListItem Value="3"> 3 </asp:ListItem>
                <asp:ListItem Value="4"> 4 </asp:ListItem>
            </asp:DropDownList>
        </div>

        <div class="form-check form-check-inline">
            <asp:RadioButton ID="RadioButton1" runat="server" name="bedSize" Checked="true" value="option1" />
            <label class="form-check-label" for="inlineRadio1">King</label>

            <asp:RadioButton ID="RadioButton2" runat="server" name="bedSize" value="option2" />
            <label class="form-check-label" for="inlineRadio2">Two Queen</label>

            <asp:RadioButton ID="RadioButton3" runat="server" name="bedSize" value="option3" />
            <label class="form-check-label" for="inlineRadio3">One Queen</label>
        </div>

        <label for="specialRequests">Special Requests</label>
        <textarea class="form-control" id="specialRequests" rows="5" runat="server"></textarea>

        <h1 class="bootstrap-override">Contact Information</h1>
        <div class="form-group">
            <label for="firstName">First Name</label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>

            <label for="lastName">Last Name</label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div class="form-group.required .control-label:after">
            <label for="email">Email</label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" CssClass="validator" ControlToValidate="TextBox5"
                Display="Dynamic" ForeColor="Red" ErrorMessage=" Must be a valid email address.">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox5" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" required="true" type="email" />
        </div>

        <div class="form-group.required .control-label:after">
            <label for="phone">Phone</label>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" CssClass="validator" ControlToValidate="TextBox6"
                Display="Dynamic" ForeColor="Red" ErrorMessage=" Use this format: 999-999-9999">
            </asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox6" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ErrorMessage=" Please enter a valid phone number."></asp:RegularExpressionValidator>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" required="true" type="tel" />
        </div>

        <label for="preferredContact">Preferred Contact Method</label>
        <div class="form-control">
            <asp:DropDownList ID="preferredContact" runat="server" CssClass="dropdown">
                <asp:ListItem Value="Phone"> Phone </asp:ListItem>
                <asp:ListItem Value="Email"> Email </asp:ListItem>
            </asp:DropDownList>
        </div>

        <asp:Button ID="Button1" class="btn btn-primary" runat="server" type="submit" Text="Submit" PostBackUrl="~/WebForm2.aspx" OnClick="Button1_Click" />
        <asp:Button ID="Button2" class="btn btn-success" runat="server" type="sumbit" Text="Clear" OnClientClick="this.form.reset();return false;" />
    </form>
    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
    </p>
</body>
</html>
<footer>
    <div class="container-fluid">
        <div style="text-align: center" />
        <p>© 2014 Royal Inns and Suites</p>
    </div>
</footer>