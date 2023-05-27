public class Errand : Task {

    private string _location;

    public string Location { get => _location; set => _location = value; }

    public Errand(string name, string description, bool isComplete, string location) : base(name, description, isComplete) {

    }

    public override void CompleteTask()
    {
        Console.WriteLine("Task Completed");
    }

    public override void NewTask()
    {
        Console.WriteLine("New Task created");
    }

    public override void ClearTask()
    {
        Console.WriteLine("Task Cleared");
    }
    
}