public class WritingAssignment : Assignment
{
    private string _title = "";

    //Constructor
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    //Method
    public string GetWritingInfo()
    {
        return $"{_title} by {_studentName}";
    }

}