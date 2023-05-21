public class Checklist : Goal {

    private int _timesCompleted;
    private int _timesNeeded;
    private int _bonusPointAmount;

    public int TimesCompleted { get => _timesCompleted; set => _timesCompleted = value; }
    public int BonusPointAmount { get => _bonusPointAmount; set => _bonusPointAmount = value; }
    public int TimesNeeded { get => _timesNeeded; set => _timesNeeded = value; }

    public Checklist() {
        
    }

   
    public Checklist(string name, string description, int pointAmount, bool isComplete, int timesCompleted, int timesNeeded, int bonusPointAmount) : base(name, description, pointAmount, isComplete) {
        _timesCompleted = timesCompleted;
        _bonusPointAmount = bonusPointAmount;
        _timesNeeded = timesNeeded;
    }

    public override string GetGoal(bool forScreen)
    {
        string retVal = "";

        if (forScreen) {
            string completedValue = this.IsComplete?"X":" ";
            retVal = ($"[{completedValue}] {this.Name} ({this.Description}) -- Completed {this._timesCompleted}/{this._timesNeeded}");
        }
        else {
            retVal = ($"ChecklistGoal~{this.Name}~{this.Description}~{this.PointAmount}~{this.IsComplete}~{this._timesCompleted}~{this._timesNeeded}~{this.BonusPointAmount}");
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
        int points = int.Parse(Console.ReadLine());
        Console.WriteLine("How many bonus points will this goal be worth? ");
        int bonusPoints = int.Parse(Console.ReadLine());
        Console.WriteLine("How many times does this goal need to be accomplished for the bonus? ");
        int completeVal = int.Parse(Console.ReadLine());



        this.Name = name;
        this.Description = description;
        this.PointAmount = points;
        this.BonusPointAmount = bonusPoints;
        this.TimesNeeded = completeVal;
        this.TimesCompleted = 0;
        this.IsComplete = false;

    }

    public override int RecordEvent()
    {
        int retVal = 0;
        this.TimesCompleted ++;

        if (TimesCompleted == TimesNeeded) {
            this.IsComplete = true;
            retVal = this.PointAmount + this.BonusPointAmount;

        } else {
            retVal = this.PointAmount;
        }

        return retVal;

    }
}