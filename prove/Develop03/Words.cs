// scriptures

public class Words
{
    private string _words;
    private bool _hidden = false;

    public Words(string text)
    {
        _words = text;
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
        if (_hidden == true)
        {
            return ("____");
        }
        else 
        {
            return _words;
        }
    }






//     public Words (string words)
//     {
//         _words = words;
//     }
    
//     public void set_words(string _verse)
//     {
//         _words = _verse;
//     }

//     public string get_words()
//     {
//         return _words;
//     }

//     public void set_hidden_words(bool hidden)
//     {
//         _hidden = hidden; 
//     }
    
    
}