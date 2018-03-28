using System;

namespace StephanScottUnit_3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double discountAmount, total, salePrice, discountPercent;
            salePrice = Convert.ToDouble(TextBox1.Text);
            discountPercent = Convert.ToDouble(TextBox2.Text);
            double discountDecimal = discountPercent / 100;
            discountAmount = salePrice * discountDecimal;
            Label1.Text = "Discount Amount: " + discountAmount;
            total = salePrice - discountAmount;
            Label2.Text = "Total Amount: " + total;
            Label3.Text = "Sale Price: " + salePrice;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }

        public string DiscA
        {
            get { return this.Label1.Text; }
        }

        public string TotalP
        {
            get { return this.Label2.Text; }
        }

        public string SaleP
        {
            get { return this.Label3.Text; }
        }
    }
}