
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StephanScottUnit_3

{ 
    public partial class WebForm2 : System.Web.UI.Page
    {
        //public object Label1 { get; private set; }
        //public object Label2 { get; private set; }
        //public object Label3 { get; private set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                lblSaleP.Text = PreviousPage.SaleP;
                lblDisc.Text = PreviousPage.DiscA;
                lblTotal.Text = PreviousPage.TotalP;
            }
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {

        }
    }
}