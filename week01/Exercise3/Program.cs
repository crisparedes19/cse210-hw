using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine("\nWelcome to the Guess My nmber game!");

        

        string repeat = "yes";

        do
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100);
            int guessCount = 0;
            int guess = -1;

            while (guess != number)
            {
                Console.Write("What is your guess? ");
                string userInput = Console.ReadLine();
                guess = int.Parse(userInput);
                guessCount += 1;

                if (guess < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                } 
            }

            Console.WriteLine($"It took you {guessCount} times.");

            Console.Write("Would you like to play again? (Yes/No) ");
            repeat = Console.ReadLine().ToLower();
        } while (repeat == "yes");
    } 
}