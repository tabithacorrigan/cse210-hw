public class Scripture {

    private List<ScriptureWord> _wordList;

    private ScriptureReference _reference;

    public List<ScriptureWord> WordList { get => _wordList; set => _wordList = value; }
    public ScriptureReference Reference { get => _reference; set => _reference = value; }

    public Scripture(string scriptureText) {

        _wordList = new List<ScriptureWord>();

        string[] words = scriptureText.Split(" ");

        foreach (string word in words) {
            
            ScriptureWord sWord = new ScriptureWord(word);

            _wordList.Add(sWord);

        }

    }

    public string GetScripture() {
        string outText = "";
        
        foreach (ScriptureWord sWord in _wordList) {
            if(!sWord.IsVisible) {
                outText = outText + ConvertStringToUnderscores(sWord.Word) + " ";

            } else {
                outText = outText + sWord.Word + " ";
            }
        }

        return outText;
    }

    public void RedactWords() {
        int wordCount = _wordList.Count();
        int redactedWordCount = 0;
        Random rnd = new Random();

        
        
        while (redactedWordCount <= 2) {
            int index = rnd.Next(wordCount);
            if (_wordList[index].IsVisible) {
                _wordList[index].IsVisible = false;
                redactedWordCount ++;
            }

            if(getNonRedactedWordCount() == 0){
                break;
            }

        }

    }

    private string ConvertStringToUnderscores(string word){
        int len = word.Length;
        string outWord = "";
        for(int x=0;x<=len-1;x++){
            outWord = outWord + "_";
        }

        return outWord;
    }

    public int getNonRedactedWordCount(){
        int outCount = 0;
        foreach(ScriptureWord word in _wordList){
            if(word.IsVisible){
                outCount ++;
            }
        }
        return outCount;
    }
}