using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction one = new Fraction();
        Console.WriteLine(one.GetFractionString());
        one.SetBottom(5);
        Console.WriteLine(one.GetFractionString());
        one.SetTop(7);
        Console.WriteLine(one.GetFractionString());
        Console.WriteLine(one.GetDecimalValue());
    }

}