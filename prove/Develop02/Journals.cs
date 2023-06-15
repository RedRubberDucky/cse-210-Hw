// Don't forget to put this at the top, so C# knows where to find the StreamWriter class
using System.IO; 
public class Journal
{
    private int _numberentry;
    private int _creationdate;
    private int _pagecount; 
    
    public Journal(int numberentry, int creationdate, int pagecount)
    {
        _numberentry = numberentry;
        _creationdate = creationdate;
        _pagecount = pagecount;
    }
    
    public string Stringify() 
    {
        return $"{_numberentry} {_creationdate} {_pagecount})";
    }
    
    public void SaveFunction() {

        string fileName = "myFile.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }
    }

}


//How to best structure the program and know how to put it all together?
//