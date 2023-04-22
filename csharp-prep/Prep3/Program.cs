using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        string userGuess = "0";
        int guess = 0;
        
        do
        {
            Console.Write("What is your guess? ");
            userGuess = Console.ReadLine();

            guess = int.Parse(userGuess);

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magicNumber);

    }
}