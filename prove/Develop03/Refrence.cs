using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _verse2;
    public Reference(string book, int chapter, int verse, int verse2 = 0)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verse2 = verse2;
        
    }
    
    public void ScriptRef(string book)
    {
        _book = book;
    }

    public string display()
    {
        return $"{_book} {_chapter}:{_verse}-{_verse2}";
    }
    
}