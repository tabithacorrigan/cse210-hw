public abstract class Task {
    
    private string _name;
    private string _description;
    private bool _isComplete;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public bool IsComplete { get => _isComplete; set => _isComplete = value; }

    public Task(string name, string description, bool isComplete) {
        
    }


    public abstract void CompleteTask();

    public abstract void NewTask();

    public abstract void ClearTask();
}