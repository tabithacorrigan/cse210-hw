public class JournalEntry
{
    private string _entry;
    private DateTime _entryDateTime;
    private string _entryPrompt;
    
    public string EntryPrompt { get => _entryPrompt; set => _entryPrompt = value; }
    public DateTime EntryDateTime { get => _entryDateTime; set => _entryDateTime = value; }
    public string Entry { get => _entry; set => _entry = value; }

    public JournalEntry()
    {
        
    }
}