public class Shapes
{
    public string _color;
    
    public Shapes(string color)
    {
        _color = color;
    }

    public string Getcolor()
    {
        return _color;
    }

    public void Setcolor(string color)
    {
        _color = color;
    }
   
   public abstract double GetArea();
}