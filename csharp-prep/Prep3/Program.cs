using System;

class Program
{
    static void Main(string[] args)
    {
        // Generate Random Number between 1 and 50
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 50);

        // Intialize the guess below the the lowest possible number
        int guess = 0;
        int count = 0;
        
        //Loop until the number is entered.
        while (guess != magicNumber)
        {
                // Ask for the Magic Number guess
                Console.Write("What is your guess?");
                //Get the response.
                guess = int.Parse(Console.ReadLine());
                count += 1;

                // Check the answer against the random number
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {count} guesses.");
                }
        }
    }
}