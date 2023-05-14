using System;

class Program
{
    static void Main(string[] args)
    {

        bool choice = true;

        do {
            Console.WriteLine("\nMenu Options:\n   1. Start breathing activity\n   2. Start reflection activity\n   3. Start listing activity\n   4. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            switch (input) {
                case "1":
                    RunBreathing();
                    break;
                
                case "2":
                    RunReflection();
                    break;
                
                case "3":
                    RunListing();
                    break;
                
                case "4":
                    choice = false;
                    break;
            }


        } while (choice != false);

        // FUNCTIONS
    }
   
    static void RunBreathing() {

        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing\n\n");
        
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        int duration = Activity.GetDuration(time);
        
        DateTime startTime = DateTime.Now;
        DateTime doneTime = startTime.AddMilliseconds(duration);


        DateTime currentTime = DateTime.Now;

        do {
            Console.Write("Breathe in...");
            RunTimer(5);
            Console.WriteLine();
            Console.Write("Breathe out...");
            RunTimer(5);
            currentTime = DateTime.Now;

        } while (currentTime < doneTime); 

        Console.WriteLine("\nGreat Job");
        RunSpinner();
        Console.Clear();
    }

    static void RunReflection(){

        Console.Clear();
        Console.WriteLine("Welcome to the Reflection Activity\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n\n");
        
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        int duration = Activity.GetDuration(time);

        Console.Clear();
        Console.Write("Get ready...");
        RunSpinner();
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:\n ");

        List<string> prompts = new List<string> {

            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless",
        };

        List<string> questions = new List<string> {

            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?",
        };

        Random promptGenerator = new Random();
        int number = promptGenerator.Next(0,prompts.Count());
        string prompt = prompts[number];
        Console.WriteLine($"-----{prompt}-----\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string proceed = Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they relate to this expirience.");
        Console.Write("You may begin in: ");
        RunTimer(5);
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime doneTime = startTime.AddMilliseconds(duration);


        DateTime currentTime = DateTime.Now;
        
        do {
            Random questionGenerator = new Random();
            int i = questionGenerator.Next(0,questions.Count());
            string question = questions[i];
            Console.WriteLine($"> {question} ");
            RunSpinner();
            currentTime = DateTime.Now;
        } while (currentTime < doneTime);
        
        Console.WriteLine($"\nGood job! You completed another {time} seconds of the Reflection Activity! Hit enter to go back to the menu.");
        string enter = Console.ReadLine();
        Console.Clear();
    }

    static void RunListing() {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n\n");
        
        Console.Write("How long, in seconds, would you like for your session? ");
        string time = Console.ReadLine();
        int duration = Activity.GetDuration(time);

        Console.Clear();
        Console.Write("Get ready...");
        RunSpinner();
        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:\n ");

        List<string> prompts = new List<string> {

            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?",
        };

        Random promptGenerator = new Random();
        int number = promptGenerator.Next(0,prompts.Count());
        string prompt = prompts[number];
        Console.WriteLine($"-----{prompt}-----\n");
        Console.Write("You may begin in: ");
        RunTimer(5);
        Console.WriteLine();
        

        DateTime startTime = DateTime.Now;
        DateTime doneTime = startTime.AddMilliseconds(duration);


        DateTime currentTime = DateTime.Now;

        int responses = 0;

        do {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses = responses + 1;
            currentTime = DateTime.Now;
        } while (currentTime < doneTime);

        Console.WriteLine($"Well Done! You listed {responses} items!");
        RunSpinner();

    }

    static void RunSpinner() {

        char[] characterArray = {'|', '/', '-', '\\', '|', '/', '-', '\\', '|'};

        foreach (char character in characterArray) {
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b \b");

        }

    }

    static void RunTimer(int time) {
    
        for (int i = time; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
    }

}