using System;

namespace StephanScott_Unit6
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private Reservation reservation;

        protected void Page_Load(object sender, EventArgs e)
        {
            if ((Session["Reservation"] != null))

            {
                reservation = (Reservation)Session["Reservation"];

                fName.Text = reservation.FName;
                lName.Text = reservation.LName;
                email.Text = reservation.Email;
                pNumber.Text = reservation.Phone;
                arrivD.Text = reservation.ArrivalD.ToShortDateString();
                depD.Text = reservation.DepD.ToShortDateString();
                numGuests.Text = reservation.numberOfPeople.ToString();
                specReq.Text = reservation.SpecReq;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label12.Text = "Thank you!";
            Label13.Text = "We will be in touch soon!";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/WebForm1.aspx");
        }
    }
}