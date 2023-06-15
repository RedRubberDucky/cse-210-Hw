public class Jobs
{
    //Responsibilities 
    
    private string _company;

    private string _jobTitle;

    private string _startMonth;
    private int _startYear;
    private string _endMonth;

    private int _endYear;

    //Behaviors
    public Jobs (string company, string jobtitle, string startMonth, int startYear, string endMonth, int endYear)
    {
        _company = company;
        _jobTitle = jobtitle;
        _startMonth = startMonth;
        _startYear = startYear;
        _endMonth = endMonth;
        _endYear = endYear;

    }

    public void display()
    {
        Console.WriteLine($"Employer:{_company}, Title:{_jobTitle}, Start Month:{_startMonth}, Start Year:{_startYear}, End Month:{_endMonth} End Year:{_endYear}");
    }

}