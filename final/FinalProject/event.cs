public class Event : Task {

    private string _location;
    private string _time;

    public string Location { get => _location; set => _location = value; }
    public string Time { get => _time; set => _time = value; }

    public Event(string name, bool isComplete, string location, string time) : base(name, isComplete) {

    }

    public Event() {

    }

    public override void NewTask()
    {
        Console.WriteLine("What event are you attending? ");
        string name = Console.ReadLine();
        Console.WriteLine("What it the location for this event (school, work, etc)? ");
        string location = Console.ReadLine();
        Console.WriteLine("What time is the event? ");
        string time = Console.ReadLine();
        Console.WriteLine();

        this.Name = name;
        this.Location = location;
        this.Time = time;
        this.IsComplete = false;

    }

    public override string GetTask() {
        string retVal = "";

        string completedValue = this.IsComplete?"X":" ";
        retVal = ($"Event: {this.Name} ({this.Location} at {this.Time}) [{completedValue}]");


        return retVal;

    }


}