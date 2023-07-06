// scriptures

public class Words
{
    private string _word;
    private bool _hidden = false;

    public Words(string text)
    {
        _word = text;
    }

    public void hide() 
        {
            _hidden = true;
        }
    // Hide
   
    // ishidden
    public bool ishidden()
    {
        if (_hidden == true)
            {
               return true; 
            }
        else 
            {
                return false; 
            }
    }

    
    // get text
    public string get_text()
    {
        if (_hidden != false)
        {
            _word = "----";
        }
        return _word;
    }
     
    public bool GetHidden()
    {
        return _hidden;
    }

}