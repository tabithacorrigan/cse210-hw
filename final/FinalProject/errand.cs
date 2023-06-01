public class Errand : Task {

    private string _location;

    public string Location { get => _location; set => _location = value; }

    public Errand(string name, bool isComplete, string location) : base(name, isComplete) {

    }

    public Errand() {

    }

    public override void NewTask()
    {
        Console.WriteLine("What errand needs ran? ");
        string name = Console.ReadLine();
        Console.WriteLine("What it the location for this task (school, work, etc)? ");
        string location = Console.ReadLine();
        Console.WriteLine();

        this.Name = name;
        this.Location = location;
        this.IsComplete = false;

    }

    public override string GetTask() {
        string retVal = "";

        string completedValue = this.IsComplete?"X":" ";
        retVal = ($"Errand: {this.Name} ({this.Location}) [{completedValue}]");


        return retVal;

    }


    
}