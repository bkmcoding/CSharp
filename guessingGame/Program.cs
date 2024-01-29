using System;

static class higherOrLower
{
    static void Main()
    {
        Random rnd = new Random();
        int userInput = 0;
        int randomNum = rnd.Next(0, 100);
        bool correctGuess = false;
        bool error = false;

        Console.WriteLine("Guess the correct number to win!");
        Console.WriteLine(" Pick a whole number between 1 and 100.");


        while (correctGuess != true)
        {
            try
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.WriteLine("please input a whole number between 1 and 100");
                error = true;
            }
            finally
            {
                if (error != true)
                {
                    if (userInput == randomNum)
                    {
                        correctGuess = true;
                    }
                    else if (userInput > randomNum)
                    {
                        Console.WriteLine("Guess a lower number");
                    }
                    else if (userInput < randomNum)
                    {
                        Console.WriteLine("Guess a higher number");
                    }
                }
            }
       
        }
        Console.WriteLine("You guessed the correct number!");
        Console.WriteLine("You win!");
    }
}