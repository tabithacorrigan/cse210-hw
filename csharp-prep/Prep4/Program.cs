using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished");

        int number = 0;
        int total = 0;
        int max = 0;
        int min = 1000;

        do
        {
            Console.Write("Enter number: ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);

            numbers.Add(number);

        } while (number != 0);

        foreach (int item in numbers)
        {
            if (item != 0)
            {
                total += item;

                if (item < min)
                {
                    min = item;
                }
                if (item > max)
                {
                    max = item;
                }
            }
            
        }

        float count = (numbers.Count) - 1;
        float average = total / count;

        Console.WriteLine(count);

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest number is: {min}");

    }
}