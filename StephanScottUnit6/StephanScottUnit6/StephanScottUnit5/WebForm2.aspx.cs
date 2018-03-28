using System;

namespace StephanScottUnit5
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
    }
}