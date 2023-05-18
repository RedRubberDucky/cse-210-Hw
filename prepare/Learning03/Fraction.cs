using System;

public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }    
    
    public Fraction(int top)
    {
        _numerator = top;
    }
    public Fraction(int top, int bottom)
    {
        _numerator = top;
        _denominator = bottom;
    }
    public int GetTop()
    {
        return _numerator;
    }
    public void SetTop(int top)
    {
        _numerator = top;
    }
    public int GetBottom()
    {
        return _denominator;
    }
    public void SetBottom(int bottom)
    {
        _denominator = bottom;
    }
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        if (_denominator == 0)
        {
            return 0;
        }
        return (double)_numerator/(double)_denominator;
    }
}