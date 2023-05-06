public class ScriptureReference {

    private bool _includeEndVerse;
    private string _book;

    private string _chapter;

    private string _verse;

    private string _endVerse;

    public string Book { get => _book; }
    public string Chapter { get => _chapter; }
    public string Verse { get => _verse; }
    public string Endverse { get => _endVerse; }

    public ScriptureReference(string book, string chapter, string verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _includeEndVerse = false;
    }

    public ScriptureReference(string book, string chapter, string verse, string endVerse){
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
        _includeEndVerse = true;
    }

    public string GetReference() {
        string outString = _book + " " + _chapter + ":" + _verse;
        outString = outString + (_includeEndVerse ? "-" + _endVerse : "");

        return outString;
    } 

}