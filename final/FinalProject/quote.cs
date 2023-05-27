public class Quote {

    private string _source;
    private string _quoteString;
    private int _year;

    public string Source { get => _source; set => _source = value; }
    public string QuoteString { get => _quoteString; set => _quoteString = value; }
    public int Year { get => _year; set => _year = value; }

    public Quote() {
        
    }

    public Quote(string quote, string source, int year) {
        _quoteString = quote;
        _source = source;
        _year = year;
    }

    public void GetQuote() { 
        Console.WriteLine("Quote Here");
    }
}