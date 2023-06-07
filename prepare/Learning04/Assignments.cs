public class Assignment
{
private string _studentName;
private string _topic;

public Assignment (string studentName, string topic)
{
    _studentName = studentName;
    _topic = topic;
}

public string display()
{
    // string stuff = $"Student Name:{_studentName}, Topic:{_topic}";
    // return stuff;
    return $"Student Name:{_studentName}, Topic:{_topic}";
}
}