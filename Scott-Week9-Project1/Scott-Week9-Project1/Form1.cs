using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week9_Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        class Employee
        {
            string _firstName;
            string _lastName;
            int _id;
            int _age;

            public Employee (string fn, string ln, int ID, int Age)
            {
                this._firstName = fn;
                this._lastName = ln;
                this._id = ID;
                this._age = Age;
            }

            //Overload the Constructor
            public Employee(string fn, string ln, int ID)
            {
                _firstName = fn;
                _lastName = ln;
                _id = ID;
            }

            public Employee(string fName)
            {
                _firstName = fName;
            }

            public Employee()
            {

            }
            public void displayEmployeeInfo()
            {
                MessageBox.Show("Employee First Name: " + _firstName + "\nEmployee Last Name: " + _lastName +
                    "\nEmployee ID: " + _id + "\nEmployee Age: " + _age);
            }
        }

        class Customer
        {
            string firstName;
            string lastName;
            int custID;

            public void displayCustomerInfo()
            {
                //Initialize Customer class fields
                firstName = "Jill";
                lastName = "Smith";
                custID = 555;

                MessageBox.Show("Customer First Name: " + firstName + "\nCustomers Last Name: " + lastName + "\nCustomer ID: " + custID);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the default constructor for the Customer class!" +
                "\nClass fields here are initialized by the displayCustomerInfo method." +
                "\nDefault values are: string = null, int = 0, double = 0.0");
            //Call the default Constructor.
            Customer Cust1 = new Customer();
            Cust1.displayCustomerInfo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee Emp = new Employee("Stephan", "Scott", 101, 33);

            Employee Emp1 = new Employee();

            Emp.displayEmployeeInfo();
            Emp1.displayEmployeeInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Calling the Constructor with 3 parameters.");
            //E1 object only calls the constructor wiht 3 parameters.
            Employee E1 = new Employee("Sarah", "Jones", 300);

            MessageBox.Show("Calling the Constructor with 1 parameter.");
            //Missing parameters will return default values.
            Employee E2 = new Employee("Matt");

            E1.displayEmployeeInfo();
            E2.displayEmployeeInfo();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is the default Constructor for the Employee class." + 
                "\nIt will initialize the class fields to the default values." +
                "\nDefault values are: string = null, int = 0, double = 0.0");

            Employee E = new Employee();
            E.displayEmployeeInfo();
        }
    }
}
