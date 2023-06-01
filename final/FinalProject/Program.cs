using System;

class Program
{
    public static List<Task> tasks;
    public static List<Shopping> items;
    static void Main(string[] args)
    {
        bool go = true;
        tasks = new List<Task>();
        items = new List<Shopping>();
         
        do {
            Console.Clear();
            Quote quote1 = new Quote();
            quote1.GetQuote();

            Console.WriteLine("\nPlease select an option to continue:\n   1. Build To-Do list\n   2. Build Shopping List\n   3. Display/Edit To-Do List\n   4. Display/Edit Shopping List\n   5. Quit\n");
            string option = Console.ReadLine();
            
            switch (option) {
                case "1":
                    BuildToDO();
                    break;
                case "2":
                    BuildShopping();
                    break;
                case "3":
                    ProcessToDo();
                    break;
                case "4":
                    ProcessShopping();
                    break;
                case "5":
                    go = false;
                    break;
            }

        } while (go);
    }

    public static void BuildToDO() {
        Console.Clear();
        bool go = true;

        do {
            Console.WriteLine("1. Scheduled task\n2. Chore\n3. Errand\n4. Event\n5. Return to Menu\n");
            Console.Write("Which type of task would you like to create? ");
            string choice = Console.ReadLine();

            switch(choice) {
                case "1":
                    Scheduled sched1 = new Scheduled();
                    sched1.NewTask();
                    tasks.Add(sched1);
                    break;
                case "2":
                    Chore chore1 = new Chore();
                    chore1.NewTask();
                    tasks.Add(chore1);
                    break;
                case "3":
                    Errand errand1 = new Errand();
                    errand1.NewTask();
                    tasks.Add(errand1);
                    break;
                case "4":
                    Event event1 = new Event();
                    event1.NewTask();
                    tasks.Add(event1);
                    break;
                case "5":
                    go = false;
                    break;
            }

        } while (go);

    }

    public static void BuildShopping () {
        Console.Clear();
        bool go = true;

        Console.WriteLine("List off the items needed from the store, or enter 'q' to end:\n");

        do {
            Console.Write("> ");
            string name = Console.ReadLine();
            if (name != "q") {

                Shopping item1 = new Shopping(name, false);
                items.Add(item1);

            } else {
                go = false;
            }

        } while (go);

    }

    public static void ProcessToDo() {

        bool go = true;
        
        do {

            Console.Clear();
            int i = 0;

            foreach (Task task in tasks) {
                Console.WriteLine($"{i + 1}. {task.GetTask()}");
                i++;
            }

            Console.Write("\nPlease select a task to complete (or hit 'q' to quit): ");
            string choice = Console.ReadLine();
            
            if (choice != "q") {
                Task currentTask = tasks[int.Parse(choice) - 1];
                currentTask.CompleteTask();

            } else {
                go = false;
            }
            
        } while(go);

    }

    public static void ProcessShopping() {
        bool go = true;
        
        do {

            Console.Clear();
            int i = 0;

            foreach (Shopping item in items) {
                Console.WriteLine($"{i + 1}. {item.GetItem()}");
                i++;
            }

            Console.Write("\nWhich items have been purchased(or hit 'q' to quit): ");
            string choice = Console.ReadLine();
            
            if (choice != "q") {
                Shopping currentItem = items[int.Parse(choice) - 1];
                currentItem.PurchaseItem();

            } else {
                go = false;
            }
            
        } while(go);


    }


}