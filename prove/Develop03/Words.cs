// scriptures

public class Words
{
    private string _words;
    private bool _hidden;

    public Words (string words)
    {
        _words = words;
    }
    
    public void set_words(string _verse)
    {
        _words = _verse;
    }

    public string get_words()
    {
        return _words;
    }

    public void set_hidden_words(bool hidden)
    {
        _hidden = hidden; 
    }
    
    
}