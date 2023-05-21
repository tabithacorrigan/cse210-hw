public class Simple : Goal {

    public Simple() {

    }
    public Simple(string name, string description, int pointAmount, bool isComplete) : base(name, description, pointAmount, isComplete) {
        
    }

    public override string GetGoal(bool forScreen)
    {
        string retVal = "";

        if (forScreen) {
            string completedValue = this.IsComplete?"X":" ";
            retVal = ($"[{completedValue}] {this.Name} ({this.Description})");
        }
        else {
            retVal = ($"SimpleGoal~{this.Name}~{this.Description}~{this.PointAmount}~{this.IsComplete}");
        }

        return retVal;

    }
     public override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal? ");
        string name = Console.ReadLine();
        Console.WriteLine("Please give a short description of your goal: ");
        string description = Console.ReadLine();
        Console.WriteLine("How many points will this goal be worth? ");
        string sPoints = Console.ReadLine();
        int points = int.Parse(sPoints);

        this.Name = name;
        this.Description = description;
        this.PointAmount = points;
        this.IsComplete = false;

    }

    public override int RecordEvent()
    {
        this.IsComplete = true;
        return this.PointAmount;
    }
}