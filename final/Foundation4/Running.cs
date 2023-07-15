

public class Running : Activity
{
    private int _distance;

    private Running(int distance, string date, int length, Activity Activity) : base (date, length)
    {
        _distance = distance;
    }

    public string distance()
    {
        return($"\n{_distance}");
    }
}