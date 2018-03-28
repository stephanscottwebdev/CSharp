using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week8_Project5
{
    public partial class Form1 : Form
    {
        //Creat struct, must be created outside of the Form Class
        struct Books
        {
            //Struct fields must be public
            public string title;
            public string author;
            public string subject;
            public int book_isbn;

            //Creat getValues method inside the books struct, it will have 4 values
            public void getValues(string t, string a, string s, int id)
            {
                title = t;
                author = a;
                subject = s;
                book_isbn = id;
            }

            //Create a display method
            public void display()
            {
                MessageBox.Show("Title: " + title +
                    "\nAuthor: " + author +
                    "\nSubject: " + subject +
                    "\nBook: " + book_isbn);
            }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Create an instance Book1 of struct Books
            Books Book1 = new Books();
            Books Book2 = new Books();

            //Create the variables from the Struct class
            string t, a, s; int id;

            //Storing input of textboxes in the variable.
            t = textBox1.Text;
            a = textBox2.Text;
            s = textBox3.Text;
            int.TryParse(textBox4.Text, out id);

            //Call the getValue method and passing the input of the textboxes as arguments to getValue method parameters
            Book1.getValues(t, a, s, id);
            //Or assign them directly
            Book2.getValues("How to Program with C#", "Dayoub", "C# Programming", 123456789);

            //Calling display method to  display values
            Book1.display();
            Book2.display();

        }
    }
}
