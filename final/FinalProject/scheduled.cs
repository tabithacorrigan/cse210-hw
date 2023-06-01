public class Scheduled : Task {

    private string _location;
    private string _time;

    public string Location { get => _location; set => _location = value; }
    public string Time { get => _time; set => _time = value; }

    public Scheduled(string name, bool isComplete, string location, string time) : base(name, isComplete) {

    }

    public Scheduled() {

    }

    public override void NewTask()
    {
        Console.WriteLine("What is the name of your scheduled task? ");
        string name = Console.ReadLine();
        Console.WriteLine("What it the location for this task (school, work, etc)? ");
        string location = Console.ReadLine();
        Console.WriteLine("What time do you need this task completed? ");
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
        retVal = ($"Scheduled: {this.Name} ({this.Location} at {this.Time}) [{completedValue}]");


        return retVal;

    }

}