public class Jobs
{
    //Responsibilities 
    
    private string _company;

    private string _jobTitle;

    private int _start;

    private int _end;

    //Behaviors
    public Jobs (string company, string jobtitle)
    {
        _company = company;
        _jobTitle = jobtitle;
    }

    public void display()
    {
        Console.WriteLine($"{_jobTitle}, {_company}, {_start}, {_end}");
    }

}