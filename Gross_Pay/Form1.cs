using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Gross_Pay
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            addEmployees1.Hide();
            viewEmployees1.Hide();
        }

        private void addEmployees_Click(object sender, EventArgs e)
        {
            addEmployees1.Show();
            
        }

        private void viewEmployees_Click(object sender, EventArgs e)
        {
            viewEmployees1.Show();
            viewEmployees1.UpdateView(addEmployees1.EmployeeList);
        }
    }
}
