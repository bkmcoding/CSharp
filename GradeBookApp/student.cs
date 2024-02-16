using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBookApp
{
    class Student
    {
        public string Fname;
        public string Lname;
        public double[] Grades;
        public double Avg { get; set; }
        public string Grade { get; set; }

        public Student(string fname, string lname, double[] grades)
        {
            Fname = fname;
            Lname = lname;
            Grades = grades;
            CalculateAvg();
            SetGrade();
        }

        private void CalculateAvg()
        {
            Avg = (Grades.Sum()) / 3;
        }

        private void SetGrade()
        {
            if (Avg >= 90)
            {
                Grade = "A";
            } else if(Avg >= 80)
            {
                Grade = "B";
            } else if(Avg >= 70)
            {
                Grade = "C";
            } else if (Avg >= 60)
            {
                Grade = "D";
            }
            else
            {
                Grade = "F";
            }
        }
    }
}
