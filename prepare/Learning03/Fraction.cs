using System;
public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
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

    public int GetTop()
    {
        int top = _top;
        return top;
    }
    public void SetTop(int top)
    {
        _top = top;
    }
    public int GetBottom()
    {
        int bottom = _bottom;
        return bottom;

    }
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        double decim = (double)_top/(double)_bottom;
        return decim;
    }
}