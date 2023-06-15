public class Entry
{
    private int _date;
    private int _time; 
    private string _location; 

    public Entry (int date, int time, string location)
    {
        _date = date;
        _time = time;
        _location = location;

    }
    public string display()
    {
        return $"Date:{_date}, Time:{_time}, Location:{_location}";
    }
    
}