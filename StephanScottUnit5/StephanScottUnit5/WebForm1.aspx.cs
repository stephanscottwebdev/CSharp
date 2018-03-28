using System;
using System.Web.UI;

namespace StephanScottUnit5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private string selectedSize;

        protected void Page_Load(object sender, EventArgs e)
        {
            Page.SetFocus(TextBox1);
            //TextBox1.SelectedDate = "<%# DateTime.Today %>";
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
                Response.Redirect("~/WebForm2.aspx");
            }

            if (!IsPostBack)
            {
                if (Session["arrivalD"] != null)
                {
                    Label1.Text = (Session["arrivalD"].ToString());
                    Label2.Text = (Session["depD"].ToString());
                }
                else
                {
                    Session["arrivalD"] = null;
                    Session["depD"] = null;
                    Session["numberOfPeople"] = null;
                    Session["NumDays"] = null;
                    Session["FName"] = null;
                    Session["LName"] = null;
                    Session["Email"] = null;
                    Session["Phone"] = null;
                    Session["SpecReq"] = null;
                    Session["preferredContact"] = null;
                    Session["SalesPrice"] = null;
                    Session["DiscountAmount"] = null;
                    Session["DiscountPercent"] = null;
                    Session["TotalPrice"] = null;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (numberOfPeople.SelectedItem.Value.Length > 0)
            {
                Response.Redirect("WebForm2.aspx?SelectedValue=" + numberOfPeople.SelectedValue);
            }

            Label1.Text = "Thank you for your request.";
            Label2.Text = "We will get back to you within 24 hours.";

            if (preferredContact.SelectedItem.Value.Length > 0)
            {
                Response.Redirect("WebForm2.aspx?SelectedValue2=" + preferredContact.SelectedValue);
            }
            if (Request.Form["bedSize"] != null)
                selectedSize = Request.Form["bedSize"].ToString();
        }

        public string FName
        {
            get { return this.TextBox3.Text; }
        }

        public string LName
        {
            get { return this.TextBox4.Text; }
        }

        public string Email
        {
            get { return this.TextBox5.Text; }
        }

        public string Phone
        {
            get { return this.TextBox6.Text; }
        }

        public string ArrivalD
        {
            get { return this.TextBox1.Text; }
        }

        public string DepD
        {
            get { return this.TextBox2.Text; }
        }

        public string NumDays
        {
            get { return this.Label2.Text; }
        }

        public string SpecReq
        {
            get { return this.specialRequests.InnerText; }
        }
    }
}