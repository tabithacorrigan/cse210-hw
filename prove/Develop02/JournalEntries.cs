using System.IO;

public class JournalEntries
{
    
    private List<JournalEntry> _entries;

    private string _fileName;

    public JournalEntries()
    {
        _entries = new List<JournalEntry>();
        
    }

    public List<JournalEntry> Entries { get => _entries; }
    public string FileName { get => _fileName;}

    public void AddEntry(JournalEntry entry)
    {
        Entries.Insert(0, entry);
    }

    public void SaveEntries(string fileName)
    {
        // when I save entries in a file, it prints "JournalENtry" to the file instead of the entry
        string file = fileName;
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (JournalEntry entry in Entries)
            {
                outputFile.WriteLine($"{entry.EntryDateTime}~{entry.EntryPrompt}~{entry.Entry}");
            }

        }    
    }

    public static JournalEntries LoadEntries(string fileName)
    {
        
        JournalEntries entries = new JournalEntries();

        //string[] lines = System.IO.File.ReadAllLines(fileName);
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~");

            JournalEntry entry = new JournalEntry();

            DateTime dt = DateTime.Parse(parts[0]);

            entry.EntryDateTime = dt;
            entry.EntryPrompt = parts[1];
            entry.Entry = parts[2];

            entries.AddEntry(entry);
        }

        return entries;
                
        

    }    
}


