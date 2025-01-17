using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        //initialize variables
        List<int> numbers = new List<int>();
        int entry = -1;
        int sum = 0;
        
        // Print Instructions
        Console.Write("Enter a list of numbers, type 0 when finished.\n");
        
        // Gather numbers from the user
        while (entry != 0)
        {
            Console.Write("Enter number:");
            entry = int.Parse(Console.ReadLine());

            if (entry != 0)
            {
                numbers.Add(entry);
            }      
        }

        // Sum all the numbers
        foreach (int number in numbers)
        {
            sum += number;
        }
        
        // Print the sum of the list
        Console.WriteLine($"The sum is: {sum}");
        // Print the average of the list
        Console.WriteLine($"The average is: {(float)((float)sum) / numbers.Count}");
        
        // Get the highest value in the list
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }

        //Print the highest number in the list.
        Console.WriteLine($"The max is: {max}");
        
        // Get the lowest number greater than 0
        int minpositive = max;
        foreach (int number in numbers)
        {
            if (number < minpositive && number > 0)
            {
                minpositive = number;
            }
        }

        //Print the lowest number greater than 0
        Console.WriteLine($"The smallest positive number is: {minpositive}");
        
        // Sort and print the list
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}