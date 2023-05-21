public abstract class Goal {

    private string _name;
    private string _description;
    private int _pointAmount;
    private bool _isComplete;

    public string Name { get => _name; set => _name = value; }
    public string Description { get => _description; set => _description = value; }
    public int PointAmount { get => _pointAmount; set => _pointAmount = value; }
    public bool IsComplete { get => _isComplete; set => _isComplete = value; }

    public Goal() {

    }

    public Goal(string name, string description, int pointAmount, bool isComplete) {
        _name = name;
        _description = description;
        _pointAmount = pointAmount;
        _isComplete = isComplete;
    }

    public abstract string GetGoal(bool forScreen);

    public abstract void CreateGoal();

    public abstract int RecordEvent();

    public void CompleteGoal() {
        _isComplete = true;
    }

    public int CalculatePoints() {
        return _pointAmount += _pointAmount;
  
    }
}