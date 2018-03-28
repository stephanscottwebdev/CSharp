using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StephanScottUnit1
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Creates variables as doubles for each item in the form.
            double discountPercent, salePrice, discountAmount, discountDecimal, total;
            //Parses the data inputed into the textboxes to doubles.
            salePrice = double.Parse(TextBox1.Text);
            discountPercent = double.Parse(TextBox2.Text);
            discountDecimal = discountPercent / 100;
            //Finds the discount amount.
            discountAmount = salePrice * discountDecimal;
            Label2.Text = discountAmount.ToString("c2");
            //Finds the total amount.
            total = salePrice - discountAmount;
            Label1.Text = total.ToString("c2");
        }
    }
}