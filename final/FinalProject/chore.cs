public class Chore : Task {
    
    public Chore(string name, bool isComplete) : base(name, isComplete) {

    }

    public Chore() {

    }

    public override void NewTask()
    {
        Console.WriteLine("What chore needs completed? ");
        string name = Console.ReadLine();
        Console.WriteLine();

        this.Name = name;
        this.IsComplete = false;

    }

    public override string GetTask() {
        string retVal = "";

        string completedValue = this.IsComplete?"X":" ";
        retVal = ($"Chore: {this.Name} [{completedValue}]");


        return retVal;

    }



}