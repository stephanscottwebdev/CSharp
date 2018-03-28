using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StephanScottUnit_2
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            double discountAmount, total, salePrice, discountPercent;
            salePrice = Convert.ToDouble(TextBox1.Text);
            discountPercent = Convert.ToDouble(TextBox2.Text);
            double discountDecimal = discountPercent / 100;
            discountAmount = salePrice * discountDecimal;
            Label1.Text = "Discount Amount: " + discountAmount;
            total = salePrice - discountAmount;
            Label2.Text = "Total Amount: " + total;
        }
    }
}