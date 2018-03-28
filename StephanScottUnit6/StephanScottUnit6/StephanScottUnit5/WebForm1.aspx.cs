using System;
using System.Web;
using System.Web.UI;

namespace StephanScottUnit5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Reservation reservation = new Reservation();

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.SetFocus(arrDate);

            if (!IsPostBack)
            {
                if (!(Request.Cookies["FirstName"] == null))
                {
                    fName.Text = Request.Cookies["FirstName"].Value;
                    email.Text = Request.Cookies["email"].Value;
                }

                if ((Session["Reservation"] != null))
                {
                    reservation = (Reservation)Session["Reservation"];
                    fName.Text = reservation.FName;
                    lName.Text = reservation.LName;
                    email.Text = reservation.Email;
                    phone.Text = reservation.Phone;
                    arrDate.Text = reservation.ArrivalD.ToShortDateString();
                    depDate.Text = reservation.DepD.ToShortDateString();
                    numberOfPeople.Text = reservation.numberOfPeople.ToString();
                    specialRequests.InnerText = reservation.SpecReq;
                    
                }
                arrDate.Text = DateTime.Today.ToShortDateString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Reservation reserve = new Reservation();

            reservation.FName = fName.Text;
            reservation.LName = lName.Text;
            reservation.Email = email.Text;
            reservation.Phone = phone.Text;
            //reservation.numberOfPeople = numberOfPeople.Text;
            //reservation.numDays = numDays;
            reservation.ArrivalD = DateTime.Parse(arrDate.Text);
            reservation.DepD = DateTime.Parse(depDate.Text);

            Session["Reservation"] = reservation;

            HttpCookie firstName = new HttpCookie("First Name", fName.Text);
            firstName.Expires = DateTime.Now.AddMonths(6);

            HttpCookie Email = new HttpCookie("email", email.Text)
            {
                Expires = DateTime.Now.AddMonths(6)
            };

            Response.Cookies.Add(firstName);
            Response.Cookies.Add(Email);

            Response.Redirect("~/Webform2.aspx");
        }
    }
}