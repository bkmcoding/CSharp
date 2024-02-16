using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Gross_Pay
{
    public partial class addEmployees : UserControl
    {
        public List<object> EmployeeList = new List<object>();

        public addEmployees()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        { 
            Employee emp = new Employee();
            string fName = String.Empty;
            string lName = String.Empty;
            float hWage = 0;
            int hWorked = 0;
            bool[] errors = { false, false, false, false };
            try
            {
                fName = firstName.Text;
                if (fName?.Length == 0)
                {
                    errors[0] = true;
                }
            }
            catch (Exception)
            {
                errors[0] = true;
            }
            try
            {
                lName = lastName.Text;
                if (lName?.Length == 0)
                {
                    errors[1] = true;
                }
            }
            catch (Exception)
            {
                errors[1] = true;
            }
            try
            {
                hWage = Convert.ToSingle(hourlyWage.Text);
            }
            catch (Exception)
            {
                errors[2] = true;
            }
            try
            {
                hWorked = Convert.ToInt32(hoursWorked.Text);
            }
            catch (Exception)
            {
                errors[3] = true;
            }

            if (emp.CheckData(errors))
            {
                emp.GetData(fName, lName, hWage, hWorked);
                EmployeeList.Add(emp);
                firstName.Text = "";
                lastName.Text = "";
                hourlyWage.Text = "";
                hoursWorked.Text = "";
            }
        }
    }
}
