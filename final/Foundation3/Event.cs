

public abstract class Event
{
    private string _event;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address; 
    
    public Event(string type, string title, string description, string date, string time, Address address)
    {
        _event = type;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string sharedinformation()
    {
        return($"\nType:{_event}\nTitle:{_title}\nDescription:{_description}\nDate:{_date}\nTime:{_time}\nAddress:{_address.printaddress()}");
    }

    public abstract string FullDetails();

    public string ShortDescription()
    {
        return($"\nType:{_event}\nTitle:{_title}\nDate:{_date}");
    }
    

    
}