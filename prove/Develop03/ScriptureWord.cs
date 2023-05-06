public class ScriptureWord {

    private string _word;

    private bool _isVisible;

    public string Word { get => _word; }

    public bool IsVisible { get => _isVisible; set => _isVisible = value; }

    public ScriptureWord(string word) {

        _isVisible = true;
        _word = word;
    }
}