

public class Swimming :Activity
{
    private string _laps;

    public Swimming(string laps,string date, int length, Activity Activity) : base(date, length)
    {
        _laps = laps;
    }
    public string laps()
    {
        return($"\n{_laps}");
    }

}