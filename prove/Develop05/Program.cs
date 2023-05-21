using System;
using System.IO;

class Program
{
    public static List<Goal> goals;
    public static int points;
    static void Main(string[] args)
    {
        bool choice = true;
        goals = new List<Goal>();
        points = 0;

        do {
            Console.WriteLine($"You have {points} points.\n");
            Console.WriteLine("\nMenu Options:\n   1. Create New Goal\n   2. List Goals\n   3. Save Goals\n   4. Load Goals\n   5. Record Event\n   6. Quit");
            Console.Write("Select a choice from the menu: ");
            string input = Console.ReadLine();
            switch (input) {
                case "1":
                    DetermineGoal();
                    break;
                
                case "2":
                    ListGoals();
                    break;
                
                case "3":
                    SaveGoals();
                    break;

                case "4":
                    LoadGoals();
                    break;

                case "5":
                    AccomplishGoal();
                    break;
                
                case "6":
                    choice = false;
                    break;
            
                }
        } while (choice != false);
        
    } 

    static void DetermineGoal() {

        Console.WriteLine("\nThe types of goals are:\n    1. Simple Goal\n    2. Eternal Goal\n    3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string input = Console.ReadLine();
        switch (input) {
            case "1":
                Simple simple1 = new Simple();
                simple1.CreateGoal();
                goals.Add(simple1);
                break;
            case "2":
                Eternal eternal1 = new Eternal();
                eternal1.CreateGoal();
                goals.Add(eternal1);
                break;
            case "3":
                Checklist checklist1 = new Checklist();
                checklist1.CreateGoal();
                goals.Add(checklist1);
                break;

        }
        Console.WriteLine($"New goal created!");        
        RunSpinner();
        Console.Clear();
    }

    static void ListGoals() {
        int i = 1;
        foreach (Goal goal in goals) {
            Console.WriteLine($"{i}. {goal.GetGoal(true)}");
            i ++;
        }
        
    }

    static void SaveGoals() {
        Console.WriteLine("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName)) {
            outputFile.WriteLine(points);
            foreach (Goal goal in goals) {
                outputFile.WriteLine(goal.GetGoal(false));
            }
        }
        Console.WriteLine($"Everything has been saved to {fileName}!");        
        RunSpinner();
        Console.Clear();
  
    }

    static void LoadGoals() {
        Console.WriteLine("What is the file name for the goal file? ");
        string fileName = Console.ReadLine();

        bool pointsRead = false;

        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines) {
            
            if (!pointsRead){
                points = int.Parse(line);
                pointsRead = true;
            }

            string[] parts = line.Split("~");

            string type = parts[0];
            switch (type) { 
                case "SimpleGoal":
                    Simple sGoal = new Simple(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    goals.Add(sGoal);
                    break;
                case "ChecklistGoal":
                    Checklist cGoal = new Checklist(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7]));
                    goals.Add(cGoal);
                    break;
                case "EternalGoal":
                    Eternal eGoal = new Eternal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]));
                    goals.Add(eGoal);
                    break;
            }
        }
        Console.WriteLine($"Everything has been loaded from {fileName}!");        
        RunSpinner();
        Console.Clear();
    }

    static void AccomplishGoal() {
        Console.WriteLine("Here are your goals: ");
        ListGoals();
        Console.WriteLine("Which goal did you accomplish? ");
        string index = Console.ReadLine();

        Goal currentGoal = goals[int.Parse(index) - 1];
        int pointVal = currentGoal.RecordEvent();
        points += pointVal;

        Console.WriteLine($"Congradulations! You have earned {pointVal} points!");
        Console.WriteLine($"You now have {points} points.\n");
        RunSpinner();
        Console.Clear();
    }

    static void RunSpinner() {

        char[] characterArray = {'|', '/', '-', '\\', '|', '/', '-', '\\', '|'};

        foreach (char character in characterArray) {
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b \b");

        }

    }

}