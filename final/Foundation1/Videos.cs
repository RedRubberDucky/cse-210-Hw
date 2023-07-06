


public class Videos
{
    public string _title;
    private string _author;
    private int _length;
    

    List<Comment> _comments = new List<Comment>();

public void addcomment(string name, string text)
{
    Comment _response = new Comment(name, text);
    _comments.Add(_response);
    
}

    public Videos (string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    

    public void displayvideo()
    {
        Console.WriteLine($"\nTitle:{_title}, Author:{_author}, Length:{_length}");
         foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.display());
        }
    }
    
}

