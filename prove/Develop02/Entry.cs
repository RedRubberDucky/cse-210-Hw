public class Entry
{

    string _date;

    
    private string _location; 
    private string _message;
    public Entry (string location, string message)
    {
        DateTime date = DateTime.Now;
        _date = date.ToShortDateString();
        _location = location;
        _message = message;
    }
    public string getentry()
    {
        return $"Date:{_date}, Location:{_location}, Message:{_message}";
    }
    
}