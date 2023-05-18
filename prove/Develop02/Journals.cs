public class Journal
{
    private string _numberentry = "";
    private string _creationdate = "";
    private string _pagecount = ""; 
    
    public Journal(string numberentry, string creationdate, string pagecount = "")
    {
        _numberentry = numberentry;
        _creationdate = creationdate;
        _pagecount = pagecount;
    }
    
    public string Stringify() 
    {
        return $"{_numberentry} {_creationdate} {_pagecount})";
    }

}


//How to best structure the program and know how to put it all together?
//