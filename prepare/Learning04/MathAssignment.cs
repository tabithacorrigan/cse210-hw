public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    //Constructor
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems;
    }

    //Methods
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}
