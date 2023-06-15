using System;

class Program : Shapes
{
    static void Main(string[] args)
    {
       List<Shapes> shapes = new List<Shapes>(); 

       Square squareone = new Square("Orange", 1);
       shapes.Add(squareone);

       Rectangle rectangleone = new Rectangle("Purple", 2, 2);
       shapes.Add(rectangleone);

       Circle circleone = new Circle("Blue", 3, 3.14159);
       shapes.Add(circleone);

        foreach (Shapes a in shapes)
        {
            string color = a.Getcolor();

            double area = a.GetArea();

            Console.WriteLine($"The color of the shape is {color} shape has an area of {area}.");
        }

    }
}