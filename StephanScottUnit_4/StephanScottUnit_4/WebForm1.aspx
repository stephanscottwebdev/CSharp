<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="StephanScottUnit_4.WebForm1" %>

<!DOCTYPE html>
<!--
 Stephan Scott
 Windows 10

 Microsoft Visual Studio Version: Community 2017

 CIS 174

 Unit 4 Royal Inns and Suites Reservation Form

 Program Description: Create a responsive form that focuses the first text bxox on load and checks the king checkbox. The submit button can 
    be used with the enter key and the clear will clear the form.

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
    
    
    <title>Unit 4</title>
</head>
<body class="container-fluid">
    <form id="form1" runat="server" defaultbutton="Button1">
        <h1 class="bootstrap-override">Royal Inns and Suites</h1>
            <p><em>Where you're always treated like royalty</em></p>
                <h1 class="bootstrap-override">Reservation Request</h1>

        <h2>Request Data</h2>

            <div class="form-group">
                <label for="arrivalDate">Arrival Date</label>
                <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" type="date" autofocus="autofocus"></asp:TextBox>  

            

                <label for="departureDate">Departure Date</label>
                <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" type="date"></asp:TextBox>  


            <label for="numberOfPeople">Number of People</label>
                <select class="form-control" id="numberOfPeople">
                    <option>1</option>
                    <option>2</option>
                    <option>3</option>
                    <option>4</option>
            </select>

            <div class="form-check form-check-inline">
                <asp:CheckBox ID="checkbox1" runat="server" type="radio" checked="true" value="option1"/>
                <label class="form-check-label" for="inlineRadio1">King</label>
            
                <asp:CheckBox ID="checkbox2" runat="server" type="radio" value="option2"/>
                <label class="form-check-label" for="inlineRadio2">Two Queen</label>
                
                <asp:CheckBox ID="checkbox3" runat="server" type="radio" value="option3"/>
                <label class="form-check-label" for="inlineRadio3">One Queen</label>
            </div>


                <label for="specialRequests">Special Requests</label>
                    <textarea class="form-control" id="specialRequests" rows="5"></textarea>
            </div>

        <h1 class ="bootstrap-override">Contact Information</h1>
        <div class="form-group">
            <label for="firstName">First Name</label>
            <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control"></asp:TextBox>  

            <label for="lastName">Last Name</label>
            <asp:TextBox ID="TextBox4" runat="server" CssClass="form-control"></asp:TextBox>  

            <label for="email">Email</label>
            <asp:TextBox ID="TextBox5" runat="server" CssClass="form-control" type="email"/>

            <label for="phone">Phone</label>
            <asp:TextBox ID="TextBox6" runat="server" CssClass="form-control" type="tel"/>

            <label for="preferred">Preferred Method</label>
                <select class="form-control" id="preferred">
                    <option>Email</option>
                    <option>Phone</option>
                </select>

           <asp:Button ID="Button1" class="btn btn-primary" runat="server" type="submit" Text="Submit" defaultbutton="Button1" OnClick="Button1_Click"/>
           <asp:Button ID="Button2" class="btn btn-success" runat="server" type="sumbit" Text="Clear" OnClientClick="this.form.reset();return false;"/>
        </div>
     </form>

    <p><asp:Label ID="Label1" runat="server"></asp:Label></p>
    <p><asp:Label ID="Label2" runat="server"></asp:Label></p>
    
</body>

</html>

    <footer>
        <div class="container-fluid">
            <div style="text-align:center"/>
            <p>© 2014 Royal Inns and Suites</p>
        </div>       
    </footer>