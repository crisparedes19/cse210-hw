using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("\nWhat is your grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
    
        string letter = "";
        string message = "";
        float lastDigit = grade % 10;
        string sign = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            message = "Congrats!, you passed the course.";
        }
        else
        {
            message = "Sadly you couldn't pass the course.";
        }
        // Strech part
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (letter == "A" && sign == "+" || letter == "F")
        {
            sign = "";
        }
        // Output part
        Console.WriteLine($"You've got a {letter}{sign}");
        Console.WriteLine(message);

    }
}