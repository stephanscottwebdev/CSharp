using System;
using System.Windows.Forms;


namespace Scott_Week6_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Global variables.
        int a, b;
        void multiply(int l, int m)
        {
            int q = l * m;
            MessageBox.Show(a + " * " + b + " = " + q);
            lblResult.Text = a.ToString() + " * " + b.ToString() + " = " + q.ToString();
        }
        int subtract(int l, int m)
        {
            int f = l - m;
            return f;
        }
        void add()
        {
            /*Creating add() method, return type is void, meaning it doesnt return anything
             * add is the method name and the () represent the parameters of the method
             * (int x, int y) if not empty they receive arguments from the calling method
             * add method has no parameters, it performs addition, when its called it returns*/
            int x = 5; //x is local
            int y = 10;
            int sum = x + y;
            int c = a + b; //c is a local variable that holds the sum of a & b

            MessageBox.Show("This method adds 5 + 10 = " + sum + "\n\nAlso adds " + a + " + " + b + " = " + c);
            MessageBox.Show(sum.ToString());
            MessageBox.Show(c.ToString());
            lblResult.Text = sum.ToString() + ", " + c.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVoid2_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(tbNum1.Text);
                b = int.Parse(tbNum2.Text);
                //Pass a and b arguments to multiply method
                //int l recieves the value of a, l = a
                //int m receives the value of b, m = b
                multiply(a, b);
            }
            catch 
            {
                MessageBox.Show("Invalid input, please enter an integer!");
            }
        }

        private void btnReturnValue_Click(object sender, EventArgs e)
        {
            try
            {
                a = int.Parse(tbNum1.Text);
                b = int.Parse(tbNum2.Text);
                /*the values of int a & b are passed to the subtract method
                int l = a, int m = b
                a & b are called arguments
                int l and int m are called parameters, they recieve arguments
                from calling the method btnReturnValue
                subtract method subtracts m from l
                the result is passed to the btnReturnValue
                then the result is stored in local variable w */
                int w = subtract(a, b);

                MessageBox.Show(w.ToString());

                lblResult.Text = a.ToString() + " - " + b.ToString() + " = " + w.ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input, please enter an integer!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbNum1.Text = "";
            tbNum2.Text = "";
            lblResult.Text = "";
        }

        private void btnVoid1_Click(object sender, EventArgs e)
        {
            //Try catch block to catch any invalid input.
            try
            {
                a = int.Parse(tbNum1.Text);
                b = int.Parse(tbNum2.Text);
                add();
            }
            catch 
            {
                MessageBox.Show("Invalid input, please enter an integer!");
            }
        }
    }
}
