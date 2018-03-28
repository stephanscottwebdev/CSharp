<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Theme="Fall" Inherits="StephanScott_Unit6.WebForm1" %>

<!DOCTYPE html>
<!--
 Stephan Scott
 Windows 10

 Microsoft Visual Studio Version: Community 2017

 CIS 174

 Unit 6 Royal Inns and Suites Reservation Form

 Program Description: Theming.

 Academic Honesty:

 I attest that this is my original work.

 I have not used unauthorized source code, either modified or unmodified.

 I have not given other fellow student(s) access to my program.
-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <link rel="stylesheet" type="text/css" href="Css/Style.css" />

    <title>Reservations</title>
</head>
<body>
    <form id="form2" runat="server" action="WebForm1.aspx">
        <section id="Title">
            <h1>Royal Inns and Suites</h1>
            <section id="tag">
                <p><em>Where you're always treated like royalty</em></p>
            </section>
        </section>

        <section id="Content">
            <h1>Reservation Request</h1>
            <div>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" HeaderText=" * indicates a required field." CssClass="text-danger"
                    ShowSummary="true" Visible="true" />
            </div>
            <h2>Request Data</h2>

            <div>
                <p>
                    <label for="arrivalDate" class="label">Arrival Date</label>
                    <asp:TextBox ID="arrDate" runat="server" type="date"></asp:TextBox>
                </p>
                <asp:CompareValidator ID="cvDate1" runat="server" Operator="LessThan" ControlToValidate="arrDate"
                    ControlToCompare="depDate" ErrorMessage="Invalid date selected.">
                </asp:CompareValidator>

                <p>
                    <label for="departureDate" class="label">Departure Date</label>
                    <asp:TextBox ID="depDate" runat="server" type="date"></asp:TextBox>
                </p>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" required="required"
                    ControlToValidate="depDate" Display="Dynamic" ForeColor="Red" ErrorMessage=" Must be after Arrival Date.">
                </asp:RequiredFieldValidator>
                <asp:CompareValidator ID="cvDate2" runat="server" Operator="GreaterThan" Type="Date" ControlToValidate="depDate"
                    ControlToCompare="arrDate" ErrorMessage=" Invalid date selected.">
                </asp:CompareValidator>
            </div>

            <label for="numberOfPeople" class="label">Number of Guests</label>
            <div>
                <asp:DropDownList ID="numberOfPeople" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="1"> 1 </asp:ListItem>
                    <asp:ListItem Value="2"> 2 </asp:ListItem>
                    <asp:ListItem Value="3"> 3 </asp:ListItem>
                    <asp:ListItem Value="4"> 4 </asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="form-check form-check-inline">
                <!--radio group-->
                <label class="label">Bed Size</label>
                <asp:RadioButton ID="RadioButton1" runat="server" GroupName="bedSize" Checked="true" value="king" />
                <label class="form-check-label" for="inlineRadio1">King</label>

                <asp:RadioButton ID="RadioButton2" runat="server" GroupName="bedSize" value="2queen" />
                <label class="form-check-label" for="inlineRadio2">Two Queen</label>

                <asp:RadioButton ID="RadioButton3" runat="server" GroupName="bedSize" value="1queen" />
                <label class="form-check-label" for="inlineRadio3">One Queen</label>
            </div>

            <h2>
                <label for="specialRequests">Special Requests</label></h2>
            <textarea id="specialRequests" rows="5" runat="server"></textarea>

            <h2>Contact Information</h2>

            <label for="firstName" class="label">First Name</label>
            <asp:TextBox ID="fName" runat="server"></asp:TextBox>
            <div>
                <label for="lastName" class="label">Last Name</label>
                <asp:TextBox ID="lName" runat="server"></asp:TextBox>
            </div>
            <div>
                <label for="email" class="label">Email</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="email"
                    Display="Dynamic" ForeColor="Red" ErrorMessage=" Must be a valid email address.">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="email" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ErrorMessage="RegularExpressionValidator"></asp:RegularExpressionValidator>
                <asp:TextBox ID="email" runat="server" required="true" type="email" />
            </div>

            <div class="form-group.required .control-label:after">
                <label for="phone" class="label">Phone</label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="phone"
                    Display="Dynamic" ForeColor="Red" ErrorMessage=" Use this format: 999-999-9999">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="phone" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ErrorMessage=" Please enter a valid phone number."></asp:RegularExpressionValidator>
                <asp:TextBox ID="phone" runat="server" required="true" type="tel" />
            </div>

            <div class="form-control">
                <label for="preferredContact" class="label">Preferred Contact Method</label>
                <asp:DropDownList ID="preferredContact" runat="server">
                    <asp:ListItem Value="Phone"> Phone </asp:ListItem>
                    <asp:ListItem Value="Email"> Email </asp:ListItem>
                </asp:DropDownList>
            </div>

            <asp:Button ID="Button1" runat="server" type="submit" Text="Submit" SkidID="btnSkin" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" type="sumbit" Text="Clear" OnClientClick="this.form.reset();return false;" />
        </section>
    </form>

    <p>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server"></asp:Label>
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