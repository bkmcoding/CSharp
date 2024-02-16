using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeBookApp
{
    public partial class Form1 : Form
    {
        public List<object> Students = new List<object>();
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string fName = null;
            string lName = null;
            double[] grades = {0,0,0};
            bool[] errors = { false, false, false, false, false };
            string[] errorText = {"First Name", "Last Name", "Grade 1", "Grade 2", "Grade 3"};
            string errorStatement = "";
            const string userInputError = "User Input Error";
            try
            {
                fName = fNameInput.Text;
            }
            catch (Exception)
            {
                errors[0] = true;
            }
            try
            {
                lName = lNameInput.Text;
            }
            catch (Exception)
            {
                errors[1] = true;
            }
            try
            {
                grades[0] = Convert.ToDouble(grade1Input.Text);
            }
            catch (Exception)
            {
                errors[2] = true;
            }
            try
            {
                grades[1] = Convert.ToDouble(grade2Input.Text);
            }
            catch (Exception)
            {
                errors[3] = true;
            }
            try
            {
                grades[2] = Convert.ToSingle(grade3Input.Text);
            }
            catch (Exception)
            {
                errors[4] = true;
            }
            for (int i = 0; i < errors.Length; i++)
            {
                if (errors[i])
                {
                    errorStatement += $"Please enter a proper value for {errorText[i]} \n";
                }
            }

            if (errorStatement != "")
            {
                MessageBox.Show(errorStatement, userInputError);
            }
            else
            {
                Students.Add(new Student(fName, lName, grades));
                fNameInput.Text = "";
                lNameInput.Text = "";
                grade1Input.Text = "";
                grade2Input.Text = "";
                grade3Input.Text = "";
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
          
            dataTable.Rows.Clear();
            Console.WriteLine(Students[0]);
            int i = 0;
            foreach (Student student  in Students )
            { 
                dataTable.Rows.Add();
                dataTable.Rows[i].Cells[0].Value = student.Fname + " " + student.Lname;
                dataTable.Rows[i].Cells[1].Value = student.Avg;
                dataTable.Rows[i].Cells[2].Value = student.Grade;
                i++;
            }
        }

        private void dataTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in dataTable.SelectedRows)
        {
            dataTable.RowsDefaultCellStyle.SelectionBackColor = row.DefaultCellStyle.BackColor;
        }
        }
    }
}
