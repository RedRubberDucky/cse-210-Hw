public class Board
{
    List<Quaotes> _quotes = new List<Quaotes>();
    private void NicePrint(string item)
    {
        Console.WriteLine("-----------------------------");
        Console.WriteLine($"{item}");
        
        Console.WriteLine("-----------------------------");

    }
    public void ShowQuotes()
    {
        foreach (Quote quote in _quotes)
        {
            NicePrint(quote.GetQuote());
        }
    }    
        public void AddQuote(Quote quote)
        {
            _quotes.Add(quote);
        }
    public void GetRandomQuote()
    {
        var random = new Random();
        var randomeNumber = random.Next(0,_quotes.Count);
        NicePrint(_quotes[randomeNumber].GetQuote());
    }
    public void FindQuotesByAuthor(string author)
    {
        foreach (Quote quote in _quotes)
        {
            if(quote.HasAuthor (author))
            {
                NicePrint(quote.GetQuote());
            }
        }
    }
}