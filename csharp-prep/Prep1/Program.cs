using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep1 World!");

        // Prompt user for thier first name
        Console.Write("What is your first name? ");
        string firstname = Console.ReadLine();
        // Prompt use for thier last name
        Console.Write("What is your last name? ");
        string lastname = Console.ReadLine();
        // Print the users full name
        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}.");
    }
}