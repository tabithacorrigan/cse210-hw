using System;

class Program
{
    static void Main(string[] args)
    {

    // TESTING GetFraction()
        // Fraction f1 = new Fraction();
        // Fraction f2 = new Fraction(5);
        // Fraction f3 = new Fraction(3,4);

        // Console.WriteLine(f1.GetFraction());
        // Console.WriteLine(f2.GetFraction());
        // Console.WriteLine(f3.GetFraction());


    // TESTING THE GETTERS AND SETTERS
        // Fraction f = new Fraction(1,5);
        // Console.WriteLine($"Original: {f.GetFraction()}\n");

        // f.SetTop(2);
        // Console.WriteLine("Top Set to 2");
        // Console.WriteLine($"Verify: {f.GetTop()}\n");

        // f.SetBottom(6);
        // Console.WriteLine("Bottom set to 6");
        // Console.WriteLine($"Verify: {f.GetBottom()}\n");

        // Console.WriteLine($"Final: {f.GetFraction()}");

    // TESTING THE GetFractionSting() AND GetDecimalValue()
        Fraction f = new Fraction(1,3);

        Console.WriteLine(f.GetFractionString());
        Console.WriteLine(f.GetDecimalValue());

    }
}