using System;

class Program
{
    static void Main(string[] args)
    {
        bool go = true;
         
        do {
            Quote quote1 = new Quote();
            quote1.GetQuote();

            Console.WriteLine("Please select an option to continue:\n   1. Build To-Do list\n   2. Build Shopping List\n   3. Quit\n");
            string option = Console.ReadLine();
            
            switch (option) {
                case "1":
                    BuildToDO();
                    break;
                case "2":
                    BuildShopping();
                    break;
                case "3":
                    go = false;
                    break;
            }

        } while (go);
    }

    public static void BuildToDO() {
        Console.Clear();
        Console.WriteLine("Build TO DO");
    }

    public static void BuildShopping () {
        Console.Clear();
        Console.WriteLine("Build Shopping");
    }
}