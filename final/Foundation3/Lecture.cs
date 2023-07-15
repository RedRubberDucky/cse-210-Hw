

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string type, string title, string description, string date, string time, Address address, string speaker, int capacityLimit): base(type, title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacityLimit;
    }

    public string LectureDetails()
    {
        return($"Speaker:{_speaker}\nCapacity:{_capacity}");
    }

    public override string FullDetails()
    {
        return($"{base.sharedinformation()}{LectureDetails()}");
    }

}