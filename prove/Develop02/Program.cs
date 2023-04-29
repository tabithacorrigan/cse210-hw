using System;

class Program
{

    private static JournalEntries _journalEntries;

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to your Journal Program!");
        string _userOption = "";

        do
        {
            DisplayMenu();
            _userOption = Console.ReadLine();
            // _option = int.Parse(_userOption);

            switch (_userOption)
            {
                case "1": 
                    WriteEntry();
                    break;
                case "2":
                // check this
                    DisplayEntries();
                    break;
                case "3":
                    Console.Write("\nPlease enter a file name: ");
                    string fileName = Console.ReadLine();
                    _journalEntries.SaveEntries(fileName);
                    break;
                case "4":
                    Console.Write("\nPlease enter a file name: ");
                    string file = Console.ReadLine();
                    _journalEntries = JournalEntries.LoadEntries(file);
                    break;
                case "5":
                    Console.Write("This will clear the current entries. Would you like to proceed? (y/n): ");
                    string proceed = Console.ReadLine();
                    if (proceed == "y")
                    {
                        ClearEntries();
                        Console.WriteLine("Journal cleared\n");
                    }
                    break;
                case "6":
                    break;
                default:
                    Console.WriteLine("Please enter a number between 1 and 5");
                    break;
            }

        } while (_userOption != "6");
        
        // display menu function
        static void DisplayMenu()
        {
            string _menu = "\nPlease select option:\n1. Write\n2. Display\n3. Save\n4. Load\n5. Clear Entries\n6. Quit\n";
            Console.WriteLine(_menu);
        }

        static void WriteEntry()
        {
            JournalPrompts prompts = new JournalPrompts();

            string prompt = prompts.GetPrompt();
            DateTime dt = DateTime.Now;
            JournalEntry entry = new JournalEntry();
            
            entry.EntryPrompt = prompt;
            entry.EntryDateTime = dt;
            Console.WriteLine("Date: {0} - Prompt: {1}", dt, prompt);
            Console.Write("> ");
            entry.Entry = Console.ReadLine();


            if(_journalEntries == null)
            {
                ClearEntries();
            }

            _journalEntries.AddEntry(entry);

        }

        static void DisplayEntries()
        {
            foreach(JournalEntry je in _journalEntries.Entries)
            {
                Console.WriteLine("{0} - {1}",je.EntryDateTime,je.EntryPrompt);
                Console.WriteLine($"{je.Entry}\n");
            }
        }

        static void ClearEntries()
        {
            _journalEntries = new JournalEntries();
        }
    }
}