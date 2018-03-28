using System;

namespace StephanScottUnit5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        public object reservation { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                if ((Session["arrivalD"] != null) &&
                     (Session["depD"] != null) &&
                     (Session["numberOfPeople"] != null) &&
                     (Session["NumDays"] != null) &&
                     (Session["FName"] != null) &&
                     (Session["LName"] != null) &&
                     (Session["Email"] != null) &&
                     (Session["Phone"] != null) &&
                     (Session["SpecReq"] != null) &&
                     (Session["preferredContact"] != null))

                {
                    arrivD.Text = (Session["arrivalD"].ToString());
                    depD.Text = (Session["depD"].ToString());
                    fName.Text = (Session["FName"].ToString());
                    lName.Text = (Session["LName"].ToString());
                    email.Text = (Session["Email"].ToString());
                    pNumber.Text = (Session["Phone"].ToString());
                    pContact.Text = (Session["preferredContact"].ToString());
                    numDays.Text = (Session["NumDays"].ToString());
                    numGuests.Text = (Session["numberOfPeople"].ToString());
                    bedSize.Text = (Session["bedSize"].ToString());
                    specReq.Text = (Session["specReq"].ToString());

                    //TimeSpan tsDays = reservation.DepartureDate - reservation.ArrivalDate;

                    //int days = tsDays.Days;
                }
            }
            string numP = Request.QueryString["SelectedValue"];
            string PrefC = Request.QueryString["SelectedValue2"];
        }
    }
}