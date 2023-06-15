public class Circle : Shapes
{
    private int _radius;
    private float _pi;

    public Circle(string color, int radius, float pi) : base (color)
    {
        _radius = radius;
        _pi = pi;
    
    }

    public override double GetArea()
    {
        return _pi * (_radius * _radius);
    }
}