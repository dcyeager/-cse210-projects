using System;
using System.Dynamic;

class Program
{
    // Main program control
    static void Main(string[] args)
    {
        Display_Welcome();

        string Name = Get_User_Name();
        int Number = Get_Number();
        int numbered2 = Square(Number);

        Results(Name, numbered2);
        
    }
     // display the opening message
       static void Display_Welcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    // Get the individuals name
    static string Get_User_Name()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }
    // Get a number from the individual
    static int Get_Number()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }
    // Perform the desired equation.
    static int Square(int number)
    {
        
        return (int)Math.Pow(number,2);
    }
    // Display the desired results
    static void Results(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}