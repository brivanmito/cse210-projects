public class Rectangle : Shape
{
    private double _base;
    private double _height;

    public Rectangle(string color, float b, float h) : base(color)
    {
        _base = b;
        _height = h;
    }
    public override double GetArea()
    {
        return _base * _height;
    }
}