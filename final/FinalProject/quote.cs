public class Quote {
    private string _source;
    private string _quoteString;

    private List<Quote> quotes;


    public string Source { get => _source; set => _source = value; }
    public string QuoteString { get => _quoteString; set => _quoteString = value; }

    public Quote() {
        
    }

    public Quote(string quote, string source) {
        _quoteString = quote;
        _source = source;
    }

    public void GetQuote() { 
        List<Quote> quoteList = PopulateQuotes();

        Random rnd = new Random();
        int randomIndex = rnd.Next(quoteList.Count);
        Quote random = quoteList[randomIndex];


        Console.WriteLine($"{random.QuoteString} \n-{random.Source}");
    }

    private List<Quote> PopulateQuotes() {
        quotes = new List<Quote>();

        quotes.Add(new Quote("We did not come to this Earth to gain our worth... We brought it with us.", "Ardeth G. Kapp"));
        quotes.Add(new Quote("God rarely moves the mountains in front of us but He always helps us climb them", "Sheri Dew"));
        quotes.Add(new Quote("I will boast of my God for in His strength I can do all things", "Alma 26:12"));
        quotes.Add(new Quote("Never let fear decide your future", "Al Fox Carraway"));
        quotes.Add(new Quote("There is much that is difficult and challenging in the world today, but there is also much that is good and uplifting!", "Thomas S Monson"));
        quotes.Add(new Quote("Now is the best time to start becomming the person we eventually want to be", "Deiter F Uchtdorf"));

        return quotes;
    }
}