using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square squareInstance = new Square("Yellow", 5);
        shapes.Add(squareInstance);
        
        Rectangle rectangleInstance = new Rectangle("Red", 5, 7);
        shapes.Add(rectangleInstance);
       
        Circle CircleInstance = new Circle("Blue", 5.0);
        shapes.Add(CircleInstance);

        foreach(Shape shape in shapes)
        {
            Console.WriteLine(shape.GetColor());
            Console.WriteLine(shape.GetArea());
            Console.WriteLine($"The color: {shape.GetColor()} has an area of {shape.GetArea()}\n\n");
        }
        
    }
}