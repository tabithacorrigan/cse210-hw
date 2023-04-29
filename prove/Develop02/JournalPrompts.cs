public class JournalPrompts
{
    // Prompt List

    private List<string> _prompts;

    public List<string> Prompts
    {
        get { return _prompts;}
    }

    public JournalPrompts()
    {
        _prompts = new List<string>();

        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What was the most 'Out of the Ordinary' thing that happened to me today?");
        _prompts.Add("How did I help those around me?");
        _prompts.Add("10 good things I loved about my life today:");
    }

    public string GetPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,_prompts.Count());

        return _prompts[number];
    }

}