using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage: ");
        string userGrade = Console.ReadLine();

        int grade = int.Parse(userGrade);
        string letter = "A";

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
            Console.WriteLine($"Congradulations! You are passing your class! You have a {letter}!");
        }
        else 
        {
            Console.WriteLine($"You have an {letter}, so you aren't passing... You can do it!");
        }
    }
}