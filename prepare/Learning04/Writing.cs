public class Writing : Assignment 
{
    public string _Title;
    public string _Subject;

    public Writing (string studentName, string topic, string Title, string Subject): base (studentName, topic)
    {
        _Title = Title;
        _Subject = Subject; 
    }
public string displaypieces()
{
    return $"Reading assignment:{_Title}, Subject of writing:{_Subject}";
}
}