using System;
using System.Collections.Generic;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        int newNumber = -1;

        while (newNumber != 0)
        {
            Console.Write("Enter a number: ");
            string inputNumber = Console.ReadLine();
            newNumber = int.Parse(inputNumber);
            if (newNumber != 0)
            {
                numbers.Add(newNumber);
            } 
        }

        foreach (int number in numbers)
        {
            newNumber += number;
        }

        int largest = numbers[0];

        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

        int smallestPositive = 999999999;

        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        float average = ((float)newNumber) / numbers.Count;

        Console.WriteLine($"The sum is: {newNumber}");
        Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
    }
}