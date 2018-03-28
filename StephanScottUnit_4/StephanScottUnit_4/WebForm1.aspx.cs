using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StephanScottUnit_4
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Throws the strings into the lables upon submission. Button event for the use of the enter key.
            this.Form.DefaultButton = "Button1";
            Label1.Text = "Thank you for your request.";
            Label2.Text = "We will get back to you within 24 hours.";

        }

    }
}