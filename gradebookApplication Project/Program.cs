using System;

namespace MyApplication
{
    static class gradebookApplication
    {
        /*public string name;
        public int gradeAmount;
        public int[] grades;
       
        public gradebookApplication()
        {
            name = string.Empty;
            gradeAmount = 0;
            grades = new int[gradeAmount - 1];
        }*/
        static string promptUserName()
        {
            string name = "";
            Console.WriteLine("What is your full name?");
            while (true)
            {
                bool error;
                try
                {
                    name = Console.ReadLine();
                    error = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a proper name.");
                    error = true;
                }
                if (!error)
                {
                    break;
                }
            }
            return name;
        }

        static int[] promptGrades()
        {
            int gradeAmount = 0;
            while (true)
            {
                bool error;
                try
                {
                    Console.WriteLine("How many grades would you like to average out?");
                    gradeAmount = Convert.ToInt16(Console.ReadLine());
                    error = false;
                }
                catch
                {
                    Console.WriteLine("Please insert a valid number");
                    error = true;
                }
                if (!error)
                {
                    break;
                }
            }
            int[] grades = new int[gradeAmount];
            int i = 0;
            do
            {
                bool error;
                try
                {
                    Console.WriteLine($"What would you like input for grade {i + 1}?");
                    grades[i] = Convert.ToInt32(Console.ReadLine());
                    error = false;
                }
                catch
                {
                    Console.WriteLine("Please insert a valid number grade");
                    error = true;
                }
                if (!error)
                {
                    i++;
                }
            }
            while (i < gradeAmount);
            return grades;

        }

        static float CalcAvg(int[] grades)
        {
            return grades.Sum() / grades.Length;
        }

        static string CalcLetterGrade(float numGrade)
        {
            string letterGrade = "F";
            if (numGrade >= 90)
            {
                letterGrade = "A";
            } else if (numGrade >= 80)
            {
                letterGrade = "B";
            } else if (numGrade >= 70)
            {
                letterGrade = "C";
            } else if (numGrade >= 60)
            {
                letterGrade = "D";
            }
            return letterGrade;
        }

        static void DisplayData(string name, int[] grades, float numGrade, string letterGrade)
        {
            Console.WriteLine("Name: " + name);
            Console.Write("Grades: ");
            for (int i = 0; i < grades.Length; i++)
                Console.Write(grades[i] + ", ");
            Console.WriteLine();
            Console.WriteLine("Final Grade: " + numGrade);
            Console.WriteLine("Letter Grade: " + letterGrade);
        }

        static void Main(string[] args)
        {
            string name = promptUserName();
            int[] grades = promptGrades();
            float numGrade = CalcAvg(grades);
            string letterGrade = CalcLetterGrade(numGrade);
            DisplayData(name, grades, numGrade, letterGrade);
        }
        }
    }

   