public class Chore : Task {
    
    public Chore(string name, string description, bool isComplete) : base(name, description, isComplete) {

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