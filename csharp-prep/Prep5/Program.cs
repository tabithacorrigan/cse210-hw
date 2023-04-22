using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int square = SquareNumber(number);
        DisplayResult(name, square);

        // Function definitions
        static string DisplayWelcome()
        {
            string welcome = ("Welcome to the program!");
            return welcome;
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string userNumber = Console.ReadLine();

            int number = int.Parse(userNumber);
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = (number * number);

            return square;
        }

        static void DisplayResult(string name, int number)
        {
            string squaredNumber = number.ToString();

            string message = ($"{name}, the square of your number is {squaredNumber}");

            Console.WriteLine(message);

        }


    }
}