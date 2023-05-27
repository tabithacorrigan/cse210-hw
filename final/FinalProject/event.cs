public class Event : Task {

    private string _location;
    private string _time;

    public string Location { get => _location; set => _location = value; }
    public string Time { get => _time; set => _time = value; }

     public Event(string name, string description, bool isComplete, string location, string time) : base(name, description, isComplete) {

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