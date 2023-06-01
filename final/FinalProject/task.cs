public abstract class Task {
    
    private string _name;
    private bool _isComplete;

    public string Name { get => _name; set => _name = value; }
    public bool IsComplete { get => _isComplete; set => _isComplete = value; }


    public Task(string name, bool isComplete) {
        
    }

    public Task() {

    }


    public void CompleteTask(){
        IsComplete = true;
    }

    public abstract void NewTask();

    public abstract string GetTask();


}