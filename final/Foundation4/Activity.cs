

public class Activity
{
    private string _date;
    private int _length;

    public Activity(string date, int length)
    {
        _date = date;
        _length = length; 
    }

    public string duration()
    {
        return($"{_date} {_length}");
    }

}