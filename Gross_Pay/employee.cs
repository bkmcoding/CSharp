using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gross_Pay
{
    public class Employee
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public float HWage { get; set; }
        public int HWorked { get; set; }
        public string Wage { get; set; }
        public string Overtime { get; set; }

        public bool CheckData(bool[] errors)
        {
            const string title = "Error";
            string message = string.Empty;
            bool error = false;
            string[] prompts = { "First Name", "Last Name", "Hours Worked value", "Hourly Wage value" };
            
            for (var i = 0; i < errors.Length; i++)
            {
                if (errors[i])
                {
                    error = true;
                    message += "Please enter a valid " + prompts[i] + ".\r\n";
                }
            }
            if (error)
            {
                MessageBox.Show(message, title);
                return false;
            } 
            return true;
        }

        public void GetData(string fname, string lname, float hourlyWage, int hoursWorked)
        {
            this.Fname = fname;
            this.Lname = lname;
            this.HWage = hourlyWage;
            this.HWorked = hoursWorked;
            CalculateWage();
        }

        public void CalculateWage()
        {
            decimal overtime = CalculateOvertime();
            Wage = $"{(overtime + (Convert.ToDecimal(HWage) * 40)):C}";
            Overtime = $"{overtime:C}";
        }

        public decimal CalculateOvertime()
        {
            if (HWorked > 40)
            {
                decimal hoursDiff = Math.Abs(HWorked - 40);
                return (Convert.ToDecimal(HWage) * (decimal)1.5 * hoursDiff);
            }
            else
            {
                return 0;
            }
        }
    }
}
