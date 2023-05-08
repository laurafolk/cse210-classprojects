using System;  //Make sure every program coding starts of with this.

class Fraction  //Fraction is the variable in this cs file.

//public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {   
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public decimal GetDecimalValue()
    {
        return (decimal)_top / (decimal)_bottom;
    }
}