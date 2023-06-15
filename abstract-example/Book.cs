public class Book
{
    private string _author;
    private string _name;
    private int _timesRead = 0;
    private bool _available = true; 

    public Book(string name, string author, bool available)
    {
        _name = name;
        _author = author; 
    }

    public void Display()
    {
        Console.WriteLine($"{_name} by {_author}");

        if(!_available)
        {
            Console.WriteLine("[Checked Out]");
        }
    }

    public book1 IsAvailable()
    {
        return _available;
    }
}