using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scott_Week11_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.scottDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scottDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.scottDataSet.Employee);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillByDepartment(this.scottDataSet.Employee);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.FillBySalary(this.scottDataSet.Employee);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double avgSalary;
            avgSalary = (double)this.employeeTableAdapter.AverageSalary();
            MessageBox.Show("The Average Salary is: " + avgSalary.ToString(), "Average Salary!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double minSalary;
            minSalary = (double)this.employeeTableAdapter.MinimumSalary();
            MessageBox.Show("The Minimum Salary is: " + minSalary.ToString(), "Minimum Salary!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double maxSalary;
            maxSalary = (double)this.employeeTableAdapter.MaximumSalary();
            MessageBox.Show("The Maximum Salary is: " + maxSalary.ToString(), "Maximum Salary!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.SearchLastName(this.scottDataSet.Employee, textBox1.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.employeeTableAdapter.Fill(this.scottDataSet.Employee);
        }
    }
}
