

public class Outdoor : Event
{
    private string _forcast;
     

    public Outdoor(string type, string title, string description, string date, string time, Address address, string weather) : base(type, title, description, date, time, address)
    {
        _forcast = weather;
        
    } 

    public string OutdoorInformation()
    {
        return($"Weather:{_forcast}");
    }

 public override string FullDetails()
    {
        return($"{base.sharedinformation()}{OutdoorInformation()}");
    }
}