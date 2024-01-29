

namespace General
{
    class Program
    {
        public List<object> Employees = new List<object>();

        public void Menu()
        {
            
            while (true)
            {
                int answer = 0;
                bool error = false;
                try
                {
                    Console.WriteLine("");
                    Console.WriteLine("What would you like to do?");
                    Console.WriteLine("1. Add a new employee");
                    Console.WriteLine("2. View current employees");
                    Console.WriteLine("3. Exit the program");
                    answer = Convert.ToInt16(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please choose one of the listed options");
                    error = true;
                }
                if (!error)
                {
                    if (answer == 1)
                    {
                        AddEmployees();
                    }
                    else if (answer == 2)
                    {
                        Console.WriteLine(Employees);
                        if (Employees != null)
                        {
                            Console.Clear();
                            for (int i = 0; i < Employees.Count; i++)
                            {
                                Employee employee = (Employee)Employees[i];
                                Console.WriteLine("");
                                DisplayEmployeeData(employee);
                            }
                        }
                        else
                        {
                            Console.WriteLine("There are no employees in the system to view");
                        }
                    }
                    else if (answer == 3)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please choose one of the listed options");
                    }
                }
            }
        }

        public void AddEmployees()
        {
            int answer = 0;
            Console.Clear();
            Console.WriteLine("How many employees would you like to add?");
            while (true)
            {
                bool error = false;
                try
                {
                    answer = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please insert a correct value");
                    error = true;
                }
                if (!error)
                {
                    break;
                }
            }
            for (int i = 0; i < answer; i++)
            {
                Employee employee = new Employee();
                employee.Update();
                Console.WriteLine(employee.FirstName);
                Employees.Add(employee);
                Console.Clear();
            }
        }


        
        static void DisplayEmployeeData(Employee employee)
        {
            Console.WriteLine("First Name:" + employee.FirstName);
            Console.WriteLine("Last Name:" + employee.LastName);
            Console.WriteLine("Hourly Pay:" + employee.HourlyPay);
            Console.WriteLine("Hours Worked:" + employee.HoursWorked);
            Console.WriteLine("Wage: " + employee.Wage);
            Console.WriteLine("Overtime: " + employee.Overtime);
        }
        
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Menu();
        }
    }
    class Employee
    {
        public string? FirstName { get; set; } = null;
        public string? LastName { get; set; } = null;
        public double HourlyPay { get; set; }
        public int HoursWorked { get; set; }
        public double Wage { get; set; }
        public double Overtime { get; set; }


        public void getData()
        {
            Console.WriteLine("Enter the first name");
            while (true)
            {
                bool error = false;
                try
                {
                    this.FirstName = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a proper first name");
                    error = true;
                }
                if (!error)
                {
                    break;
                }

            }
            Console.WriteLine("Enter the last name");
            while (true)
            {
                bool error = false;
                try
                {
                    LastName = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a proper last name");
                    error = true;
                }
                if (!error)
                {
                    break;
                }
            }
            Console.WriteLine("Enter the hourly wage");
            while (true)
            {
                bool error = false;
                try
                {
                    HourlyPay = Convert.ToDouble(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a proper hourly wage");
                    error = true;
                }
                if (!error)
                {
                    break;
                }
            }
            Console.WriteLine("Enter the hours worked");
            while (true)
            {
                bool error = false;
                try
                {
                    HoursWorked = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a proper value for hours worked");
                    error = true;
                }
                if (!error)
                {
                    break;
                }
            }
        }

        public void CalculateWage()
        {
            if (this.HoursWorked > 40)
            {
                int hoursDiff = this.HoursWorked - 40;
                this.Wage = (this.HourlyPay * 1.5 * hoursDiff) + (this.HourlyPay * 40);
            }
            else
            {
                this.Wage = this.HourlyPay * this.HoursWorked;
            }
        }

        public void CalculateOvertime()
        {
            if (this.HoursWorked > 40)
            {
                int hoursDiff = Math.Abs(this.HoursWorked - 40);
                this.Overtime = this.Wage * 1.5 * hoursDiff;
            }
           
        }

        public void Update()
        {
            getData();
            CalculateWage();
            CalculateOvertime();
        }
    }
}