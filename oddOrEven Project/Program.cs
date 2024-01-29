using System;

    // Calculates the odd or even of a given number by the user
    class oddOrEven
    {
        static void Main(string[] args)
        {
            bool run = true;
            long userInput = 0;
            bool errors = false;
            Console.WriteLine("Please enter a whole number: ");
            while (run)
            {
                try
                {
                    userInput = Convert.ToInt32(Console.ReadLine());
                    errors = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter a valid number");
                    errors = true;
                }
                finally
                {
                    if (errors == false)
                        run = false;
                }
            }
                if (userInput % 2 == 0)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine("Odd");
                }            
        }
    }





