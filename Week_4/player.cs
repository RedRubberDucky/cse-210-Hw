public class Player
{
    private string _name;
    private string _position;
    private int _jersey;

    // Constructor
    public Player(string name, int jersey)
    {
        _name = name;
        _jersey = jersey; 
    }

    // Constructor
    public Player(string name, int jersey, string position)
    {
        _name = name;
        _jersey = jersey;
        _position = position;
    }

    //Constructor
    public void SetPosition(string position)
    {
        _position = position;
    }

    //How to display the information
    public string Display()
    {
        return $"{_name}: {_jersey} {_position}";
    }
}