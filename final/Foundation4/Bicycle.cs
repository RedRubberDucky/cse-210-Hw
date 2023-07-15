

public class Bicycle : Activity
{
    private int _speed;

    public Bicycle(int speed, string date, int length, Activity Activity) : base(date, length)
    {
        _speed = speed;
    }

    public string speed()
    {
        return($"\n{_speed}");
    }
}