using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace StephanScottUnit_3
{
    public partial class Default : System.Web.UI.Page
    {
        public object SalePrice { get; private set; }
        public object DiscountPercent { get; private set; }

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

        protected void Button2_Click1(object sender, EventArgs e)
        {

        }
    }
}